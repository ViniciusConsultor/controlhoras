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
    public partial class VerEscalafonEmpleadoForm : Form
    {
        IDatos datos;

        public VerEscalafonEmpleadoForm()
        {
            InitializeComponent();
            try
            {
                datos = ControladorDatos.getInstance();
            }
            catch
            {
                throw;
            }
        }

        private void mtFuncionario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && mtFuncionario.Text != "")
            {
                try
                {
                    EmPleadOs Funcionario = datos.obtenerEmpleado(int.Parse(mtFuncionario.Text));
                    mtFuncionario.Text = Funcionario.NroEmpleado.ToString();
                    txtNombreFuncionario.Text = Funcionario.Nombre + " " + Funcionario.Apellido;
                    SendKeys.Send("{ENTER}");
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
                        EmPleadOs Funcionario = datos.obtenerEmpleado(busquedaEmps.idEmpleadoSeleccionado);
                        mtFuncionario.Text = Funcionario.NroEmpleado.ToString();
                        txtNombreFuncionario.Text = Funcionario.Nombre + " " + Funcionario.Apellido;
                        SendKeys.Send("{ENTER}");
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
