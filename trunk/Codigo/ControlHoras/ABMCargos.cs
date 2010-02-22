using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace ControlHoras
{
    public partial class ABMCargos : Form
    {
        IDatosABMTipos datos = null;
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";
        

        static ABMCargos ventana = null;
        public static ABMCargos getVentana()
        {
            if (ventana == null)
                ventana = new ABMCargos();
            return ventana;
        }

        private ABMCargos()
        {
            InitializeComponent();

            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            datos = DatosABMTipos.getInstance();
            
        }

        private void limpiarForm()
        {
            txtNombre.Text = "";
            lblIdTipoCargo.Text = "";
            mtHsComunes.Text = "";
            txtDescripcion.Text = "";
            cmbTipoFacturacion.SelectedIndex = 0;
            cbCobraExtras.Checked = false;
            cbFulltime.Checked = false;
            cbEstado.Checked = false;

        }

        private void ABMCargos_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            List<TipOscarGoS> cargos = datos.obtenerTiposCargos(false);
            foreach (TipOscarGoS cat in cargos)
            {
                int n = -10;
                try
                {
                    n = dgvCargos.Rows.Add();
                    dgvCargos.Rows[n].Cells["idTipoCargo"].Value = cat.IDCargo.ToString();
                    dgvCargos.Rows[n].Cells["Nombre"].Value = cat.Nombre;
                    dgvCargos.Rows[n].Cells["Descripcion"].Value = cat.Descripcion;
                    dgvCargos.Rows[n].Cells["HsComunes"].Value = cat.CantidadHsComunes.ToString();
                    dgvCargos.Rows[n].Cells["TipoFacturacion"].Value = cat.TipoFacturacion;
                    if (cat.Fulltime == 0)
                        dgvCargos.Rows[n].Cells["Fulltime"].Value = true;
                    else
                        dgvCargos.Rows[n].Cells["Fulltime"].Value = false;
                    if (cat.CobraHsExtras == 0)
                        dgvCargos.Rows[n].Cells["CobraHsExtras"].Value = true;
                    else
                        dgvCargos.Rows[n].Cells["CobraHsExtras"].Value = false;
                    if (cat.Activo == 0)
                        dgvCargos.Rows[n].Cells["Activo"].Value = "SI";
                    else
                        dgvCargos.Rows[n].Cells["Activo"].Value = "NO";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando las Cargos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n >= 0)
                        try
                        {
                            dgvCargos.Rows.RemoveAt(n);
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
            if (txtNombre.Text != "" && txtDescripcion.Text != "")
            {
                try
                {
                    int numFila = 0;
                    while (dgvCargos.RowCount > numFila && lblIdTipoCargo.Text != dgvCargos.Rows[numFila].Cells["IdTipoCargo"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvCargos.RowCount)
                    {
                        
                        // Modifica el valor en la base de datos
                        datos.modificarTipoCargo(int.Parse(lblIdTipoCargo.Text), txtNombre.Text, txtDescripcion.Text,int.Parse(mtHsComunes.Text),cmbTipoFacturacion.SelectedItem.ToString(),cbCobraExtras.Checked,cbFulltime.Checked,cbEstado.Checked);
                        dgvCargos.Rows[numFila].Cells["idTipoCargo"].Value = lblIdTipoCargo.Text;
                        dgvCargos.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvCargos.Rows[numFila].Cells["Descripcion"].Value = txtDescripcion.Text;
                        dgvCargos.Rows[numFila].Cells["HsComunes"].Value = mtHsComunes.Text;
                        dgvCargos.Rows[numFila].Cells["TipoFacturacion"].Value = cmbTipoFacturacion.SelectedItem.ToString();
                        if (cbFulltime.Checked)
                            dgvCargos.Rows[numFila].Cells["Fulltime"].Value = cbFulltime.Checked;
                        else
                            dgvCargos.Rows[numFila].Cells["Fulltime"].Value = cbFulltime.Checked;
                        if (cbCobraExtras.Checked)
                            dgvCargos.Rows[numFila].Cells["CobraHsExtras"].Value = cbCobraExtras.Checked;
                        else
                            dgvCargos.Rows[numFila].Cells["CobraHsExtras"].Value = cbCobraExtras.Checked;
                        if (cbEstado.Checked)
                            dgvCargos.Rows[numFila].Cells["Activo"].Value = cbEstado.Checked;
                        else
                            dgvCargos.Rows[numFila].Cells["Activo"].Value = cbEstado.Checked;
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
                int numFila = -10;
                try
                {
                                      
                    // Doy de alta el cargo en la base de datos
                    int numCargo = datos.altaCargo(txtNombre.Text, txtDescripcion.Text, int.Parse(mtHsComunes.Text), cmbTipoFacturacion.SelectedItem.ToString(), cbCobraExtras.Checked, cbFulltime.Checked, cbEstado.Checked);

                    numFila = dgvCargos.Rows.Add();
                    dgvCargos.Rows[numFila].Cells["idTipoCargo"].Value = lblIdTipoCargo.Text;
                    dgvCargos.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                    dgvCargos.Rows[numFila].Cells["Descripcion"].Value = txtDescripcion.Text;
                    dgvCargos.Rows[numFila].Cells["HsComunes"].Value = mtHsComunes.Text;
                    dgvCargos.Rows[numFila].Cells["TipoFacturacion"].Value = cmbTipoFacturacion.SelectedItem.ToString();
                    if (cbFulltime.Checked)
                        dgvCargos.Rows[numFila].Cells["Fulltime"].Value = cbFulltime.Checked;
                    else
                        dgvCargos.Rows[numFila].Cells["Fulltime"].Value = cbFulltime.Checked;
                    if (cbCobraExtras.Checked)
                        dgvCargos.Rows[numFila].Cells["CobraHsExtras"].Value = cbCobraExtras.Checked;
                    else
                        dgvCargos.Rows[numFila].Cells["CobraHsExtras"].Value = cbCobraExtras.Checked;
                    if (cbEstado.Checked)
                        dgvCargos.Rows[numFila].Cells["Activo"].Value = cbEstado.Checked;
                    else
                        dgvCargos.Rows[numFila].Cells["Activo"].Value = cbEstado.Checked;
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        dgvCargos.Rows.RemoveAt(numFila);
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

        private void dgvCargos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            lblIdTipoCargo.Text = dgvCargos.Rows[e.RowIndex].Cells["IdTipoCargo"].Value.ToString();
            txtNombre.Text = dgvCargos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtDescripcion.Text = dgvCargos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            mtHsComunes.Text = dgvCargos.Rows[e.RowIndex].Cells["HsComunes"].Value.ToString();
            cmbTipoFacturacion.SelectedItem = dgvCargos.Rows[e.RowIndex].Cells["TipoFacturacion"].Value;
            if (dgvCargos.Rows[e.RowIndex].Cells["Activo"].Value.ToString() == "NO")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;
            cbFulltime.Checked = (bool)dgvCargos.Rows[e.RowIndex].Cells["Fulltime"].Value;
            cbCobraExtras.Checked = (bool)dgvCargos.Rows[e.RowIndex].Cells["CobraHsExtras"].Value;
            

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;



        }

        private void ABMCargos_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        
    }
}
