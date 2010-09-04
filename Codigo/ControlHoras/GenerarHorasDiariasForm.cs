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

namespace ControlHoras
{
    public partial class GenerarHorasDiariasForm : Form
    {
        IDatos datos;        

        public GenerarHorasDiariasForm()
        {
            InitializeComponent();
            datos = ControladorDatos.getInstance();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show(this, "Confirma el inicio de la Generacion?", "Confirmacion",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dg == DialogResult.Yes)
            {
                try
                {
                    lblProcesando.Visible = true;
                    lblNroCliente.Visible = true;
                    // Consolidar todos los escalafones
                    // 1- Que se cumple el contrato de todos los serivicios
                    // 2- Que todos los empleados (no de licencia ni descanso, ni suspendios, trabaja las hs normales correspondientes a su cargo por jornada
                    //    6 diasa  la semana, y que tiene un dia de descanso.
                    // 3- Que no se solapan los horarios de los emplreados.

                    List<ClientEs> clientes = datos.obtenerClientes(true);
                    progressBarGeneracion.Minimum = 1;
                    progressBarGeneracion.Maximum = clientes.Count;
                    int indice = 1;
                    progressBarGeneracion.Value = indice;
                    foreach (ClientEs cli in clientes)
                    {
                        lblNroCliente.Text = cli.NumeroCliente.ToString();
                        foreach (SERVicIoS ser in cli.SERVicIoS)
                        {
                            //ContraToS contrato = datos.obtenerContrato((int)ser.NumeroCliente, (int)ser.NumeroServicio);
                            //IEnumerator<LineAshOrAs> enumer = contrato.LineAshOrAs.GetEnumerator();
                            //while (enumer.MoveNext())
                            //{
                            //enumer.Current.HoRaRioDiA[0].
                            //}
                            Thread.Sleep(1000); 
                        }
                        progressBarGeneracion.Value = indice;
                        indice += 1;
                    }
                    MessageBox.Show(this, "Proceso Finalizado Correctamente.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Generacion Cancelada." + "\n" + ex.Message, "Error al Generar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    lblProcesando.Visible = false;
                    lblNroCliente.Visible = false;
                }
            }
        }
    }
}
