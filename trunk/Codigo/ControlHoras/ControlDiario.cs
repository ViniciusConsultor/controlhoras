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
    public partial class ControlDiario : Form
    {
        private static ControlDiario ventana = null;
        private ClientEs cliente;
        private SERVicIoS servicio;

        private IDatos datos;
        private string fechaMask = @"  /  /";

        //Controlador controller;
        Color ColorOriginalFila = Color.White;
        Color ColorEntradaFila = Color.SlateGray;
        Color ColorSalidaFila = Color.Yellow;

        private ControlDiario()
        {
            datos = ControladorDatos.getInstance();
            
            InitializeComponent();
            //controller = Controlador.getControlador();
        }

         public static ControlDiario getInstance()
        {
            if (ventana == null)
                ventana = new ControlDiario();
            return ventana;
        }       

        private void mtServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && mtServicio.Text != "")
            {
                try
                {
                    //mtServicio.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (datos.existeClienteServicio(int.Parse(ucCliente.ClienteNRO),int.Parse(mtServicio.Text)))
                    {
                        servicio = datos.obtenerServicioCliente(int.Parse(ucCliente.ClienteNRO), int.Parse(mtServicio.Text));
                        txtServicio.Text = servicio.Nombre;
                        
                        SendKeys.Send("{TAB}");
                    }
                    else
                        MessageBox.Show("No existe el servicio en el Cliente.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.KeyCode == Keys.F2)
            {
                // Abrir ventana de busqueda de servicios de ese cliente.
            }
        }
        
        private void mtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            mtFecha.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mtFecha.Text == "" )
            {
                mtFecha.Text = System.DateTime.Now.ToShortDateString();
            }
            mtFecha.TextMaskFormat = MaskFormat.IncludeLiterals;
            if (e.KeyCode == Keys.Enter && mtFecha.MaskFull)
            {
                int numFila = dgvHoras.Rows.Count;
                while (numFila > 0)
                {
                    numFila--;
                    dgvHoras.Rows.RemoveAt(numFila);
                    
                }
                dgvHoras.Refresh();
                DateTime fecha = DateTime.Parse(mtFecha.Text);
                List<HoRaSGeneraDaSEScalaFOn> listFunc = datos.obtenerHorasGeneradasServicio((int)servicio.NumeroCliente, (int)servicio.NumeroServicio, fecha);
                rellenarDatosDgvHoras(listFunc);
            }
           // mtFecha.TextMaskFormat = MaskFormat.IncludeLiterals;
            
        }

        private void rellenarDatosDgvHoras(List<HoRaSGeneraDaSEScalaFOn> funcControlDiario)
        {
            foreach (HoRaSGeneraDaSEScalaFOn f in funcControlDiario)
            {                                
                    int num = dgvHoras.Rows.Add();
                    dgvHoras.Rows[num].Cells["IdHorasGeneradasEscalafon"].Value = f.IDHorasGeneradasEscalafon;
                    dgvHoras.Rows[num].Cells["NroEmpleado"].Value = f.EmPleadOs.NroEmpleado;
                    dgvHoras.Rows[num].Cells["Funcionario"].Value = f.EmPleadOs.Nombre + " " + f.EmPleadOs.Apellido;
                    dgvHoras.Rows[num].Cells["HoraEntrada"].Value = f.HoraEntrada.ToString("HH:mm");
                    dgvHoras.Rows[num].Cells["HoraSalida"].Value = f.HoraSalida.ToString("HH:mm");    
            }

        }

        
              

        private void dgvHoras_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                dgvHoras.Rows[e.RowIndex].Selected = true;
                menuStripdgvHoras.Show(dgvHoras,e.Location);
            }
        }

        private void cambiarFuncionario_Click(object sender, EventArgs e)
        {   
            try
            {
                MotIVOsCamBiosDiARioS motivoCambio = null;
                int idFuncSeleccionado = int.Parse(dgvHoras.SelectedRows[0].Cells["NroEmpleado"].Value.ToString() );
                string nombreFunc = dgvHoras.SelectedRows[0].Cells["Funcionario"].Value.ToString();
                CambiarFuncionario change = new CambiarFuncionario(idFuncSeleccionado,nombreFunc);
                DialogResult dg = change.ShowDialog(this);

                if (dg == DialogResult.OK)
                {
                    MotivoCambioDiarioForm mcdf = new MotivoCambioDiarioForm();
                    dg = mcdf.ShowDialog(this);
                    if (dg == DialogResult.OK)
                    {
                        int numFila = dgvHoras.SelectedRows[0].Index;
                        motivoCambio = mcdf.motivoCambio;
                        long idhge = (long)dgvHoras.Rows[numFila].Cells["IdHorasGeneradasEscalafon"].Value;
                        //motivoCambio.IdHorasGeneradasEscalafon = idhge;
                        //datos.cambiarFuncionarioControlDiario(idhge, change.FuncionarioNuevo.NroEmpleado, motivoCambio);
                        dgvHoras.Rows[numFila].Cells["NroEmpleado"].Value = change.FuncionarioNuevo.NroEmpleado;
                        dgvHoras.Rows[numFila].Cells["Funcionario"].Value = change.FuncionarioNuevo.Nombre + " " + change.FuncionarioNuevo.Apellido;

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      

        private void btnDiaSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                mtFecha.Text = DateTime.Parse(mtFecha.Text).AddDays(1).ToShortDateString();
                mtFecha.Focus();
                SendKeys.Send("{ENTER}");
            }
            catch (Exception ex)
            {
            }
        }

        private void btnDiaAnterior_Click(object sender, EventArgs e)
        {
            try
            {

                mtFecha.Text = DateTime.Parse(mtFecha.Text).AddDays(-1).ToShortDateString();
                mtFecha.Focus();
                SendKeys.Send("{ENTER}");
            }
            catch (Exception ex)
            {
            }
        }


        private void cambiarHoraEntrada_Click(object sender, EventArgs e)
        {
            if (dgvHoras.SelectedRows[0].Cells["HoraEntrada"].Value.ToString() != "")
                MessageBox.Show(this, "No se puede cambiar lo hora de entrada si tiene marcada la entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    int idFuncSeleccionado = int.Parse(dgvHoras.SelectedRows[0].Cells["NroEmpleado"].Value.ToString());
                    string nombreFunc = dgvHoras.SelectedRows[0].Cells["Empleado"].Value.ToString();
                    string horaini = dgvHoras.SelectedRows[0].Cells["HoraInicio"].Value.ToString();
                    CambiarHoraFuncionario changeHourForm = new CambiarHoraFuncionario(idFuncSeleccionado, nombreFunc, "Cambio de Hora de Entrada", horaini);
                    DialogResult dg = changeHourForm.ShowDialog(this);

                    if (dg == DialogResult.OK)
                    {
                        MotivoCambioDiarioForm mcdf = new MotivoCambioDiarioForm();
                        dg = mcdf.ShowDialog(this);
                        if (dg == DialogResult.OK)
                        {
                            int numFila = dgvHoras.SelectedRows[0].Index;
                            
                            long idhge = (long)dgvHoras.Rows[numFila].Cells["IdHorasGeneradasEscalafon"].Value;
                            int nroEmp = (int)dgvHoras.Rows[numFila].Cells["NroEmpleado"].Value;
                            string HoraNueva = changeHourForm.getHoraNueva();

                            datos.cambiarHoraFuncionarioControlDiario(idhge, nroEmp, HoraNueva, true, mcdf.motivoCambio);

                            dgvHoras.Rows[numFila].Cells["HoraInicio"].Value = HoraNueva;
                            //cambiarHoraEntradaFuncionario(dgvHoras.SelectedRows[0].Index, changeHourForm.getHoraNueva());                           
                        }
                        

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cambiarHoraEntradaFuncionario(int numFila, string HoraNueva)
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private void cambiarHoraSalida_Click(object sender, EventArgs e)
        {
            if (dgvHoras.SelectedRows[0].Cells["Salida"].Value.ToString() != "")
                MessageBox.Show(this, "No se puede cambiar el funcionario si tiene marcada la salida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    int idFuncSeleccionado = int.Parse(dgvHoras.SelectedRows[0].Cells["NroEmpleado"].Value.ToString());
                    string nombreFunc = dgvHoras.SelectedRows[0].Cells["Funcionario"].Value.ToString();
                    string horafin = dgvHoras.SelectedRows[0].Cells["HoraSalida"].Value.ToString();
                    //CambiarHoraFuncionario changeHourForm = new CambiarHoraFuncionario(idFuncSeleccionado, nombreFunc, "Cambio de Hora de Salida", horafin);
                    //DialogResult dg = changeHourForm.ShowDialog(this);

                    //if (dg == DialogResult.OK)
                    //{
                    //    cambiarHoraSalidaFuncionario(dgvHoras.SelectedRows[0].Index, changeHourForm.getHoraNueva());

                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cambiarHoraSalidaFuncionario(int numFila, string HoraNueva)
        {
            try
            {
                //Funcionario f = controller.obtenerFuncionario(int.Parse(dgvHoras.Rows[numFila].Cells["Numero"].Value.ToString()));
                //// Un dia planificacion esta identificado por el cliente, servicio, dia y HoraInicio
                //int idCliente = int.Parse(mtCliente.Text);
                int idServ = int.Parse(mtServicio.Text);
                DateTime fecha = DateTime.Parse(mtFecha.Text);
                string HoraIni = dgvHoras.Rows[numFila].Cells["HoraEntrada"].Value.ToString();

                //f.setHoraSalidaFuncionarioServicioDia(idCliente, idServ, fecha, HoraIni, HoraNueva);
                dgvHoras.Rows[numFila].Cells["HoraSalida"].Value = HoraNueva;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        private void agregarFuncionario_Click(object sender, EventArgs e)
        {

        }

       


       
    }
}
