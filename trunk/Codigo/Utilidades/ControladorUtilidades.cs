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

namespace Utilidades
{
    public static class ControladorUtilidades
    {
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

        public static bool exportToExcel(DataGridView dgv, string fileName)
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

            maxWithPerColumn = new double[dgv.Columns.Count];
            DisplayFormatType cellType;
            while (fila < dgv.Rows.Count)
            {
                columna = 0;
                while (columna < dgv.Columns.Count)
                {
                    
                    if (dgv[columna, fila].ValueType == typeof(DateTime))
                    {
                        cellType = DisplayFormatType.ShortDate;
                        if (dgv[columna,fila].Value.ToString() != "")
                            hoja[columna, fila+1].Value = ((DateTime)dgv[columna,fila].Value).ToShortDateString();
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

        //public static bool exportToExcel_COM(DataGridView dgv, string fileName)
        //{

        //    object readOnly = true;
        //    object falso = false;
        //    DateTime auxdt;
        //    object missing = null;

        //    Excel.Application ExApp;
        //    Excel._Workbook oWBook;
        //    Excel._Worksheet oSheet;
        //    try
        //    {
        //        // Iniciar Excel y obtener el objeto Aplicacion.
        //        ExApp = new Excel.Application();

        //        //Get a new workbook.
        //        //oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
        //        oWBook = ExApp.Workbooks.Open(fileName, missing, readOnly, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
        //        oSheet = (Excel._Worksheet)oWBook.ActiveSheet;

        //        oWBook.Author = "Trust International S.A."; 
                         
        //        oSheet.Name = "Exportacion";
        //        //hoja.FreezeTopRows = 3;
        //        //hoja.DisplayFormat = DisplayFormatType.None;
        //        //hoja.PrintOptions.Orientation = PageOrientation.Landscape;
        //        //hoja.PrintOptions.SetMargins(0.5, 0.4, 0.5, 0.4);
                
        //        XmlStyle estiloCeldaNombreColumnas = new XmlStyle();
        //        estiloCeldaNombreColumnas.Font.Bold = true;
        //        estiloCeldaNombreColumnas.Alignment.Horizontal = Yogesh.ExcelXml.HorizontalAlignment.Center;
        //        estiloCeldaNombreColumnas.Border.LineStyle = Borderline.Continuous;
        //        estiloCeldaNombreColumnas.Border.Weight = 2;
        //        estiloCeldaNombreColumnas.Border.Sides = BorderSides.All;



        //        // Primero cargo todas las columnas permitiendo hacerle algun formato diferente.
        //        foreach (DataGridViewColumn col in dgv.Columns)
        //        {
        //            oSheet.Cells[col.Index, 0] = col.Name;
        //            //hoja[col.Index, 0].Style = estiloCeldaNombreColumnas;
        //        }

                
        //        // Mes
        //        oSheet.Cells[1, 5] = dtpMesFacturacion.Value.Month + "/" + dtpMesFacturacion.Value.Year;
        //        oSheet.Cells[2, 3] = facturacion.NroCliente + "/" + datos.getNombreCliente(facturacion.NroCliente);
        //        // Nombre
        //        string nomServicio = nombreArchivo.Substring(nombreArchivo.LastIndexOf('-') + 1);
        //        oSheet.Cells[3, 3] = nomServicio;

        //        int i = 0;
        //        foreach (DataDiaFacturacion ddf in facturacion.ListaDiaFacturacion)
        //        {
        //            oSheet.Cells[6 + i, 2] = ddf.Dia.ToString(@"dd/MM/yyyy");
        //            oSheet.Cells[6 + i, 3] = String.Format("{0}:{1}", ddf.HsComunes.Days * 24 + ddf.HsComunes.Hours, ddf.HsComunes.Minutes);
        //            oSheet.Cells[6 + i, 4] = String.Format("{0}:{1}", ddf.HsExtras.Days * 24 + ddf.HsExtras.Hours, ddf.HsExtras.Minutes); ;
        //            if (esFeriado(ddf.Dia))
        //            {
        //                Excel.Range MyRange;
        //                MyRange = (Excel.Range)oSheet.get_Range(
        //                    oSheet.Cells[6 + i, 2], oSheet.Cells[6 + i, 4]);
        //                MyRange.Interior.Color = System.Drawing.Color.YellowGreen.ToArgb();
        //                tieneFeriados = true;
        //            }
        //            i++;
        //        }

        //        oSheet.Cells[31 + 6, 3] = String.Format("{0}:{1}:{2}", facturacion.TotalHsComunes.Days * 24 + facturacion.TotalHsComunes.Hours, facturacion.TotalHsComunes.Minutes, facturacion.TotalHsComunes.Seconds);
        //        oSheet.Cells[31 + 6, 4] = String.Format("{0}:{1}:{2}", facturacion.TotalHsExtras.Days * 24 + facturacion.TotalHsExtras.Hours, facturacion.TotalHsExtras.Minutes, facturacion.TotalHsExtras.Seconds);

        //        if (tieneFeriados)
        //        {
        //            oSheet.Cells[40, 3] = "Dias Feriados";
        //            oSheet.get_Range(oSheet.Cells[40, 2], oSheet.Cells[40, 2]).Interior.Color = System.Drawing.Color.YellowGreen.ToArgb();
        //        }

        //        //oWBook.PrintPreview(falso);
        //        object a = Path.Combine(outputDirectory, nombreArchivo + ".xls");
        //        if (!abrirExcel)
        //        {
        //            ExApp.Visible = false;
        //            oWBook.SaveAs(a, missing, missing, missing, missing, missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlLocalSessionChanges, missing, missing, missing, true);
        //            ExApp.Quit();
        //        }
        //        else
        //            ExApp.Visible = true;
        //    }
        //    catch (Exception theException)
        //    {
        //        String errorMessage;
        //        errorMessage = "Error: ";
        //        errorMessage = String.Concat(errorMessage, theException.Message);
        //        errorMessage = String.Concat(errorMessage, " Line: ");
        //        errorMessage = String.Concat(errorMessage, theException.Source);
        //        throw theException;
        //    }



        //    ExcelXmlWorkbook libro = new ExcelXmlWorkbook();

            

            

        //    XmlStyle estiloCeldaNormal = new XmlStyle();
        //    estiloCeldaNormal.Font.Bold = false;
        //    estiloCeldaNormal.Alignment.Horizontal = Yogesh.ExcelXml.HorizontalAlignment.Left;
        //    estiloCeldaNormal.Border.LineStyle = Borderline.Continuous;
        //    estiloCeldaNormal.Border.Weight = 1;
        //    estiloCeldaNormal.Border.Sides = BorderSides.All;
        //    //estiloCeldaNormal.DisplayFormat = DisplayFormatType.Text;
            
        //    int fila = 0;
        //    int columna = 0;
        //    double[] maxWithPerColumn;

        //    maxWithPerColumn = new double[dgv.Columns.Count];
        //    DisplayFormatType cellType;
        //    while (fila < dgv.Rows.Count)
        //    {
        //        columna = 0;
        //        while (columna < dgv.Columns.Count)
        //        {
                    
        //            if (dgv[columna, fila].ValueType == typeof(DateTime))
        //            {
        //                cellType = DisplayFormatType.ShortDate;
        //                if (dgv[columna,fila].Value.ToString() != "")
        //                    hoja[columna, fila+1].Value = ((DateTime)dgv[columna,fila].Value).ToShortDateString();
        //            }
        //            else if (dgv[columna, fila].ValueType == typeof(Boolean))
        //            {
        //                cellType = DisplayFormatType.Custom;
        //                if (dgv[columna, fila].Value.ToString() != "")
        //                    hoja[columna, fila+1].Value = ((Boolean)dgv[columna, fila].Value);
        //            }
        //            else if (dgv[columna, fila].ValueType == typeof(int) || dgv[columna, fila].ValueType == typeof(uint) || dgv[columna, fila].ValueType == typeof(byte) || dgv[columna, fila].ValueType == typeof(sbyte))
        //            {
        //                cellType = DisplayFormatType.Standard;
        //                if (dgv[columna, fila].Value.ToString() != "")
        //                    hoja[columna, fila + 1].Value = dgv[columna, fila].Value;
        //            }
        //            else
        //            {
        //                // String
        //                String str = dgv[columna, fila].Value.ToString();//.Replace("\n",Environment.NewLine);
        //                cellType = DisplayFormatType.Text;
        //                hoja[columna, fila + 1].Value = str;
                        
        //            }
                    
        //            if (dgv[columna, fila].Value.ToString().Length > maxWithPerColumn[columna])
        //            {
        //                maxWithPerColumn[columna] = (double)dgv[columna, fila].Value.ToString().Length;
        //            }
        //            //hoja[columna, fila].ContentType = ContentType.Formula;
        //            estiloCeldaNormal.DisplayFormat = cellType;
        //            hoja[columna, fila + 1].Style = estiloCeldaNormal;
        //            columna++;

        //        }
        //        fila++;
        //    }
        //    columna = 0;
        //    while (columna < dgv.Columns.Count)
        //    {
        //        hoja.Columns(columna).Width = dgv.Columns[columna].Width;
        //        columna++;
        //    }
            
        //    // no extension is added if not present

        //    Stream sw = new FileStream(fileName,FileMode.Create);
        //    bool retval;
        //    retval = libro.Export(sw);
        //    sw.Close();
        //    return retval;
        //}




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
