using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Logica;

namespace ControlHoras
{
    public partial class CambiarNumeroEmpleado : Form
    {
        private IEmpleados sistema = Logica.ControladorEmpleados.getInstance();
        private IDatos datos = Datos.ControladorDatos.getInstance();
        
        public CambiarNumeroEmpleado()
        {
            InitializeComponent();
        }

        static CambiarNumeroEmpleado ventana = null;
        public static CambiarNumeroEmpleado getVentana()
        {
            if (ventana == null)
                ventana = new CambiarNumeroEmpleado();
            return ventana;
        }


        private void mtNumeroEmpleadoActual_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (mtNumeroEmpleadoActual.Text != "" && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                // traigo el empleado y lleno los datos de los campos.
                EmPleadOs empleado;
                try
                {
                    if (sistema.existeEmpleado(int.Parse(mtNumeroEmpleadoActual.Text)))
                    {
                        empleado = datos.obtenerEmpleado(int.Parse(mtNumeroEmpleadoActual.Text));
                        txtEmpleado.Text = empleado.Nombre + " " + empleado.Apellido;
                    }
                    else
                    {
                        MessageBox.Show("No existe un empleado con el Número: " + mtNumeroEmpleadoActual.Text, "No Existe Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.KeyCode == Keys.F2)
            {
                // abro la ventana de busqueda de empleados.
                btnBuscarEmpleado.PerformClick();

            }
            
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Seguro que quiere cambiar el NumeroEmpleado del Empleado " + txtEmpleado.Text + " de " + mtNumeroEmpleadoActual.Text + " a " + mtNumeroEmpleadoNuevo.Text + "?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (mtNumeroEmpleadoActual.Text != "" && txtEmpleado.Text != "" && mtNumeroEmpleadoNuevo.Text != "")
                {
                    try
                    {
                        datos.cambiarNumeroEmpleado(int.Parse(mtNumeroEmpleadoActual.Text), int.Parse(mtNumeroEmpleadoNuevo.Text));
                        MessageBox.Show("El Numero del Empleado a sido cambiado con exito.","Modifacion con exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error el cambiar el NumeroEmpleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el Número Actual del empleado al que desea cambiarle el número y el Número Nuevo", "Error de Datos Ingresados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            BuscarEmpleados busquedaEmps = new BuscarEmpleados();
            DialogResult res = busquedaEmps.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                try
                {
                    mtNumeroEmpleadoActual.Text = busquedaEmps.idEmpleadoSeleccionado.ToString();
                    mtNumeroEmpleadoActual.Focus();
                    SendKeys.Send("{ENTER}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CambiarNumeroEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

    }
}
