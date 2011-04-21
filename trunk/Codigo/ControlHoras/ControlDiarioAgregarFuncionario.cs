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
    public partial class ControlDiarioAgregarFuncionario : Form
    {

        private IDatos controller;
        public EmPleadOs funcionario { get; private set; }
        public DateTime HoraInicio { get; private set; }
        public DateTime HoraFin { get; private set; }
        public DateTime FechaCorresponde { get; set; }
        public MotIVOsCamBiosDiARioS MotivoCambio { get; private set; }

        public ControlDiarioAgregarFuncionario(DateTime fecha)
        {
            InitializeComponent();
            FechaCorresponde = fecha;
            controller = Datos.ControladorDatos.getInstance();
            btnAceptar.Enabled = false;
        }

        private void mtFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && mtFuncionario.Text != "")
            {
                try
                {
                    funcionario = controller.obtenerEmpleado(int.Parse(mtFuncionario.Text));
                    if (funcionario.Activo == 0 && FechaCorresponde >= funcionario.FechaBaja)
                    {
                        // Funcionario Inactivo y la FechaCorresponde es mayor o igual a la fecha de baja.
                        funcionario = null;
                        MessageBox.Show(this, "El Funcionario " + mtFuncionario.Text + " esta Inactivo. No se puede agregar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                    else
                    {
                        mtFuncionario.Text = funcionario.NroEmpleado.ToString();
                        txtNombreFuncionarioNuevo.Text = funcionario.Nombre + " " + funcionario.Apellido;
                        btnAceptar.Enabled = true;
                        SendKeys.Send("{TAB}");

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
                        funcionario = controller.obtenerEmpleado(busquedaEmps.idEmpleadoSeleccionado);
                        mtFuncionario.Text = funcionario.NroEmpleado.ToString();
                        txtNombreFuncionarioNuevo.Text = funcionario.Nombre + " " + funcionario.Apellido;
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



        private void mtHoraInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void mtHoraFin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                SendKeys.Send("{TAB}");
            }
        }



        private void ControlDiarioAgregarFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (mtFuncionario.Text != "" && mtHoraFin.MaskCompleted && mtHoraInicio.MaskCompleted)
            {
                DateTime aux;
                if (DateTime.TryParse(FechaCorresponde.ToShortDateString() + " " + mtHoraInicio.Text, out aux))
                {
                    HoraInicio = aux;
                    if (DateTime.TryParse(FechaCorresponde.ToShortDateString() + " " + mtHoraFin.Text, out aux))
                    {
                        HoraFin = aux;

                        if (HoraInicio.CompareTo(HoraFin) >= 0)
                        {
                            // Si HoraInicio es mayor o igual a HoraFin, consulto si la hora fin es del dia siguiente;
                            DialogResult res = MessageBox.Show("La HoraFin es inferior a la HoraInicio. La HoraFin corresponde al dia de mañana?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (res == DialogResult.Yes)
                            {
                                MotivoCambioDiarioForm mcdf = new MotivoCambioDiarioForm(FechaCorresponde);
                                DialogResult dr = mcdf.ShowDialog(this);
                                if (dr == DialogResult.OK)
                                {
                                    MotivoCambio = mcdf.motivoCambio;
                                    HoraFin = HoraFin.AddDays(1);
                                    this.Close();
                                }
                            }
                            else
                                btnCancelar.PerformClick();

                        }
                        else
                        {
                            MotivoCambioDiarioForm mcdf = new MotivoCambioDiarioForm(FechaCorresponde);
                            DialogResult dr = mcdf.ShowDialog(this);
                            if (dr == DialogResult.OK)
                            {
                                MotivoCambio = mcdf.motivoCambio;
                                //HoraFin.AddDays(1);
                                this.Close();
                            }
                            else
                                btnCancelar.PerformClick();
                        }
                    }
                    else
                        MessageBox.Show(this, "El formato de la HoraFin no es un formato de hora valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(this, "El formato de la HoraInicio no es un formato de hora valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "Debe ingresar todos los datos.", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
