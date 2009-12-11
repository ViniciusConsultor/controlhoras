using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;

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

        private void mtFunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && mtFunc.MaskCompleted)
            {
                Funcionario fun = controller.obtenerFuncionario(int.Parse(mtFunc.Text));
                NumFunc = mtFunc.Text; 
                txtFunc.Text = NomFunc = fun.getNombre();
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.F2)
            {
                // Abrir ventana de busqueda de clientes
            }
        }


       
    }
}
