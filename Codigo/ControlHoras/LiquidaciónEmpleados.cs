using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;
using Datos;
using Utilidades;
using System.Globalization;


namespace ControlHoras
{
    public partial class LiquidaciónEmpleados : Form
    {
        IDatos datos;
        DataTable empleados;
        List<DateTime> feriados;
        DateTime mesAct;
        int cant, ind;

        object missing = null;
        string exefile = null;
        FileInfo Info = null;
        string dirbase = null;
        string dirRelativaDocs = null;
        ProgressBarShow progress = null;
        public LiquidaciónEmpleados()
        {
            InitializeComponent();

            try
            {
                datos = ControladorDatos.getInstance();
                feriados = datos.ObtenerFeriados();
                
                missing = System.Reflection.Missing.Value;
                exefile = Application.ExecutablePath;
                Info = new FileInfo(exefile);
                //dirbase = Info.Directory.Parent.Parent.FullName;
                dirbase = Info.DirectoryName;//System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                dirRelativaDocs = ConfigurationManager.AppSettings["DirectorioRelativoDocs"].ToString();
                                      
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MesDTP.CustomFormat = @"MMMM,yyyy";
            MesDTP.Format = DateTimePickerFormat.Custom;
            MesDTP.Value = DateTime.Now.AddMonths(-1);
        }

        private void LiquidarBTN_Click(object sender, EventArgs e)
        {            
            DateTime inicio, fin, aux;

            AnteriorBTN.Visible = false;
            PosteriorBTN.Visible = false;
            
            inicio = new DateTime(MesDTP.Value.Year, MesDTP.Value.Month, 1);
            aux = new DateTime(MesDTP.Value.Year, MesDTP.Value.AddMonths(1).Month, 1);
            fin = aux.AddDays(-1);

            try
            {
                datos.LiquidarEmpleados(inicio, fin);
                datos.empleadosLiquidados(out empleados);
                //datos.CalcularDescansos();
                

                splitContainer2.Visible = true;
                mesAct = MesDTP.Value;
                string auxst = MesDTP.Value.ToString(@"MMMM' del 'yyyy");
                MesTB.Text = auxst.Substring(0, 1).ToUpper() + auxst.Substring(1);

                cant = empleados.Rows.Count;
                if (cant == 0)
                    MessageBox.Show("No existen horas registradas para: " + MesDTP.Value.ToString(@"MMMM/yyyy"), "No hay datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (cant > 1)
                    {
                        AnteriorBTN.Visible = true;
                        PosteriorBTN.Visible = true;
                    }
                    ind = 0;
                    CargarEmpleado();
                    btnExportarTodos.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al efectuar la liquidación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }            
        }

        private void CargarEmpleado()
        {
            int nroEmp, numf, sep = 0;            
            DateTime auxdt = DateTime.Today;           

            LiquidacionDGV.Rows.Clear();

            //DataGridViewButtonColumn
            
            nroEmp = int.Parse(empleados.Rows[ind].ItemArray[0].ToString());
            mtNumeroEmpleado.Text = nroEmp.ToString();

            try
            {
                EmPleadOs emp = datos.obtenerEmpleado(nroEmp);
                TipOscarGoS tc = datos.obtenerCargo((int)emp.IDCargo);

                EmpleadoLBL.Text = emp.NroEmpleado.ToString() + " - " + emp.Apellido + ", " + emp.Nombre;
                CargoLBL.Text = tc.Nombre;

                bool cobraextra = (tc.CobraHsExtras == 1);

                List<DataDiaFacturacion> liq = datos.LiquidarUnEmpleado(emp, tc);                

                List<int> obs = datos.obtenerObsCambios(nroEmp, mesAct);                

                foreach (DataDiaFacturacion dia in liq)
                {
                    numf = LiquidacionDGV.Rows.Add();                    
                    
                    if (feriados.Contains(dia.Dia))
                        sep = 2;
                    else
                        sep = 0;
                    //sep = (feriados.Contains(iter.Current.Key))?2:0;

                    LiquidacionDGV.Rows[numf].Cells[0].Value = dia.Dia.Day.ToString();
                    LiquidacionDGV.Rows[numf].Cells[1 + sep].Value = (auxdt + dia.HsComunes).ToString("HH:mm");
                    LiquidacionDGV.Rows[numf].Cells[2 + sep].Value = (auxdt + dia.HsExtras).ToString("HH:mm");
                    if (obs.Contains(dia.Dia.Day))
                        LiquidacionDGV.Rows[numf].Cells[5].Value = "*";
                }

                CalcularTotales();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            //EXTRAS LIQUIDACIÓN

            ExtraLiquiGB.Visible = false;
            ExtraLiquidaciónLB.DataSource = null;
            ExtraLiquidaciónLB.Items.Clear();
            

            DataEmpleadoExLiquidacion exLiqui = null;

            try
            {
                exLiqui = datos.obtenerExLiquidacionEmpleado(nroEmp, mesAct);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (exLiqui.listaExLiqui.Count > 0)
            {
                ExtraLiquiGB.Visible = true;
                
                Dictionary<int, string> exsliqs = new Dictionary<int,string>();
                int i=0;
                foreach(DataExtraLiquidacion el in exLiqui.listaExLiqui)
                {
                    
                    exsliqs.Add(i,@"$U "+el.valor.ToString()+ " (" + el.descripcion+" "+el.cuota+")");
                    i++;
                }

                BindingSource bs = new BindingSource();
                bs.DataSource = exsliqs;
                
                ExtraLiquidaciónLB.ValueMember = "Key";
                ExtraLiquidaciónLB.DisplayMember = "Value";

                if (ExtraLiquidaciónLB.DataSource != null)
                {
                    //cmb.BindingContext[cmb.DataSource].SuspendBinding();
                    ExtraLiquidaciónLB.DataSource = exsliqs;
                    ExtraLiquidaciónLB.BeginUpdate();                    
                    ExtraLiquidaciónLB.EndUpdate();
                    //cmb.BindingContext[cmb.DataSource].ResumeBinding();
                }
                else
                    ExtraLiquidaciónLB.DataSource = bs;

                ExtraLiquidaciónLB.SelectedIndex = -1;

                ExLiquiTotTB.Text = "$U " + exLiqui.total.ToString();
            }
           

            //EVENTOS

            EventosGB.Visible = false;
            EventosTB.Text = "";

            DataEventosHE eventos = null;

            try
            {
                eventos = datos.obtenerEventosHistEmpleado(nroEmp, mesAct);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (eventos.listaEventos.Count > 0)
            {
                EventosGB.Visible = true;

                string aux = "";
                foreach (DataEventoHistEmpleado e in eventos.listaEventos)
                {
                    aux = aux + "* " + e.inicio.ToString(@"dd/MM/yyyy") + " a " + e.fin.ToString(@"dd/MM/yyyy") + " - " + e.tipo + " (" + e.desc + ")" + "\n";
                }

                EventosTB.Text = aux;
            }

        }


        //private void CargarEmpleado2()
        //{
        //    int nroEmp, numf, sep = 0;
        //    TimeSpan hc, he;
        //    DateTime auxdt = DateTime.Today;
        //    DateTime aux2;

        //    LiquidacionDGV.Rows.Clear();

        //    //DataGridViewButtonColumn

        //    nroEmp = int.Parse(empleados.Rows[ind].ItemArray[0].ToString());
        //    mtNumeroEmpleado.Text = nroEmp.ToString();

        //    try
        //    {
        //        EmPleadOs emp = datos.obtenerEmpleado(nroEmp);
        //        TipOscarGoS tc = datos.obtenerCargo((int)emp.IDCargo);

        //        EmpleadoLBL.Text = emp.NroEmpleado.ToString() + " - " + emp.Apellido + ", " + emp.Nombre;
        //        CargoLBL.Text = tc.Nombre;

        //        bool cobraextra = (tc.CobraHsExtras == 1);

        //        Dictionary<DateTime, TimeSpan> liq = datos.LiquidarunEmpleado(nroEmp);
        //        Dictionary<DateTime, TimeSpan>.Enumerator iter = liq.GetEnumerator();

        //        List<int> obs = datos.obtenerObsCambios(nroEmp, mesAct);

        //        while (iter.MoveNext())
        //        {
        //            numf = LiquidacionDGV.Rows.Add();
        //            aux2 = new DateTime(2000, iter.Current.Key.Month, iter.Current.Key.Day);
        //            if (feriados.Contains(aux2))
        //                sep = 2;
        //            else
        //                sep = 0;
        //            //sep = (feriados.Contains(iter.Current.Key))?2:0;
        //            CalcularHsExtras(cobraextra, (int)tc.CantidadHsComunes, iter.Current.Value, out hc, out he);
        //            LiquidacionDGV.Rows[numf].Cells[0].Value = iter.Current.Key.Day.ToString();
        //            LiquidacionDGV.Rows[numf].Cells[1 + sep].Value = (auxdt + hc).ToString("HH:mm");
        //            LiquidacionDGV.Rows[numf].Cells[2 + sep].Value = (auxdt + he).ToString("HH:mm");
        //            if (obs.Contains(iter.Current.Key.Day))
        //                LiquidacionDGV.Rows[numf].Cells[5].Value = "*";
        //        }

        //        CalcularTotales();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    //EXTRAS LIQUIDACIÓN

        //    ExtraLiquiGB.Visible = false;
        //    ExtraLiquidaciónLB.DataSource = null;
        //    ExtraLiquidaciónLB.Items.Clear();


        //    DataEmpleadoExLiquidacion exLiqui = null;

        //    try
        //    {
        //        exLiqui = datos.obtenerExLiquidacionEmpleado(nroEmp, mesAct);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    if (exLiqui.listaExLiqui.Count > 0)
        //    {
        //        ExtraLiquiGB.Visible = true;

        //        Dictionary<int, string> exsliqs = new Dictionary<int, string>();
        //        int i = 0;
        //        foreach (DataExtraLiquidacion el in exLiqui.listaExLiqui)
        //        {

        //            exsliqs.Add(i, @"$U " + el.valor.ToString() + " (" + el.descripcion + " " + el.cuota + ")");
        //            i++;
        //        }

        //        BindingSource bs = new BindingSource();
        //        bs.DataSource = exsliqs;

        //        ExtraLiquidaciónLB.ValueMember = "Key";
        //        ExtraLiquidaciónLB.DisplayMember = "Value";

        //        if (ExtraLiquidaciónLB.DataSource != null)
        //        {
        //            //cmb.BindingContext[cmb.DataSource].SuspendBinding();
        //            ExtraLiquidaciónLB.DataSource = exsliqs;
        //            ExtraLiquidaciónLB.BeginUpdate();
        //            ExtraLiquidaciónLB.EndUpdate();
        //            //cmb.BindingContext[cmb.DataSource].ResumeBinding();
        //        }
        //        else
        //            ExtraLiquidaciónLB.DataSource = bs;

        //        ExtraLiquidaciónLB.SelectedIndex = -1;

        //        ExLiquiTotTB.Text = "$U " + exLiqui.total.ToString();
        //    }


        //    //EVENTOS

        //    EventosGB.Visible = false;
        //    EventosTB.Text = "";

        //    DataEventosHE eventos = null;

        //    try
        //    {
        //        eventos = datos.obtenerEventosHistEmpleado(nroEmp, mesAct);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }

        //    if (eventos.listaEventos.Count > 0)
        //    {
        //        EventosGB.Visible = true;

        //        string aux = "";
        //        foreach (DataEventoHistEmpleado e in eventos.listaEventos)
        //        {
        //            aux = aux + "* " + e.inicio.ToString(@"dd/MM/yyyy") + " a " + e.fin.ToString(@"dd/MM/yyyy") + " - " + e.tipo + " (" + e.desc + ")" + "\n";
        //        }

        //        EventosTB.Text = aux;
        //    }

        //}

        private void CalcularTotales()
        {
            TimeSpan hsc, hsex, hsfe, hsfeex;
            hsc = hsex = hsfe = hsfeex = new TimeSpan(0);
            for (int i = 0; i < LiquidacionDGV.Rows.Count; i++)
            {
                hsc = hsc + new TimeSpan(int.Parse((LiquidacionDGV.Rows[i].Cells[1].Value ?? "00:00").ToString().Split(':').ElementAt(0)), int.Parse((LiquidacionDGV.Rows[i].Cells[1].Value ?? "00:00").ToString().Split(':').ElementAt(1)), 0);
                hsex = hsex + new TimeSpan(int.Parse((LiquidacionDGV.Rows[i].Cells[2].Value ?? "00:00").ToString().Split(':').ElementAt(0)), int.Parse((LiquidacionDGV.Rows[i].Cells[2].Value ?? "00:00").ToString().Split(':').ElementAt(1)), 0);
                hsfe = hsfe + new TimeSpan(int.Parse((LiquidacionDGV.Rows[i].Cells[3].Value??"00:00").ToString().Split(':').ElementAt(0)), int.Parse((LiquidacionDGV.Rows[i].Cells[3].Value??"00:00").ToString().Split(':').ElementAt(1)), 0);
                hsfeex = hsfeex + new TimeSpan(int.Parse((LiquidacionDGV.Rows[i].Cells[4].Value ?? "00:00").ToString().Split(':').ElementAt(0)), int.Parse((LiquidacionDGV.Rows[i].Cells[4].Value ?? "00:00").ToString().Split(':').ElementAt(1)), 0);                
            }
            
            HsComunesTB.Text = impHora(hsc);
            HsExtraTB.Text = impHora(hsex);
            HsFeriadoTB.Text = impHora(hsfe);
            HsFerExtTB.Text = impHora(hsfeex);
        }


        

        private void CalcularHsExtras(bool cobraextras, int cantHscomun, TimeSpan HsTotal, out TimeSpan HsComun, out TimeSpan HsExtras)
        {
            HsComun = HsTotal;
            HsExtras = new TimeSpan(0);
            TimeSpan aux = new TimeSpan(cantHscomun,0,0);
            if (cobraextras && HsTotal > aux)
            {
                HsComun = aux;
                HsExtras = HsTotal - aux;
            }
        }

        private void AnteriorBTN_Click(object sender, EventArgs e)
        {
            if ((ind - 1) < 0)
                ind = cant - 1;
            else
                ind = ind - 1;
            CargarEmpleado();
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {
            ind = (ind + 1) % cant;
            CargarEmpleado();
        }


        private string impHora(TimeSpan h)
        {
            return System.Math.Abs(System.Math.Truncate(h.TotalHours)).ToString() + ":" + System.Math.Abs(h.Minutes).ToString();
        }

        private void ExcelBTN_Click(object sender, EventArgs e)
        {
            generarExcel(true,"");   
        }

        private void generarExcel(bool abrirExcel, string outputDirectory)
        {
            string pathdoc = Path.Combine(dirbase, dirRelativaDocs);
            string fileName = Path.Combine(pathdoc, "LiquiEmpleado.xls");
            string bufer;

            if (File.Exists(fileName))
            {
                object readOnly = true;
                object falso = false;
                DateTime auxdt;

                Excel.Application ExApp;
                Excel._Workbook oWBook;
                Excel._Worksheet oSheet;
                Excel.Range ran;

                CultureInfo CultOriginal = System.Threading.Thread.CurrentThread.CurrentCulture;

                try
                {
                    // Iniciar Excel y obtener el objeto Aplicacion.
                    ExApp = new Excel.Application();

                    //****AGREGADO POR EL TEMA DE LA CULTURA*****
                    
                    //CultureInfo cSystemCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                    //CultureInfo cExcelCulture = new CultureInfo(ExAppLanguageSettings.get_LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI));
                    //System.Threading.Thread.CurrentThread.CurrentCulture = cExcelCulture;
                    
                    //object ob = ExApp.LanguageSettings;
                    //CultureInfo cExcelCulture = new CultureInfo

                    
                    //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");


                    //Get a new workbook.
                    //oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                    oWBook = ExApp.Workbooks.Open(fileName, missing, readOnly, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                    //oSheet = (Excel._Worksheet)oWBook.ActiveSheet;
                    oSheet = (Excel._Worksheet)oWBook.Worksheets.get_Item(1);

                    // Mes
                    oSheet.Cells[2, 3] = MesTB.Text;
                    // Nombre
                    oSheet.Cells[4, 4] = EmpleadoLBL.Text;
                    // Cargo
                    oSheet.Cells[5, 4] = CargoLBL.Text;

                    //Eventos Historial
                    if (EventosTB.Text != "")
                        oSheet.Cells[7, 7] = EventosTB.Text;

                    //Los días del mes
                    auxdt = new DateTime(mesAct.Year, mesAct.Month, 1);
                    for (int i = 0; i < DateTime.DaysInMonth(mesAct.Year, mesAct.Month); i++)
                    {
                        oSheet.Cells[8 + i, 2] = auxdt.ToString(@"dd/MM/yyyy");
                        auxdt = auxdt.AddDays(1);
                    }

                    

                    int auxInt, nroEmp = int.Parse(empleados.Rows[ind].ItemArray[0].ToString());
                    string st;
                    List<MotIVOsCamBiosDiARioS> obs;
                    List<HoRaSGeneraDaSEScalaFOn> des;

                    //Descansos
                    des = datos.obtenerDescansos(nroEmp, mesAct);
                    foreach (HoRaSGeneraDaSEScalaFOn d in des)
                    {
                        oSheet.Cells[7 + d.FechaCorrespondiente.Day, 7] = "DESCANSO - ";
                    }

                    //Horas Trabajadas
                    for (int i = 0; i < LiquidacionDGV.Rows.Count; i++)
                    {
                        auxInt = int.Parse(LiquidacionDGV.Rows[i].Cells[0].Value.ToString());
                        
                        oSheet.Cells[7 + auxInt, 3] = (LiquidacionDGV.Rows[i].Cells[1].Value ?? "00:00").ToString();
                        oSheet.Cells[7 + auxInt, 4] = (LiquidacionDGV.Rows[i].Cells[2].Value ?? "00:00").ToString();
                        oSheet.Cells[7 + auxInt, 5] = (LiquidacionDGV.Rows[i].Cells[3].Value ?? "00:00").ToString();
                        oSheet.Cells[7 + auxInt, 6] = (LiquidacionDGV.Rows[i].Cells[4].Value ?? "00:00").ToString();

                        
                        //Observaciones
                        auxdt = new DateTime(mesAct.Year, mesAct.Month, auxInt);
                        obs = datos.obtenerMotivosCambiosDiarios(null,null,nroEmp, auxdt);
                        if (obs.Count > 0)
                        {
                            st = "";
                            foreach (MotIVOsCamBiosDiARioS m in obs)
                                st = st + "*" + m.Observaciones + "* ";
                            bufer = (oSheet.get_Range(oSheet.Cells[7 + auxInt, 7], oSheet.Cells[7 + auxInt, 7]).get_Value(missing) ?? "").ToString();
                            oSheet.Cells[7 + auxInt, 7] = bufer + st;                            
                        }
                    }                   
 


                    //EXTRAS LIQUIDACION
                    if (ExtraLiquidaciónLB.Items.Count > 0)
                    {
                        oSheet = (Excel._Worksheet)oWBook.Worksheets.get_Item(2);

                        // Mes
                        oSheet.Cells[2, 3] = MesTB.Text;
                        // Nombre
                        oSheet.Cells[4, 4] = EmpleadoLBL.Text;
                        // Cargo
                        oSheet.Cells[5, 4] = CargoLBL.Text;

                        //string st;
                        int u, p1, b, p2, i=0; 
                            
                        foreach (object item in ExtraLiquidaciónLB.Items)
                        {
                            st = item.ToString();
                            u = st.IndexOf('U')+2;
                            p1 = st.IndexOf('(');
                            b = st.IndexOf('/');
                            p2 = st.IndexOf(')');

                            oSheet.Cells[9 + i, 3] = st.Substring(u, p1 - u - 1);
                            oSheet.Cells[9 + i, 4] = st.Substring(p1 + 1, b - p1 - 2);
                            oSheet.Cells[9 + i, 5] = st.Substring(b - 2, 2) + " de " + ((b + 2 == p2) ? st.Substring(b + 1, 1) : st.Substring(b + 1, 2));
                            i++;
                        }
                        i++;
                        oSheet.Cells[9 + i, 2] = @"Total($U):";
                        oSheet.Cells[9 + i, 3] = ExLiquiTotTB.Text.Substring(3);
                        
                    }

                    //oWBook.PrintPreview(falso);
                    object a = Path.Combine(outputDirectory, EmpleadoLBL.Text + ".xls");
                    if (!abrirExcel)
                    {
                        ExApp.Visible = false;
                        oWBook.SaveAs(a, missing, missing, missing, missing, missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, missing, missing, missing, true);
                        ExApp.Quit();
                    }
                    else
                        ExApp.Visible = true;
                }
                catch (Exception theException)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, theException.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, theException.Source);
                    throw theException;
                }
                finally
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = CultOriginal;
                }
            }
            else
            {
                throw new NoExisteException("No existe el archivo template: " + fileName);
            }
        }

        private void mtNumeroEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtNumeroEmpleado.Text != "" && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                int aux = int.Parse(mtNumeroEmpleado.Text);
                if (datos.existeEmpleadoLiquidado(aux))
                {
                    buscarIndice(aux);
                    CargarEmpleado();
                }
                else                
                    MessageBox.Show("No existen datos para el empleado Nro: "+mtNumeroEmpleado.Text+" para: "+mesAct.ToString(@"MMMM,yyyy"), "No Hay Datos", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void buscarIndice(int nroEmpleado)
        {
            bool f = false;
            int aux = 0;
            while(aux<empleados.Rows.Count && !f)
            {
                f = (empleados.Rows[aux].ItemArray.ElementAt(0).ToString()==nroEmpleado.ToString());
                if (f)
                    ind = aux;
                else
                    aux++;
            }            
        }

        private void mtNumeroEmpleado_Click(object sender, EventArgs e)
        {
            mtNumeroEmpleado.Text = "";
        }

        private void btnExportTodos_Click(object sender, EventArgs e)
        {
            try
            {
                splitContainer1.Panel2.Enabled = false;
                int indice = 0;
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    progress = new ProgressBarShow(1, empleados.Rows.Count);
                    progress.StartPosition = FormStartPosition.CenterParent;
                    progress.Show(this);
                    LiquidarBTN.Enabled = false;
                    while (indice <= empleados.Rows.Count - 1)
                    {
                        try
                        {
                            PosteriorBTN_Click(null, EventArgs.Empty);
                            generarExcel(false, folderBrowserDialog1.SelectedPath);
                            indice++;
                            progress.aumentar();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    MessageBox.Show("Liquidacion Finalizada con Exito.", "Liquidacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Liquidacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                splitContainer1.Panel2.Enabled = true;
                if (progress != null)
                {
                    progress.Close();
                    progress.Dispose();
                    progress = null;
                }
                LiquidarBTN.Enabled = true;
            }
        }

        private void LiquidaciónEmpleados_Enter(object sender, EventArgs e)
        {
            if (progress != null)
            {
                progress.Focus();
                progress.BringToFront();
            }
        }

        private void LiquidacionDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LiquidacionDGV.Columns[e.ColumnIndex].Name == "Observaciones")
            {                
                DateTime fecha = new DateTime(mesAct.Year, mesAct.Month, int.Parse(LiquidacionDGV.Rows[e.RowIndex].Cells["Dia"].Value.ToString()));
                string nroEmp = EmpleadoLBL.Text.Substring(0,EmpleadoLBL.Text.IndexOf('-')-1);
                try
                {
                    List<MotIVOsCamBiosDiARioS> mot = datos.obtenerMotivosCambiosDiarios(null,null,int.Parse(nroEmp), fecha);

                    if (mot.Count > 0)
                    {
                        VerObservaciones obs = new VerObservaciones(mot);
                        obs.ShowDialog(this);
                    }

                }
                catch (Exception ex)
                {                    
                    MessageBox.Show(ex.Message, "Error al obtener los motivos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } 

        }               
        
    }
}
