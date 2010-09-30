using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using DbLinq.Data.Linq;
using System.Threading;
using Logica;

namespace ControlHoras
{
    public partial class GenerarHorasDiariasForm : Form
    {
        IDatos datos;
        IClientesServicios controladorClientes;
        public GenerarHorasDiariasForm()
        {
            InitializeComponent();
            datos = ControladorDatos.getInstance();
            controladorClientes = ControladorClientesServicios.getInstance();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde;
            DateTime fechaHasta;
            List<string> listaErrores = new List<string>();
            if(DateTime.TryParse(mtFechaDesde.Text,out fechaDesde))
            {
                if (DateTime.TryParse(mtFechaHasta.Text, out fechaHasta))
                {
                    if (fechaDesde <= fechaHasta)
                    {
                        DialogResult dg = MessageBox.Show(this, "Confirma el inicio de la Generacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dg == DialogResult.Yes)
                        {
                            try
                            {
                                lbErrores.Text = "";
                                lbErrores.DataSource = null;
                                lblProcesando.Visible = true;
                                lblNroCliente.Visible = true;
                                // Consolidar todos los escalafones
                                // 1- Que se cumple el contrato de todos los serivicios
                                // 2- Que todos los empleados (no de licencia ni descanso, ni suspendios, trabaja las hs normales correspondientes a su cargo por jornada
                                //    6 diasa  la semana, y que tiene un dia de descanso.
                                // 3- Que no se solapan los horarios de los emplreados.
                                TimeSpan diffTime = fechaHasta - fechaDesde;
                                progressBarGeneracion.Minimum = 1;
                                progressBarGeneracion.Maximum = diffTime.Days+1;
                                DateTime dateAux = fechaDesde;
                                int indice = 1;
                                bool huboErrores = false;
                                // Obtenemos la lista de clientes activos.
                                List<ClientEs> clientes = datos.obtenerClientes(true);
                                bool sobrescribirHorasGeneradas = false;
                                controladorClientes.iniciarGeneracionHoras();
                                while (dateAux <= fechaHasta)
                                {
                                    lblFecha.Text = dateAux.ToShortDateString();
                                    lblFecha.Refresh();
                                    progressBarGeneracion.Value = indice;
                                    
                                    foreach (ClientEs cli in clientes)
                                    {
                                        lblNroCliente.Text = cli.NumeroCliente.ToString();
                                        lblNroCliente.Refresh();
                                        foreach (SERVicIoS ser in cli.SERVicIoS)
                                        {
                                            try
                                            {
                                                controladorClientes.generarHorasDiaServicio((int)cli.NumeroCliente, (int)ser.NumeroServicio, dateAux, sobrescribirHorasGeneradas);
                                            }
                                            catch (YaExistenHorasGeneradasParaLaFechaException yehgplf)
                                            {
                                                if (!sobrescribirHorasGeneradas)
                                                {
                                                    DialogResult dg2 = MessageBox.Show(this, "Ya existen Horas Generadas en el periodo. Desea sobreescribirlas?", "Ya Existen Horas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                                    if (dg2 == DialogResult.Yes)
                                                    {
                                                        sobrescribirHorasGeneradas = true;
                                                        controladorClientes.generarHorasDiaServicio((int)cli.NumeroCliente, (int)ser.NumeroServicio, dateAux, sobrescribirHorasGeneradas);
                                                    }
                                                }                 
                                            }
                                            catch (Exception exGen)
                                            {
                                                huboErrores = true;
                                                listaErrores.Add(exGen.Message + ": " + exGen.InnerException.Message);
                                                break;
                                            }
                                        }
                                    }
                                    indice++;
                                    dateAux = dateAux.AddDays(1);
                                    if (huboErrores)
                                        break; 
                                }
                                if (!huboErrores)
                                {
                                    controladorClientes.finalizarGeneracionHoras(true,sobrescribirHorasGeneradas);
                                    MessageBox.Show(this, "Proceso Finalizado Correctamente.","Generacion Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                }
                                else
                                {
                                    controladorClientes.finalizarGeneracionHoras(false,false);
                                    lbErrores.DataSource = listaErrores;
                                    MessageBox.Show(this, "Generacion Cancelada." + "\n" + listaErrores.First(), "Error al Generar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(this, "Generacion Cancelada." + "\n", "Error al Generar. " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                lblProcesando.Visible = false;
                                lblNroCliente.Visible = false;
                            }
                        }else
                            MessageBox.Show(this, "La Fecha Desde debe ser menor a la Fecha Hasta.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }else
                        MessageBox.Show(this, "FechaHasta debe ser mayor o igual a FechaDesde.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                    MessageBox.Show(this, "El formato de la fecha Desde ingresada no es correcto.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
