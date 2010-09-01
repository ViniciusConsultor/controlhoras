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
    public partial class ABMCiudades : Form
    {
        IABMTipos tipos = ControladorABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";
        static ABMCiudades ventana = null;
        public static ABMCiudades getVentana()
        {
            if (ventana == null)
                ventana = new ABMCiudades();
            return ventana;
        }


        private ABMCiudades()
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

        private void ABMCiudades_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            Dictionary<int,string> dptos = tipos.obtenerCiudades(false);
            foreach (int iter in dptos.Keys)
            {
                int n = -10;
                try
                {
                    n = dgvCiudades.Rows.Add();
                    dgvCiudades.Rows[n].Cells["idCiudad"].Value = iter;
                    dgvCiudades.Rows[n].Cells["Nombre"].Value = dptos[iter];
                    //dgvCiudades.Rows[n].Cells["Activa"].Value = cat[3];
                    dgvCiudades.Rows[n].Cells["Activa"].Value = "S";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las Departamentos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvCiudades.Rows.RemoveAt(n);
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
                    while (dgvCiudades.RowCount > numFila && lblidCategoria.Text != dgvCiudades.Rows[numFila].Cells["idCiudad"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvCiudades.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                        tipos.modificarCiudad(int.Parse(lblidCategoria.Text), txtNombre.Text, ! cbEstado.Checked);

                        dgvCiudades.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvCiudades.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
                    lblidCategoria.Text = tipos.altaCiudad(txtNombre.Text,!cbEstado.Checked).ToString();

                    n = dgvCiudades.Rows.Add();
                    dgvCiudades.Rows[n].Cells["idCiudad"].Value = lblidCategoria.Text;
                    dgvCiudades.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvCiudades.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        dgvCiudades.Rows.RemoveAt(n);
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
            int rowindex = dgvCiudades.SelectedRows[0].Index;
            if (rowindex == -1)
            {
                return;
            }
            txtNombre.Text = dgvCiudades.Rows[rowindex].Cells["Nombre"].Value.ToString();
            if (dgvCiudades.Rows[rowindex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblidCategoria.Text = dgvCiudades.Rows[rowindex].Cells["idCiudad"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }

        private void ABMCiudades_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null; 
        }
    }
}
