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
    public partial class CerrarEscalafonForm : Form
    {
        private IDatos datos;
        private Image ImagenOK = Imagenes.check_ok;
        private Image ImagenError = Imagenes.check_error;
        private Image ImagenProcesando = Imagenes.procesando_2;


        public CerrarEscalafonForm()
        {
            InitializeComponent();
        }

        private void btnCerrarEscalafon_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde;
            DateTime fechaHasta;

            if (DateTime.TryParse(mtFechaDesde.Text, out fechaDesde))
            {
                if (DateTime.TryParse(mtFechaHasta.Text, out fechaHasta))
                {
                    DialogResult dr = MessageBox.Show("Seguro que quiere cerrar el escalafon en el rango fechas dado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            setLabelCerrando("Cerrando...");
                            setCerrandoImageProcesando();
                            this.Refresh();
                            aplicarControlesCierreEscalafon(fechaDesde,fechaHasta);
                            
                            // Cerramos los escalafones del rango dado.
                            datos.cerrarEscalafones(fechaDesde, fechaHasta);
                            setCerrandoImageOK();
                            this.Refresh();
                            MessageBox.Show("Escalafones cerrado correctamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            setCerrandoImageError();
                            this.Refresh();
                            MessageBox.Show("No se pudo Cerrar el Escalafon\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
        }

       
    
        private void aplicarControlesCierreEscalafon(DateTime fechaDesde,DateTime fechaHasta)
        {
            try
            {
                DateTime dtAux;
                bool cerrada;
                dtAux = fechaDesde;
                string message = "Error en los siguientes Cliente/Servicio Fecha:";
                bool escalafonGenerado = false;
                ControladorClientesServicios cliservs = ControladorClientesServicios.getInstance();
                List<ClientEs> clientes = datos.obtenerClientes(true);
                List<string> listaErrores = new List<string>();
               
                bool erroresDeEscalafonNoGenerado = false;
                while (dtAux <= fechaHasta)
                {
                    // Que no este cerrado el escalafon
                    cerrada = datos.tieneEscalafonCerrado(dtAux);
                    if (cerrada)
                        throw new Exception("La fecha " + dtAux.Date.ToShortDateString() + " ya tiene el escalafon cerrado");
                    
                    // Controlamos que no hayan funcionarios activos sin asignar.
                    int cantFuncActivosSinAsignar = datos.obtenerCantidadFuncionariosActivosSinAsignar(dtAux);
                    if (cantFuncActivosSinAsignar > 0)
                        throw new Exception("Existen "+cantFuncActivosSinAsignar+" funcionarios Activos sin asignar a ningun Servicio.");

                    // Controlamos con controles de Consolidacion y Horas generadas para todos los servicios.
                    panelCierre.Visible = true;
                    foreach (ClientEs cli in clientes)
                    {
                        foreach (SERVicIoS ser in cli.SERVicIoS)
                        {
                            if (ser.Activo == 1)
                            {
                                setLabelCerrando("Controlando "+cli.NumeroCliente+"/"+ser.NumeroServicio+"...");
                                this.Refresh();
                                // Aplicamos controles sobre el escalafon. Los mismos controles que el de Consolidacion
                                listaErrores = cliservs.ejecutarControlesEscalafonServicio((int)cli.NumeroCliente, (int)ser.NumeroServicio);
                                if (listaErrores.Count > 0)
                                {
                                    message += "\n - " + cli.NumeroCliente + "/" + ser.NumeroServicio + " Fecha: " + dtAux.ToShortDateString();
                                    foreach (string s in listaErrores)
                                    {
                                        message += "\t" + s + "\n";
                                    }
                                    erroresDeEscalafonNoGenerado = true;

                                }
                                else
                                {
                                    // Controlamos que tenga horas generadas
                                    escalafonGenerado = datos.tieneEscalafonGenerado((int)cli.NumeroCliente, (int)ser.NumeroServicio, dtAux);
                                    if (!escalafonGenerado)
                                    {
                                        message += "\n - " + cli.NumeroCliente + "/" + ser.NumeroServicio + " Fecha: " + dtAux.ToShortDateString() + ": No tiene generado el escalafon.";
                                        erroresDeEscalafonNoGenerado = true;
                                    }
                                }
                            }
                        }
                    }

                    dtAux = dtAux.AddDays(1);
                }

                if (erroresDeEscalafonNoGenerado)
                {
                    throw new Exception(message);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private void CerrarEscalafonForm_Load(object sender, EventArgs e)
        {
            datos = Datos.ControladorDatos.getInstance();
        }

        public void setCerrandoImageOK()
        {
            CierrePicBox.Image = ImagenOK;
            CierrePicBox.Refresh();
        }

        public void setCerrandoImageError()
        {
            CierrePicBox.Image = ImagenError;
            CierrePicBox.Refresh();
        }

        public void setCerrandoImageProcesando()
        {
            CierrePicBox.Image = ImagenProcesando;
            CierrePicBox.Refresh();
        }

        public void setLabelCerrando(string text)
        {
            lblCerrando.Text = text;
            lblCerrando.Refresh();
            this.Refresh();
        }
    }
}
