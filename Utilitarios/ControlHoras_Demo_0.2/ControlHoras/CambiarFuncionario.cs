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
    public partial class CambiarFuncionario : Form
    {

        private Controlador Controller;

        public CambiarFuncionario(int idFunc, string nombre)
        {
            InitializeComponent();
            mtFuncionarioActual.Text = idFunc.ToString();
            txtNombreFuncionarioActual.Text = nombre;
            Controller = new Controlador();
        }

        public int getFuncionarioNuevo()
        {
            return int.Parse(mtFuncionarioNuevo.Text);
        }

        private void mtFuncionarioNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && mtFuncionarioNuevo.Text != "")
            {
                try
                {
                    Funcionario f = Controller.obtenerFuncionario(int.Parse(mtFuncionarioNuevo.Text));
                    txtNombreFuncionarioNuevo.Text = f.getNombre() + " " + f.getApellido();
                    //SendKeys.Send("{TAB}");
                    btnAceptar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.KeyCode == Keys.F2)
            {
                // Abrir ventana de busqueda de servicios de ese cliente.
            }
        }



    }
}
