﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Logica;

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
            Controlador controller = Controlador.getControlador();
            Application.Run(new VentanaPrincipal());
        }
    }
}
