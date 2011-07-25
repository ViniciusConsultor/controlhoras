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
    public partial class BuscarEmpleados : Form
    {
        private IDatos datos;
        public int idEmpleadoSeleccionado;

        public BuscarEmpleados()
        {
            InitializeComponent();
            try
            {
                datos = ControladorDatos.getInstance();
            }
            catch (Exception e)
            {
                throw e;
            }
            cmbCampoBusqueda.SelectedIndex = 1;
            
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBusqueda.Text != "" & e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void cargarGrillaResultados(List<EmPleadOs> res)
        {
            dgvResultado.Rows.Clear();
            int iter = 0;
            int n;
            while (iter < res.Count)
            {
                n = dgvResultado.Rows.Add();
                dgvResultado.Rows[n].Cells["idEmpleado"].Value = res[iter].NroEmpleado.ToString();
                dgvResultado.Rows[n].Cells["Nombre"].Value = res[iter].Nombre;
                dgvResultado.Rows[n].Cells["Apellido"].Value = res[iter].Apellido;
                dgvResultado.Rows[n].Cells["Documento"].Value = res[iter].NumeroDocumento;
                dgvResultado.Rows[n].Cells["CelularPersonal"].Value = res[iter].Celular;
                iter++;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<EmPleadOs> listEmps = datos.buscarEmpleados(cmbCampoBusqueda.SelectedItem.ToString(), txtBusqueda.Text,cbInactivos.Checked);
                cargarGrillaResultados(listEmps);
                if (listEmps.Count == 0)
                    MessageBox.Show(this,"No se han encontrado datos con estos filtros.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (dgvResultado.SelectedRows.Count > 0)
                idEmpleadoSeleccionado = int.Parse(dgvResultado.SelectedRows[0].Cells["idEmpleado"].Value.ToString());
            if (this.Owner.GetType().Equals(typeof(ABMEmpleados)))
            {
                ((ABMEmpleados)this.Owner).setNroEmpleado(idEmpleadoSeleccionado);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarEmpleados_Load(object sender, EventArgs e)
        {
            //if (this.Owner.GetType().Equals(typeof(ABMEmpleados)))
            //{
            //    this.DialogResult = DialogResult.None;
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

    }

        
}
