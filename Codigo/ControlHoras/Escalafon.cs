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
    public partial class Escalafon : Form
    {

        IDatos datos;
        ClientEs cliente = null;
        SERVicIoS servicio;
        ContraToS contrato;

        static Escalafon ventana = null;
        
        public Escalafon()
        {
            InitializeComponent();
       
            try
            {
                datos = ControladorDatos.getInstance();
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        public static Escalafon getVentana()
        {
            if (ventana == null)
                ventana = new Escalafon();
            return ventana;
        }

        private void limpiarForm()
        {
        }
        // TAMANIO COLUMNAS
        // Nº Emp: 40 |Funcionario: 120 |Codigo Puesto: 52 |Hora Confirma: 49 |Lunes: 75 |Martes: 100 |Miercoles: 100 |Jueves: 100 |Viernes: 100 |Sabado: 100 |Domingo: 100 |A Cargo De: 80
        
        private void dgEscalafon_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgEscalafon.SelectedCells.Count > 0)
            {
                DataGridViewCell celdaSeleccionada = dgEscalafon.SelectedCells[0];
                // Si se apreta F4 en alguna celda de la primer o segunda columna se abre el buscador de funcionarios.
                if (e.KeyCode == Keys.F4 && dgEscalafon.SelectedCells[0].ColumnIndex < 2)
                {
                    // Muestro ventana de busqueda de empleados. La misma que en ABMEmpleados
                    BuscarEmpleados busquedaEmps = new BuscarEmpleados();
                    DialogResult res = busquedaEmps.ShowDialog(this);
                    if (res == DialogResult.OK)
                    {
                        try
                        {
                            EmPleadOs emp = datos.obtenerEmpleado(busquedaEmps.idEmpleadoSeleccionado);
                            dgEscalafon.Rows[celdaSeleccionada.RowIndex].Cells[0].Value = emp.NroEmpleado;
                            dgEscalafon.Rows[celdaSeleccionada.RowIndex].Cells[1].Value = emp.Nombre + " " + emp.Apellido;
                            
                            SendKeys.Send("{ENTER}");   
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dgEscalafon_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void Escalafon_Load(object sender, EventArgs e)
        {
            
            int numR = dgvHsPorCubrir.Rows.Add();
            dgvHsPorCubrir.Rows[numR].HeaderCell.Value = "Hs Faltan Cubrir";
        }

        private void btnAgregarLineaEscalafon_Click(object sender, EventArgs e)
        {
            int n = dgEscalafon.Rows.Add();
            ((DataGridViewComboBoxCell)dgEscalafon.Rows[n].Cells[dgEscalafon.Columns.Count - 1]).Value = "EMPRESA";
        //    DataGridViewComboBoxColumn dgvcbc = dgEscalafon.Columns[dgEscalafon.Columns.Count - 1] as DataGridViewComboBoxColumn;
            
        }

        private void btnEliminarLineaEscalafon_Click(object sender, EventArgs e)
        {
            if (dgEscalafon.SelectedCells.Count > 0)
            {
                string msg = "Esta seguro que desea eliminar la fila " + dgEscalafon.SelectedCells[0].RowIndex + 1 + "?";
                if (dgEscalafon.Rows[dgEscalafon.SelectedCells[0].RowIndex].Cells[0].Value != null)
                    msg += "\nEn esta linea se encuentra asignado el funcionario " + dgEscalafon.Rows[dgEscalafon.SelectedCells[0].RowIndex].Cells[0].Value + " - " + dgEscalafon.Rows[dgEscalafon.SelectedCells[0].RowIndex].Cells[1].Value;
                DialogResult dr = MessageBox.Show(msg, "Eliminar Linea Escalafon", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                    dgEscalafon.Rows.RemoveAt(dgEscalafon.SelectedCells[0].RowIndex);
            }
        }

        private void Escalafon_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        private void dgvHsPorCubrir_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        private void dgvHsPorCubrir_RowHeadersWidthChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dgvHsPorCubrir.Rows[0].HeaderCell.Size.Width.ToString());
        }

        private void mtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtCliente.Text != "" && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                // traigo el cliente.                
                try
                {
                    if (datos.existeCliente(int.Parse(mtCliente.Text)))
                    {
                        cliente = datos.obtenerCliente(int.Parse(mtCliente.Text));
                        limpiarForm();
                        txtCliente.Text = cliente.Nombre;
                    }
                    else
                    {
                        MessageBox.Show("No existe el cliente numero " + mtCliente.Text, "No existe cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                // abro la ventana de busqueda de clientes.                
                btnBuscarClientes.PerformClick();
            }
            
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            BuscarClientes sear = new BuscarClientes();
            DialogResult res = sear.ShowDialog(this);

            if (res == DialogResult.OK)
            {
                mtCliente.Text = sear.NumCliente;
                mtCliente.Focus();
                SendKeys.Send("{ENTER}");
            }
        }

        private void mtServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtCliente!= null && mtServicio.Text != "" && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                // seteo el servicio.                
                SERVicIoS servicio;

                try
                {
                    if (datos.existeCliente(int.Parse(mtCliente.Text)))
                    {
                        servicio = getServicioCliente(int.Parse(mtCliente.Text),int.Parse(mtServicio.Text));
                        
                        limpiarForm();
                        txtServicio.Text = servicio.Nombre;
                        //Falta traer el contrato.
                        contrato = datos.obtenerContrato(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text));

                        cargarVentana();
                    }
                    else
                    {
                        MessageBox.Show("No existe el cliente numero " + mtCliente.Text, "No existe cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                // abro la ventana de busqueda de servicios.                
                //btnBuscarServicios.PerformClick();
            }
        }

        private SERVicIoS getServicioCliente(int nroCli, int nroServicio)
        {
            SERVicIoS ser = null;
            
            foreach (SERVicIoS s in datos.obtenerServiciosCliente(nroCli))
            {
                
                if (s.NumeroServicio == (uint)nroServicio)
                {
                    ser = s;
                    break;
                }
            }
            if (ser == null)
                throw new Exception("No existe el servicio número " + nroServicio + " en el cliente " + cliente.NumeroCliente);
            return ser;
        }


        private void cargarVentana()
        {
            // Cargar las hs por dia del contrato en el dvg
        }

    }
}
