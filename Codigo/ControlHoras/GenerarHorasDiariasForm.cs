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
            RichTextBoxMensaje.Text = "1-Seleccione los servicios\n2-Presione el botón Generar para iniciar el proceso de Generación de las Horas Diarias para todos los Servicios Activos seleccionados, según el Escalafón armado para cada servicio. El proceso de Generación, antes de iniciar, corre una consolidación comprobando la consistencia del Escalafon de todos los servicios.";
        }

        private void GenerarHorasDiariasForm_Load(object sender, EventArgs e)
        {
            try
            {
                ucTreeClientesServicios.cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde;
            DateTime fechaHasta;
            List<string> listaErrores = new List<string>();
            
            if (DateTime.TryParse(mtFechaDesde.Text, out fechaDesde))
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
                                progressBarGeneracion.Maximum = diffTime.Days + 1;
                                DateTime dateAux = fechaDesde;
                                int indice = 1;
                                bool huboErrores = false;
                                bool huboErroresConsolidacion = false;
                                
                                // Obtenemos la lista de clientes activos.
                                //List<ClientEs> clientes = datos.obtenerClientes(true);
                                //List<ClientEs> clientes = ucTreeClientesServicios.obtenerClientesSeleccionados();
                                Dictionary<int, List<int>> clientesServiciosSeleccionados = ucTreeClientesServicios.obtenerClientesServiciosSeleccionados();
                                Dictionary<int, List<int>>.Enumerator iter = clientesServiciosSeleccionados.GetEnumerator();
                                Dictionary<string, List<string>> listaErroresConsolidacion =  new Dictionary<string,List<string>>();
                                List<string> errores;
                                
                                int nroCliente;

                                

                                bool sobrescribirHorasGeneradas = false;
                                controladorClientes.iniciarGeneracionHoras();
                                while (dateAux <= fechaHasta)
                                {
                                    lblFecha.Text = dateAux.ToShortDateString();
                                    lblFecha.Refresh();
                                    progressBarGeneracion.Value = indice;

                                    while (iter.MoveNext())
                                    {
                                        nroCliente = iter.Current.Key;

                                        lblNroCliente.Text = nroCliente.ToString();
                                        lblNroCliente.Refresh();

                                        foreach (int nroServicio in iter.Current.Value)
                                        {
                                            // Corremos la consolidacion para el cliente servicio
                                            try
                                            {
                                                errores = controladorClientes.ejecutarControlesEscalafonServicio(nroCliente, nroServicio);
                                                if (errores.Count > 0)
                                                    listaErroresConsolidacion.Add(nroCliente + ":" + nroServicio, errores);
                                            }
                                            catch (ControlEscalafonServicioException ces)
                                            {
                                                listaErroresConsolidacion.Add(nroCliente + ":" + nroServicio, new List<string> { ces.Message } );
                                            }
                                            
                                            try
                                            {
                                                errores = controladorClientes.ejecutarControlesEscalafonEmpleado(nroCliente, nroServicio);
                                                if (errores.Count > 0)
                                                {
                                                    if (!listaErroresConsolidacion.ContainsKey(nroCliente + ":" + nroServicio))
                                                        listaErroresConsolidacion.Add(nroCliente + ":" + nroServicio, errores);
                                                    else
                                                    {
                                                        //errores = (List<string>)listaErrores[nroCliente + ":" + nroServicio].Concat(errores);
                                                        errores = concatenar(listaErroresConsolidacion[nroCliente + ":" + nroServicio], errores);
                                                        listaErrores.Remove(nroCliente + ":" + nroServicio);
                                                        listaErroresConsolidacion.Add(nroCliente + ":" + nroServicio, errores);
                                                    }
                                                }                            
                                            }
                                            catch (ControlEscalafonEmpleadoException ces)
                                            {                            
                                                if (!listaErroresConsolidacion.ContainsKey(nroCliente + ":" + nroServicio))
                                                    listaErroresConsolidacion.Add(nroCliente + ":" + nroServicio, new List<string> { ces.Message });
                                                else
                                                {
                                                    //errores = (List<string>)listaErrores[nroCliente + ":" + nroServicio].Concat(new List<string> { ces.Message });
                                                    errores = concatenar(listaErroresConsolidacion[nroCliente + ":" + nroServicio], new List<string> { ces.Message });
                                                    listaErrores.Remove(nroCliente + ":" + nroServicio);
                                                    listaErroresConsolidacion.Add(nroCliente + ":" + nroServicio, errores);
                                                }
                                            }

                                            if (listaErroresConsolidacion.Count > 0)
                                            {
                                                // Si la consolidacion da errores
                                                // Despliego el conjunto de errores.
                                                huboErroresConsolidacion = true;
                                               
                                            }
                                            else
                                            {
                                                try
                                                {
                                                    controladorClientes.generarHorasDiaServicio(nroCliente, nroServicio, dateAux, sobrescribirHorasGeneradas);
                                                }
                                                catch (YaExistenHorasGeneradasParaLaFechaException)
                                                {
                                                    if (!sobrescribirHorasGeneradas)
                                                    {
                                                        DialogResult dg2 = MessageBox.Show(this, "Ya existen Horas Generadas en el periodo. Desea sobreescribirlas?", "Ya Existen Horas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                                        if (dg2 == DialogResult.Yes)
                                                        {
                                                            sobrescribirHorasGeneradas = true;
                                                            controladorClientes.generarHorasDiaServicio(nroCliente, nroServicio, dateAux, sobrescribirHorasGeneradas);
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
                                    }
                                    
                                    iter = clientesServiciosSeleccionados.GetEnumerator();
                                    indice++;
                                    dateAux = dateAux.AddDays(1);
                                    if (huboErrores || huboErroresConsolidacion)
                                        break;
                                }
                                if (huboErroresConsolidacion)
                                {
                                    MessageBox.Show(this, "Consolidacion Finalizada Con Errores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    controladorClientes.finalizarGeneracionHoras(false, false);
                                    //lbErrores.DataSource = listaErroresConsolidacion;
                                    //MessageBox.Show(this, "Generacion Cancelada." + "\n" + listaErrores.First(), "Error al Generar", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    AbroWordConErrores(listaErroresConsolidacion);
                                }
                                else
                                {
                                    if (!huboErrores)
                                    {
                                        controladorClientes.finalizarGeneracionHoras(true, sobrescribirHorasGeneradas);
                                        MessageBox.Show(this, "Proceso Finalizado Correctamente.", "Generacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        controladorClientes.finalizarGeneracionHoras(false, false);
                                        lbErrores.DataSource = listaErrores;
                                        MessageBox.Show(this, "Generacion Cancelada." + "\n" + listaErrores.First(), "Error al Generar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
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
                        }
                        //else
                        //    MessageBox.Show(this, "La Fecha Desde debe ser menor a la Fecha Hasta.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show(this, "FechaHasta debe ser mayor o igual a FechaDesde.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(this, "El formato de la fecha Desde ingresada no es correcto.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }


        private List<string> concatenar(List<string> l1, List<string> l2)
        {
            List<string> aux = new List<string>(l1);
            foreach (string st in l2)
                aux.Add(st);
            return aux;
        }

        private void AbroWordConErrores(Dictionary<string, List<string>> listaErrores)
        {
            Prueba_2 p = new Prueba_2(listaErrores);
            p.Show();

            //Dictionary<string, List<string>>.Enumerator iter = listaErrores.GetEnumerator();

            //object missing = null;

            //Word._Application oWord;
            //oWord = new Word.ApplicationClass();
            //Word._Document oDoc;
            //oDoc = new Word.DocumentClass();

            //oWord.Visible = true;

            //// Acá Try
            //try
            //{

            //    oDoc = oWord.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            //    object ini = 0;
            //    object fin = 40;
            //    Word.Range rng;

            //    iter.MoveNext();

            //    rng = oDoc.Range(ref ini, ref fin);
            //    rng.Text = iter.Current.Key.ToString();

            //    ini = (int)ini + 40;
            //    fin = (int)fin + 40;

            //    rng = oDoc.Range(ref ini, ref fin);
            //    rng.Text = iter.Current.Value[0].ToString();
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
        }

    }
}
