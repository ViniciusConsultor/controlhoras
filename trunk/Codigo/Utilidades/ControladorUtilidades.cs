using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yogesh.ExcelXml;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Globalization;

namespace Utilidades
{
    public static class ControladorUtilidades
    {
        private static bool LogEnabled = false;
        private static string LogFilePath = "C:\\trustLogic.log";

        public static void writeToLog(Exception objException)
        {
            if (ConfigurationSettings.AppSettings.AllKeys.Contains("LogEnabled"))
                    bool.TryParse(ConfigurationSettings.AppSettings["LogEnabled"], out LogEnabled);
            if (LogEnabled)
            {
                if (ConfigurationSettings.AppSettings.AllKeys.Contains("LogFilePath"))
                    LogFilePath=ConfigurationSettings.AppSettings["LogFilePath"];
            }

            if (LogEnabled)
            {
                string strException = string.Empty;
                try
                {
                    StreamWriter swLog = new StreamWriter(LogFilePath, true);
                    swLog.WriteLine("Source        : " +
                            objException.Source.ToString().Trim());
                    swLog.WriteLine("Method        : " +
                            objException.TargetSite.Name.ToString());
                    swLog.WriteLine("Date        : " +
                            DateTime.Now.ToLongTimeString());
                    swLog.WriteLine("Time        : " +
                            DateTime.Now.ToShortDateString());
                    swLog.WriteLine("Error        : " +
                            objException.Message.ToString().Trim());
                    swLog.WriteLine("Stack Trace    : " +
                            objException.StackTrace.ToString().Trim());
                    swLog.WriteLine("-------------------------------------------------------------------");
                    swLog.Flush();
                    swLog.Close();
                }
                catch (Exception)
                {
             
                }
             
            }
        }

        public static string encriptarStringToMD5(string str)
        {
            string addclave = "6ytrdagwiskddywjankdhdyeuwabyd73jsknxgdyeje";
            try
            {
                str = addclave + str;
                System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] data = System.Text.Encoding.ASCII.GetBytes(str);
                data = x.ComputeHash(data);
                string aaa = System.Text.Encoding.ASCII.GetString(data);

                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
            catch
            {
                throw;
            }
        }

        public static bool exportToExcel_old(DataGridView dgv, string fileName)
        {
            ExcelXmlWorkbook libro = new ExcelXmlWorkbook();

            libro.Properties.Author = "Trust International S.A."; // Tomar el nombre de la empresa de Propertie.
            
            Worksheet hoja = libro[0];
            hoja.Name = "Exportacion";
            //hoja.FreezeTopRows = 3;
            //hoja.DisplayFormat = DisplayFormatType.None;
            hoja.PrintOptions.Orientation = PageOrientation.Landscape;
            hoja.PrintOptions.SetMargins(0.5, 0.4, 0.5, 0.4);

            XmlStyle estiloCeldaNombreColumnas = new XmlStyle();
            estiloCeldaNombreColumnas.Font.Bold = true;
            estiloCeldaNombreColumnas.Alignment.Horizontal = Yogesh.ExcelXml.HorizontalAlignment.Center;
            estiloCeldaNombreColumnas.Border.LineStyle = Borderline.Continuous;
            estiloCeldaNombreColumnas.Border.Weight = 2;
            estiloCeldaNombreColumnas.Border.Sides = BorderSides.All;



            // Primero cargo todas las columnas permitiendo hacerle algun formato diferente.
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                hoja[col.Index, 0].Value = col.Name;
                hoja[col.Index, 0].Style = estiloCeldaNombreColumnas;
            }

            XmlStyle estiloCeldaNormal = new XmlStyle();
            estiloCeldaNormal.Font.Bold = false;
            estiloCeldaNormal.Alignment.Horizontal = Yogesh.ExcelXml.HorizontalAlignment.Left;
            estiloCeldaNormal.Border.LineStyle = Borderline.Continuous;
            estiloCeldaNormal.Border.Weight = 1;
            estiloCeldaNormal.Border.Sides = BorderSides.All;
            //estiloCeldaNormal.DisplayFormat = DisplayFormatType.Text;
            
