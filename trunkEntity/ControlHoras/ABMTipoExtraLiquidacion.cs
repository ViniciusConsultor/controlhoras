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
    public partial class ABMTipoExtraLiquidacion : Form
    {
        IDatosABMTipos tipos = DatosABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";
        static ABMTipoExtraLiquidacion ventana = null;
        public static ABMTipoExtraLiquidacion getVentana()
        {
            if (ventana == null)
                ventana = new ABMTipoExtraLiquidacion();
            return ventana;
        }


        private ABMTipoExtraLiquidacion()
        {
            InitializeComponent();

            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            
        }

        private void limpiarForm()
        {
            txtNombre.Text = "";
            cbEstado.Checked = false;
            cmbLlevaHs.Checked = false;
        }

        private void ABMTipoExtraLiquidacion_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            List<TipOExtraLiquidAcIon> tipoextras = tipos.obtenerTipoExtraLiquidacion(false);
            foreach (TipOExtraLiquidAcIon te in tipoextras)
            {
                int n = -10;
                try
                {
                    n = dgvTipoExtrasLiquidacion.Rows.Add();
                    dgvTipoExtrasLiquidacion.Rows[n].Cells["idTipoExtraLiquidacion"].Value = te.IDTipoExtraLiquidacion;
                    dgvTipoExtrasLiquidacion.Rows[n].Cells["Nombre"].Value = te.Nombre;
                    dgvTipoExtrasLiquidacion.Rows[n].Cells["Activa"].Value = te.Activo==1;
                    dgvTipoExtrasLiquidacion.Rows[n].Cells["LlevaHs"].Value = te.LlevaHs==1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando los TiposExtrasLiquidacion. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvTipoExtrasLiquidacion.Rows.RemoveAt(n);
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
                    while (dgvTipoExtrasLiquidacion.RowCount > numFila && lblIdTipoExtra.Text != dgvTipoExtrasLiquidacion.Rows[numFila].Cells["idTipoExtraLiquidacion"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvTipoExtrasLiquidacion.RowCount)
                    {

                        TipOExtraLiquidAcIon te = new TipOExtraLiquidAcIon();
                        te.IDTipoExtraLiquidacion= byte.Parse(lblIdTipoExtra.Text);
                        te.Nombre = txtNombre.Text;
                        te.LlevaHs = (cmbLlevaHs.Checked ? (sbyte)1 : (sbyte)0);
                        te.Activo = (cbEstado.Checked ? (sbyte)0 : (sbyte)1);
                        // Modifica el valor en la base de datos
                        tipos.modificarTipoExtraLiquidacion(te);

                        dgvTipoExtrasLiquidacion.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvTipoExtrasLiquidacion.Rows[numFila].Cells["Activa"].Value = !cbEstado.Checked;
                        dgvTipoExtrasLiquidacion.Rows[numFila].Cells["LlevaHs"].Value = cmbLlevaHs.Checked;
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
                    // Doy de alta en la base de datos
                    lblIdTipoExtra.Text = tipos.altaTipoExtraLiquidacion(txtNombre.Text,!cbEstado.Checked, cmbLlevaHs.Checked).ToString();

                    n = dgvTipoExtrasLiquidacion.Rows.Add();
                    dgvTipoExtrasLiquidacion.Rows[n].Cells["idTipoExtraLiquidacion"].Value = lblIdTipoExtra.Text;
                    dgvTipoExtrasLiquidacion.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvTipoExtrasLiquidacion.Rows[n].Cells["Activa"].Value = !cbEstado.Checked;
                    dgvTipoExtrasLiquidacion.Rows[n].Cells["LlevaHs"].Value = cmbLlevaHs.Checked;

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        dgvTipoExtrasLiquidacion.Rows.RemoveAt(n);
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

        private void dgvTipoExtrasLiquidacion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int rowindex = dgvTipoExtrasLiquidacion.SelectedRows[0].Index;
            if (rowindex == -1)
            {
                return;
            }
            txtNombre.Text = dgvTipoExtrasLiquidacion.Rows[rowindex].Cells["Nombre"].Value.ToString();
            cbEstado.Checked = ! (bool)dgvTipoExtrasLiquidacion.Rows[rowindex].Cells["Activa"].Value;
            
            cmbLlevaHs.Checked = (bool)dgvTipoExtrasLiquidacion.Rows[rowindex].Cells["LlevaHs"].Value;
                
            lblIdTipoExtra.Text = dgvTipoExtrasLiquidacion.Rows[rowindex].Cells["idTipoExtraLiquidacion"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void ABMTipoExtraLiquidacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null; 
        }
    }
}
