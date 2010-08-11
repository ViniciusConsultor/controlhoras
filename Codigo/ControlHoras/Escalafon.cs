using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Datos;

namespace ControlHoras
{
    public partial class Escalafon : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();
        IDatos datos;
        ClientEs cliente = null;
        SERVicIoS servicio;
        ContraToS contrato;

        int idser;
        int ind;
        int cant;
        int[] numerosSer;

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
            
            idser = -1;
            InicializardgEscalafon();
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
                            dgEscalafon.Rows[celdaSeleccionada.RowIndex].Cells[0].Value = emp.NroEmpleado.ToString();
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
            dgEscalafon.Focus();
            dgEscalafon.CurrentCell = dgEscalafon.Rows[n].Cells[0];
            //dgEscalafon.Rows[n].Cells[2].Selected = true;
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
                        limpiarForm();
                        ind = 0;
                        int numCli = int.Parse(mtCliente.Text);
                        cliente = datos.obtenerCliente(numCli);                        
                        txtCliente.Text = cliente.Nombre;
                        Cliente cli = sistema.obtenerCliente(numCli);
                        List<Servicio> servicios = cli.getListaServicios();
                        if (servicios.Count != 0)
                        {
                            //GuardarBTN.Enabled = true;
                            //ServicioGB.Enabled = true;

                            cant = servicios.Count;
                            numerosSer = new int[cant];
                            int i = 0;
                            foreach (Servicio ser in servicios)
                            {
                                numerosSer[i] = ser.getNumero();
                                if (ser.getNumero() == idser)
                                    ind = i;

                                i++;
                            }
                                                      
                            Servicio serv = sistema.obtenerServicioCliente(numCli, numerosSer[ind]);

                            mtServicio.Text = serv.getNumero().ToString();
                            txtServicio.Text = serv.getNombre();
                            
                            if (cant > 1)
                            {
                                AnteriorBTN.Visible = true;
                                PosteriorBTN.Visible = true;
                            }

                            cargarVentana();
                        }
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

        private void AnteriorBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(mtCliente.Text);
            if ((ind - 1) < 0)
                ind = cant - 1;
            else
                ind = ind - 1;

            limpiarForm();
            
            Servicio serv = sistema.obtenerServicioCliente(numCli, numerosSer[ind]);

            mtServicio.Text = serv.getNumero().ToString();
            txtServicio.Text = serv.getNombre();

            cargarVentana();   
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(mtCliente.Text);
            ind = (ind + 1) % cant;

            limpiarForm();

            Servicio serv = sistema.obtenerServicioCliente(numCli, numerosSer[ind]);

            mtServicio.Text = serv.getNumero().ToString();
            txtServicio.Text = serv.getNombre();

            cargarVentana();            
        }


        private void cargarVentana()
        {
            // Cargar las hs por dia del contrato en el dvg
        }

        private void InicializardgEscalafon()
        {
            MaskedTextBoxColumn mtbc;
            DataGridViewColumn dgvc;
            DataGridViewCell cell;

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Nº Emp";
            mtbc.HeaderText = "Nº Emp";
            mtbc.Mask = @"0000";
            mtbc.Width = 45;
            mtbc.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);            
            this.dgEscalafon.Columns.Add(mtbc);

            cell = new DataGridViewTextBoxCell();
            dgvc = new DataGridViewColumn(cell);
            dgvc.Name = "Funcionario";
            dgvc.HeaderText = "Funcionario";            
            dgvc.Width = 150;
            dgvc.ReadOnly = true;
            dgvc.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);            
            this.dgEscalafon.Columns.Add(dgvc);
            
            cell = new DataGridViewTextBoxCell();
            dgvc = new DataGridViewColumn(cell);
            dgvc.Name = "Código Puesto";
            dgvc.HeaderText = "Código Puesto";
            dgvc.Width = 52;            
            this.dgEscalafon.Columns.Add(dgvc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Hora Confirma";
            mtbc.HeaderText = "Hora Confirma";
            mtbc.Mask = @"0 Hs";
            mtbc.Width = 49;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dgEscalafon.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Lunes";
            mtbc.HeaderText = "Lunes";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            mtbc.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            this.dgEscalafon.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Martes";
            mtbc.HeaderText = "Martes";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            mtbc.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            this.dgEscalafon.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Miercoles";
            mtbc.HeaderText = "Miercoles";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            mtbc.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            this.dgEscalafon.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Jueves";
            mtbc.HeaderText = "Jueves";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            mtbc.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            this.dgEscalafon.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Viernes";
            mtbc.HeaderText = "Viernes";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            mtbc.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            this.dgEscalafon.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Sabado";
            mtbc.HeaderText = "Sabado";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            mtbc.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            this.dgEscalafon.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Domingo";
            mtbc.HeaderText = "Domingo";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            mtbc.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            this.dgEscalafon.Columns.Add(mtbc);

            DataGridViewComboBoxColumn cbc = new DataGridViewComboBoxColumn();
            cbc.Name = "A Cargo De";
            cbc.HeaderText = "A Cargo De";
            cbc.Width = 80;
            cbc.Items.Add("CLIENTE");
            cbc.Items.Add("EMPRESA");
            this.dgEscalafon.Columns.Add(cbc);

            //dgEscalafon.EditMode = DataGridViewEditMode.EditOnEnter;
        }

    }
}
