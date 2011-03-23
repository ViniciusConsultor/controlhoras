﻿using System;
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
    public partial class ControlDiario : Form
    {
        private static ControlDiario ventana = null;
        private ClientEs cliente;
        private SERVicIoS servicio;
        private Dictionary<long, HoRaSGeneraDaSEScalaFOn> listaFuncsCargados = null;

        IClientesServicios sistema;
        int ind;
        int cant;
        int[] numerosSer;

        private IDatos datos;
        private string fechaMask = @"  /  /";

        //Controlador controller;
        Color ColorOriginalFila = Color.White;
        Color ColorEntradaFila = Color.SlateGray;
        Color ColorSalidaFila = Color.Yellow;

        private ControlDiario()
        {
            
            
            ind = 0;
            cant = 0;
            
            InitializeComponent();
            listaFuncsCargados = new Dictionary<long, HoRaSGeneraDaSEScalaFOn>();
            try
            {
                sistema = ControladorClientesServicios.getInstance();
                datos = ControladorDatos.getInstance();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                        cliente = datos.obtenerCliente(int.Parse(ucCliente.ClienteNRO));
                        mtFecha.Focus();
                        MessageBox.Show(DateTime.Now.ToShortDateString());
                        mtFecha.Text = DateTime.Now.ToShortDateString();
                        SendKeys.Send("{ENTER}");
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

        private void ucCliente_cliPronto(object sender, EventArgs e)
        {
            //AgregarBTN.Enabled = false;
            //GuardarBTN.Enabled = false;
            //ContratoBTN.Enabled = false;

            AnteriorBTN.Visible = false;
            PosteriorBTN.Visible = false;

            if (ucCliente.find)
            {
                try
                {
                    //DateTime tmpFecha = DateTime.Now;
                    int numCli = int.Parse(ucCliente.ClienteNRO);
                    cliente = datos.obtenerCliente(numCli);
                    Cliente cli = sistema.obtenerCliente(numCli);
                    List<Servicio> servicios = cli.getListaServicios();
                    if (servicios.Count != 0)
                    {
                        cant = servicios.Count;
                        numerosSer = new int[cant];

                        int i = 0;
                        foreach (Servicio ser in servicios)
                        {
                            numerosSer[i] = ser.getNumero();
                            i++;
                        }

                        servicio = datos.obtenerServicioCliente(numCli, numerosSer[ind]);
                        mtServicio.Text = numerosSer[ind].ToString();
                        txtServicio.Text = servicio.Nombre;

                        mtFecha.Focus();
                        //MessageBox.Show(DateTime.Now.ToShortDateString());
                        //tmpFecha.Kind = DateTimeKind.Local;
                        //MessageBox.Show(tmpFecha.ToShortDateString());
                        string temp = DateTime.Now.ToShortDateString();
                        mtFecha.Text = temp;
                        SendKeys.Send("{ENTER}");

                        if (cant > 1)
                        {
                            AnteriorBTN.Visible = true;
                            PosteriorBTN.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //else
            //    MessageBox.Show("No existe el Cliente "+ucCliente.ClienteNRO, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void mtFecha_KeyDown(object sender, KeyEventArgs e)
        {
            mtFecha.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (e.KeyCode == Keys.Enter && mtFecha.Text == "")
            {
                mtFecha.Text = System.DateTime.Now.ToShortDateString();
            }
            mtFecha.TextMaskFormat = MaskFormat.IncludeLiterals;
            if (e.KeyCode == Keys.Enter && mtFecha.MaskFull)
            {
                try
                {
                    int numFila = dgvHoras.Rows.Count;
                    while (numFila > 0)
                    {
                        numFila--;
                        dgvHoras.Rows.RemoveAt(numFila);

                    }
                    dgvHoras.Refresh();
                    DateTime fecha = DateTime.Parse(mtFecha.Text);
                    lblDia.Text = nombreDiasInglesAEspanol(fecha.DayOfWeek.ToString());
                    List<HoRaSGeneraDaSEScalaFOn> listFunc = datos.obtenerHorasGeneradasServicio((int)servicio.NumeroCliente, (int)servicio.NumeroServicio, fecha);
                    rellenarDatosDgvHoras(listFunc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           // mtFecha.TextMaskFormat = MaskFormat.IncludeLiterals;
            
        }

        private string nombreDiasInglesAEspanol(string nomDiaIngles)
        {
            switch (nomDiaIngles)
            {
                case "Monday":
                    return "Lunes";

                case "Tuesday":
                    return "Martes";

                case "Wednesday":
                    return "Miercoles";
                case "Thursday":
                    return "Jueves";
                case "Friday":
                    return "Viernes";
                case "Saturday":
                    return "Sabado";
                case "Sunday":
                    return "Domingo";

            }
            return null;
        }

        private void rellenarDatosDgvHoras(List<HoRaSGeneraDaSEScalaFOn> funcControlDiario)
        {
            try
            {
                listaFuncsCargados = new Dictionary<long, HoRaSGeneraDaSEScalaFOn>();
                foreach (HoRaSGeneraDaSEScalaFOn f in funcControlDiario)
                {
                    int num = dgvHoras.Rows.Add();
                    dgvHoras.Rows[num].Cells["IdHorasGeneradasEscalafon"].Value = f.IDHorasGeneradasEscalafon;
                    dgvHoras.Rows[num].Cells["NroEmpleado"].Value = f.NroEmpleado;
                    EmPleadOs e = datos.obtenerEmpleado((int)f.NroEmpleado);
                    dgvHoras.Rows[num].Cells["Funcionario"].Value = e.Nombre + " " + e.Apellido;
                    dgvHoras.Rows[num].Cells["HoraEntrada"].Value = f.HoraEntrada.ToString("HH:mm");
                    dgvHoras.Rows[num].Cells["HoraSalida"].Value = f.HoraSalida.ToString("HH:mm");
                    listaFuncsCargados.Add(f.IDHorasGeneradasEscalafon, f);
                }
            }
            catch
            {
                throw;
            }
        }

        private void cambiarFuncionario_Click(object sender, EventArgs e)
        {   
            try
            {
                MotIVOsCamBiosDiARioS motivoCambio = null;
                int idFuncSeleccionado = int.Parse(dgvHoras.SelectedRows[0].Cells["NroEmpleado"].Value.ToString() );
                string nombreFunc = dgvHoras.SelectedRows[0].Cells["Funcionario"].Value.ToString();
                DateTime fecha = DateTime.Parse(mtFecha.Text);
                ControlDiarioCambiarFuncionario change = new ControlDiarioCambiarFuncionario(idFuncSeleccionado,nombreFunc, fecha);
                DialogResult dg = change.ShowDialog(this);

                if (dg == DialogResult.OK)
                {
                        
                    MotivoCambioDiarioForm mcdf = new MotivoCambioDiarioForm(DateTime.Parse(mtFecha.Text));
                    dg = mcdf.ShowDialog(this);
                    if (dg == DialogResult.OK)
                    {
                        int numFila = dgvHoras.SelectedRows[0].Index;
                        motivoCambio = mcdf.motivoCambio;
                        long idhge = (long)dgvHoras.Rows[numFila].Cells["IdHorasGeneradasEscalafon"].Value;
                        //motivoCambio.IDHorasGeneradasEscalafon = idhge;
                        motivoCambio.NumeroCliente = uint.Parse(ucCliente.ClienteNRO);
                        motivoCambio.NroEmpleado = (uint) idFuncSeleccionado;
                        motivoCambio.NumeroServicio = servicio.NumeroServicio;                        
                        datos.cambiarFuncionarioControlDiario(idhge,(int)change.FuncionarioNuevo.NroEmpleado, motivoCambio);
                        listaFuncsCargados[idhge].NroEmpleado = change.FuncionarioNuevo.NroEmpleado;
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

        private void cambiarHora(bool cambiarEntrada, string texto)
        {
            long idhge = int.Parse(dgvHoras.SelectedRows[0].Cells["IDHorasGeneradasEscalafon"].Value.ToString());
            int idFuncSeleccionado = (int)listaFuncsCargados[idhge].NroEmpleado;
            string nombreFunc = dgvHoras.SelectedRows[0].Cells["Funcionario"].Value.ToString();
            DateTime horaini = listaFuncsCargados[idhge].HoraEntrada;
            DateTime horafin = listaFuncsCargados[idhge].HoraSalida;
            CambiarHoraFuncionario changeHourForm = new CambiarHoraFuncionario(idFuncSeleccionado, nombreFunc, texto, horaini, horafin, cambiarEntrada);
            DialogResult dg = changeHourForm.ShowDialog(this);

            if (dg == DialogResult.OK)
            {
                MotivoCambioDiarioForm mcdf = new MotivoCambioDiarioForm(DateTime.Parse(mtFecha.Text));
                dg = mcdf.ShowDialog(this);
                if (dg == DialogResult.OK)
                {
                    int numFila = dgvHoras.SelectedRows[0].Index;

                    //long idhge = (long)dgvHoras.Rows[numFila].Cells["IdHorasGeneradasEscalafon"].Value;
                    //int nroEmp = (int)listaFuncsCargados[idhge].NroEmpleado;
                    DateTime FechaHoraNueva = changeHourForm.getFechaHoraNueva();
                    mcdf.motivoCambio.NroEmpleado = listaFuncsCargados[idhge].NroEmpleado;
                    mcdf.motivoCambio.NumeroCliente = uint.Parse(ucCliente.ClienteNRO);
                    mcdf.motivoCambio.NumeroServicio = servicio.NumeroServicio;
                    //DateTime DateNueva = DateTime.Parse(mtFecha.Text + " " + HoraNueva);
                    datos.cambiarHoraFuncionarioControlDiario(idhge, (int)listaFuncsCargados[idhge].NroEmpleado, FechaHoraNueva, cambiarEntrada, mcdf.motivoCambio);

                    if (cambiarEntrada)
                    {
                        listaFuncsCargados[idhge].HoraEntrada = FechaHoraNueva;
                        dgvHoras.Rows[numFila].Cells["HoraEntrada"].Value = FechaHoraNueva.ToString("HH:mm");
                    }
                    else
                    {
                        listaFuncsCargados[idhge].HoraSalida = FechaHoraNueva;
                        dgvHoras.Rows[numFila].Cells["HoraSalida"].Value = FechaHoraNueva.ToString("HH:mm");
                    }
                }


            }
        }

        private void cambiarHoraEntrada_Click(object sender, EventArgs e)
        {
         
            try
            {
                cambiarHora(true, "Cambio de Hora de Entrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }


        private void agregarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                ControlDiarioAgregarFuncionario cdaf = new ControlDiarioAgregarFuncionario(DateTime.Parse(mtFecha.Text));
                DialogResult res = cdaf.ShowDialog(this);
                if (res == DialogResult.OK)
                {
                    EmPleadOs emp = cdaf.funcionario;
                    DateTime fechaCorresponde = DateTime.Parse(mtFecha.Text);
                    DateTime horaInicio = DateTime.Parse(fechaCorresponde.ToShortDateString()+ " " + cdaf.HoraInicio.ToShortTimeString());
                    DateTime horaFin = DateTime.Parse(fechaCorresponde.ToShortDateString() + " " + cdaf.HoraFin.ToShortTimeString());
                    // Genero una nueva HoraGeneradasEscalafon
                    HoRaSGeneraDaSEScalaFOn hgeNew = new HoRaSGeneraDaSEScalaFOn();
                    hgeNew.FechaCorrespondiente = fechaCorresponde;
                    hgeNew.HoraEntrada = horaInicio;
                    hgeNew.HoraSalida = horaFin;
                    hgeNew.NroEmpleado = emp.NroEmpleado;
                    hgeNew.NumeroCliente = cliente.NumeroCliente;
                    hgeNew.NumeroServicio = servicio.NumeroServicio;
                    
                    cdaf.MotivoCambio.EmPleadOs = emp;
                    cdaf.MotivoCambio.FechaCorresponde = fechaCorresponde;
                    cdaf.MotivoCambio.FechaCambio = DateTime.Now;
                                     
                    cdaf.MotivoCambio.NumeroCliente = cliente.NumeroCliente;
                    cdaf.MotivoCambio.NumeroServicio = servicio.NumeroServicio;

                    long idHGE = ControladorClientesServicios.getInstance().agregarEmpleadoControlDiario(fechaCorresponde, hgeNew, cdaf.MotivoCambio);
                    hgeNew.IDHorasGeneradasEscalafon = idHGE;
                    listaFuncsCargados.Add(idHGE, hgeNew);
                    int num = dgvHoras.Rows.Add();
                    dgvHoras.Rows[num].Cells["IdHorasGeneradasEscalafon"].Value = hgeNew.IDHorasGeneradasEscalafon;
                    dgvHoras.Rows[num].Cells["NroEmpleado"].Value = hgeNew.NroEmpleado;
                    
                    dgvHoras.Rows[num].Cells["Funcionario"].Value = emp.Nombre + " " + emp.Apellido;
                    dgvHoras.Rows[num].Cells["HoraEntrada"].Value = hgeNew.HoraEntrada.ToString("HH:mm");
                    dgvHoras.Rows[num].Cells["HoraSalida"].Value = hgeNew.HoraSalida.ToString("HH:mm");    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHoras_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                dgvHoras.Rows[e.RowIndex].Selected = true;
             //   menuStripdgvHoras.Show(dgvHoras, e.Location);
            }
        }

        private void ControlDiario_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        private void cambiarHoraSalida_Click(object sender, EventArgs e)
        {
            try
            {
                cambiarHora(false, "Cambio de Hora de Entrada");
                //int idFuncSeleccionado = int.Parse(dgvHoras.SelectedRows[0].Cells["NroEmpleado"].Value.ToString());
                //string nombreFunc = dgvHoras.SelectedRows[0].Cells["NroEmpleado"].Value.ToString();
                //string horasal = dgvHoras.SelectedRows[0].Cells["HoraSalida"].Value.ToString();
                //CambiarHoraFuncionario changeHourForm = new CambiarHoraFuncionario(idFuncSeleccionado, nombreFunc, "Cambio de Hora de Entrada", horasal);
                //DialogResult dg = changeHourForm.ShowDialog(this);

                //if (dg == DialogResult.OK)
                //{
                //    MotivoCambioDiarioForm mcdf = new MotivoCambioDiarioForm(DateTime.Parse(mtFecha.Text));
                //    dg = mcdf.ShowDialog(this);
                //    if (dg == DialogResult.OK)
                //    {
                //        int numFila = dgvHoras.SelectedRows[0].Index;

                //        long idhge = (long)dgvHoras.Rows[numFila].Cells["IdHorasGeneradasEscalafon"].Value;
                //        int nroEmp = int.Parse(dgvHoras.Rows[numFila].Cells["NroEmpleado"].Value.ToString());
                //        string HoraNueva = changeHourForm.getHoraNueva();
                //        mcdf.motivoCambio.NroEmpleado = (uint)nroEmp;
                //        mcdf.motivoCambio.NumeroCliente = uint.Parse(ucCliente.ClienteNRO);
                //        mcdf.motivoCambio.NumeroServicio = servicio.NumeroServicio;
                //        DateTime DateNueva = DateTime.Parse(mtFecha.Text + " " + HoraNueva);
                //        datos.cambiarHoraFuncionarioControlDiario(idhge,nroEmp, DateNueva, false, mcdf.motivoCambio);

                //        dgvHoras.Rows[numFila].Cells["HoraSalida"].Value = HoraNueva;
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            KeyEventArgs kea = new KeyEventArgs(Keys.F2);
            ucCliente.ClienteMT_KeyDown(sender, kea);
        }

        private void AnteriorBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(ucCliente.ClienteNRO);
            if ((ind - 1) < 0)
                ind = cant - 1;
            else
                ind = ind - 1;


            servicio = datos.obtenerServicioCliente(int.Parse(ucCliente.ClienteNRO), numerosSer[ind]);
            mtServicio.Text = numerosSer[ind].ToString();
            txtServicio.Text = servicio.Nombre;

            mtFecha.Focus();
            //mtFecha.Text = DateTime.Now.ToShortDateString();
            SendKeys.Send("{ENTER}");
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(ucCliente.ClienteNRO);
            ind = (ind + 1) % cant;

            servicio = datos.obtenerServicioCliente(int.Parse(ucCliente.ClienteNRO), numerosSer[ind]);
            mtServicio.Text = numerosSer[ind].ToString();
            txtServicio.Text = servicio.Nombre;

            mtFecha.Focus();
            //mtFecha.Text = DateTime.Now.ToShortDateString();
            SendKeys.Send("{ENTER}");
        }

        private void ControlDiario_Shown(object sender, EventArgs e)
        {
            ucCliente.cliPronto += new EventHandler(ucCliente_cliPronto);
        }

        private void quitarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int idFuncSeleccionado = int.Parse(dgvHoras.SelectedRows[0].Cells["NroEmpleado"].Value.ToString());
                string nombreFunc = dgvHoras.SelectedRows[0].Cells["Funcionario"].Value.ToString();

                DialogResult res = MessageBox.Show("Seguro que quiere quitar el Funcionario: " + idFuncSeleccionado + " - " + nombreFunc, "Quitar Funcionario?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    DateTime fechaCorresponde = DateTime.Parse(mtFecha.Text);
                    MotivoCambioDiarioForm mcdf = new MotivoCambioDiarioForm(fechaCorresponde);
                    res = mcdf.ShowDialog(this);
                    if (res == DialogResult.OK)
                    {
                        int numFila = dgvHoras.SelectedRows[0].Index;

                        long idhge = (long)dgvHoras.Rows[numFila].Cells["IdHorasGeneradasEscalafon"].Value;
                        int nroEmp = int.Parse(dgvHoras.Rows[numFila].Cells["NroEmpleado"].Value.ToString());
                        //string HoraNueva = changeHourForm.getHoraNueva();
                        mcdf.motivoCambio.NroEmpleado = (uint)nroEmp;
                        mcdf.motivoCambio.NumeroCliente = uint.Parse(ucCliente.ClienteNRO);
                        mcdf.motivoCambio.NumeroServicio = servicio.NumeroServicio;

                        datos.quitarFuncionarioControlDiario(idhge, mcdf.motivoCambio);
                        listaFuncsCargados.Remove(idhge);
                        dgvHoras.Rows.RemoveAt(numFila);
                    }
                    
               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
       
    }
}
