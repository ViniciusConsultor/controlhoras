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
    public partial class ContratoForm : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();
        private IDatos datos = ControladorDatos.getInstance();
        int idser;
        int ind;
        int cant;
        int[] numerosSer;
        String LlenarCamposObligatorios = "Debe llenar todos los campos obligatorios.";

        DataGridViewCell celda;
        string stbuffer;
        
        string[] dias = new string[]{"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"};

        public ContratoForm()
        {
            InitializeComponent();
                       
            InicializarCargaHorariaDGV();            
            CostoCB.SelectedIndex = 0;
            bcUC.cliPronto += new EventHandler(bcUC_cliPronto);
            stbuffer = @"N/T";
            celda = null;

            bcUC.Controls["ClienteMT"].Focus();
            idser = -1;
        }

        public ContratoForm(string idCliente, string idServicio)
        {
            InitializeComponent();

            InicializarCargaHorariaDGV();
            CostoCB.SelectedIndex = 0;
            ind = 0;
            cant = 0;
            bcUC.cliPronto += new EventHandler(bcUC_cliPronto);
            stbuffer = @"N/T";

            bcUC.ClienteNRO = idCliente;
            idser = int.Parse(idServicio);            
        }


        private void InicializarCargaHorariaDGV()
        {
            MaskedTextBoxColumn mtbc;

            
            
            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Lunes";
            mtbc.HeaderText = "Lunes";            
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Martes";
            mtbc.HeaderText = "Martes";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Miercoles";
            mtbc.HeaderText = "Miercoles";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Jueves";
            mtbc.HeaderText = "Jueves";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Viernes";
            mtbc.HeaderText = "Viernes";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Sabado";
            mtbc.HeaderText = "Sabado";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.Name = "Domingo";
            mtbc.HeaderText = "Domingo";
            mtbc.Mask = @"00:00 \a 00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);
        }

        private void CostoCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CostoCB.SelectedItem.ToString() == "fijo")
                MontoTB.ReadOnly = false;
            else
                MontoTB.ReadOnly = true;
        }

        private void FinCKB_CheckedChanged(object sender, EventArgs e)
        {
            if (FinCKB.Checked)
                FFinMTB.Enabled = true;
            else
                FFinMTB.Enabled = false;
        }

        private void bcUC_cliPronto(object sender, EventArgs e)
        {
            GuardarBTN.Enabled = false;
            AnteriorBTN.Visible = false;
            PosteriorBTN.Visible = false;
            LimpiarForm();
            
            ServicioGB.Enabled = false;

            ind = 0;

            if (bcUC.find)
            {
                int numCli = int.Parse(bcUC.ClienteNRO);
                Cliente cli = sistema.obtenerCliente(numCli);
                List<Servicio> servicios = cli.getListaServicios();
                if (servicios.Count != 0)
                {
                    GuardarBTN.Enabled = true;
                    ServicioGB.Enabled = true;                    
                    
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
                                      
                    
                    llenarForm(numCli, numerosSer[ind]);

                    
                    //NroMTB.Focus();
                    //NroMTB.SelectAll();

                    if (cant > 1)
                    {
                        AnteriorBTN.Visible = true;
                        PosteriorBTN.Visible = true;
                    }
                }
            }
        }

        private void llenarForm(int numCli, int numSer)
        {
            Servicio ser = sistema.obtenerServicioCliente(numCli, numSer);            

            NroMTB.Text = ser.getNumero().ToString();
            NombreTB.Text = ser.getNombre();

            
            ConSeguridadFisica con = null;
            int nroCon = CalcNroContrato(numCli, numSer);
            if (datos.existeContrato(nroCon))
            {
                con = sistema.getContrato(CalcNroContrato(numCli, numSer));

                FIniMTB.Text = con.getFechaIni().ToString();
                if (con.getFechaFin() != null)
                {
                    FinCKB.Checked = true;
                    FFinMTB.Text = con.getFechaFin().ToString();
                }
                if(con.GetCostoFijo())
                    CostoCB.SelectedIndex = 1;
                else
                    CostoCB.SelectedIndex = 0;
                if (con.getHorasExtras())
                    HorasExtrasCHK.Checked = true;
                AjusteTB.Text = con.getAjuste();
                ObsTB.Text = con.getObservaciones();
                MontoTB.Text = con.getMonto().ToString();

                int i = 0;
                DataGridViewRow insr = null;
                foreach (LineaDeHoras l in con.getLineas())
                {
                    insr = new DataGridViewRow();
                    object[] param = { l.getPuesto(), (l.getArmado())? "1":"0", l.getCantEmp().ToString(), l.getCostoH().ToString()};
                    
                    insr.CreateCells( CargaHorariaDGV, param);

                    CargaHorariaDGV.Rows.Add(insr);

                    foreach (HorarioXDia h in l.getHorario())
                    {
                        CargaHorariaDGV.Rows[i].Cells[h.getDia()].Value = h.getHoraIni() + " a " + h.getHoraFin();
                        //insr.Cells[h.getDia()].Value = h.getHoraIni() + " a " + h.getHoraFin();
                    }
                    
                    // Carga los N/T
                    for (int j=0; j < 11; j++)
                    {
                        if (CargaHorariaDGV.Rows[i].Cells[j].Value == null)
                            CargaHorariaDGV.Rows[i].Cells[j].Value = @"N/T";
                    }
                                        
                    i++;                  
                    
                }
                /*
                con = datos.obtenerContrato(CalcNroContrato(numCli, numSer));
                FIniMTB.Text=con.FechaIni.ToString();
                if (con.FechaFin != null)
                {
                    FinCKB.Checked=true;
                    FFinMTB.Text=con.FechaFin.ToString();
                }
                if (con.CostoFijo == 1)
                    CostoCB.SelectedIndex = 1;
                else
                    CostoCB.SelectedIndex = 0;
                if (con.HorasExtras==1)
                    HorasExtrasCHK.Checked=true;
                AjusteTB.Text=con.Ajuste;
                ObsTB.Text=con.Observaciones;
                MontoTB.Text=con.Costo.ToString();
                */
            }
            //else
            //    FIniMTB.Focus();            
        }

        private void AnteriorBTN_Click(object sender, EventArgs e)
        {            
            int numCli = int.Parse(bcUC.ClienteNRO);
            if ((ind - 1) < 0)
                ind = cant - 1;
            else
                ind = ind - 1;

            LimpiarForm();
            llenarForm(numCli, numerosSer[ind]);
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {    
            int numCli = int.Parse(bcUC.ClienteNRO);
            ind = (ind + 1) % cant;

            LimpiarForm();
            llenarForm(numCli, numerosSer[ind]);
        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            //LimpiarPlanilla();

            bcUC.Controls["ClienteMT"].Focus();
            SendKeys.Send("{ENTER}");
        }

        private void ContratoForm_Shown(object sender, EventArgs e)
        {
            if (bcUC.Controls["ClienteMT"].Text != "")
            {
                bcUC.Controls["ClienteMT"].Focus();
                SendKeys.Send("{ENTER}");                
            }
        }

        private void CargaHorariaDGV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                /*foreach (DataGridViewCell c in CargaHorariaDGV.SelectedCells)
                    c.Selected = false;
                
                CargaHorariaDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;*/

                celda = CargaHorariaDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                CargaHorariaCMS.Show(MousePosition);                
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (CargaHorariaDGV.SelectedCells[0].Value != null)
            if (celda != null)
                stbuffer = celda.Value.ToString();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in CargaHorariaDGV.SelectedCells)
                c.Value = stbuffer;            
        }

        private void marcarNTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell c in CargaHorariaDGV.SelectedCells)
                c.Value = @"N/T";
        }

        private void GuardarBTN_Click(object sender, EventArgs e)
        {
            if (checkDatosObligatorios())
            {
                try
                {                    
                    int numCli = int.Parse(bcUC.ClienteNRO);
                    int numSer = int.Parse(NroMTB.Text);
                    DateTime dti = DateTime.ParseExact(FIniMTB.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                    DateTime? dtf = null;
                    if (FinCKB.Checked)
                        dtf = DateTime.ParseExact(FFinMTB.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                    bool costo = (CostoCB.SelectedItem.ToString() == "fijo");
                    bool hx = HorasExtrasCHK.Checked;
                    float monto = 0;
                    if (MontoTB.Text != "")
                        monto = int.Parse(MontoTB.Text);
                    int nroCon = CalcNroContrato(numCli, numSer);

                    ConSeguridadFisica con = new ConSeguridadFisica(hx, 0, 0, 0, dti, dtf, AjusteTB.Text, ObsTB.Text, costo, monto);

                    // ACA GUARDO TODOS LOS DATOS DEL DATAGRIDVIEW

                    LineaDeHoras linea = null;
                    HorarioXDia hor = null;
                    DataGridViewCell cel = null;
                    foreach (DataGridViewRow fila in CargaHorariaDGV.Rows)
                    {
                        if (fila.Cells[0].RowIndex + 1 < CargaHorariaDGV.RowCount)
                        {
                            if (fila.Cells["Armado"].Value == null)
                                fila.Cells["Armado"].Value = "0";
                            linea = new LineaDeHoras(fila.Cells["Puesto"].Value.ToString(), (fila.Cells["Armado"].Value.ToString() == "1") ? true : false, float.Parse(fila.Cells["PrecioXHora"].Value.ToString()), int.Parse(fila.Cells["Cantidad"].Value.ToString()), 0, 0);
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
                        sistema.altaContrato(nroCon , con);
  
                    /*
                    if (datos.existeContrato(nroCon))
                        datos.modificarContrato(nroCon, dti, dtf, costo, hx, AjusteTB.Text, ObsTB.Text, monto);
                    else
                        sistema.altaContratoServicioCliente(numCli, numSer, CalcNroContrato(numCli,numSer), dti, dtf, costo,  hx, AjusteTB.Text, ObsTB.Text, monto);
                    */
                    //CancelarBTN.PerformClick();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }

        private string obtHFin(string texto)
        {
            return texto.Substring(8, 5);
        }

        private string obtHIni(string texto)
        {
            return texto.Substring(0, 5);
        }

        private bool checkDatosObligatorios()
        {
            bool valFIni = (FIniMTB.Text.IndexOfAny(new Char[]{'1','2','3','4','5','6','7','8','9','0'}) != -1);
            if (valFIni)
                return true;
            else
                return false;
        }

        public int CalcNroContrato(int nroCli, int nroSer)
        {
            return nroCli * 10 + nroSer;
        }


        private bool ValidarFecha(string fecha)
        {
            DateTime dt;
            DateTimeStyles dts = new DateTimeStyles();

            return DateTime.TryParseExact(fecha, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo, dts, out dt);
        }

        private void FIniMTB_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(FIniMTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(FIniMTB, "No es una fecha válida");
            }
        }           

        private void FIniMTB_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(FIniMTB, "");
        }

        private void FFinMTB_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(FFinMTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(FFinMTB, "No es una fecha válida");
            }

        }

        private void FFinMTB_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(FFinMTB, "");
        }

        private void LimpiarForm()
        {            
            FIniMTB.Text = "";
            FinCKB.Checked = false;
            FFinMTB.Text = "";
            CostoCB.SelectedIndex = 0;
            HorasExtrasCHK.Checked = false;
            AjusteTB.Text = "";
            ObsTB.Text = "";
            MontoTB.Text = "";

            CargaHorariaDGV.Rows.Clear();
        }
    
    }
}
