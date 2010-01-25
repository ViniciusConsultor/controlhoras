using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace ControlHoras
{
    public partial class Selección_de_Recurso : Form
    {
        private Controlador controller = null;
        public string NumFunc = "";
        public string NomFunc = "";

        public Selección_de_Recurso()
        {
            InitializeComponent();
            controller = Controlador.getControlador();
            mtFunc.Focus();
        }

  

       
    }
}
