using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Logica;
using Datos;


namespace ControlHoras
{
    public partial class Escalafon : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();
        IEmpleados sistemaEmp = ControladorEmpleados.getInstance();
        IDatos datos;
        ClientEs cliente = null;        
        ContraToS contrato;


        int idser;
        int ind;
        int cant;
        int[] numerosSer;
        DataGridViewCell celda, LastCellChanged = null;
        string stbuffer;
        TimeSpan[] hporCubrir;

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
                dgvHsPorCubrir.Refresh();
                DataGridViewCell celdaSeleccionada = dgEscalafon.SelectedCells[0];
                // Si se apreta F4 en alguna celda de la primer o segunda columna se abre el buscador de funcionarios.
                if (e.KeyCode == Keys.F4 && dgEscalafon.CurrentCell.ColumnIndex < 2)
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
                //if (dgEscalafon.CurrentCell.ColumnIndex=0 
                
            }
        }
               
        private void Escalafon_Load(object sender, EventArgs e)
        {
            
            int numR = dgvHsPorCubrir.Rows.Add();
            dgvHsPorCubrir.Rows[numR].HeaderCell.Value = "Hs Faltan Cubrir";

            dgvHsPorCubrir.ClearSelection();

            //DataGridViewColumnHeaderCell c = new DataGridViewColumnHeaderCell();
            //c.Style.BackColor = Color.Gray;
            //c.Style.ForeColor=Color.Red;            
            //dgvHsPorCubrir.Columns[7].HeaderCell = c;
            //dgvHsPorCubrir.Columns[7].HeaderCell.Value = "ORTO";

            //c.Value = dgvHsPorCubrir.Columns[7].HeaderCell.HasStyle.ToString();
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
                            splitContainer1.Panel2.Enabled = true;
                            GuardarBTN.Enabled = true;
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

                            cargarVentana(numCli, numerosSer[ind]);
                        }
                    }
                    else
                    {
                        GuardarBTN.Enabled = false;
                        splitContainer1.Panel2.Enabled = false;
                        MessageBox.Show("No existe el cliente numero " + mtCliente.Text, "No existe cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    GuardarBTN.Enabled = false;
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

                        cargarVentana(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text));
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

            cargarVentana(numCli, numerosSer[ind]);   
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(mtCliente.Text);
            ind = (ind + 1) % cant;

            limpiarForm();

            Servicio serv = sistema.obtenerServicioCliente(numCli, numerosSer[ind]);

            mtServicio.Text = serv.getNumero().ToString();
            txtServicio.Text = serv.getNombre();

            cargarVentana(numCli, numerosSer[ind]);            
        }


        private void cargarVentana(int numCli, int numSer)
        {
            // Cargar las hs por dia del contrato en el dvg
            ConSeguridadFisica con = null;
            int nroCon = CalcNroContrato(numCli, numSer);
            if (datos.existeContrato(nroCon))
            {
                con = sistema.getContrato(CalcNroContrato(numCli, numSer));
                hporCubrir = con.getTotalesHoras();
                CargarHporCubrir();               
            }
        }

        private string impHora(TimeSpan h)
        {
            return h.Hours.ToString() + ":" + h.Minutes.ToString();
        }

        public int CalcNroContrato(int nroCli, int nroSer)
        {
            return nroCli * 1000 + nroSer;
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
        
        private void dgEscalafon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            LastCellChanged = dgEscalafon.CurrentCell;
        }       

        private void dgEscalafon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                celda = dgEscalafon.Rows[e.RowIndex].Cells[e.ColumnIndex];
                EscalafonCMS.Show(MousePosition);
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (celda != null)
                stbuffer = celda.Value.ToString();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dgEscalafon.SelectedCells)
                c.Value = stbuffer;
        }

        private void descansoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dgEscalafon.SelectedCells)
            {
                //c.Style 
                c.Value = "Descanso";
            }
        }

        private void licenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dgEscalafon.SelectedCells)
            {
                //c.Style 
                c.Value = "Licencia";
            }
        }

        private bool ValidarLinea(int fila)
        {
            DataGridViewRow f;

            foreach (DataGridViewCell c in dgEscalafon.SelectedCells)
                c.Selected = false;
            
            f = dgEscalafon.Rows[fila];

            //Validar Empleado
            if (f.Cells[0].Value == null || f.Cells[0].Value == "")
            {
                dgEscalafon.Focus();
                dgEscalafon.CurrentCell = f.Cells[0];
                f.Cells[0].Selected = true;

                return false;
            }

            //Validar Codigo Puesto
            if (f.Cells[2].Value == null )
            {
                dgEscalafon.Focus();
                dgEscalafon.CurrentCell = f.Cells[2];
                f.Cells[2].Selected = true;
                return false;
            }

            //Validar Hora Confirmar
            if (f.Cells[3].Value == null)
            {
                dgEscalafon.Focus();
                dgEscalafon.CurrentCell = f.Cells[3];
                f.Cells[3].Selected = true;
                return false;
            }

            //Validar Horarios
            for (int j = 4; j < 11; j++)
            {
                if (f.Cells[j].Value == null || !ValidarHorario(f.Cells[j].Value.ToString()))
                {
                    dgEscalafon.Focus();
                    dgEscalafon.CurrentCell = f.Cells[j];
                    f.Cells[j].Selected = true;
                    return false;
                }
            }           

            return true;
        }

        private bool ValidarHorario(string hor)
        {
            if (hor=="Descanso" || hor=="Licencia")
                return true;
            if (hor.IndexOfAny(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }) == -1)
                return false;
            if (hor.Length != 13)
                return false;
            string hini = obtHIni(hor);
            string hfin = obtHFin(hor);
            DateTimeStyles dts = new DateTimeStyles();
            DateTime dti;
            DateTime dtf;

            if (!DateTime.TryParseExact(hini, @"HH:mm", DateTimeFormatInfo.InvariantInfo, dts, out dti))
                return false;
            if (!DateTime.TryParseExact(hfin, @"HH:mm", DateTimeFormatInfo.InvariantInfo, dts, out dtf))
                return false;
            if (dti > dtf)
                return false;
            return true;
        }

        private bool esEntero(string p)
        {
            int aux;
            return int.TryParse(p, out aux);
        }

        private string obtHFin(string texto)
        {
            return texto.Substring(8, 5);
        }

        private string obtHIni(string texto)
        {
            return texto.Substring(0, 5);
        }

         private void btnAgregarLineaEscalafon_Click(object sender, EventArgs e)
        {
            int f = dgEscalafon.RowCount -1;
            if (f > -1)
            {
                if (ValidarLinea(f))
                {
                    //TimeSpan [] horas = ObtenerHoras(f);
                    //hporCubrir = restar(hporCubrir, horas);
                    //CargarHporCubrir();

                    ActHorasBTN.PerformClick();
                    int n = dgEscalafon.Rows.Add();
                    ((DataGridViewComboBoxCell)dgEscalafon.Rows[n].Cells[dgEscalafon.Columns.Count - 1]).Value = "EMPRESA";
                    
                    dgEscalafon.Focus();
                    dgEscalafon.CurrentCell = dgEscalafon.Rows[n].Cells[0];
                    //dgEscalafon.Rows[n].Cells[2].Selected = true;
                }
                else
                    MessageBox.Show(this, "Error en la línea anterior en la celda seleccionada", "Línea no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = dgEscalafon.Rows.Add();
                ((DataGridViewComboBoxCell)dgEscalafon.Rows[n].Cells[dgEscalafon.Columns.Count - 1]).Value = "EMPRESA";
                
                dgEscalafon.Focus();
                dgEscalafon.CurrentCell = dgEscalafon.Rows[n].Cells[0];
                //dgEscalafon.Rows[n].Cells[2].Selected = true;
            }
        }

         private void CargarHporCubrir()
         {
             for (int i = 0; i < 7; i++)
             {
                 dgvHsPorCubrir.Rows[0].Cells[i].Value = impHora(hporCubrir[i]);
             }
         }

         private TimeSpan[] restar(TimeSpan[] hporCubrir, TimeSpan[] horas)
         {
             TimeSpan[] aux = new TimeSpan[7];
             for (int i = 0; i < 7; i++)
             {
                 aux[i] = hporCubrir[i] - horas[i];
             }
             return aux;
         }

         private TimeSpan[] ObtenerHoras(int f)
         {
             TimeSpan[] aux = new TimeSpan[7];
             TimeSpan a = new TimeSpan(0, 0, 0);
             string valor;
             DataGridViewRow fila = dgEscalafon.Rows[f];
             for (int i = 0; i < 7; i++)
             {
                 valor = fila.Cells[i + 4].Value.ToString();
                 if (valor == "Descanso" || valor == "Licencia")
                     aux[i] = a;
                 else
                     aux[i] = calcDif(fila.Cells[i + 4].Value.ToString());
             }
             return aux;
         }

         private TimeSpan calcDif(string p)
         {
             DateTime dti, dtf;
             TimeSpan res;

             dti = DateTime.ParseExact(p.Substring(0,5), @"HH:mm", DateTimeFormatInfo.InvariantInfo);
             dtf = DateTime.ParseExact(p.Substring(8,5), @"HH:mm", DateTimeFormatInfo.InvariantInfo);
             res = dtf - dti;

             return res;
         }

         private void dgEscalafon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
         {
             if (LastCellChanged != null && LastCellChanged.Value != null)
             {
                 //&& LastCellChanged.Value != ""
                 if (LastCellChanged.ColumnIndex == 0)
                 {
                     EmPleadOs emp;
                     try
                     {
                         if (sistemaEmp.existeEmpleado(int.Parse(LastCellChanged.Value.ToString())))
                         {
                             emp = datos.obtenerEmpleado(int.Parse(LastCellChanged.Value.ToString()));
                             dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[1].Value = emp.Nombre + " " + emp.Apellido;
                             //dgEscalafon.CurrentCell = dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[2];
                         }
                         else
                         {
                             dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[1].Value = "";
                             MessageBox.Show("No existe el empleado Nro: " + LastCellChanged.Value.ToString(), "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[0].Value = "";
                             //dgEscalafon.CurrentCell = LastCellChanged;
                             //dgEscalafon.CurrentCell.InitializeEditingControl(LastCellChanged.RowIndex, LastCellChanged.Value.ToString(), LastCellChanged.Style);
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }

                 }
             }
         }

         private void ActHorasBTN_Click(object sender, EventArgs e)
         {
             //Validar DataGrid
             bool aux = ValidarEscalafon();
             int totLineas = dgEscalafon.RowCount;

             
             if (aux && totLineas>0)
             {
                 int numCli = int.Parse(mtCliente.Text);
                 int numSer = int.Parse(mtServicio.Text);
                 ConSeguridadFisica con = null;
                 int nroCon = CalcNroContrato(numCli, numSer);
                 try
                 {
                     if (datos.existeContrato(nroCon))
                     {
                         con = sistema.getContrato(CalcNroContrato(numCli, numSer));
                         hporCubrir = con.getTotalesHoras();
                         for (int i = 0; i < totLineas; i++)
                         {
                             hporCubrir = restar(hporCubrir, ObtenerHoras(i));
                         }

                         CargarHporCubrir();
                     }
                 }
                 catch (Exception ex)
                 {
                     
                     MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             else
                 MessageBox.Show(this, "Error en la celda seleccionada", "Línea no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

         private void GuardarBTN_Click(object sender, EventArgs e)
         {
             if (ValidarEscalafon())
             {
                 int numCli = int.Parse(mtCliente.Text);
                 int numSer = int.Parse(mtServicio.Text);
                 /*
                 ConSeguridadFisica con = new ConSeguridadFisica(hx, 0, 0, 0, dti, dtf, AjusteTB.Text, ObsTB.Text, costo, monto);

                 // ACA GUARDO TODOS LOS DATOS DEL DATAGRIDVIEW

                 LineaDeHoras linea = null;
                 HorarioXDia hor = null;
                 DataGridViewCell cel = null;
                 string precio;
                 foreach (DataGridViewRow fila in CargaHorariaDGV.Rows)
                 {
                     if (fila.Cells[0].RowIndex + 1 < CargaHorariaDGV.RowCount)
                     {
                         if (fila.Cells["Armado"].Value == null)
                             fila.Cells["Armado"].Value = "0";
                         precio = fila.Cells["PrecioXHora"].Value.ToString().Substring(3);
                         linea = new LineaDeHoras(fila.Cells["Puesto"].Value.ToString(), (fila.Cells["Armado"].Value.ToString() == "1") ? true : false, float.Parse(precio), int.Parse(fila.Cells["Cantidad"].Value.ToString()), 0, 0);
                         for (int i = 0; i < 7; i++)
                         {
                             cel = fila.Cells[dias[i]];
                             if (cel.Value.ToString() != @"N/T")
                             {
                                 hor = new HorarioXDia(dias[i], obtHIni(cel.Value.ToString()), obtHFin(cel.Value.ToString()));
                                 linea.addDia(hor);
                             }
                         }
                         con.addLinea(linea);
                     }
                 }

                 if (datos.existeContrato(nroCon))
                     sistema.modificarContrato(nroCon, con);
                 else
                     sistema.altaContrato(nroCon, con);
                  
                 */
                 MessageBox.Show("Datos guardados correctamente.", "Guardado de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
                 MessageBox.Show(this, "Error en la celda seleccionada", "Línea no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);

         }

        private bool ValidarEscalafon()
        {
            bool aux = true;
            int nroLinea = 0;
            int totLineas = dgEscalafon.RowCount;

            while (aux && nroLinea < totLineas)
            {
                aux = ValidarLinea(nroLinea);
                nroLinea++;
            }

            return aux;
        }

    }
}
