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


namespace ControlHoras
{
    public partial class ExportToExcel : Form
    {
        private IDatos datos;
        private List<string> columnasSeleccionadas = null;
        private static ExportToExcel ventana = null;
        private List<ConsultAsEmPleadOs> consultasEmpleados;
        private string fechaMask = @"  /  /";

        private ExportToExcel()
        {
            datos = ControladorDatos.getInstance();
            columnasSeleccionadas = new List<string>();
            InitializeComponent();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void CargarCombo(ComboBox cmb, Dictionary<int, string> docs)
        //{
        //    BindingSource bs = new BindingSource();
        //    bs.DataSource = docs;
        //    cmb.DataSource = bs;
        //    cmb.ValueMember = "Key";
        //    cmb.DisplayMember = "Value";
        //}

        private void cargaGrillaResultados()
        {
            //int n = 0;
            //while( n <= listBoxCampos.CheckedItems.Count-1)
            //{
                
            //    n++;
            //}
          
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
                    gbPorTablasFiltros.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
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
                    if (ControladorUtilidades.exportToExcel(dgvResultados, saveExcelFileDialog.FileName))
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

        private void ExportToExcel_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        private void tcConsultas_TabIndexChanged(object sender, EventArgs e)
        {
            dgvResultados.Rows.Clear();
        }

        private void cmbEmpleadosConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s;
            if (cmbEmpleadosConsultas.SelectedValue != null && int.TryParse(cmbEmpleadosConsultas.SelectedValue.ToString(),out s))
            {
                ConsultAsEmPleadOs cons = consultasEmpleados[consultasEmpleados.IndexOf((ConsultAsEmPleadOs)cmbEmpleadosConsultas.SelectedItem)];
               
                txtConsultasEmpleadosDescripcion.Text = cons.Descripcion;
                if (cons.Query.Contains("FECHA"))
                {
                    panelConsultasEmpleadoFecha.Visible = true;
                }
                else
                    panelConsultasEmpleadoFecha.Visible = false;
                
                
            }
        }

        private bool ValidarFecha(string fecha)
        {
            DateTime dt;
            DateTimeStyles dts = new DateTimeStyles();

            if (fecha == fechaMask)
                return true;
            else
                return DateTime.TryParseExact(fecha, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo, dts, out dt);
        }

        private void mtConsultasEmpleadoFecha_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(mtConsultasEmpleadoFecha.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtConsultasEmpleadoFecha, "No es una fecha válida");
            }
        }

        private void mtConsultasEmpleadoFecha_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(mtConsultasEmpleadoFecha, "");
        }

        private void btnEmpleadosConsultar_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parametrosQuery = new Dictionary<string, string>();
            if (consultasEmpleados[consultasEmpleados.IndexOf((ConsultAsEmPleadOs)cmbEmpleadosConsultas.SelectedItem)].Query.Contains("FECHA") && panelConsultasEmpleadoFecha.Visible)
            {
                if (mtConsultasEmpleadoFecha.Text == fechaMask)
                    MessageBox.Show("Debe llenar el campo fecha para la consulta.", "Llenar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    try
                    {
                        parametrosQuery.Add("FECHA", mtConsultasEmpleadoFecha.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
            try
            {
                DataSet ds = datos.ejecutarConsultaEmpleado(int.Parse(cmbEmpleadosConsultas.SelectedValue.ToString()), parametrosQuery);
                dgvResultados.DataSource = ds.Tables[0];
                btnExportToExcel.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