            int fila = 0;
            int columna = 0;
            double[] maxWithPerColumn;
            TimeSpan h;
            maxWithPerColumn = new double[dgv.Columns.Count];
            DisplayFormatType cellType;
            while (fila < dgv.Rows.Count)
            {
                columna = 0;
                while (columna < dgv.Columns.Count)
                {
                    
                    if (dgv[columna, fila].ValueType == typeof(DateTime))
                    {
                        cellType = DisplayFormatType.GeneralDate;
                        if (dgv[columna,fila].Value.ToString() != "")
                            hoja[columna, fila+1].Value = ((DateTime)dgv[columna,fila].Value).ToShortDateString();
                    }
                    else if (dgv[columna, fila].ValueType == typeof(TimeSpan))
                    {
                        cellType = DisplayFormatType.Time;
                        h = (TimeSpan)dgv[columna, fila].Value;
                        if (dgv[columna, fila].Value.ToString() != "")
                            hoja[columna, fila + 1].Value = System.Math.Abs(System.Math.Truncate(h.TotalHours)).ToString()  + ":" + System.Math.Abs(h.Minutes).ToString();          
                                //((TimeSpan)dgv[columna, fila].Value).ToString();
                    }
                    else if (dgv[columna, fila].ValueType == typeof(Boolean))
                    {
                        cellType = DisplayFormatType.Custom;
                        if (dgv[columna, fila].Value.ToString() != "")
                            hoja[columna, fila+1].Value = ((Boolean)dgv[columna, fila].Value);
                    }
                    else if (dgv[columna, fila].ValueType == typeof(int) || dgv[columna, fila].ValueType == typeof(uint) || dgv[columna, fila].ValueType == typeof(byte) || dgv[columna, fila].ValueType == typeof(sbyte))
                    {
                        cellType = DisplayFormatType.Standard;
                        if (dgv[columna, fila].Value.ToString() != "")
                            hoja[columna, fila + 1].Value = dgv[columna, fila].Value;
                    }
                    else
                    {
                        // String
                        String str = dgv[columna, fila].Value.ToString();//.Replace("\n",Environment.NewLine);
                        cellType = DisplayFormatType.Text;
                        hoja[columna, fila + 1].Value = str;
                        
                    }
                    
                    if (dgv[columna, fila].Value.ToString().Length > maxWithPerColumn[columna])
                    {
                        maxWithPerColumn[columna] = (double)dgv[columna, fila].Value.ToString().Length;
                    }
                    //hoja[columna, fila].ContentType = ContentType.Formula;
                    estiloCeldaNormal.DisplayFormat = cellType;
                    hoja[columna, fila + 1].Style = estiloCeldaNormal;
                    columna++;

                }
                fila++;
            }
            columna = 0;
            while (columna < dgv.Columns.Count)
            {
                hoja.Columns(columna).Width = dgv.Columns[columna].Width;
                columna++;
            }
            
            // no extension is added if not present

            Stream sw = new FileStream(fileName,FileMode.Create);
            bool retval;
            retval = libro.Export(sw);
            sw.Close();
            return retval;
        }


        public static bool exportToExcel(DataGridView dgv, string fileName, string titulo, string userName)
        {
            // FUENTE: http://msdn.microsoft.com/en-us/library/microsoft.office.interop.excel(v=office.11).aspx
            object readOnly = true;

            Excel.Application ExApp = null;
            Excel._Workbook oWBook = null;
            Excel._Worksheet oSheet = null;
            Excel.Range oRng = null;
            CultureInfo CultOriginal = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            try
            {
                // Iniciar Excel y obtener el objeto Aplicacion.
                ExApp = new Excel.Application();

                //Get a new workbook.
                //oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                object misValue = System.Reflection.Missing.Value;


                ExApp = new Excel.ApplicationClass();
                oWBook = ExApp.Workbooks.Add(misValue);
                oSheet = (Excel.Worksheet)oWBook.Worksheets.get_Item(1);
                
                oWBook.Author = "Trust International S.A.";
                oSheet.Name = "Exportacion";

                // Cargamos el titulo, linea 1
                oRng = oSheet.get_Range(oSheet.Cells[1, 1], oSheet.Cells[1, dgv.Columns.Count]);
                oRng.Cells.MergeCells = true;
                oRng.Cells.Value2 = titulo;
                oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
                oRng.Cells.Font.FontStyle = FontStyle.Bold; 
                oRng.Cells.Font.Size = 14;

                int fila_offset = 3;

                // Primero cargo todas las columnas permitiendo hacerle algun formato diferente.
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    oSheet.Cells[fila_offset, col.Index + 1] = col.Name;
                }

                oRng = oSheet.get_Range(oSheet.Cells[fila_offset, 1], oSheet.Cells[fila_offset, dgv.Columns.Count]);
                oRng.Font.Bold = true;
                //oRng.Style = 
                oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, System.Type.Missing);


                int fila = 0;
                int columna = 0;
                fila_offset++;
                // Mes
                columna = 1;
               
