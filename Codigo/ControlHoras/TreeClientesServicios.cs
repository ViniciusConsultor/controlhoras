using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace ControlHoras
{
    public partial class TreeClientesServicios : UserControl
    {
        private IDatos datos;
        private bool byHand;
        //private bool nodeParentPrevStates;
        private TreeViewAction action;

        public TreeClientesServicios()
        {
            InitializeComponent();
        }

        private void TreeClientesServicios_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Carga los datos en el UserControl con la lista de clientes activos.
        /// </summary>
        public void cargarDatos(bool soloactivos)
        {
            try
            {
                if (!this.DesignMode)
                {
                    datos = ControladorDatos.getInstance();
                }
            }
            catch
            {
                throw;
            }
            try
            {
                List<ClientEs> clientes = datos.obtenerClientes(soloactivos);
                TreeNode tnParent;
                TreeNode tnChild;
                tvClientesServicios.BeginUpdate();
                foreach (ClientEs cli in clientes)
                {
                    tnParent = new TreeNode("Cliente: " + cli.NumeroCliente + " | " + cli.Nombre);
                    foreach (SERVicIoS ser in cli.SERVicIoS)
                    {
                        if (ser.Activo == 1)
                        {
                            tnChild = new TreeNode("Servicio: " + ser.NumeroServicio + " | " + ser.Nombre);
                            tnParent.Nodes.Add(tnChild);
                        }
                    }
                    tvClientesServicios.Nodes.Add(tnParent);
                }
                tvClientesServicios.EndUpdate();
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Carga los datos en el UserControl con la lista de cliente pasada por parametros.
        /// </summary>
        /// <param name="listaClientes">Lista de ClientEs con la cual se cargara el Control.</param>
        public void cargarDatos(List<ClientEs> listaClientes)
        {
           
            try
            {
                TreeNode tnParent;
                TreeNode tnChild;
                tvClientesServicios.BeginUpdate();
                tvClientesServicios.Nodes.Clear();
                foreach (ClientEs cli in listaClientes)
                {
                    tnParent = new TreeNode("Cliente: " + cli.NumeroCliente + " | " + cli.Nombre);
                    foreach (SERVicIoS ser in cli.SERVicIoS)
                    {
                        tnChild = new TreeNode("Servicio: " + ser.NumeroServicio + " | " + ser.Nombre);
                        tnParent.Nodes.Add(tnChild);
                    }
                    tvClientesServicios.Nodes.Add(tnParent);
                }
                tvClientesServicios.EndUpdate();
            }
            catch
            {
                throw;
            }
        }

        public Dictionary<int, List<int>> obtenerClientesServiciosSeleccionados()
        {
            try
            {
                Dictionary<int, List<int>> diccClienteServicio = new Dictionary<int, List<int>>();
                int nroCliente;
                int nroServicio;
                string auxStr;
                List<int> serviciosCliente;
                foreach (TreeNode tn in tvClientesServicios.Nodes)
                {
                    if (tn.Checked)
                    {
                        auxStr = tn.Text.Split('|')[0];
                        auxStr = auxStr.Remove(0, 9).Trim();
                        //str = str.Remove(str.Length - auxStr-1).Trim();
                        nroCliente = int.Parse(auxStr);
                        serviciosCliente = new List<int>();
                        foreach (TreeNode tnChild in tn.Nodes)
                        {
                            if (tnChild.Checked)
                            {
                                auxStr = tnChild.Text.Split('|').First();
                                auxStr = auxStr.Remove(0, 9).Trim();
                                
                                nroServicio = int.Parse(auxStr);
                                serviciosCliente.Add(nroServicio);
                            }
                        }
                        if (serviciosCliente.Count > 0)
                            diccClienteServicio.Add(nroCliente, serviciosCliente);
                    }
                }

                return diccClienteServicio;
            }
            catch
            {
                throw;
            }
            
        }

        private void tvClientesServicios_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //seleccionarNodo(e.Node);
        }

        private void seleccionarNodo(TreeNode nodo)
        {
            bool byHand_prev;
            if ((action == TreeViewAction.ByMouse || action == TreeViewAction.ByKeyboard) || byHand)
            {
                if (nodo.Text.StartsWith("Cliente:"))
                {
                    byHand_prev = byHand;
                    byHand = false;
                    foreach (TreeNode tn in nodo.Nodes)
                    {
                        tn.Checked = nodo.Checked;
                    }
                    byHand = byHand_prev;
                }
                else if (nodo.Text.StartsWith("Servicio:"))
                {
                    if (nodo.Checked && !nodo.Parent.Checked)
                    {
                        byHand_prev = byHand;
                        byHand = false;
                        nodo.Parent.Checked = true;
                        byHand = byHand_prev;
                    }
                    else if (!nodo.Checked)
                    {
                        bool ningunoSeleccionado = true;
                        foreach (TreeNode tnc in nodo.Parent.Nodes)
                        {
                            if (tnc.Checked)
                            {
                                ningunoSeleccionado = false;
                                break;
                            }
                        }
                        if (ningunoSeleccionado)
                        {
                            byHand_prev = byHand;
                            byHand = false;
                            nodo.Parent.Checked = false;
                            byHand = byHand_prev;
                        }
                    }
                }

            }
        }



        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tvClientesServicios.Nodes)
            {
                tn.Checked = true;
                foreach (TreeNode child in tn.Nodes)
                    child.Checked = true;
            }
        }

        private void btnDeseleccionarTodos_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tvClientesServicios.Nodes)
            {
                tn.Checked = false;
                foreach (TreeNode child in tn.Nodes)
                    child.Checked = false;
            }
        }

        public List<ClientEs> obtenerClientesSeleccionados()
        {
            try
            {
                string auxStr;
                ClientEs auxCli = null;
                List<ClientEs> clientes = new List<ClientEs>();
                foreach (TreeNode tn in tvClientesServicios.Nodes)
                {
                    if (tn.Checked)
                    {
                        auxStr = tn.Text.Split('|')[0];
                        auxStr = auxStr.Remove(0, 9).Trim();
                        //str = str.Remove(str.Length - auxStr-1).Trim();
                        auxCli = datos.obtenerCliente(int.Parse(auxStr));
                        clientes.Add(auxCli);
                    }
                }

                return clientes;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }


        public void marcarClienteServicio(int NroCliente, int NroServicio, bool chequeado)
        {
            try
            {
                byHand = true;
                bool encontrado = false;
                foreach (TreeNode tn in tvClientesServicios.Nodes)
                {
                    if (tn.Text.StartsWith("Cliente:") && tn.Text.Contains(" " + NroCliente.ToString() + " |"))
                    {
                        foreach (TreeNode hijo in tn.Nodes)
                        {
                            if (hijo.Text.StartsWith("Servicio:") && hijo.Text.Contains(NroServicio.ToString()))
                            {
                                hijo.Checked = true;
                                encontrado = true;
                                //seleccionarNodo(hijo);
                                break;
                            }
                        }
                        if (encontrado)
                            break;
                    }
                }
                tvClientesServicios.Update();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                byHand = false;
            }
        }


        public void seleccionarCliente(int NroCliente, bool chequeado)
        {
            try
            {
                foreach (TreeNode tn in tvClientesServicios.Nodes)
                {
                    if (tn.Text.StartsWith("Cliente:") && tn.Text.Contains(" " + NroCliente.ToString() + "|"))
                    {
                        tn.Checked = chequeado;
                        break;                  
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tvClientesServicios_AfterCheck(object sender, TreeViewEventArgs e)
        {
            seleccionarNodo(e.Node);
        }

        private void tvClientesServicios_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            action = e.Action;
        }
    }
}
