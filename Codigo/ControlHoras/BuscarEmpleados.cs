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
            datos = ControladorDatos.getInstance();
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
                dgvResultado.Rows[n].Cells["idEmpleado"].Value = res[iter].IDEmpleado.ToString();
                dgvResultado.Rows[n].Cells["Nombre"].Value = res[iter].Nombre;
                dgvResultado.Rows[n].Cells["Apellido"].Value = res[iter].Apellido;
                dgvResultado.Rows[n].Cells["Documento"].Value = res[iter].NumeroDocumento;
                dgvResultado.Rows[n].Cells["Direccion"].Value = res[iter].Direccion;
                dgvResultado.Rows[n].Cells["Telefono"].Value = res[iter].Telefonos;
                iter++;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<EmPleadOs> listEmps = datos.buscarEmpleaos(cmbCampoBusqueda.SelectedItem.ToString(), txtBusqueda.Text);
                cargarGrillaResultados(listEmps);
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
            btnAceptar.PerformClick();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count > 0)
                idEmpleadoSeleccionado = int.Parse(dgvResultado.SelectedRows[0].Cells["idEmpleado"].Value.ToString());
        }

    }

        
}
