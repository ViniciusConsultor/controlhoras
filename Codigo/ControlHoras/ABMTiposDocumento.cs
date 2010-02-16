using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace ControlHoras
{
    public partial class ABMTiposDocumento : Form
    {
        IABMTipos tipos = ControladorABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";
        static ABMTiposDocumento ventana = null;

        public static ABMTiposDocumento getVentana()
        {
            if (ventana == null)
                ventana = new ABMTiposDocumento();
            return ventana;
        }

        private ABMTiposDocumento()
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

        private void ABMTiposDocumento_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            Dictionary<int,string> tiposDocumentos = tipos.obtenerTipoDocumentos(false);
            foreach (int iter in tiposDocumentos.Keys)
            {
                int n = -10;
                try
                {
                    n = dgvTiposDocumento.Rows.Add();
                    dgvTiposDocumento.Rows[n].Cells["idTipoDocumento"].Value = iter;
                    dgvTiposDocumento.Rows[n].Cells["Nombre"].Value = tiposDocumentos[iter];
                    //dgvTiposDocumento.Rows[n].Cells["Activa"].Value = cat[3];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las TiposDocumento. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvTiposDocumento.Rows.RemoveAt(n);
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
                    while (dgvTiposDocumento.RowCount > numFila && lblidCategoria.Text != dgvTiposDocumento.Rows[numFila].Cells["idTipoDocumento"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvTiposDocumento.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                        tipos.modificarTipoDocumento(int.Parse(lblidCategoria.Text), txtNombre.Text, ! cbEstado.Checked);

                        dgvTiposDocumento.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvTiposDocumento.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
                    lblidCategoria.Text = tipos.altaTipoDocumento(txtNombre.Text, !cbEstado.Checked).ToString();

                    n = dgvTiposDocumento.Rows.Add();
                    dgvTiposDocumento.Rows[n].Cells["idTipoDocumento"].Value = lblidCategoria.Text;
                    dgvTiposDocumento.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvTiposDocumento.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvTiposDocumento.Rows.RemoveAt(n);
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

        private void dgvTiposDocumento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtNombre.Text = dgvTiposDocumento.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            if (dgvTiposDocumento.Rows[e.RowIndex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblidCategoria.Text = dgvTiposDocumento.Rows[e.RowIndex].Cells["idTipoDocumento"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }

        
    }
}
