using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace ControlHoras
{
    public partial class ExportToExcel : Form
    {
        private IDatos datos;


        public ExportToExcel()
        {
            datos = ControladorDatos.getInstance();
            InitializeComponent();
        }

        private void ExportToExcel_Load(object sender, EventArgs e)
        {
            //cargaResultados();
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

        }

        private void cargaGrillaResultados()
        {
            List<string> columnasSeleccionadas = new List<string>();
            int n = 0;
            while( n <= listBoxCampos.CheckedItems.Count-1)
            {
                columnasSeleccionadas.Add(listBoxCampos.CheckedItems[n].ToString());
                n++;
            }
            try
            {
                DataSet dataTable = datos.obtenerDataFromTable(cmbTablas.SelectedItem.ToString(), columnasSeleccionadas);
                dgvResultados.DataSource = dataTable.Tables[0];
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
                cargaListaColumnas();
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

        }

        

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
          int index = 0;
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
            }
        }

    }
}
