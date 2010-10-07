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
        

        public TreeClientesServicios()
        {
            InitializeComponent();
            
        }

        private void TreeClientesServicios_Load(object sender, EventArgs e)
        {

        }

        public void cargarDatos()
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

            List<ClientEs> clientes = datos.obtenerClientes(true);
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
            if (e.Node.Text.StartsWith("Cliente:"))
            {
                foreach (TreeNode tn in e.Node.Nodes)
                {
                    tn.Checked = e.Node.Checked;
                }
            }
            else if (e.Node.Text.StartsWith("Servicio:"))
            {
                if (e.Node.Checked && !e.Node.Parent.Checked)
                    e.Node.Parent.Checked = true;
                else if (!e.Node.Checked)
                {
                    bool ningunoSeleccionado = true;
                    foreach (TreeNode tnc in e.Node.Parent.Nodes)
                    {
                        if (tnc.Checked)
                        {
                            ningunoSeleccionado = false;
                            break;
                        }
                    }
                    if (ningunoSeleccionado)
                        e.Node.Parent.Checked = false;
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
    }
}
