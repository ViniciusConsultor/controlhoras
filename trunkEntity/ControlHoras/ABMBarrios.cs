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
    public partial class ABMBarrios : Form
    {
       IABMTipos tipos = ControladorABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";
        static ABMBarrios ventana = null;
        public static ABMBarrios getVentana()
        {
            if (ventana == null)
                ventana = new ABMBarrios();
            return ventana;
        }


        private ABMBarrios()
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

        private void ABMBarrios_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            Dictionary<int,string> dptos = tipos.obtenerBarrios(false);
            foreach (int iter in dptos.Keys)
            {
                int n = -10;
                try
                {
                    n = dgvBarrios.Rows.Add();
                    dgvBarrios.Rows[n].Cells["idDepartamento"].Value = iter;
                    dgvBarrios.Rows[n].Cells["Nombre"].Value = dptos[iter];
                    //dgvBarrios.Rows[n].Cells["Activa"].Value = cat[3];
                    dgvBarrios.Rows[n].Cells["Activa"].Value = "S";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las Departamentos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvBarrios.Rows.RemoveAt(n);
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
                    while (dgvBarrios.RowCount > numFila && lblidCategoria.Text != dgvBarrios.Rows[numFila].Cells["idDepartamento"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvBarrios.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                        tipos.modificarBarrio(int.Parse(lblidCategoria.Text), txtNombre.Text, ! cbEstado.Checked);

                        dgvBarrios.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvBarrios.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
                    lblidCategoria.Text = tipos.altaBarrio(txtNombre.Text,!cbEstado.Checked).ToString();

                    n = dgvBarrios.Rows.Add();
                    dgvBarrios.Rows[n].Cells["idDepartamento"].Value = lblidCategoria.Text;
                    dgvBarrios.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvBarrios.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        dgvBarrios.Rows.RemoveAt(n);
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
            int rowindex = dgvBarrios.SelectedRows[0].Index;
            if (rowindex == -1)
            {
                return;
            }
            txtNombre.Text = dgvBarrios.Rows[rowindex].Cells["Nombre"].Value.ToString();
            if (dgvBarrios.Rows[rowindex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblidCategoria.Text = dgvBarrios.Rows[rowindex].Cells["idDepartamento"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }

        private void ABMBarrios_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null; 
        }

        
    }
}
