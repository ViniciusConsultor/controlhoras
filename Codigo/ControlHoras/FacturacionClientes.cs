using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Utilidades;
using System.IO;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;

namespace ControlHoras
{
    public partial class FacturacionClientes : Form
    {

        IDatos datos;
        object missing = null;
        string exefile = null;
        FileInfo Info = null;
        string dirbase = null;
        string dirRelativaDocs = null;
        DateTime fechaSeleccionada;

        public FacturacionClientes()
        {
            InitializeComponent();
            try
            {
                datos = Datos.ControladorDatos.getInstance();
                missing = System.Reflection.Missing.Value;
                exefile = Application.ExecutablePath;
                Info = new FileInfo(exefile);
                fechaSeleccionada = dtpMesFacturacion.Value;
                cargarClientesServicios();
                dirbase = Info.DirectoryName;
                dirRelativaDocs = ConfigurationManager.AppSettings["DirectorioRelativoDocs"].ToString();
        
            }
            catch
            {
                throw;
            }
        }

        private void cargarClientesServicios()
        {
            try
            {
                List<ClientEs> clientesParaFact = datos.obtenerClientesParaFacturacion(fechaSeleccionada);
                
                tcClientesServicios.cargarDatos(clientesParaFact);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = fbdFolder.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string DirPath = fbdFolder.SelectedPath;
                    Dictionary<int, List<int>> cliServsSeleccionados = tcClientesServicios.obtenerClientesServiciosSeleccionados();
                    if (cliServsSeleccionados.Count > 0)
                    {
                        //int nroCli;
                        ClientEs cliente;
                        SERVicIoS servicio;
                        Dictionary<int, List<int>>.Enumerator iter = cliServsSeleccionados.GetEnumerator();
                        progressBar.Minimum = 0;
                        progressBar.Maximum = cliServsSeleccionados.Count;
                        progressBar.Value = progressBar.Minimum;
                        while (iter.MoveNext())
                        {
                            progressBar.Increment(1);

                            cliente = datos.obtenerCliente(iter.Current.Key);
                            
                            lblEstado.Text = iter.Current.Key.ToString() + " - " + cliente.NombreFantasia;
                            Application.DoEvents();

                            DateTime DiaInicioFact = new DateTime(dtpMesFacturacion.Value.Year, dtpMesFacturacion.Value.Month, cliente.DiaInicioFacturacion);
                            DateTime DiaFinFact;
                            try
                            {
                                DiaFinFact = new DateTime(dtpMesFacturacion.Value.Year, dtpMesFacturacion.Value.Month, cliente.DiaFinFacturacion);
                            }
                            catch (Exception exD)
                            {
                                // Si tira exception es porque el DiaFin no es correcto para el mes. En este caso obtenemos el ultimo dia del mes.
                                // Obtengo el ultimo dia del mes.
                                DiaFinFact = new DateTime(dtpMesFacturacion.Value.Year, dtpMesFacturacion.Value.Month, DateTime.DaysInMonth(dtpMesFacturacion.Value.Year, dtpMesFacturacion.Value.Month));
                            }
                            foreach (int serv in iter.Current.Value)
                            {
                                servicio = datos.obtenerServicioCliente((int)cliente.NumeroCliente, serv);
                                DataFacturacion factCliente = datos.facturarClienteServicio((int)cliente.NumeroCliente, serv, DiaInicioFact, DiaFinFact);
                                generarExcelFacturacionCliente(DirPath, dtpMesFacturacion.Value.Year.ToString() + dtpMesFacturacion.Value.Month.ToString() +"-"+ cliente.Nombre + "-" + servicio.Nombre, factCliente, false);
                            }
                        }
                        MessageBox.Show("Proceso de Facturacion terminado con Exito", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Debe seleccionar por lo menos un Cliente/Servicio a Facturar", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch
            {
                throw;
            }
        
        }

        private bool esFeriado(DateTime d)
        {
            try
            {
                List<DateTime> feriados = datos.ObtenerFeriados();
                foreach (DateTime dia in feriados)
                {
                    if (dia.Day == d.Day && dia.Month == d.Month)
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void generarExcelFacturacionCliente(string outputDirectory, string nombreArchivo, DataFacturacion facturacion, bool abrirExcel)
        {
            string dirbase = Info.DirectoryName;//System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string dirRelativaDocs = ConfigurationManager.AppSettings["DirectorioRelativoDocs"].ToString();
            string pathdoc = Path.Combine(dirbase,dirRelativaDocs);
            string fileName = Path.Combine(pathdoc, "FacturaCliente.xls");
            if (File.Exists(fileName))
            {
                object readOnly = true;
                object falso = false;
                DateTime auxdt;

                Excel.Application ExApp;
                Excel._Workbook oWBook;
                Excel._Worksheet oSheet;
                bool tieneFeriados = false;
                // Iniciar Excel y obtener el objeto Aplicacion.
                ExApp = new Excel.Application();
                try
                {

                    //Get a new workbook.
                    //oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                    oWBook = ExApp.Workbooks.Open(fileName, missing, readOnly, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                    oSheet = (Excel._Worksheet)oWBook.ActiveSheet;


                    // Mes
                    oSheet.Cells[1, 5] = dtpMesFacturacion.Value.Month + "/" + dtpMesFacturacion.Value.Year;
                    oSheet.Cells[2, 3] = facturacion.NroCliente + "/" + datos.getNombreCliente(facturacion.NroCliente);
                    // Nombre
                    string nomServicio = nombreArchivo.Substring(nombreArchivo.LastIndexOf('-') + 1);
                    oSheet.Cells[3, 3] = nomServicio;
                    Excel.Range MyRange;
                    int i = 0;
                    foreach (DataDiaFacturacion ddf in facturacion.ListaDiaFacturacion)
                    {
                        oSheet.Cells[6 + i, 2] = ddf.Dia.ToString(@"dd/MM/yyyy");
                        oSheet.Cells[6 + i, 3] = String.Format("{0}:{1}", ddf.HsComunes.Days * 24 + ddf.HsComunes.Hours, ddf.HsComunes.Minutes);
                        oSheet.Cells[6 + i, 4] = String.Format("{0}:{1}", ddf.HsExtras.Days * 24 + ddf.HsExtras.Hours, ddf.HsExtras.Minutes); ;
                        if (esFeriado(ddf.Dia))
                        {
                            MyRange = (Excel.Range)oSheet.get_Range(
                                oSheet.Cells[6 + i, 2], oSheet.Cells[6 + i, 4]);
                            MyRange.Interior.Color = System.Drawing.Color.YellowGreen.ToArgb();
                            tieneFeriados = true;
                        }
                        i++;
                    }

                    //MyRange = oSheet.get_Range(oSheet.Cells[31+6, 3], oSheet.Cells[31+6, 4]);
                    //MyRange.Cells.NumberFormat = "[h]:mm";
                    //oSheet.Cells[31 + 6, 3] = String.Format("{0}:{1}:{2}", facturacion.TotalHsComunes.Days*24+facturacion.TotalHsComunes.Hours, facturacion.TotalHsComunes.Minutes, facturacion.TotalHsComunes.Seconds);
                    //oSheet.Cells[31 + 6, 4] = String.Format("{0}:{1}:{2}", facturacion.TotalHsExtras.Days * 24 + facturacion.TotalHsExtras.Hours, facturacion.TotalHsExtras.Minutes, facturacion.TotalHsExtras.Seconds);

                    if (tieneFeriados)
                    {
                        oSheet.Cells[40, 3] = "Dias Feriados";
                        oSheet.get_Range(oSheet.Cells[40, 2], oSheet.Cells[40, 2]).Interior.Color = System.Drawing.Color.YellowGreen.ToArgb();
                    }

                    //oWBook.PrintPreview(falso);
                    object a = Path.Combine(outputDirectory, nombreArchivo + ".xls");
                    if (!abrirExcel)
                    {
                        ExApp.Visible = false;
                        oWBook.SaveAs(a, missing, missing, missing, missing, missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, missing, missing, missing, true);
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
                    if (!abrirExcel)
                    {
                        ExApp.Quit();
                    }
                }
            }
            else
            {
                throw new NoExisteException("No existe el archivo template: " + fileName);
            }
        }

        private void dtpMesFacturacion_ValueChanged(object sender, EventArgs e)
        {
            if (!(fechaSeleccionada.Year == dtpMesFacturacion.Value.Year && fechaSeleccionada.Month == dtpMesFacturacion.Value.Month))
            {
                fechaSeleccionada = dtpMesFacturacion.Value;
                cargarClientesServicios();
            }
        }
    }
}
