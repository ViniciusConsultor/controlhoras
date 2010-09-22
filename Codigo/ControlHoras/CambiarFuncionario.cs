using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
namespace ControlHoras
{
    public partial class CambiarFuncionario : Form
    {

        private IDatos Controller;
        public EmPleadOs FuncionarioNuevo { get; private set; }
        public string HoraInicio { get; private set; }
        public string HoraFin { get; private set; }

        public CambiarFuncionario(int idFunc, string nombre)
        {
            InitializeComponent();
            mtFuncionarioActual.Text = idFunc.ToString();
            txtNombreFuncionarioActual.Text = nombre;
            Controller = ControladorDatos.getInstance();
        }       

        private void mtFuncionarioNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && mtFuncionarioNuevo.Text != "")
            {
                try
                {
                    FuncionarioNuevo = Controller.obtenerEmpleado(int.Parse(mtFuncionarioNuevo.Text));
                    mtFuncionarioNuevo.Text = FuncionarioNuevo.NroEmpleado.ToString();
                    txtNombreFuncionarioNuevo.Text = FuncionarioNuevo.Nombre + " " + FuncionarioNuevo.Apellido;
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
                // Muestro ventana de busqueda de empleados. La misma que en ABMEmpleados
                BuscarEmpleados busquedaEmps = new BuscarEmpleados();
                DialogResult res = busquedaEmps.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        FuncionarioNuevo = Controller.obtenerEmpleado(busquedaEmps.idEmpleadoSeleccionado);
                        mtFuncionarioNuevo.Text = FuncionarioNuevo.NroEmpleado.ToString();
                        txtNombreFuncionarioNuevo.Text = FuncionarioNuevo.Nombre + " " + FuncionarioNuevo.Apellido;
                        SendKeys.Send("{ENTER}");
                        btnAceptar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
