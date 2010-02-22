using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yogesh.ExcelXml;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Utilidades
{
    public static class ControladorUtilidades
    {

        public static bool exportToExcel(DataGridView dgv, string fileName)
        {
            ExcelXmlWorkbook libro = new ExcelXmlWorkbook();

            libro.Properties.Author = "Trust International S.A."; // Tomar el nombre de la empresa de Propertie.

            Worksheet hoja = libro[0];
            hoja.Name = "Exportacion";
            //hoja.FreezeTopRows = 3;

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

            int fila = 0;
            int columna = 0;
            double[] maxWithPerColumn;

            maxWithPerColumn = new double[dgv.Columns.Count];
            ContentType cellType;
            while (fila < dgv.Rows.Count)
            {
                columna = 0;
                while (columna < dgv.Columns.Count)
                {

                    if (dgv[columna, fila].ValueType == typeof(DateTime))
                    {
                        cellType = ContentType.DateTime;
                        if (dgv[columna,fila].Value.ToString() != "")
                            hoja[columna, fila+1].Value = ((DateTime)dgv[columna,fila].Value).ToShortDateString();
                    }
                    else if (dgv[columna, fila].ValueType == typeof(Boolean))
                    {
                        cellType = ContentType.Boolean;
                        if (dgv[columna, fila].Value.ToString() != "")
                            hoja[columna, fila+1].Value = ((Boolean)dgv[columna, fila].Value);
                    }
                    else if (dgv[columna, fila].ValueType == typeof(int) || dgv[columna, fila].ValueType == typeof(uint) || dgv[columna, fila].ValueType == typeof(byte) || dgv[columna, fila].ValueType == typeof(sbyte))
                    {
                        cellType = ContentType.Number;
                        if (dgv[columna, fila].Value.ToString() != "")
                            hoja[columna, fila+1].Value = dgv[columna, fila].Value;
                    }
                    else
                        hoja[columna, fila + 1].Value = dgv[columna, fila].Value.ToString();
    
                    hoja[columna, fila + 1].Style = estiloCeldaNormal;
                    if (dgv[columna, fila].Value.ToString().Length > maxWithPerColumn[columna])
                    {
                        maxWithPerColumn[columna] = (double)dgv[columna, fila].Value.ToString().Length;
                    }
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

    }
}
