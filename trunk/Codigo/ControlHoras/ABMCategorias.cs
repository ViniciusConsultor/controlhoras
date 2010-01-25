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
    public partial class ABMCategorias : Form
    {
        Controlador sistema = Controlador.getControlador();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";

        public ABMCategorias()
        {
            InitializeComponent();

            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            
        }

        private void limpiarForm()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            cbEstado.Checked = false;

        }

        private void ABMCategorias_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            /*List<String[]> categorias = sistema.traerCategorias(false);
            foreach (String[] cat in categorias)
            {
                int n = -10;
                try
                {
                    n = dgvCategorias.Rows.Add();
                    dgvCategorias.Rows[n].Cells["idCategoria"].Value = cat[0];
                    dgvCategorias.Rows[n].Cells["Nombre"].Value = cat[1];
                    dgvCategorias.Rows[n].Cells["Descripción"].Value = cat[2];
                    dgvCategorias.Rows[n].Cells["Activa"].Value = cat[3];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las Categorias. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n >= 0)
                        try
                        {
                            dgvCategorias.Rows.RemoveAt(n);
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(this, ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            } */
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDescripcion.Text != "")
            {
                try
                {
                    int numFila = 0;
                    while (dgvCategorias.RowCount > numFila && lblidCategoria.Text != dgvCategorias.Rows[numFila].Cells["idCategoria"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvCategorias.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                       // sistema.modificarCategoria(int.Parse(lblidCategoria.Text), txtNombre.Text, txtDescripcion.Text, estado);

                        dgvCategorias.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvCategorias.Rows[numFila].Cells["Descripción"].Value = txtDescripcion.Text;
                        dgvCategorias.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
            if (txtNombre.Text != "" && txtDescripcion.Text != "")
            {
                int n = -10;
                try
                {
                    char estado = 'S';
                    if (cbEstado.Checked)
                        estado = 'N';
                    
                    // Doy de alta la categoria en la base de datos
                 //   lblidCategoria.Text = sistema.altaCategoria(txtNombre.Text, txtDescripcion.Text, estado).ToString();

                    n = dgvCategorias.Rows.Add();
                    dgvCategorias.Rows[n].Cells["idCategoria"].Value = lblidCategoria.Text;
                    dgvCategorias.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvCategorias.Rows[n].Cells["Descripción"].Value = txtDescripcion.Text;
                    dgvCategorias.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        dgvCategorias.Rows.RemoveAt(n);
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

        private void dgvCategorias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtNombre.Text = dgvCategorias.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = dgvCategorias.Rows[e.RowIndex].Cells["Descripción"].Value.ToString();
            if (dgvCategorias.Rows[e.RowIndex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblidCategoria.Text = dgvCategorias.Rows[e.RowIndex].Cells["idCategoria"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }

        
    }
}
