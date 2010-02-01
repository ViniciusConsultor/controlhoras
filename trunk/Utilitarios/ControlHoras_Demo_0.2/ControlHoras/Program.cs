using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Dominio;

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
            Controlador controller = new Controlador();
            Application.Run(new ControlDiario());
        }
    }
}
