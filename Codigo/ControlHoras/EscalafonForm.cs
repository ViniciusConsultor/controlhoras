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
    public partial class EscalafonForm : Form
    {
        IClientesServicios sistema;// = ControladorClientesServicios.getInstance();
        IEmpleados sistemaEmp;// = ControladorEmpleados.getInstance();
        IDatos datos;
        ClientEs cliente = null;        
        ContraToS con;
        ConSeguridadFisica contrato = null;


        int idser;
        int ind;
        int cant;
        int[] numerosSer;
        DataGridViewCell celda, LastCellChanged = null;
        string stbuffer;
        string oldvalor;
        TimeSpan[] hporCubrir;
        string[] dias = new string[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
        bool ContCubierto;

        static EscalafonForm ventana = null;
        
        private EscalafonForm()
        {
            InitializeComponent();       
            
            try
            {
                sistema = ControladorClientesServicios.getInstance();
                sistemaEmp = ControladorEmpleados.getInstance();
                datos = ControladorDatos.getInstance();
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            
            idser = -1;
            ContCubierto = false;
            InicializardgEscalafon();
        }

        public static EscalafonForm getVentana()
        {
            if (ventana == null)
                ventana = new EscalafonForm();
            return ventana;
        }

        private void limpiarForm()
        {
            dgEscalafon.Rows.Clear();
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
                            dgEscalafon.Rows[celdaSeleccionada.RowIndex].Cells[1].Value = emp.Apellido + " " + emp.Nombre;
                            
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
            dgvHsPorCubrir.Rows[numR].HeaderCell.Value = "Horas : Minutos";// "Hs Faltan Cubrir";

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
                int aux = dgEscalafon.SelectedCells[0].RowIndex + 1;
                string msg = "Esta seguro que desea eliminar la fila " + aux.ToString() + "?";
                if (dgEscalafon.Rows[dgEscalafon.SelectedCells[0].RowIndex].Cells[0].Value != null)
                    msg += "\nEn esta linea se encuentra asignado el funcionario " + dgEscalafon.Rows[dgEscalafon.SelectedCells[0].RowIndex].Cells[0].Value + " - " + dgEscalafon.Rows[dgEscalafon.SelectedCells[0].RowIndex].Cells[1].Value;
                DialogResult dr = MessageBox.Show(msg, "Eliminar Linea Escalafon", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    dgEscalafon.Rows.RemoveAt(dgEscalafon.SelectedCells[0].RowIndex);
                    ActualizarHporCubrir();
                }
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
                    limpiarForm();
                    if (datos.existeCliente(int.Parse(mtCliente.Text)))
                    {
                        if (!datos.ClienteActivo(int.Parse(mtCliente.Text)))
                            MessageBox.Show("El cliente "+ mtCliente.Text +" está inactivo", "Cliente Inactivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        ind = 0;
                        int numCli = int.Parse(mtCliente.Text);                        
                        Cliente cli = sistema.obtenerCliente(numCli);
                        txtCliente.Text = cli.getNombre();
                        List<Servicio> servicios = cli.getListaServicios();
                        if (servicios.Count != 0)
                        {                            
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

                            if (cant > 1)
                            {
                                AnteriorBTN.Visible = true;
                                PosteriorBTN.Visible = true;
                            }
                            else
                            {
                                AnteriorBTN.Visible = false;
                                PosteriorBTN.Visible = false;
                            }
                            
                            cargarVentana(numCli, numerosSer[ind]);
                        }
                        else
                        {
                            AnteriorBTN.Visible = false;
                            PosteriorBTN.Visible = false;                            
                            mtServicio.Text = "";
                            txtServicio.Text = "";
                            GraficosPL.Visible = false;
                            //ConLBL.Visible = false;
                            //cubiertoTB.Visible = false;
                            //CubiertoLBL.Visible = false;
                            LimpiarHporCubrir();
                            GuardarBTN.Enabled = false;
                            splitContainer1.Panel2.Enabled = false;
                            MessageBox.Show("El cliente numero " + mtCliente.Text + " no tiene servicios asociados.", "Cliente sin Servicios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        AnteriorBTN.Visible = false;
                        PosteriorBTN.Visible = false;
                        txtCliente.Text = "";
                        mtServicio.Text = "";
                        txtServicio.Text = "";
                        GraficosPL.Visible = false;
                        //ConLBL.Visible = false;
                        //cubiertoTB.Visible = false;
                        //CubiertoLBL.Visible = false;
                        LimpiarHporCubrir();
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
                        con = datos.obtenerContrato(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text));

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

            cargarVentana(numCli, numerosSer[ind]);   
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(mtCliente.Text);
            ind = (ind + 1) % cant;

            limpiarForm();           

            cargarVentana(numCli, numerosSer[ind]);            
        }


        private void cargarVentana(int numCli, int numSer)
        {
            try
            {
                Servicio serv = sistema.obtenerServicioCliente(numCli, numerosSer[ind]);

                mtServicio.Text = serv.getNumero().ToString();
                txtServicio.Text = serv.getNombre();

                int nroCon = CalcNroContrato(numCli, numSer);
                if (!datos.existeContrato(nroCon))
                {
                    GraficosPL.Visible = false;
                    //ConLBL.Visible = false;
                    //cubiertoTB.Visible = false;
                    //CubiertoLBL.Visible = false;
                    LimpiarHporCubrir();
                    GuardarBTN.Enabled = false;
                    splitContainer1.Panel2.Enabled = false;                    
                    MessageBox.Show("Este servicio no tiene contrato.\nNo se puede generar escalafón.", "Servicio sin Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GraficosPL.Visible = true;
                    //ConLBL.Visible = true;
                    //cubiertoTB.Visible = true;
                    //CubiertoLBL.Visible = true;                    
                    GuardarBTN.Enabled = true;
                    splitContainer1.Panel2.Enabled = true;

                    Escalafon esc = null;
                    int nroEsc = CalcNroContrato(numCli, numSer);
                    if (datos.existeEscalafon(nroEsc))
                    {
                        esc = sistema.getEscalafon(nroEsc);

                        int i = 0;
                        DataGridViewRow insr = null;
                        foreach (EscalafonEmpleado l in esc.ListaEscalafonEmpleados)
                        {
                            insr = new DataGridViewRow();

                            object[] param = { l.NroEmpleado.ToString(), datos.getNombreEmpleado(l.NroEmpleado), l.CodigoPuesto, l.CantidadHsLlamadaAntesHoraInicio.ToString() + " Hs" };

                            insr.CreateCells(dgEscalafon, param);

                            dgEscalafon.Rows.Add(insr);

                            foreach (HorarioEscalafon h in l.Horario)
                            {
                                if (h.EsLaborable())
                                {
                                    dgEscalafon.Rows[i].Cells[h.getDia()].Value = h.getHoraIni() + " a " + h.getHoraFin();
                                    if (h.Solapea())
                                        dgEscalafon.Rows[i].Cells[h.getDia()].Style.BackColor = Color.Red;
                                }
                                else
                                {
                                    switch (h.getTipoDia())
                                    {
                                        case 1:
                                            dgEscalafon.Rows[i].Cells[h.getDia()].Value = "EnOtroServ";
                                            break;
                                        case 2:
                                            dgEscalafon.Rows[i].Cells[h.getDia()].Value = "Descanso";
                                            break;
                                        case 3:
                                            dgEscalafon.Rows[i].Cells[h.getDia()].Value = "Licencia";
                                            break;
                                        default:
                                            dgEscalafon.Rows[i].Cells[h.getDia()].Value = "Error";
                                            break;
                                    }

                                }

                            }

                            dgEscalafon.Rows[i].Cells[11].Value = l.AcargoDe;
                            i++;
                        }
                    }

                    // Cargar las hs por dia del contrato en el dvg            
                    contrato = sistema.getContrato(CalcNroContrato(numCli, numSer));
                    hporCubrir = contrato.getTotalesHoras();
                    CargarHporCubrir();
                    ActualizarHporCubrir();
                    VerContratoBTN.Enabled = true;
                }            
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarHporCubrir()
        {
            for (int i = 0; i < 7; i++)
            {
                dgvHsPorCubrir.Rows[0].Cells[i].Value = "";
                dgvHsPorCubrir.Rows[0].Cells[i].Style.BackColor = Color.White;
            }
        }

        private string impHora(TimeSpan h)
        {
            return System.Math.Abs(System.Math.Truncate(h.TotalHours)).ToString()  + ":" + System.Math.Abs(h.Minutes).ToString();          
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
            cbc.Items.Add("Cliente");
            cbc.Items.Add("Empresa");
            this.dgEscalafon.Columns.Add(cbc);

            //dgEscalafon.EditMode = DataGridViewEditMode.EditOnEnter;
        }
        
        private void dgEscalafon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            LastCellChanged = dgEscalafon.CurrentCell;
            if (dgEscalafon.CurrentCell.Value != null)
            {
                oldvalor = dgEscalafon.CurrentCell.Value.ToString();                
            }
            else
                oldvalor = "v";
            
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
            {                
                if (c.ColumnIndex > 3 && c.ColumnIndex < 11)
                {
                    if (c.Value != null)
                        CargarHorarioCelda(c.ColumnIndex, c.Value.ToString(), stbuffer);
                    else
                        CargarHorarioCelda(c.ColumnIndex, "v", stbuffer);
                }
                c.Value = stbuffer;
            }
        }

        private void CargarHorarioCelda(int indice, string viejo, string nuevo)
        {
            TimeSpan old = ObtenerHoraString(viejo);
            TimeSpan niu = ObtenerHoraString(nuevo);
            TimeSpan aux = niu - old;
            hporCubrir[indice - 4] = hporCubrir[indice - 4] - aux;
            
            CargarHporCubrir();
        }

        private void descansoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dgEscalafon.SelectedCells)
            {               
                if (c.ColumnIndex > 3 && c.ColumnIndex < 11)
                {
                    if (c.Value != null)
                        CargarHorarioCelda(c.ColumnIndex, c.Value.ToString(), "Descanso");
                    else
                        CargarHorarioCelda(c.ColumnIndex, "v", "Descanso");
                }
                //c.Style 
                c.Value = "Descanso";
            }
        }

        private void licenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dgEscalafon.SelectedCells)
            {                
                if (c.ColumnIndex > 3 && c.ColumnIndex < 11)
                {
                    if (c.Value != null)
                        CargarHorarioCelda(c.ColumnIndex, c.Value.ToString(), "Licencia");
                    else
                        CargarHorarioCelda(c.ColumnIndex, "v", "Licencia");
                }
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
            if (f.Cells[0].Value == null || f.Cells[0].Value.ToString() == "")
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
            if (f.Cells[3].Value == null || f.Cells[3].Value.ToString().IndexOfAny(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }) != 0)
            {
                dgEscalafon.Focus();
                dgEscalafon.CurrentCell = f.Cells[3];
                f.Cells[3].Selected = true;
                return false;
            }

            //Validar Horarios
            for (int j = 4; j < 11; j++)
            {
                if (f.Cells[j].Value == null)
                    f.Cells[j].Value = "EnOtroServ";
                else
                    if(!ValidarHorario(f.Cells[j].Value.ToString()))
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
            if (hor=="EnOtroServ" || hor=="Descanso" || hor=="Licencia")
                return true;
            if (hor.IndexOfAny(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }) != 0)
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
            //if (dti > dtf)
            //    return false;
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
                    ActualizarHporCubrir();
                    int n = dgEscalafon.Rows.Add();
                    ((DataGridViewComboBoxCell)dgEscalafon.Rows[n].Cells[dgEscalafon.Columns.Count - 1]).Value = "Cliente";

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
                ((DataGridViewComboBoxCell)dgEscalafon.Rows[n].Cells[dgEscalafon.Columns.Count - 1]).Value = "Cliente";
                
                dgEscalafon.Focus();
                dgEscalafon.CurrentCell = dgEscalafon.Rows[n].Cells[0];
                //dgEscalafon.Rows[n].Cells[2].Selected = true;
            }
        }

         private void CargarHporCubrir()
         {

             bool cubierto = true;
             for (int i = 0; i < 7; i++)
             {
                 dgvHsPorCubrir.Rows[0].Cells[i].Value = impHora(hporCubrir[i]);
                 if (hporCubrir[i] > TimeSpan.Zero)
                 {
                     dgvHsPorCubrir.Rows[0].Cells[i].Style.BackColor = Color.FromArgb(255, 128, 128);//Rojo
                     cubierto = false;
                 }
                 else
                     if (hporCubrir[i] < TimeSpan.Zero)
                         dgvHsPorCubrir.Rows[0].Cells[i].Style.BackColor = Color.FromArgb(128, 255, 128);//Verde
                     else
                         dgvHsPorCubrir.Rows[0].Cells[i].Style.BackColor = Color.White;//Blanco
             }
             ContCubierto = cubierto;
             if (cubierto)
             {
                 cubiertoTB.BackColor = Color.FromArgb(128, 255, 128);
                 CubiertoLBL.Text = "CUBIERTO";
             }
             else
             {
                 cubiertoTB.BackColor = Color.FromArgb(255, 128, 128);
                 CubiertoLBL.Text = "NO CUBIERTO";
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

         private TimeSpan[] ObtenerHorasFila(int f)
         {
             TimeSpan[] aux = new TimeSpan[7];             
             string valor;
             DataGridViewRow fila = dgEscalafon.Rows[f];
             for (int i = 0; i < 7; i++)
             {
                 valor = fila.Cells[i + 4].Value.ToString();
                 aux[i] = ObtenerHoraString(valor);
                 //if (valor=="EnOtroServ" || valor == "Descanso" || valor == "Licencia")
                 //    aux[i] = a;
                 //else
                 //    aux[i] = calcDif(fila.Cells[i + 4].Value.ToString());
             }
             return aux;
         }

         private TimeSpan ObtenerHoraString(string horario)
         {
             TimeSpan a = new TimeSpan(0, 0, 0);
             if (horario == "EnOtroServ" || horario == "Descanso" || horario == "Licencia" || horario == "v")
                 return a;
             else
                 return calcDif(horario);
         }


         private TimeSpan calcDif(string p)
         {
             DateTime dti, dtf;
             TimeSpan res;

             dti = DateTime.ParseExact(p.Substring(0,5), @"HH:mm", DateTimeFormatInfo.InvariantInfo);
             dtf = DateTime.ParseExact(p.Substring(8,5), @"HH:mm", DateTimeFormatInfo.InvariantInfo);
             if (dtf < dti)
                 dtf = dtf.AddDays(1);
             res = dtf - dti;

             return res;
         }

         private void dgEscalafon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
         {
             if (LastCellChanged != null && LastCellChanged.Value != null)
             {
                 int j = LastCellChanged.ColumnIndex;
                 //&& LastCellChanged.Value != ""
                 try
                 {
                     if (LastCellChanged.ColumnIndex == 0)
                     {
                         EmPleadOs emp;
                        
                         if (sistemaEmp.existeEmpleado(int.Parse(LastCellChanged.Value.ToString())))
                         {
                             emp = datos.obtenerEmpleado(int.Parse(LastCellChanged.Value.ToString()));
                             if (emp.Activo == 1)
                             {
                                 dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[1].Value = emp.Nombre + " " + emp.Apellido;
                                 //dgEscalafon.CurrentCell = dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[2];
                             }
                             else
                             {
                                 MessageBox.Show("El empleado " + emp.Nombre + " " + emp.Apellido + " - " + emp.NroEmpleado + " está inactivo", "Empleado Inactivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[0].Value = "";
                                 dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[1].Value = "";                                 
                             }
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
                     else
                         if (LastCellChanged.ColumnIndex > 3 && LastCellChanged.ColumnIndex < 11)
                         {
                             if (dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[j].Value == null || !ValidarHorario(dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[j].Value.ToString()))
                             {
                                 dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[j].Value = oldvalor;
                                 dgEscalafon.Focus();
                                 dgEscalafon.CurrentCell = dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[j];
                                 dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[j].Selected = true;
                                 MessageBox.Show(this, "Horario mal ingresado", "Celda no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             }
                             else
                             {
                                 CargarHorarioCelda(j, oldvalor, dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[j].Value.ToString());
                                 if (PisaHorario(dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[0].Value.ToString(), LastCellChanged.RowIndex, dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[j].Value.ToString()))
                                     MessageBox.Show("El empleado " + dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[0].Value.ToString() + " ya trabaja dentro de ese horario en este cliente", "Solapamiento de Horarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                 //TimeSpan aux = ObtenerHoraString(dgEscalafon.Rows[LastCellChanged.RowIndex].Cells[j].Value.ToString());
                                 //hporCubrir[j-4] = hporCubrir[j-4] - aux;
                                 //CargarHporCubrir();
                             }

                         }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }                   
             }
         }

         private bool PisaHorario(string NroFunc, int NroLinea, string Hor)
         {
             int totLineas = dgEscalafon.RowCount;
             string valor;

             if (!(Hor == "EnOtroServ" || Hor == "Descanso" || Hor == "Licencia" || Hor == "v"))
             {
                 if (totLineas > 0)
                 {
                     for (int i = 0; i < totLineas; i++)
                     {
                         if (i != NroLinea && dgEscalafon.Rows[i].Cells[0].Value.ToString() == NroFunc)
                         {
                             for (int j = 0; j < 7; j++)
                             {
                                 valor = (string) dgEscalafon.Rows[i].Cells[j + 4].Value;
                                 if (valor != null)
                                 {
                                     if (valor == "EnOtroServ" || valor == "Descanso" || valor == "Licencia" || valor == "v")
                                         j = j;
                                     else
                                         if (HorariosSolapados(obtHIni(Hor), obtHFin(Hor), obtHIni(valor), obtHFin(valor)))
                                             return true;
                                 }
                             }
                         }
                     }
                 }
             }
             return false;
         }            

         private void GuardarBTN_Click(object sender, EventArgs e)
         {
             bool solapa;
             bool hubosolapa = false;
             dgEscalafon.EndEdit();

             try
             {
                 if (ValidarEscalafon())
                 {
                     int numCli = int.Parse(mtCliente.Text);
                     int numSer = int.Parse(mtServicio.Text);
                     int nroCon = CalcNroContrato(numCli, numSer);
                     Escalafon es = new Escalafon();
                     es.Cubierto = ContCubierto;
                     es.ListaEscalafonEmpleados = new List<EscalafonEmpleado>();

                     // ACA GUARDO TODOS LOS DATOS DEL DATAGRIDVIEW

                     EscalafonEmpleado linea;
                     HorarioEscalafon hor = null;
                     DataGridViewCell cel = null;

                     foreach (DataGridViewRow fila in dgEscalafon.Rows)
                     {
                         linea = new EscalafonEmpleado();
                         linea.NroEmpleado = int.Parse(fila.Cells[0].Value.ToString());
                         linea.CodigoPuesto = fila.Cells[2].Value.ToString();
                         linea.CantidadHsLlamadaAntesHoraInicio = int.Parse(fila.Cells[3].Value.ToString().Substring(0, 1));
                         linea.AcargoDe = fila.Cells[11].Value.ToString();
                         linea.Horario = new List<HorarioEscalafon>();
                         solapa = false;
                         for (int i = 0; i < 7; i++)
                         {
                             cel = fila.Cells[dias[i]];
                             if (cel.Value.ToString().IndexOfAny(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }) == -1) //cel.Value.ToString() == "Descanso" || cel.Value.ToString() == "Licencia")
                             {
                                 hor = new HorarioEscalafon(dias[i], cel.Value.ToString());
                                 cel.Style.BackColor = Color.FromArgb(255, 255, 192);//Amarillito
                             }
                             else
                             {
                                 solapa = sistema.EsHorarioSolapado(nroCon, linea.NroEmpleado, dias[i], obtHIni(cel.Value.ToString()), obtHFin(cel.Value.ToString()));
                                 hor = new HorarioEscalafon(dias[i], obtHIni(cel.Value.ToString()), obtHFin(cel.Value.ToString()), solapa);
                                 if (solapa)
                                 {
                                     hubosolapa = true;
                                     cel.Style.BackColor = Color.Red;//Rojo
                                 }
                                 else
                                     cel.Style.BackColor = Color.FromArgb(255, 255, 192);//Amarillito
                             }
                             linea.Horario.Add(hor);
                         }

                         es.ListaEscalafonEmpleados.Add(linea);
                     }

                     if (datos.existeEscalafon(nroCon))
                         sistema.modificarEscalafon(nroCon, es);
                     else
                         sistema.altaEscalafon(numCli, numSer, nroCon, es);

                     sistema.marcarSolapados(nroCon, es);

                     if (hubosolapa)
                     {                         
                         MessageBox.Show("Datos guardados correctamente.\nEn los horarios en rojo el empleado ya trabaja.", "Guardado de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                     else
                         MessageBox.Show("Datos guardados correctamente.", "Guardado de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                     MessageBox.Show(this, "Error en la celda seleccionada", "Línea no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
             catch (Exception ex)
             {                 
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
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

        private void enOtroServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in dgEscalafon.SelectedCells)
            {               
                if (c.ColumnIndex > 3 && c.ColumnIndex < 11)
                {
                    if (c.Value != null)
                        CargarHorarioCelda(c.ColumnIndex, c.Value.ToString(), "EnOtroServ");
                    else
                        CargarHorarioCelda(c.ColumnIndex, "v", "EnOtroServ");
                }
                //c.Style 
                c.Value = "EnOtroServ";
            }
        }

        private bool EsHorario(string texto)
        {
            return (texto.IndexOfAny(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }) == 0);
        }

        private void VerContratoBTN_Click(object sender, EventArgs e)
        {
            int NroCon = CalcNroContrato(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text));
            ShowContrato sc = new ShowContrato(int.Parse(mtCliente.Text), int.Parse(mtServicio.Text), NroCon);
            sc.Show();
        }

        private void ActualizarHporCubrir()
        {
            int numCli = int.Parse(mtCliente.Text);
            int numSer = int.Parse(mtServicio.Text);
            
            int nroCon = CalcNroContrato(numCli, numSer);
            try
            {
                if (datos.existeContrato(nroCon))
                {
                    contrato = sistema.getContrato(nroCon);
                    hporCubrir = contrato.getTotalesHoras();
                    CargarHporCubrir();

                    int totLineas = dgEscalafon.RowCount;
                    if (totLineas > 0)
                    {
                        if (ValidarEscalafon())
                        {
                            for (int i = 0; i < totLineas; i++)
                            {
                                hporCubrir = restar(hporCubrir, ObtenerHorasFila(i));
                            }

                            CargarHporCubrir();
                        }
                        else
                            MessageBox.Show(this, "Error en la celda seleccionada", "Línea no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HorariosSolapados(string hi1, string hf1, string hi2, string hf2)
        {
            DateTime dti1, dtf1, dti2, dtf2;

            dti1 = DateTime.ParseExact(hi1, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dtf1 = DateTime.ParseExact(hf1, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dti2 = DateTime.ParseExact(hi2, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dtf2 = DateTime.ParseExact(hf2, @"HH:mm", DateTimeFormatInfo.InvariantInfo);

            if (dti2 < dtf1 && dtf2 > dti1)
                return true;
            else
                return false;
        }

        private void dgvHsPorCubrir_SelectionChanged(object sender, EventArgs e)
        {
            dgvHsPorCubrir.ClearSelection();
        }

        private void btnVerEscalafonFuncionario_Click(object sender, EventArgs e)
        {
            VerEscalafonEmpleadoForm veef = new VerEscalafonEmpleadoForm();
            try
            {
                veef.ShowDialog(this);
            }
            catch (Exception ex)
            {
            }
        }
        
    }
}
