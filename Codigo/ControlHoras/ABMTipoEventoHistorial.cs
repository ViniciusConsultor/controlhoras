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
    public partial class ABMTipoEventoHistorial : Form
    {
        IABMTipos tipos = ControladorABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";

        public ABMTipoEventoHistorial()
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

            Dictionary<int,string> tiposDocumentos = tipos.obtenerTipoDocumentos(false);
            foreach (int iter in tiposDocumentos.Keys)
            {
                int n = -10;
                try
                {
                    n = dgvCategoria.Rows.Add();
                    dgvCategoria.Rows[n].Cells["idTipoDocumento"].Value = iter;
                    dgvCategoria.Rows[n].Cells["Nombre"].Value = tiposDocumentos[iter];
                    //dgvCategoria.Rows[n].Cells["Activa"].Value = cat[3];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las Categoria. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvCategoria.Rows.RemoveAt(n);
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
                    while (dgvCategoria.RowCount > numFila && lblIdTipoEventoHistorial.Text != dgvCategoria.Rows[numFila].Cells["idTipoDocumento"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvCategoria.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                        tipos.modificarTipoDocumento(int.Parse(lblIdTipoEventoHistorial.Text), txtNombre.Text, ! cbEstado.Checked);

                        dgvCategoria.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvCategoria.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
                    lblIdTipoEventoHistorial.Text = tipos.altaTipoDocumento(txtNombre.Text, !cbEstado.Checked).ToString();

                    n = dgvCategoria.Rows.Add();
                    dgvCategoria.Rows[n].Cells["idTipoDocumento"].Value = lblIdTipoEventoHistorial.Text;
                    dgvCategoria.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvCategoria.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvCategoria.Rows.RemoveAt(n);
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

        private void dgvCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtNombre.Text = dgvCategoria.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            if (dgvCategoria.Rows[e.RowIndex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblIdTipoEventoHistorial.Text = dgvCategoria.Rows[e.RowIndex].Cells["idTipoDocumento"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }


        
    }
}
