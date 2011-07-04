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
    public partial class ControlDiarioCambiarFuncionario : Form
    {

        private IDatos Controller;
        public EmPleadOs FuncionarioNuevo { get; private set; }
        public string HoraInicio { get; private set; }
        public string HoraFin { get; private set; }
        private DateTime FechaCorresponde;

        public ControlDiarioCambiarFuncionario(int idFunc, string nombre, DateTime Fecha)
        {
            InitializeComponent();
            mtFuncionarioActual.Text = idFunc.ToString();
            txtNombreFuncionarioActual.Text = nombre;
            FechaCorresponde = Fecha;
            try
            {
                Controller = ControladorDatos.getInstance();
            }
            catch
            {
                throw;
            }
        }       

        private void mtFuncionarioNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && mtFuncionarioNuevo.Text != "")
            {
                try
                {
                    FuncionarioNuevo = Controller.obtenerEmpleado(int.Parse(mtFuncionarioNuevo.Text));
                    if (FuncionarioNuevo.Activo == 0 && FechaCorresponde >= FuncionarioNuevo.FechaBaja)
                    {
                        // Funcionario Inactivo.
                        FuncionarioNuevo = null;
                        MessageBox.Show(this, "El Funcionario " + mtFuncionarioNuevo.Text + " esta Inactivo. No se puede agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        mtFuncionarioNuevo.Text = FuncionarioNuevo.NroEmpleado.ToString();
                        txtNombreFuncionarioNuevo.Text = FuncionarioNuevo.Nombre + " " + FuncionarioNuevo.Apellido;
                        SendKeys.Send("{TAB}");
                        btnAceptar.Enabled = true;
                    }
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

        private void mtFuncionarioNuevo_Leave(object sender, EventArgs e)
        {
            if (mtFuncionarioNuevo.Text != "")
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
        }

        private void CambiarFuncionario_Shown(object sender, EventArgs e)
        {
            mtFuncionarioNuevo.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

    }
}
