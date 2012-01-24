using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace ControlHoras
{
    public partial class ListaNegraServicios : Form
    {
        IABMTipos tipos = ControladorABMTipos.getInstance();
        static ListaNegraServicios ventana = null;
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";

        private ListaNegraServicios()
        {
            InitializeComponent();

            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            
        }

        public static ListaNegraServicios getVentana()
        {
            if (ventana == null)
                ventana = new ListaNegraServicios();
            return ventana;
        }



        private void limpiarForm()
        {
           
        }

        private void ListaNegraServicios_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;

            try
            {
                Dictionary<int, string> bancos = tipos.obtenerBancos(false);
                foreach (int iter in bancos.Keys)
                {
                    int n = -10;
                    try
                    {
                        n = dgvBancos.Rows.Add();
                        dgvBancos.Rows[n].Cells["idBanco"].Value = iter;
                        dgvBancos.Rows[n].Cells["Nombre"].Value = bancos[iter];
                        // dgvBancos.Rows[n].Cells["Activa"].Value = cat[3];

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Error Cargando las Bancos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (n > -10)
                            try
                            {
                                dgvBancos.Rows.RemoveAt(n);
                            }
                            catch (Exception ex1)
                            {
                                MessageBox.Show(this, ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                try
                {
                    int numFila = 0;
                    while (dgvBancos.RowCount > numFila && lblIdListaNegraServicios.Text != dgvBancos.Rows[numFila].Cells["idBanco"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvBancos.RowCount)
                    {
                        char estado = 'S';
                        
                        // Modifica el valor en la base de datos
                       
                        
                        btnAgregar.Enabled = true;
                        btnGuardar.Enabled = false;
                        limpiarForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
                int n = -10;
                try
                {
                    char estado = 'S';
                    

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n > -10)
                        try
                        {
                            dgvBancos.Rows.RemoveAt(n);
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(this, ex2.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                }
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void dgvTiposMotivoCambioDiario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int rowindex = dgvBancos.SelectedRows[0].Index;
            if (rowindex == -1)
            {
                return;
            }
            
            lblIdListaNegraServicios.Text = dgvBancos.Rows[rowindex].Cells["idBanco"].Value.ToString();

            btnAgregar.Enabled = false;
            btnGuardar.Enabled = true;
            


        }

        private void ListaNegraServicios_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        private void tsbBuscarFuncionario_Click(object sender, EventArgs e)
        {
            // Muestro ventana de busqueda de empleados. La misma que en ABMEmpleados
            BuscarEmpleados busquedaEmps = new BuscarEmpleados();
            DialogResult res = busquedaEmps.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                try
                {
                    //EmPleadOs Funcionario = datos.obtenerEmpleado(busquedaEmps.idEmpleadoSeleccionado);
                    //mtFuncionario.Text = Funcionario.NroEmpleado.ToString();
                    //txtNombreFuncionario.Text = Funcionario.Nombre + " " + Funcionario.Apellido;
                    SendKeys.Send("{ENTER}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
