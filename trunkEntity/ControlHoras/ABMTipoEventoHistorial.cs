using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Datos;

namespace ControlHoras
{
    public partial class ABMTipoEventoHistorial : Form
    {
        IABMTipos tipos = ControladorABMTipos.getInstance();
        IDatosABMTipos DatosTipos = DatosABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";
        static ABMTipoEventoHistorial ventana = null;
        
        public static ABMTipoEventoHistorial getVentana()
        {
            if (ventana == null)
                ventana = new ABMTipoEventoHistorial();
            return ventana;
        }

        private ABMTipoEventoHistorial()
        {
            InitializeComponent();

            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            
        }

        private void limpiarForm()
        {
            txtNombre.Text = "";
            cbEstado.Checked = false;

        }

        private void ABMCategoria_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

                       
            List<TipOsEventOHistOrIal> tiposEvento = DatosTipos.obtenerTiposEventoHistorial(false);
            foreach (TipOsEventOHistOrIal iter in tiposEvento)
            {
                int n = -10;
                try
                {
                    n = dgvEventosHistorial.Rows.Add();
                    dgvEventosHistorial.Rows[n].Cells["idTipoEventoHistorial"].Value = iter.IDTipoEventoHistorial;
                    dgvEventosHistorial.Rows[n].Cells["Nombre"].Value = iter.Nombre;
                    if (iter.Activo == 1)
                        dgvEventosHistorial.Rows[n].Cells["Activa"].Value = "S";
                    else
                        dgvEventosHistorial.Rows[n].Cells["Activa"].Value = "N";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las Categoria. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvEventosHistorial.Rows.RemoveAt(n);
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(this, ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                try
                {
                    int numFila = 0;
                    while (dgvEventosHistorial.RowCount > numFila && lblIdTipoEventoHistorial.Text != dgvEventosHistorial.Rows[numFila].Cells["idTipoEventoHistorial"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvEventosHistorial.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                        DatosTipos.modificarTipoEventoHistorial(int.Parse(lblIdTipoEventoHistorial.Text), txtNombre.Text, !cbEstado.Checked);

                        dgvEventosHistorial.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvEventosHistorial.Rows[numFila].Cells["Activa"].Value = estado;

                        btnAgregar.Enabled = true;
                        btnGuardar.Enabled = false;
                        limpiarForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                int n = -10;
                try
                {
                    char estado = 'S';
                    if (cbEstado.Checked)
                        estado = 'N';
                    
                    // Doy de alta la categoria en la base de datos
                    lblIdTipoEventoHistorial.Text = DatosTipos.altaTipoEventoHistorial(txtNombre.Text, !cbEstado.Checked).ToString();

                    n = dgvEventosHistorial.Rows.Add();
                    dgvEventosHistorial.Rows[n].Cells["idTipoEventoHistorial"].Value = lblIdTipoEventoHistorial.Text;
                    dgvEventosHistorial.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvEventosHistorial.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvEventosHistorial.Rows.RemoveAt(n);
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(this, ex2.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                }
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void dgvTiposMotivoCambioDiario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int rowindex = dgvEventosHistorial.SelectedRows[0].Index;
            if (rowindex == -1)
            {
                return;
            }
            txtNombre.Text = dgvEventosHistorial.Rows[rowindex].Cells["Nombre"].Value.ToString();
            if (dgvEventosHistorial.Rows[rowindex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblIdTipoEventoHistorial.Text = dgvEventosHistorial.Rows[rowindex].Cells["idTipoEventoHistorial"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }

        private void ABMTipoEventoHistorial_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }


        
    }
}
