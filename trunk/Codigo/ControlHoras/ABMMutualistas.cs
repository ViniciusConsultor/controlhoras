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
    public partial class ABMMutualistas : Form
    {
        IABMTipos tipos = ControladorABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";
        static ABMMutualistas ventana = null;
        public static ABMMutualistas getVentana()
        {
            if (ventana == null)
                ventana = new ABMMutualistas();
            return ventana;
        }

        private ABMMutualistas()
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

        private void ABMMutualistas_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            Dictionary<int, string> mutualistas = tipos.obtenerMutualistas(false);
            foreach (int iter in mutualistas.Keys)
            {
                int n = -10;
                try
                {
                    n = dgvMutualistas.Rows.Add();
                    dgvMutualistas.Rows[n].Cells["idMutualista"].Value = iter;
                    dgvMutualistas.Rows[n].Cells["Nombre"].Value = mutualistas[iter];
                    //dgvMutualistas.Rows[n].Cells["Activa"].Value = cat[3];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las Mutualistas. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvMutualistas.Rows.RemoveAt(n);
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
                    while (dgvMutualistas.RowCount > numFila && lblidCategoria.Text != dgvMutualistas.Rows[numFila].Cells["idMutualista"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvMutualistas.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                        tipos.modificarMutualista(int.Parse(lblidCategoria.Text), txtNombre.Text, ! cbEstado.Checked);

                        dgvMutualistas.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvMutualistas.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
                    
                    // Doy de alta la Mutualista en la base de datos
                    lblidCategoria.Text = tipos.altaMutualista(txtNombre.Text, !cbEstado.Checked).ToString();

                    n = dgvMutualistas.Rows.Add();
                    dgvMutualistas.Rows[n].Cells["idMutualista"].Value = lblidCategoria.Text;
                    dgvMutualistas.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvMutualistas.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        dgvMutualistas.Rows.RemoveAt(n);
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

        private void dgvMutualistas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtNombre.Text = dgvMutualistas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            if (dgvMutualistas.Rows[e.RowIndex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblidCategoria.Text = dgvMutualistas.Rows[e.RowIndex].Cells["idMutualista"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }

        private void ABMMutualistas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        
    }
}
