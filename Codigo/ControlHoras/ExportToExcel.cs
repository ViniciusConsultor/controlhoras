using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using Utilidades;
using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Configuration;


namespace ControlHoras
{
    public partial class ExportToExcel : Form
    {
        private IDatos datos;
        private List<string> columnasSeleccionadas = null;
        private static ExportToExcel ventana = null;
        private List<ConsultAsEmPleadOs> consultasEmpleados;
        private List<ConsultAsClientEs> consultasClientes;
        private string fechaMask = @"  /  /";
        private bool nuevoFormatoExportToExcel = true;
        private bool cerrando = false;

        private ExportToExcel()
        {
           InitializeComponent();
           try
           {               
               datos = ControladorDatos.getInstance();
               columnasSeleccionadas = new List<string>();
           }
           catch
           {
               throw;
           }
        }

        public static ExportToExcel getInstance()
        {
            if (ventana == null)
                ventana = new ExportToExcel();
            return ventana;
        }

        private void ExportToExcel_Load(object sender, EventArgs e)
        {
            try
            {
                //cargaTabTablas();
                List<string> schema = datos.obtenerNombreTablas();
                List<string> tablasOcultas = new List<string> { "horariodia", "lineashoras" };
                cerrando = false;
                string dbname = datos.obtenerNombreBaseDatos();
                string tmpNombre;
                cmbTablas.BeginUpdate();
                foreach (string nom in schema)
                {
                    tmpNombre = nom.Substring(dbname.Length + 1);
                    if (!tablasOcultas.Contains(tmpNombre))
                        cmbTablas.Items.Add(tmpNombre);
                }
                cmbTablas.EndUpdate();

                // cargaTabEmpleados
                cmbEmpleadosConsultas.BeginUpdate();
                consultasEmpleados = datos.obtenerConsultasEmpleados(true);
                cmbEmpleadosConsultas.DataSource = consultasEmpleados;
                cmbEmpleadosConsultas.DisplayMember = "Nombre";
                cmbEmpleadosConsultas.ValueMember = "IDConsultaEmpleado";
                cmbEmpleadosConsultas.EndUpdate();

                // cargaTabClientes
                cmbClientesConsultas.BeginUpdate();
                consultasClientes = datos.obtenerConsultasClientes(true);
                cmbClientesConsultas.DataSource = consultasClientes;
                cmbClientesConsultas.DisplayMember = "Nombre";
                cmbClientesConsultas.ValueMember = "IDConsultaCliente";
                cmbClientesConsultas.EndUpdate();
                cmbClientesConsultas.SelectedIndex = 0;

                tcConsultas.SelectedIndex = 1;
                if(ConfigurationManager.AppSettings.AllKeys.Contains("ConsultasExportToExcel_FormatoNuevo"))
                    nuevoFormatoExportToExcel = bool.Parse(ConfigurationManager.AppSettings["ConsultasExportToExcel_FormatoNuevo"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargaGrillaResultados()
        {
            try
            {
                if (columnasSeleccionadas.Count >= 1)
                {
                    DataSet dataTable = datos.obtenerDataFromTable(cmbTablas.SelectedItem.ToString(), columnasSeleccionadas, cbPorTablasInactivos.Checked);
                    dgvResultados.DataSource = dataTable.Tables[0];
                }else
                    MessageBox.Show("Debe seleccionar por lo menos una campo para consultar.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargaListaColumnas()
        {
            string tablaSelected = null;
            try
            {
                tablaSelected = cmbTablas.SelectedItem.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            if(tablaSelected!= null)
                try
                {
                    List<string> columnasOcultas = new List<string>();
                    
                    if (!tablaSelected.Contains(datos.obtenerNombreBaseDatos()))
                        tablaSelected = datos.obtenerNombreBaseDatos() + "." + tablaSelected;
                    List<string> tableColumns = datos.obtenerTableColumnsName(tablaSelected);
                    listBoxCampos.Items.Clear();
                    listBoxCampos.BeginUpdate();
                    foreach (string columna in tableColumns)
                    {
                        if (!columnasOcultas.Contains(columna)) 
                            listBoxCampos.Items.Add(columna);
                       
                    }
                    listBoxCampos.EndUpdate();
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargaGrillaResultados();
            btnExportToExcel.Enabled = true;
            
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedItem.ToString() != "")
            {
                btnCancelar.PerformClick();
                cargaListaColumnas();
                lblOrdenResultado.Text = "";
                List<string> tablasMuestroGroupBox = new List<string> { "empleados", "clientes", "servicios" };
                string tablaSelected = cmbTablas.SelectedItem.ToString();
                if (tablasMuestroGroupBox.Contains(tablaSelected))
                {
                    //gbPorTablasFiltros.Visible = true;
                    lblPorTablaNombre.Text = tablaSelected;
                    if (listBoxCampos.Items.Contains("Activo"))
                        cbPorTablasInactivos.Visible = true;

                }
                else
                    gbPorTablasFiltros.Visible = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbPorTablasFiltros.Visible = false;
            cbPorTablasInactivos.Visible = false;
            listBoxCampos.Items.Clear();
            dgvResultados.DataSource = null;
            lblOrdenResultado.Text = "";
            columnasSeleccionadas.Clear();
            btnExportToExcel.Enabled = false;

        }

        

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
          int index = 0;
          // Primero deselecciono todo
          while (index < listBoxCampos.Items.Count)
          {
            listBoxCampos.SetItemChecked(index, false);
            index++;
          }
          index = 0;
          while (index < listBoxCampos.Items.Count)
          {
                listBoxCampos.SetItemChecked(index, true);
                    index++;
          }  
        }

        private void btnDeseleccionarTodos_Click(object sender, EventArgs e)
        {
            int index = 0;
            while (index < listBoxCampos.Items.Count)
            {
                listBoxCampos.SetItemChecked(index, false);
                index++;
            }
        }

        private void listBoxCampos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string previous = " - ";
            if (e.NewValue == CheckState.Checked)
            {
                if (lblOrdenResultado.Text == "")
                    previous = "";
                lblOrdenResultado.Text = lblOrdenResultado.Text + previous + listBoxCampos.Items[e.Index].ToString();
                columnasSeleccionadas.Add(listBoxCampos.Items[e.Index].ToString());
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                if (lblOrdenResultado.Text.StartsWith(listBoxCampos.Items[e.Index].ToString() + " - "))
                    // Si se deselecciono el primer elemento, se borra el " - " que queda al inicio
                    lblOrdenResultado.Text = lblOrdenResultado.Text.Remove(0, listBoxCampos.Items[e.Index].ToString().Length + 3);
                else if (lblOrdenResultado.Text.EndsWith(" - " + listBoxCampos.Items[e.Index].ToString()))
                    // Si se deselecciono el ultimo, se borra el " - " que queda al final
                    lblOrdenResultado.Text = lblOrdenResultado.Text.Remove(lblOrdenResultado.Text.Length - listBoxCampos.Items[e.Index].ToString().Length - 3, listBoxCampos.Items[e.Index].ToString().Length +3);
                else if (lblOrdenResultado.Text.Equals(listBoxCampos.Items[e.Index].ToString()))
                    lblOrdenResultado.Text = "";
                else{
                    lblOrdenResultado.Text = lblOrdenResultado.Text.Replace(" " + listBoxCampos.Items[e.Index].ToString() + " ", "  ");
                    if (lblOrdenResultado.Text.Contains(" -  - "))
                        lblOrdenResultado.Text = lblOrdenResultado.Text.Replace(" -  - ", " - ");
                }
                columnasSeleccionadas.Remove(listBoxCampos.Items[e.Index].ToString());
            }

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = saveExcelFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string TituloListado = getListadoEnEjecucion();
                    bool resB;
                    if (nuevoFormatoExportToExcel)
                        resB = ControladorUtilidades.exportToExcel(dgvResultados, saveExcelFileDialog.FileName, TituloListado, ((VentanaPrincipal)this.Owner).userName);
                    else
                        resB = ControladorUtilidades.exportToExcel_old(dgvResultados,saveExcelFileDialog.FileName);
                    if (resB)
                    {
                        DialogResult res = MessageBox.Show("Archivo Exportado correctamente. Desea abrir ahora el archivo exportado?", "Exportacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            // try forcing the window to be full-screen maximized
                            System.Diagnostics.ProcessStartInfo defapp = new System.Diagnostics.ProcessStartInfo();

                            defapp.FileName = @saveExcelFileDialog.FileName;
                            defapp.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
                            System.Diagnostics.Process.Start(defapp);
                        }

                    }
                    else
                        MessageBox.Show("Error al exportar el archivo.", "Exportacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exportacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getListadoEnEjecucion()
        {
            if (tcConsultas.SelectedTab == tbClientes)
            {
               return ((ConsultAsClientEs)cmbClientesConsultas.SelectedItem).Nombre;
            }
            else if (tcConsultas.SelectedTab == tbEmpleados)
            {
                return ((ConsultAsEmPleadOs)cmbEmpleadosConsultas.SelectedItem).Nombre;
            }
            else if (tcConsultas.SelectedTab == tbPorTablas)
            {
                return cmbTablas.SelectedText;
            }
            return "";
        }

        private void ExportToExcel_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        private void tcConsultas_TabIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvResultados.DataSource = null;
                dgvResultados.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (tcConsultas.SelectedTab == tbClientes)
            {
                panelPorTablas.Visible = false;
                panelFiltros.Visible = true;
                cmbClientesConsultas.SelectedIndex = 0;
                cmbEmpleadosConsultas_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else if (tcConsultas.SelectedTab == tbEmpleados)
            {
                panelPorTablas.Visible = false;
                panelFiltros.Visible = true;
                cmbEmpleadosConsultas.SelectedIndex = 0;
                cmbClientesConsultas_SelectedIndexChanged(this, EventArgs.Empty);
            }
            else if (tcConsultas.SelectedTab == tbPorTablas)
            {
                panelPorTablas.Visible = true;
                panelFiltros.Visible = false;
            }
        }


        private void showFilters(string query)
        {
            if (query.Contains("FECHASOLA"))
            {
                panelFecha.Visible = true;
                lblmtFecha.Text = "Fecha";
            }
            else
                panelFecha.Visible = false;

            if (query.Contains("NROCLIENTE"))
            {
                panelCliente.Visible = true;
                if (query.Contains("NROSERVICIO") || query.Contains("IFNROSERVICIO"))
                    panelServicio.Visible = true;
                else
                    panelServicio.Visible = false;
            }
            else
            {
                panelCliente.Visible = false;
                panelServicio.Visible = false;
            }
            if (query.Contains("FECHADESDE") && query.Contains("FECHAHASTA"))
                panelFechaDesdeHasta.Visible=true;
            else
                panelFechaDesdeHasta.Visible = false;
            if (query.Contains("NROEMPLEADO") || query.Contains("IFNROEMPLEADO"))
                panelEmpleado.Visible = true;
            else
                panelEmpleado.Visible = false;
        }

        private void cmbEmpleadosConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s;
            if (cmbEmpleadosConsultas.SelectedValue != null && int.TryParse(cmbEmpleadosConsultas.SelectedValue.ToString(),out s))
            {
                ConsultAsEmPleadOs consulta = consultasEmpleados[consultasEmpleados.IndexOf((ConsultAsEmPleadOs)cmbEmpleadosConsultas.SelectedItem)];
                txtConsultasEmpleadosDescripcion.Text = consulta.Descripcion;
                showFilters(consulta.Query);
                if (consulta.Nombre.Contains("BAJAS SIN FECHA DE PAGO PREVISTO"))
                    lblmtFecha.Text = "Fecha Desde";
                if (consulta.Nombre.Contains("BAJAS SIN FECHA DE PAGO PREVISTO"))
                    lblmtFecha.Text = "Fecha Pago Prevista";
                
            }
        }


        private void cmbClientesConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s;
            if (cmbClientesConsultas.SelectedValue != null && int.TryParse(cmbClientesConsultas.SelectedValue.ToString(), out s))
            {
                ConsultAsClientEs consulta = consultasClientes[consultasClientes.IndexOf((ConsultAsClientEs)cmbClientesConsultas.SelectedItem)];
                txtClientesDescripcionConsulta.Text = consulta.Descripcion;
                showFilters(consulta.Query);
            }
        }


        private bool ValidarFecha(string fecha)
        {
            DateTime dt;
            DateTimeStyles dts = new DateTimeStyles();
            try
            {
                if (fecha == fechaMask)
                    return true;
                else
                    return DateTime.TryParseExact(fecha, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo, dts, out dt);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void mtConsultasEmpleadoFecha_Validating(object sender, CancelEventArgs e)
        {
            if (panelFechaDesdeHasta.Visible)
            {
                if (!ValidarFecha(mtFechaDesde.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(mtFechaDesde, "No es una fecha válida");
                }
                if (!ValidarFecha(mtFechaHasta.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(mtFechaHasta, "No es una fecha válida");
                }
            }

            if (mtFecha.Visible && !ValidarFecha(mtFecha.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtFecha, "No es una fecha válida");
            }
            if (mtFecha.Visible && !ValidarFecha(mtFecha.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtFecha, "No es una fecha válida");
            }
        }

        private void mtConsultasEmpleadoFecha_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(mtFecha, "");
        }

        private void btnEmpleadosConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametrosQuery = new Dictionary<string, string>();
            if (consultasEmpleados[consultasEmpleados.IndexOf((ConsultAsEmPleadOs)cmbEmpleadosConsultas.SelectedItem)].Query.Contains("FECHASOLA") && panelFecha.Visible)
            {
                if (mtFecha.Text == fechaMask)
                    MessageBox.Show("Debe llenar el campo fecha para la consulta.", "Llenar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    try
                    {
                        parametrosQuery.Add("FECHASOLA", mtFecha.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
            try
            {
                new Exception("No usar btnEmpleadoConsultar_Click!!!");
                //dgvResultados.DataSource = ds.Tables[0];
                //btnExportToExcel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            bool error = false;
            Dictionary<string, string> parametrosQuery = new Dictionary<string, string>();
            try
            {
                string cquery;
                if (tcConsultas.SelectedTab == tbEmpleados)
                {
                    ConsultAsEmPleadOs query = consultasEmpleados[consultasEmpleados.IndexOf((ConsultAsEmPleadOs)cmbEmpleadosConsultas.SelectedItem)];
                    cquery = query.Query;
                }
                else
                {
                    ConsultAsClientEs query = consultasClientes[consultasClientes.IndexOf((ConsultAsClientEs)cmbClientesConsultas.SelectedItem)];
                    cquery = query.Query;
                }
                
                if (cquery.Contains("FECHASOLA") && panelFecha.Visible)
                {
                    if (mtFecha.Text == fechaMask)
                    {
                        error = true;
                        MessageBox.Show("Debe llenar el campo fecha para la consulta.", "Llenar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            parametrosQuery.Add("FECHASOLA", mtFecha.Text);
                        }
                        catch (Exception ex)
                        {
                            error = true;
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                if (cquery.Contains("NROCLIENTE") && panelCliente.Visible)
                {
                    if (mtNroCliente.Text == "")
                    {
                        error = true;
                        MessageBox.Show("Debe llenar los campos requeridos para la consulta.", "Llenar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            parametrosQuery.Add("NROCLIENTE", mtNroCliente.Text);
                        }
                        catch (Exception ex)
                        {
                            error = true;
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        if (cquery.Contains("IFNROSERVICIO"))
                        {
                            try
                            {
                                if (mtNroServicio.Text != "")
                                    parametrosQuery.Add("NROSERVICIO", mtNroServicio.Text);
                            }
                            catch (Exception ex)
                            {
                                error = true;
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (cquery.Contains("NROSERVICIO"))
                        {
                            mtNroServicio.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            if (mtNroServicio.Text == "")
                            {
                                error = true;
                                MessageBox.Show("Debe llenar los campos requeridos para la consulta.", "Llenar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                try
                                {
                                    parametrosQuery.Add("NROSERVICIO", mtNroServicio.Text);
                                }
                                catch (Exception ex)
                                {
                                    error = true;
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                        }
                    }
                }
                if (panelFechaDesdeHasta.Visible)
                {
                    try
                    {
                        parametrosQuery.Add("FECHADESDE", mtFechaDesde.Text);
                        parametrosQuery.Add("FECHAHASTA", mtFechaHasta.Text);
                    }
                    catch (Exception ex)
                    {
                        error = true;
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (panelEmpleado.Visible)
                {
                    try
                    {
                        if (mtNumeroEmpleado.Text != "") 
                            parametrosQuery.Add("NROEMPLEADO", mtNumeroEmpleado.Text);
                    }
                    catch (Exception ex)
                    {
                        error = true;
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                if (!error)
                {
                    DataSet ds;
                    if (tcConsultas.SelectedTab == tbClientes)
                    {
                        ds = datos.ejecutarConsultaCliente(int.Parse(cmbClientesConsultas.SelectedValue.ToString()), parametrosQuery);
                       
                    }
                    else
                    {
                        ds = datos.ejecutarConsultaEmpleado(int.Parse(cmbEmpleadosConsultas.SelectedValue.ToString()), parametrosQuery);
                    }
                     
                    dgvResultados.DataSource = ds.Tables[0];
                    if (dgvResultados.Rows.Count == 0)
                        MessageBox.Show("No se han encontrado datos.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        btnExportToExcel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtNumeroEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtNumeroEmpleado.Text != "")
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    EmPleadOs emp = datos.obtenerEmpleado(int.Parse(mtNumeroEmpleado.Text));
                    lblEmpleado.Text = emp.Apellido + " " + emp.Nombre;
                }
            }
        }

        private void mtNroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtNroCliente.Text != "")
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    ClientEs cli = datos.obtenerCliente(int.Parse(mtNroCliente.Text));
                    lblCliente.Text = cli.Nombre;
                }
            }
        }

        private void mtNroServicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtNroServicio.Text != "")
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    SERVicIoS serv = datos.obtenerServicioCliente(int.Parse(mtNroCliente.Text),int.Parse(mtNroServicio.Text));
                    lblServicio.Text = serv.Nombre;
                }
            }
        
        }

        private void ExportToExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrando = true;
        }

       
    }
}
