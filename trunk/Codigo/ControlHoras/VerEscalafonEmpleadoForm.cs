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
                    dgvEscalafonEmpleado.Rows.Clear();
                    EmPleadOs Funcionario = datos.obtenerEmpleado(int.Parse(mtFuncionario.Text));
                    mtFuncionario.Text = Funcionario.NroEmpleado.ToString();
                    txtNombreFuncionario.Text = Funcionario.Nombre + " " + Funcionario.Apellido;
                    cargarGrilla(Funcionario);
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

        private void cargarGrilla(EmPleadOs Funcionario)
        {
            int n = -10;
            try
            {
                List<EScalaFOneMpLeadO> listaEscs = datos.getHorariosEmpleado((int)Funcionario.NroEmpleado);
                foreach (EScalaFOneMpLeadO l in listaEscs)
                {
                    n = dgvEscalafonEmpleado.Rows.Add();
                    dgvEscalafonEmpleado.Rows[n].Cells["ClienteServicio"].Value = l.EScalaFOn.NumeroCliente.ToString() + "/" + l.EScalaFOn.NumeroServicio.ToString();
                    foreach (HoRaRioEScalaFOn h in l.HoRaRioEScalaFOn)
                    {

                        
                        switch (h.TipOsDiAs.NoMbRe)
                        {
                            case "Descanso":
                                dgvEscalafonEmpleado.Rows[n].Cells[h.DiA].Value = "Descanso";
                                break;
                            case "Laborable":
                                dgvEscalafonEmpleado.Rows[n].Cells[h.DiA].Value = h.HoRaInI + " a " + h.HoRaFIn;
                                break;
                            //case "Licencia":
                            //    dgvEscalafonEmpleado.Rows[n].Cells[h.DiA].Value = "Licencia";
                            //    break;
                            //default:
                            //    dgvEscalafonEmpleado.Rows[n].Cells[h.DiA].Value = "Desconocido";
                        }

                    }
                    n = -10;
                }
            }
            catch (Exception ex)
            {
                if (n != -10)
                    dgvEscalafonEmpleado.Rows.RemoveAt(n);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvEscalafonEmpleado.ClearSelection();
        }       
    }
}
