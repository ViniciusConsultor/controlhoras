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
    public partial class AgregarFuncionarioControlDiarioForm : Form
    {

        private IDatos datos;
        public EmPleadOs FuncionarioNuevo { get; private set; }
        public string HoraEntrada { get; private set; }
        public string HoraSalida { get; private set; }

        public AgregarFuncionarioControlDiarioForm(int nroCliente, int NroServicio)
        {
            InitializeComponent();
            datos = ControladorDatos.getInstance();
            lblNroCliente.Text = nroCliente.ToString();
            lblNroServicio.Text = NroServicio.ToString();
            FuncionarioNuevo = null;
        }

        private void mtFuncionarioNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && mtFuncionarioNuevo.Text != "")
            {
                try
                {
                    FuncionarioNuevo = datos.obtenerEmpleado(int.Parse(mtFuncionarioNuevo.Text));
                    mtFuncionarioNuevo.Text = FuncionarioNuevo.NroEmpleado.ToString();
                    txtNombreFuncionarioNuevo.Text = FuncionarioNuevo.Nombre + " " + FuncionarioNuevo.Apellido;
                    SendKeys.Send("{ENTER}");
                    //btnAceptar.Enabled = true;
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
                        FuncionarioNuevo = datos.obtenerEmpleado(busquedaEmps.idEmpleadoSeleccionado);
                        mtFuncionarioNuevo.Text = FuncionarioNuevo.NroEmpleado.ToString();
                        txtNombreFuncionarioNuevo.Text = FuncionarioNuevo.Nombre + " " + FuncionarioNuevo.Apellido;
                        SendKeys.Send("{ENTER}");
                        //btnAceptar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FuncionarioNuevo != null && mtFuncionarioNuevo.Text != "" && mtHoraEntrada.MaskFull && mtHoraSalida.MaskFull)
            {
                HoraEntrada = mtHoraEntrada.Text;
                HoraSalida = mtHoraSalida.Text;
            }
            else
                MessageBox.Show(this,"Debe llenar todos los campos.","Llenar Datos",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
