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
    public partial class ABMBancos : Form
    {
        IABMTipos tipos = ControladorABMTipos.getInstance();
        static ABMBancos ventana = null;
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";

        private ABMBancos()
        {
            InitializeComponent();

            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            
        }

        public static ABMBancos getVentana()
        {
            if (ventana == null)
                ventana = new ABMBancos();
            return ventana;
        }



        private void limpiarForm()
        {
            txtNombre.Text = "";
            cbEstado.Checked = false;

        }

        private void ABMBancos_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            try
            {
                Dictionary<int, string> bancos = tipos.obtenerBancos(false);
                foreach (int iter in bancos.Keys)
                {
                    int n = -10;
                    try
                    {
                        n = dgvBancos.Rows.Add();
                        dgvBancos.Rows[n].Cells["idBanco"].Value = iter;
                        dgvBancos.Rows[n].Cells["Nombre"].Value = bancos[iter];
                        // dgvBancos.Rows[n].Cells["Activa"].Value = cat[3];

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Error Cargando las Bancos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (n > -10)
                            try
                            {
                                dgvBancos.Rows.RemoveAt(n);
                            }
                            catch (Exception ex1)
                            {
                                MessageBox.Show(this, ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                try
                {
                    int numFila = 0;
                    while (dgvBancos.RowCount > numFila && lblidCategoria.Text != dgvBancos.Rows[numFila].Cells["idBanco"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvBancos.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                        tipos.modificarBanco(int.Parse(lblidCategoria.Text), txtNombre.Text,! cbEstado.Checked);

                        dgvBancos.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvBancos.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
                    lblidCategoria.Text = tipos.altaBanco(txtNombre.Text, !cbEstado.Checked).ToString();

                    n = dgvBancos.Rows.Add();
                    dgvBancos.Rows[n].Cells["idBanco"].Value = lblidCategoria.Text;
                    dgvBancos.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvBancos.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvBancos.Rows.RemoveAt(n);
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
            int rowindex = dgvBancos.SelectedRows[0].Index;
            if (rowindex == -1)
            {
                return;
            }
            
            txtNombre.Text = dgvBancos.Rows[rowindex].Cells["Nombre"].Value.ToString();
            if (dgvBancos.Rows[rowindex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblidCategoria.Text = dgvBancos.Rows[rowindex].Cells["idBanco"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;
            


        }

        private void ABMBancos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        
    }
}
