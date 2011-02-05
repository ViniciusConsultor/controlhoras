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

        private Image ImagenOK = Imagenes.check_ok;
        private Image ImagenError = Imagenes.check_error;
        private Image ImagenProcesando = Imagenes.procesando_2;

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


        private Dictionary<string,List<string>> consolidar()
        {
            Dictionary<string, List<string>> listaErroresConsolidacion = new Dictionary<string, List<string>>();
            List<string> errores;
            int nroCliente;
            try
            {
                setConsolidacionImageProcesando();
                
                //List<string> listaErrores = new List<string>();
                Dictionary<int, List<int>> clientesServiciosSeleccionados = ucTreeClientesServicios.obtenerClientesServiciosSeleccionados();
                Dictionary<int, List<int>>.Enumerator iter = clientesServiciosSeleccionados.GetEnumerator();
                progressBarReset(0, clientesServiciosSeleccionados.Count());
                
                List<string> listaAux;
                while (iter.MoveNext())
                {
                    nroCliente = iter.Current.Key;
                    
                    foreach (int nroServicio in iter.Current.Value)
                    {
                        setLabelConsolidacion("Consolidando " + nroCliente + " - " + nroServicio);
                        // Corremos la consolidacion para el cliente servicio
                        errores = new List<string>();

                        try
                        {
                            listaAux = controladorClientes.ejecutarControlesEscalafonServicio(nroCliente, nroServicio);
                            errores = concatenar(errores, listaAux);
                            //if (errores.Count > 0)
                            //    listaErroresConsolidacion.Add(nroCliente + ":" + nroServicio, errores);
                        }
                        catch (ControlEscalafonServicioException ces)
                        {
                            errores.Add(ces.Message);
                            //listaErroresConsolidacion.Add(nroCliente + ":" + nroServicio, new List<string> { ces.Message } );
                        }

                        try
                        {
                            listaAux = controladorClientes.ejecutarControlesEscalafonEmpleado(nroCliente, nroServicio);
                            errores = concatenar(errores, listaAux);
                       
                        }
                        catch (ControlEscalafonEmpleadoException ces)
                        {
                            errores.Add(ces.Message);
                           
                        }
                        if (errores.Count > 0)
                            listaErroresConsolidacion.Add(nroCliente + ":" + nroServicio, errores);
                    }
                    progressBarAvanzar();
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaErroresConsolidacion;        
                                                        
        }


        private Dictionary<string,List<string>> generarHoras(DateTime fechaDesde,DateTime fechaHasta)
        {
            
            lblNroCliente.Visible = true;
            int indice = 1;
            bool huboErrores = false;
            bool sobrescribirHorasGeneradas = false;
            List<string> listaErrores = new List<string>();
                
            try
            {
                TimeSpan diffTime = fechaHasta - fechaDesde;
                DateTime dateAux = fechaDesde;
                
                // Obtenemos la lista de clientes activos.
                Dictionary<int, List<int>> clientesServiciosSeleccionados = ucTreeClientesServicios.obtenerClientesServiciosSeleccionados();
                Dictionary<int, List<int>>.Enumerator iter = clientesServiciosSeleccionados.GetEnumerator();
                int nroCliente;
                string clienteServicioError="";

                controladorClientes.iniciarGeneracionHoras();
                while (dateAux <= fechaHasta)
                {
                    lblFecha.Text = dateAux.ToShortDateString();
                    lblFecha.Refresh();
                    
                    while (iter.MoveNext())
                    {
                        nroCliente = iter.Current.Key;

                        lblNroCliente.Text = nroCliente.ToString();
                        lblNroCliente.Refresh();

                        foreach (int nroServicio in iter.Current.Value)
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
                                        try
                                        {
                                            controladorClientes.generarHorasDiaServicio(nroCliente, nroServicio, dateAux, sobrescribirHorasGeneradas);

                                        }
                                        catch(Exception ex)
                                        {
                                            huboErrores = true;
                                            clienteServicioError = nroCliente + ":" + nroServicio;
                                            listaErrores.Add(ex.Message);
                                        }
                                    }
                                }
                            }
                            catch (Exception exGen)
                            {
                                huboErrores = true;
                                clienteServicioError = nroCliente + ":" + nroServicio;
                                listaErrores.Add(exGen.Message);
                                break;
                            }
                        }
                    }       
                    iter = clientesServiciosSeleccionados.GetEnumerator();
                    indice++;
                    dateAux = dateAux.AddDays(1);                
                }
                if (!huboErrores)
                {
                    controladorClientes.finalizarGeneracionHoras(true, sobrescribirHorasGeneradas);
                    
                    return new Dictionary<string, List<string>>();
                }
                else
                {
                    controladorClientes.finalizarGeneracionHoras(false, false);
                    Dictionary<string, List<string>> errores = new Dictionary<string, List<string>>();
                    errores.Add(clienteServicioError, listaErrores);
                    return errores;
                }    
            }
            catch (Exception ex)
            {
                throw ex;
                // MessageBox.Show(this, "Error al Generar. " + ex.Message, "Generacion Cancelada.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lblNroCliente.Visible = false;
            }
            
            //else
            //    MessageBox.Show(this, "La Fecha Desde debe ser menor a la Fecha Hasta.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde;
            DateTime fechaHasta;
            bool errorConsolidacion = false;
            //List<string> listaErrores = new List<string>();
            
            if (DateTime.TryParse(mtFechaDesde.Text, out fechaDesde))
            {
                if (DateTime.TryParse(mtFechaHasta.Text, out fechaHasta))
                {
                    if (fechaDesde <= fechaHasta)
                    {
                        DialogResult dg = MessageBox.Show(this, "Confirma el inicio de la Generacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dg == DialogResult.Yes)
                        {
                            panelConsolidacion.Visible = false;
                            panelGeneracion.Visible = false;

                            ucTreeClientesServicios.Enabled = false;
                            Dictionary<string, List<string>> listaErrores;
                            try
                            {
                                // Primero consolidamos
                                panelConsolidacion.Visible = true;
                                progressBar.Visible = true;
                                listaErrores = consolidar();
                                if (listaErrores.Count > 0)
                                {
                                    // Si la consolidacion da errores
                                    // Despliego el conjunto de errores.
                                    setConsolidacionImageError();
                                    errorConsolidacion = true;
                                    MessageBox.Show(this, "Generacion Cancelada.", "Error al Generar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    AbroWordConErrores(listaErrores);
                                }
                                else
                                {
                                    // Si la consolidacion estuvo OK, GENERAMOS
                                    setConsolidacionImageOK();
                                    setGeneracionImageProcesando();
                                    panelGeneracion.Visible = true;
                                    listaErrores=generarHoras(fechaDesde, fechaHasta);
                                    if (listaErrores.Count > 0)
                                    {
                                        setGeneracionImageError();
                                        AbroWordConErrores(listaErrores);
                                    }
                                    else
                                    {
                                        setGeneracionImageOK();
                                        MessageBox.Show(this, "Proceso Finalizado Correctamente.", "Generacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            catch (Exception exx)
                            {
                                if (errorConsolidacion)
                                {
                                    setConsolidacionImageError();
                                    MessageBox.Show(this, "Consolidacion Finalizada Con Errores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    setGeneracionImageError();
                                    MessageBox.Show(this, exx.Message, "Error en la Generacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                            }
                            finally
                            {
                                ucTreeClientesServicios.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                            MessageBox.Show(this, "FechaHasta debe ser mayor o igual a FechaDesde.", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 }     
                 else
                       MessageBox.Show(this, "El formato de la fecha Hasta ingresada no es correcto.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(this, "El formato de la fecha Desde ingresada no es correcto.", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        
            
        }


        private List<string> concatenar(List<string> l1, List<string> l2)
        {
            List<string> aux = new List<string>(l1);
            foreach (string st in l2)
                aux.Add(st);
            return aux;
        }


        public void setGeneracionShowImage()
        {
            generandoPicBox.Visible = true;
            generandoPicBox.Refresh();
        }

        public void setGeneracionImageOK()
        {
            generandoPicBox.Image = ImagenOK;
            generandoPicBox.Refresh();
        }

        public void setGeneracionImageError()
        {
            generandoPicBox.Image = ImagenError;
            generandoPicBox.Refresh();
        }

        public void setGeneracionImageProcesando()
        {
            generandoPicBox.Image = ImagenProcesando;
            generandoPicBox.Refresh();
        }

        public void setLabelGeneracion(string text)
        {
            lblGenerando.Text = text;
            lblGenerando.Refresh();
            this.Refresh();
        }

        public void setConsolidacionImageOK()
        {
            ConsolidandoPicBox.Image = ImagenOK;
            ConsolidandoPicBox.Refresh();
        }

        public void setConsolidacionImageError()
        {
            ConsolidandoPicBox.Image = ImagenError;
            ConsolidandoPicBox.Refresh();
        }

        public void setConsolidacionImageProcesando()
        {
            ConsolidandoPicBox.Image = ImagenProcesando;
            ConsolidandoPicBox.Refresh();
        }

        public void setLabelConsolidacion(string text)
        {
            lblConsolidando.Text = text;
            lblConsolidando.Refresh();
            this.Refresh();
        }

        public void progressBarReset(int valorInicio, int valorFin)
        {
            progressBar.Minimum = valorInicio;
            progressBar.Maximum = valorFin;
            progressBar.Value = progressBar.Minimum;
            progressBar.Refresh();
        }
        public void progressBarAvanzar()
        {
            progressBar.Value += 1;
            progressBar.Refresh();
        }

        private void AbroWordConErrores(Dictionary<string, List<string>> listaErrores)
        {
            Prueba_2 p = new Prueba_2(listaErrores);
            p.Show();

        }
    }
}
