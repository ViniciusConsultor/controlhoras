using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
//using Logica;

namespace ControlHoras
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Seteamos la Cultura para formatear las fechas y moneadas.
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-UY");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-UY");
            Application.Run(new VentanaPrincipal());   
        }
    }
}
