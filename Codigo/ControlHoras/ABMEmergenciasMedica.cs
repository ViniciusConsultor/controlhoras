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
    public partial class ABMEmergenciasMedica : Form
    {
        IABMTipos tipos = ControladorABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";

        public ABMEmergenciasMedica()
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

        private void ABMEmergenciasMedica_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            Dictionary<int,string> emergencias = tipos.obtenerEmergenciaMedicas(false);
            foreach (int iter in emergencias.Keys)
            {
                int n = -10;
                try
                {
                    n = dgvEmergenciasMedica.Rows.Add();
                    dgvEmergenciasMedica.Rows[n].Cells["idEmergenciaMedica"].Value = iter;
                    dgvEmergenciasMedica.Rows[n].Cells["Nombre"].Value = emergencias[iter];
                    //dgvEmergenciasMedica.Rows[n].Cells["Activa"].Value = cat[3];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las EmergenciasMedica. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvEmergenciasMedica.Rows.RemoveAt(n);
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
                    while (dgvEmergenciasMedica.RowCount > numFila && lblidCategoria.Text != dgvEmergenciasMedica.Rows[numFila].Cells["idEmergenciaMedica"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvEmergenciasMedica.RowCount)
                    {
                        char estado = 'S';
                        if (cbEstado.Checked)
                        {
                            estado = 'N';
                        }
                        
                        // Modifica el valor en la base de datos
                        tipos.modificarEmergenciaMedica(int.Parse(lblidCategoria.Text), txtNombre.Text,!cbEstado.Checked);

                        dgvEmergenciasMedica.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvEmergenciasMedica.Rows[numFila].Cells["Activa"].Value = estado;
                        
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
                    
                    // Doy de alta la EmergenciaMedica en la base de datos
                    lblidCategoria.Text = tipos.altaEmergenciaMedica(txtNombre.Text, !cbEstado.Checked).ToString();

                    n = dgvEmergenciasMedica.Rows.Add();
                    dgvEmergenciasMedica.Rows[n].Cells["idEmergenciaMedica"].Value = lblidCategoria.Text;
                    dgvEmergenciasMedica.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvEmergenciasMedica.Rows[n].Cells["Activa"].Value = estado.ToString();

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvEmergenciasMedica.Rows.RemoveAt(n);
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

        private void dgvEmergenciasMedica_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtNombre.Text = dgvEmergenciasMedica.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            if (dgvEmergenciasMedica.Rows[e.RowIndex].Cells["Activa"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            lblidCategoria.Text = dgvEmergenciasMedica.Rows[e.RowIndex].Cells["idEmergenciaMedica"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }


        
    }
}
