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
    public partial class ConsolidarEscalafonesForm : Form
    {

        IDatos datos;
        IClientesServicios dominio;

        public ConsolidarEscalafonesForm()
        {
            InitializeComponent();
        }


        private void ConsolidarEscalafonesForm_Load(object sender, EventArgs e)
        {
            try
            {
                ucTreeClientesServicios.cargarDatos();
                datos = ControladorDatos.getInstance();
                dominio = ControladorClientesServicios.getInstance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btnConsolidar_Click(object sender, EventArgs e)
        {
            try
            {
                //List<string> listaErrores = new List<string>();
                Dictionary<string, List<string>> listaErrores =  new Dictionary<string,List<string>>();
                Dictionary<int, List<int>> clientesServiciosSeleccionados = ucTreeClientesServicios.obtenerClientesServiciosSeleccionados();
                Dictionary<int,List<int>>.Enumerator iter = clientesServiciosSeleccionados.GetEnumerator();
                int nroCliente;
                List<string> errores;
                pbConsolidacion.Minimum = 1;
                pbConsolidacion.Maximum = clientesServiciosSeleccionados.Count;
                int valor = 1;
                while (iter.MoveNext())
                {
                    nroCliente = iter.Current.Key;
                    pbConsolidacion.Value = valor;
                    foreach (int nroServicio in iter.Current.Value)
                    {
                        try
                        {
                            errores = dominio.ejecutarControlesEscalafonServicio(nroCliente, nroServicio);
                            listaErrores.Add(nroCliente + ":" + nroServicio, errores);
                        }
                        catch (ControlEscalafonServicioException ces)
                        {
                            listaErrores.Add(nroCliente + ":" + nroServicio, new List<string> { ces.Message } );
                        }
                        
                        try
                        {
                            errores = dominio.ejecutarControlesEscalafonEmpleado(nroCliente, nroServicio);
                            try
                            {
                                listaErrores.Add(nroCliente + ":" + nroServicio, errores);
                            }
                            catch (Exception ex)
                            {
                              
                            }
                        }
                        catch (ControlEscalafonEmpleadoException ces)
                        {
                            listaErrores.Add(nroCliente + ":" + nroServicio, new List<string> { ces.Message });
                        }
                    }
                    valor++;
                }

                if (listaErrores.Count > 0)
                {
                    CRErroresConsolidacionEscalafones crece = new CRErroresConsolidacionEscalafones(listaErrores);
                    crece.Show();
                    // Despliego el conjunto de errores.
                    MessageBox.Show(this, "Consolidacion Finalizada Con Errores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(this, "Consolidacion Finalizada Correctamente. No se han encontrado errores en los escalafones.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ControlEscalafonEmpleadoException ceee)
            {
                MessageBox.Show(ceee.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
