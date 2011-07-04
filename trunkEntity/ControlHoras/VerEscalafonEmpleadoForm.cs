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
        private enum MOSTRAR_DATOS {ESCALAFON,CONTROLDIARIO};
        MOSTRAR_DATOS funcionalidad;
        DateTime fechaCorrespondiente;
        int NroFuncionario;

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

        public void setNroFuncionario(int NroFuncionario)
        {
            mtFuncionario.Text = NroFuncionario.ToString();
            mtFuncionario_KeyDown(this, new KeyEventArgs(Keys.Enter));
            this.NroFuncionario = NroFuncionario;
        }

        public void setFechaCorrespondiente(DateTime fecha)
        {
            this.fechaCorrespondiente = fecha;
            mtFechaCorrespondiente.Text = fecha.ToShortDateString();
        }

        public void setFechaNroFuncionario(DateTime fecha, int NroFuncionario)
        {
            setFechaCorrespondiente(fecha);
            setNroFuncionario(NroFuncionario);
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
                    NroFuncionario = (int)Funcionario.NroEmpleado;
                    txtNombreFuncionario.Text = Funcionario.Nombre + " " + Funcionario.Apellido;
                    if (funcionalidad == MOSTRAR_DATOS.ESCALAFON)
                        cargarGrillaEscalafon(Funcionario);
                    else if (funcionalidad == MOSTRAR_DATOS.CONTROLDIARIO)
                    {
                        fechaCorrespondiente = DateTime.Parse(mtFechaCorrespondiente.Text);
                        cargarGrillaControlDiario(Funcionario);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (e.KeyCode == Keys.F2)
            {
                btnBuscarFuncionario.PerformClick();
            }

        }

        private void cargarGrillaControlDiario(EmPleadOs Funcionario)
        {
            int n = -10;
            try
            {
                List<HoRaSGeneraDaSEScalaFOn> listaHs = datos.obtenerHorasGeneradasEscalafonEmpleado((uint)Funcionario.NroEmpleado,fechaCorrespondiente);
                ClientEs cli;
                foreach (DataGridViewColumn Col in dgvEscalafonEmpleado.Columns)
                {
                    if (Col.Index > 1)
                        Col.Visible = false;
                }
                dgvEscalafonEmpleado.Update();
                foreach (HoRaSGeneraDaSEScalaFOn l in listaHs)
                {
                    n = dgvEscalafonEmpleado.Rows.Add();
                    cli = datos.obtenerCliente((int)l.NumeroCliente);
                    dgvEscalafonEmpleado.Rows[n].Cells["ClienteServicio"].Value = cli.NumeroCliente + " - "+ cli.Nombre;
                    dgvEscalafonEmpleado.Rows[n].Cells["Servicio"].Value = l.NumeroServicio.ToString();
                    dgvEscalafonEmpleado.Columns[Utilidades.ControladorUtilidades.nombreDiasInglesAEspanol(fechaCorrespondiente.DayOfWeek.ToString())].Visible = true;
                    dgvEscalafonEmpleado.Rows[n].Cells[Utilidades.ControladorUtilidades.nombreDiasInglesAEspanol(fechaCorrespondiente.DayOfWeek.ToString())].Value = l.HoraEntrada.ToString("dd/MM/yyyy HH:mm") + " a " + l.HoraSalida.ToString("dd/MM/yyyy HH:mm");
                    n = -10;
                }
                dgvEscalafonEmpleado.Update();
            }
            catch (Exception ex)
            {
                if (n != -10)
                    dgvEscalafonEmpleado.Rows.RemoveAt(n);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvEscalafonEmpleado.ClearSelection();
        }

        private void cargarGrillaEscalafon(EmPleadOs Funcionario)
        {
            int n = -10;
            try
            {
                List<EScalaFOneMpLeadO> listaEscs = datos.getHorariosEmpleado((int)Funcionario.NroEmpleado);
                ClientEs cli;
                foreach (EScalaFOneMpLeadO l in listaEscs)
                {
                    n = dgvEscalafonEmpleado.Rows.Add();
                    cli = datos.obtenerCliente((int)l.EScalaFOn.NumeroCliente);
                    dgvEscalafonEmpleado.Rows[n].Cells["ClienteServicio"].Value = cli.Nombre ;
                    dgvEscalafonEmpleado.Rows[n].Cells["Servicio"].Value = l.EScalaFOn.NumeroServicio.ToString();
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

        private void VerEscalafonEmpleadoForm_Load(object sender, EventArgs e)
        {
            if (this.Owner.GetType().Equals(typeof(EscalafonForm)))
            {
                funcionalidad = MOSTRAR_DATOS.ESCALAFON;
                panelFecha.Visible = false;
            }
            else if (this.Owner.GetType().Equals(typeof(ControlDiario)))
            {
                funcionalidad = MOSTRAR_DATOS.CONTROLDIARIO;
                panelFecha.Visible = true;
            }
            
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
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
