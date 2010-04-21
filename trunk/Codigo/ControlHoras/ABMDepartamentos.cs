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
    public partial class ABMDepartamentos : Form
    {
        IABMTipos tipos = ControladorABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";
        static ABMDepartamentos ventana = null;
        public static ABMDepartamentos getVentana()
        {
            if (ventana == null)
                ventana = new ABMDepartamentos();
            return ventana;
        }


        private ABMDepartamentos()
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

        private void ABMDepartamentos_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            Dictionary<int,string> dptos = tipos.obtenerDepartamentos(false);
            foreach (int iter in dptos.Keys)
            {
                int n = -10;
                try
                {
                    n = dgvDepartamentos.Rows.Add();
                    dgvDepartamentos.Rows[n].Cells["idDepartamento"].Value = iter;
                    dgvDepartamentos.Rows[n].Cells["Nombre"].Value = dptos[iter];
                    //dgvDepartamentos.Rows[n].Cells["Activa"].Value = cat[3];
                    dgvDepartamentos.Rows[n].Cells["Activa"].Value = "S";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las Departamentos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvDepartamentos.Rows.RemoveAt(n);
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
                    while (dgvDepartamentos.RowCount > numFila && lblidCategoria.Text != dgvDepartamentos.Rows[numFila].Cells["idDepartamento"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvDepartamentos.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                        tipos.modificarDepartamento(int.Parse(lblidCategoria.Text), txtNombre.Text, ! cbEstado.Checked);

                        dgvDepartamentos.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvDepartamentos.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
                    lblidCategoria.Text = tipos.altaDepartamento(txtNombre.Text,!cbEstado.Checked).ToString();

                    n = dgvDepartamentos.Rows.Add();
                    dgvDepartamentos.Rows[n].Cells["idDepartamento"].Value = lblidCategoria.Text;
                    dgvDepartamentos.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvDepartamentos.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        dgvDepartamentos.Rows.RemoveAt(n);
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

        private void dgvDepartamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtNombre.Text = dgvDepartamentos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            if (dgvDepartamentos.Rows[e.RowIndex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblidCategoria.Text = dgvDepartamentos.Rows[e.RowIndex].Cells["idDepartamento"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }

        private void ABMDepartamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null; 
        }

        
    }
}
