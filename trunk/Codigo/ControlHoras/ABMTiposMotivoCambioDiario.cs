using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Logica;
using Datos;

namespace ControlHoras
{
    public partial class ABMTiposMotivoCambioDiario : Form
    {
        IDatos datos = null;
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";
        static ABMTiposMotivoCambioDiario ventana = null;

        public static ABMTiposMotivoCambioDiario getVentana()
        {
            if (ventana == null)
                ventana = new ABMTiposMotivoCambioDiario();
            return ventana;
        }


        private ABMTiposMotivoCambioDiario()
        {
            InitializeComponent();

            datos = ControladorDatos.getInstance();
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            
        }

        private void limpiarForm()
        {
            txtNombre.Text = "";
            cbEstado.Checked = false;

        }

        private void ABMTiposMotivoCambioDiario_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            List<TipOsMotIVOCamBIoDiARio> movs = datos.obtenerTiposMotivoCambioDiario();
            foreach (TipOsMotIVOCamBIoDiARio iter in movs)
            {
                int n = -10;
                try
                {
                    n = dgvTiposMotivoCambioDiario.Rows.Add();
                    dgvTiposMotivoCambioDiario.Rows[n].Cells["IdTipoMotivoCambioDiario"].Value = iter.IDTipoMotivo;
                    dgvTiposMotivoCambioDiario.Rows[n].Cells["Nombre"].Value = iter.Descripcion;
                    if (iter.Activo == 1)
                        dgvTiposMotivoCambioDiario.Rows[n].Cells["Activa"].Value = "S";
                    else
                        dgvTiposMotivoCambioDiario.Rows[n].Cells["Activa"].Value = "N";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando los TiposMovimientoCambioDiario. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvTiposMotivoCambioDiario.Rows.RemoveAt(n);
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
            TipOsMotIVOCamBIoDiARio tipoMotivo = new TipOsMotIVOCamBIoDiARio();
            if (txtNombre.Text != "")
            {
                try
                {
                    int numFila = 0;
                    while (dgvTiposMotivoCambioDiario.RowCount > numFila && lblIdTiposMotivoCambioDiario.Text != dgvTiposMotivoCambioDiario.Rows[numFila].Cells["IdTipoMotivoCambioDiario"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvTiposMotivoCambioDiario.RowCount)
                    {
                        char estado = 'S';
                        tipoMotivo.Activo = 1;
                        if (cbEstado.Checked)
                        {
                            tipoMotivo.Activo = 0;
                            estado = 'N';
                        }
                        
                        tipoMotivo.Descripcion =  txtNombre.Text;
                        tipoMotivo.IDTipoMotivo = (uint) int.Parse(lblIdTiposMotivoCambioDiario.Text);
                        // Modifica el valor en la base de datos
                        datos.modificacionTipoMotivoCambioDiario(tipoMotivo);
                        dgvTiposMotivoCambioDiario.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvTiposMotivoCambioDiario.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
            TipOsMotIVOCamBIoDiARio tipoMotivo = new TipOsMotIVOCamBIoDiARio();
            if (txtNombre.Text != "")
            {
                int n = -10;
                try
                {
                    char estado = 'S';
                    tipoMotivo.Activo = 1;
                    if (cbEstado.Checked)
                    {
                        estado = 'N';
                        tipoMotivo.Activo = 0;
                    }

                    tipoMotivo.Descripcion = txtNombre.Text;
                    
                    datos.altaTipoMotivoCambioDiario(tipoMotivo);
                    lblIdTiposMotivoCambioDiario.Text = tipoMotivo.IDTipoMotivo.ToString();
                    n = dgvTiposMotivoCambioDiario.Rows.Add();
                    dgvTiposMotivoCambioDiario.Rows[n].Cells["IdTipoMotivoCambioDiario"].Value = lblIdTiposMotivoCambioDiario.Text;
                    dgvTiposMotivoCambioDiario.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvTiposMotivoCambioDiario.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        dgvTiposMotivoCambioDiario.Rows.RemoveAt(n);
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

        private void dgvTiposMotivoCambioDiario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtNombre.Text = dgvTiposMotivoCambioDiario.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            if (dgvTiposMotivoCambioDiario.Rows[e.RowIndex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblIdTiposMotivoCambioDiario.Text = dgvTiposMotivoCambioDiario.Rows[e.RowIndex].Cells["IdTipoMotivoCambioDiario"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }

        private void ABMTiposMotivoCambioDiario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null; 
        }

        
    }
}
