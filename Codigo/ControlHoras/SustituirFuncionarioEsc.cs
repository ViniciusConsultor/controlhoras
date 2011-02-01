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
    public partial class SustituirFuncionarioEsc : Form
    {
        private IDatos Controller;
        IClientesServicios sistema;
        EmPleadOs FuncionarioViejo = null;        
        EmPleadOs FuncionarioNuevo = null;
        bool FVPronto = false;
        bool FNPronto = false;

        static SustituirFuncionarioEsc ventana = null;

        public static SustituirFuncionarioEsc getVentana()
        {
            if (ventana == null)
                ventana = new SustituirFuncionarioEsc();
            return ventana;
        }

        private void SustituirFuncionarioEsc_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        private SustituirFuncionarioEsc()
        {
            InitializeComponent();

            Controller = ControladorDatos.getInstance();
            sistema = ControladorClientesServicios.getInstance();

            mtFuncionarioActual.Focus();
        }

        private void mtFuncionarioActual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && mtFuncionarioActual.Text != "")
            {
                try
                {
                    FuncionarioViejo = Controller.obtenerEmpleado(int.Parse(mtFuncionarioActual.Text));
                    mtFuncionarioActual.Text = FuncionarioViejo.NroEmpleado.ToString();
                    txtNombreFuncionarioActual.Text = FuncionarioViejo.Nombre + " " + FuncionarioViejo.Apellido;
                    //SendKeys.Send("{TAB}");
                    mtFuncionarioNuevo.Focus();
                    FVPronto = true;
                    if (FVPronto && FNPronto)
                        btnAceptar.Enabled = true;
                }
                catch (Exception ex)
                {
                    FVPronto = false;
                    btnAceptar.Enabled = false;
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
                        FuncionarioViejo = Controller.obtenerEmpleado(busquedaEmps.idEmpleadoSeleccionado);
                        mtFuncionarioActual.Text = FuncionarioViejo.NroEmpleado.ToString();
                        txtNombreFuncionarioActual.Text = FuncionarioViejo.Nombre + " " + FuncionarioViejo.Apellido;
                        SendKeys.Send("{ENTER}");
                        mtFuncionarioNuevo.Focus();
                        FVPronto = true;
                        if (FVPronto && FNPronto)
                            btnAceptar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        FVPronto = false;
                        btnAceptar.Enabled = false;
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                    btnAceptar.Focus();
                    FNPronto = true;
                    if (FVPronto && FNPronto)
                        btnAceptar.Enabled = true;
                }
                catch (Exception ex)
                {
                    FNPronto = false;
                    btnAceptar.Enabled = false;
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
                        btnAceptar.Focus();
                        FNPronto = true;
                        if (FVPronto && FNPronto)
                            btnAceptar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        FNPronto = false;
                        btnAceptar.Enabled = false;
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Está seguro que quiere sustituir a\n" + FuncionarioViejo.NroEmpleado.ToString() + " - " + FuncionarioViejo.Nombre + " " + FuncionarioViejo.Apellido + "\n por\n" + FuncionarioNuevo.NroEmpleado.ToString() + " - " + FuncionarioNuevo.Nombre + " " + FuncionarioNuevo.Apellido, "Sustitución de empleados", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                try
                {
                    if (!sistema.SustituirEmpleadoEnEscalafon((int)FuncionarioNuevo.NroEmpleado, (int)FuncionarioViejo.NroEmpleado))
                        MessageBox.Show("No se pudo realizar el cambio porque\nel empleado: " + FuncionarioViejo.NroEmpleado.ToString() + " - " + FuncionarioViejo.Nombre + " " + FuncionarioViejo.Apellido + "\n y el empleado: " + FuncionarioNuevo.NroEmpleado.ToString() + " - " + FuncionarioNuevo.Nombre + " " + FuncionarioNuevo.Apellido + "\n solapan horarios.", "Error al sustituir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("El empleado: " + FuncionarioViejo.NroEmpleado.ToString() + " - " + FuncionarioViejo.Nombre + " " + FuncionarioViejo.Apellido + " ha sido sustituido en el escalafón\n por el empleado: " + FuncionarioNuevo.NroEmpleado.ToString() + " - " + FuncionarioNuevo.Nombre + " " + FuncionarioNuevo.Apellido + " con éxito.", "Sustitución con éxito", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }     

    }
}
