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
    public partial class ServiciosFuncionariosSumarHsComunes : Form
    {

        Dictionary<String,bool> listaFuncionarios;
        IDatos datos;

        public ServiciosFuncionariosSumarHsComunes()
        {
            InitializeComponent();
        }

        private void ServiciosFuncionariosSumarHsComunes_Load(object sender, EventArgs e)
        {
            try
            {
                datos = ControladorDatos.getInstance();
                List<EmPleadOs> lista = datos.buscarEmpleados("TODOS", "", false);
                listaFuncionarios = new Dictionary<String,bool>();
                foreach (EmPleadOs emp in lista)
                {
                    if (emp.TipOscarGoS.TipoFacturacion.Equals("JORNALERO", StringComparison.CurrentCultureIgnoreCase))
                    {
                        listaFuncionarios.Add(emp.NroEmpleado + " - " + emp.Apellido + " " + emp.Nombre,false);
                    }
                }
                cargarClientesServicios();
                marcarClientesServicios_Y_Empleados_Seleccionados();
                recargarCheckedListBoxFuncionarios(listaFuncionarios.Keys.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void marcarClientesServicios_Y_Empleados_Seleccionados()
        {
            try
            {
                List<HsComUnEsAdICIonAleSLiquidAcIonEmPleadO> listaSeleccionados = datos.obtenerHsComunesAdicionalesLiquidacionEmpleados(null, null);
                foreach (HsComUnEsAdICIonAleSLiquidAcIonEmPleadO sel in listaSeleccionados)
                {
                    if(sel.ClienteOeMpleado == "CLIENTE")
                    {
                        tcClientesServicios.marcarClienteServicio(int.Parse(sel.ClienteEmpleadoCorrespondiente.Split('-')[0].Trim()), int.Parse(sel.ClienteEmpleadoCorrespondiente.Split('-')[1].Trim()),true);
                    }
                    else if (sel.ClienteOeMpleado == "EMPLEADO")
                    {
                        foreach (String str in listaFuncionarios.Keys)
                        {
                            if (str.ToLower().Contains(sel.ClienteEmpleadoCorrespondiente))
                            {
                                listaFuncionarios[str] = true;
                                break;
                            }
                        }
                    }

                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarClientesServicios()
        {
            try
            {
                tcClientesServicios.cargarDatos(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnFiltrarFuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> aux = new List<string>();
                foreach (String str in listaFuncionarios.Keys)
                {
                    if (str.ToLower().Contains(txtFiltro.Text.ToLower()))
                        aux.Add(str);
                }
                recargarCheckedListBoxFuncionarios(aux);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lbFuncionarios_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                listaFuncionarios[lbFuncionarios.Items[e.Index].ToString()] = true;
            else if (e.NewValue == CheckState.Unchecked)
                listaFuncionarios[lbFuncionarios.Items[e.Index].ToString()] = false;
        }

        private void recargarCheckedListBoxFuncionarios(List<String> lista)
        {
            try
            {
                lbFuncionarios.BeginUpdate();
                lbFuncionarios.DataSource = lista;
                lbFuncionarios.EndUpdate();
                int index = 0;
                while (index < lbFuncionarios.Items.Count)
                {
                    lbFuncionarios.SetItemChecked(index, listaFuncionarios[lbFuncionarios.Items[index].ToString()]);
                    index++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnFiltroSeleccionados_Click(object sender, EventArgs e)
        {
            

        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnFiltrarFuncionarios.PerformClick();

        }

        private void btnClearFiltro_Click(object sender, EventArgs e)
        {
            cbSeleccionados.Checked = false;
            txtFiltro.Text = "";
            btnFiltrarFuncionarios.PerformClick();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<HsComUnEsAdICIonAleSLiquidAcIonEmPleadO> listaAGuadar = new List<HsComUnEsAdICIonAleSLiquidAcIonEmPleadO>();
                HsComUnEsAdICIonAleSLiquidAcIonEmPleadO temp;
                
                // Registramos los Clientes/Servicios seleccionados
                Dictionary<int,List<int>> clientesServicios = tcClientesServicios.obtenerClientesServiciosSeleccionados();
                foreach (int NroCliente in clientesServicios.Keys)
                {
                    foreach (int NroServ in clientesServicios[NroCliente])
                    {
                        temp = new HsComUnEsAdICIonAleSLiquidAcIonEmPleadO();
                        temp.ClienteOeMpleado = "CLIENTE";
                        temp.ClienteEmpleadoCorrespondiente = NroCliente + " - " + NroServ;
                        temp.HsAdicionalesEnSegs = null;
                        listaAGuadar.Add(temp);
                    }
                }

                // Registramos los empleados seleccionados
                foreach (String LineaEmp in listaFuncionarios.Keys)
                {
                    if (listaFuncionarios[LineaEmp])
                    {
                        temp = new HsComUnEsAdICIonAleSLiquidAcIonEmPleadO();
                        temp.ClienteOeMpleado = "EMPLEADO";
                        temp.ClienteEmpleadoCorrespondiente = LineaEmp.Split('-')[0].Trim();
                        temp.HsAdicionalesEnSegs = "1800"; // 30 min por defecto.
                        listaAGuadar.Add(temp);
                    }
                }

                // Persistimos
                datos.guardarHsComunesAdicionalesLiquidacionEmpleados(listaAGuadar);
                MessageBox.Show("Datos Guardados Correctamente.", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void cbSeleccionados_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeleccionados.Checked)
            {
                try
                {
                    List<String> aux = new List<string>();
                    foreach (String str in listaFuncionarios.Keys)
                    {
                        if (listaFuncionarios[str])
                            aux.Add(str);
                    }
                    recargarCheckedListBoxFuncionarios(aux);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtFiltro.Text = "";
                btnFiltrarFuncionarios.PerformClick();
            }
        }

        

    }
}
