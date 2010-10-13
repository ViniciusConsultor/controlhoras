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
using Word = Microsoft.Office.Interop.Word;

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
                            if (errores.Count > 0)
                                listaErrores.Add(nroCliente + ":" + nroServicio, errores);
                        }
                        catch (ControlEscalafonServicioException ces)
                        {
                            listaErrores.Add(nroCliente + ":" + nroServicio, new List<string> { ces.Message } );
                        }
                        
                        try
                        {
                            errores = dominio.ejecutarControlesEscalafonEmpleado(nroCliente, nroServicio);
                            if (errores.Count > 0)
                            {
                                if (!listaErrores.ContainsKey(nroCliente + ":" + nroServicio))
                                    listaErrores.Add(nroCliente + ":" + nroServicio, errores);
                                else
                                {
                                    //errores = (List<string>)listaErrores[nroCliente + ":" + nroServicio].Concat(errores);
                                    errores = concatenar(listaErrores[nroCliente + ":" + nroServicio], errores);
                                    listaErrores.Remove(nroCliente + ":" + nroServicio);
                                    listaErrores.Add(nroCliente + ":" + nroServicio, errores);
                                }
                            }                            
                        }
                        catch (ControlEscalafonEmpleadoException ces)
                        {                            
                            if (!listaErrores.ContainsKey(nroCliente + ":" + nroServicio))
                                listaErrores.Add(nroCliente + ":" + nroServicio, new List<string> { ces.Message });
                            else
                            {
                                //errores = (List<string>)listaErrores[nroCliente + ":" + nroServicio].Concat(new List<string> { ces.Message });
                                errores = concatenar(listaErrores[nroCliente + ":" + nroServicio], new List<string> { ces.Message });
                                listaErrores.Remove(nroCliente + ":" + nroServicio);
                                listaErrores.Add(nroCliente + ":" + nroServicio, errores);
                            }
                        }
                    }
                    valor++;
                }

                if (listaErrores.Count > 0)
                {
                    //CRErroresConsolidacionEscalafones crece = new CRErroresConsolidacionEscalafones(listaErrores);
                    //crece.Show();
                    // Despliego el conjunto de errores.
                    MessageBox.Show(this, "Consolidacion Finalizada Con Errores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AbroWordConErrores(listaErrores);
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