                while (columna <= dgv.Columns.Count)
                {
                    fila = 0;
                    while (fila < dgv.Rows.Count)
                    {    
                        if (dgv[columna - 1, fila].ValueType == typeof(TimeSpan) || dgv[columna-1,fila].Value.ToString().Contains(':'))
                            oSheet.Cells[fila + fila_offset, columna] = dgv[columna - 1, fila].Value.ToString();
                        else
                            oSheet.Cells[fila + fila_offset, columna] = dgv[columna - 1, fila].Value;
                        fila++;
                    }

                    oRng = oSheet.get_Range(oSheet.Cells[fila_offset, columna], oSheet.Cells[fila + fila_offset, columna]);
                    if (dgv[columna - 1, 0].ValueType == typeof(DateTime))
                    {
                        oRng.NumberFormat = "DD/MM/YYYY";
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    }
                    else if (dgv[columna - 1, 0].ValueType == typeof(TimeSpan) || dgv[columna - 1, 0].Value.ToString().Contains(':'))
                    {

                        oRng.NumberFormat = "[h]:mm";
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    }
                    else if (dgv[columna - 1, 0].ValueType == typeof(Boolean))
                    {
                        //oRng.NumberFormat = "Sí;Sí;No";
                        oRng.NumberFormat = "@";
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    }
                    else if (dgv[columna - 1, 0].ValueType == typeof(Int64) || dgv[columna - 1, 0].ValueType == typeof(int) || dgv[columna - 1, 0].ValueType == typeof(uint) || dgv[columna - 1, 0].ValueType == typeof(byte) || dgv[columna - 1, 0].ValueType == typeof(sbyte))
                    {
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.NumberFormat = "0";
                    }
                    else
                    {
                        // String
                        oRng.NumberFormat = "@";
                        oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                    }

                    oRng.EntireColumn.AutoFit();
                    oRng.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin, Excel.XlColorIndex.xlColorIndexAutomatic, System.Type.Missing);
                    Marshal.FinalReleaseComObject(oRng);
                    columna++;

                }

                fila++;

                // Mostramos el usuario y la fecha de generacion despues de los datos.
                // UserName
                oRng = oSheet.get_Range(oSheet.Cells[fila, 1], oSheet.Cells[fila, 2]);
                oRng.Interior.Color = ColorTranslator.ToOle(Color.Beige);
                oRng.Cells.Font.Bold = true;
                oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Cells.MergeCells = true;
                oRng.Cells.Value2 = "Usuario: " + userName;

                fila++;
                // Fecha
                oRng = oSheet.get_Range(oSheet.Cells[fila, 1], oSheet.Cells[fila, 2]);
                oRng.Cells.MergeCells = true;
                oRng.Interior.Color = ColorTranslator.ToOle(Color.Beige);
                oRng.Cells.Font.Bold = true;
                oRng.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Cells.Value2 = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                

                ExApp.Visible = false;
                //oWBook.SaveAs(fileName, missing, missing, missing, missing, missing, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missing, missing, missing, true);
                oWBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, misValue, misValue, misValue, misValue);
                oWBook.Close(true, misValue, misValue);
                //ExApp.Save(fileName);

                return true;
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
                GC.Collect();
                GC.WaitForPendingFinalizers();
                if (oRng != null)
                    Marshal.FinalReleaseComObject(oRng);
                if (oSheet != null)
                    Marshal.FinalReleaseComObject(oSheet);
                if (oWBook != null)
                    Marshal.FinalReleaseComObject(oWBook);
                if (ExApp != null)
                {
                    ExApp.Quit();
                    Marshal.FinalReleaseComObject(ExApp);
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                System.Threading.Thread.CurrentThread.CurrentCulture = CultOriginal;
            }


        }




        public static byte[] convertImagenToByte(Image img)
        {
            byte[] byteArray;
            try
            {
                MemoryStream ms = new MemoryStream();
                Image img2 = (Image)img.Clone();
                img2.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                img2.Dispose();
                byteArray = ms.ToArray();
                ms.Close();
                ms.Dispose();
                return byteArray;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Image convertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray != null)
            {
                MemoryStream ms = new MemoryStream(byteArray, 0,
                byteArray.Length);
                ms.Write(byteArray, 0, byteArray.Length);
                return Image.FromStream(ms, true);
            }
            return null;
        }
        public static Image imageResize(Image img, double porcentaje)
        {
            
            //get the height and width of the image
            int originalW = img.Width;
            int originalH = img.Height;
            
            //get the new size based on the percentage change
            int resizedW = 140;// (int)(originalW * porcentaje);
            int resizedH = 120;// (int)(originalH * porcentaje);
            
            //create a new Bitmap the size of the new image
            Bitmap bmp = new Bitmap(resizedW, resizedH);
            
            //create a new graphic from the Bitmap
            Graphics graphic = Graphics.FromImage((Image)bmp);
            graphic.InterpolationMode = InterpolationMode.Default;
            
            //draw the newly resized image
            graphic.DrawImage(img, 0, 0, resizedW, resizedH);
            
            //dispose and free up the resources
            graphic.Dispose();
            
            //return the image
            return (Image)bmp;

        }

        public static string nombreDiasInglesAEspanol(string nomDiaIngles)
        {
            switch (nomDiaIngles)
            {
                case "Monday":
                    return "Lunes";

                case "Tuesday":
                    return "Martes";

                case "Wednesday":
                    return "Miercoles";
                case "Thursday":
                    return "Jueves";
                case "Friday":
                    return "Viernes";
                case "Saturday":
                    return "Sabado";
                case "Sunday":
                    return "Domingo";

            }
            throw new Exception(nomDiaIngles + " No es un dia en ingles reconocido");
        }

    }
}
