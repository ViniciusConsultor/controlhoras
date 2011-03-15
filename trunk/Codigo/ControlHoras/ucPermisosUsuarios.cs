using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using System.Collections;

namespace ControlHoras
{
    public partial class ucPermisosUsuarios : UserControl
    {
        IDatos datos;
        Dictionary<int, PantAllAwInForm> pantallasCargadas;

        public ucPermisosUsuarios()
        {
            InitializeComponent();
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

            List<PantAllAwInForm> listaPantallasCargadas = datos.obtenerPantallasWinForms(true);
            pantallasCargadas = new Dictionary<int,PantAllAwInForm>();
            TreeNode tnParent;
            TreeNode tnChild;
            tvWinForms_Controls.BeginUpdate();
            foreach (PantAllAwInForm pant in listaPantallasCargadas)
            {
                tnParent = new TreeNode("Pantalla:"+pant.IDPantallaWinForm+" | "+ pant.Nombre);
                foreach (PerMisOControl pc in pant.PerMisOControl)
                {
                    tnChild = new TreeNode("Control:"+pc.IDPermisoControl+" | " + pc.NombreVisual);
                    tnParent.Nodes.Add(tnChild);
                    
                }
                tvWinForms_Controls.Nodes.Add(tnParent);
                pantallasCargadas.Add(pant.IDPantallaWinForm,pant);
            }
            tvWinForms_Controls.EndUpdate();
        }

        public Dictionary<int, List<int>> obtenerPantallasYControlesSeleccionados()
        {
            try
            {
                Dictionary<int, List<int>> diccPantallaControl = new Dictionary<int, List<int>>();
                int idPantalla;
                int idControl;
                string auxStr;
                List<int> ControlesPantalla;
                foreach (TreeNode tn in tvWinForms_Controls.Nodes)
                {
                    if (tn.Checked)
                    {
                        auxStr = tn.Text.Split('|')[0].Split(':')[1];
                        auxStr = auxStr.Trim();
                        //str = str.Remove(str.Length - auxStr-1).Trim();
                        idPantalla = int.Parse(auxStr);
                        ControlesPantalla = new List<int>();
                        foreach (TreeNode tnChild in tn.Nodes)
                        {
                            if (tnChild.Checked)
                            {
                                auxStr = tnChild.Text.Split('|')[0].Split(':')[1].Trim();
                                //auxStr = auxStr.Remove(0, 9).Trim();

                                idControl = int.Parse(auxStr);
                                ControlesPantalla.Add(idControl);
                            }
                        }
                        diccPantallaControl.Add(idPantalla, ControlesPantalla);
                    }
                }

                return diccPantallaControl;
            }
            catch
            {
                throw;
            }

        }

       
        private void tvWinForms_Controls_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            


        }

        private void btnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tvWinForms_Controls.Nodes)
            {
                tn.Checked = true;
                foreach (TreeNode child in tn.Nodes)
                    child.Checked = true;
            }
        }

        private void btnDeseleccionarTodos_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tvWinForms_Controls.Nodes)
            {
                tn.Checked = false;
                foreach (TreeNode child in tn.Nodes)
                    child.Checked = false;
            }
        }


        
        public List<PantAllAwInForm> obtenerPantallasSeleccionadas()
        {
            try
            {
                string auxStr;
                PantAllAwInForm pantalla;
                List<PantAllAwInForm> listaPantallas = new List<PantAllAwInForm>();
                foreach (TreeNode tn in tvWinForms_Controls.Nodes)
                {
                    if (tn.Checked)
                    {
                        auxStr = tn.Text.Split('|')[1].Trim();
                        int idPantalla = int.Parse(auxStr);
                        //str = str.Remove(str.Length - auxStr-1).Trim();
                        pantalla =  pantallasCargadas[idPantalla];
                        listaPantallas.Add(pantalla);
                    }
                }

                return listaPantallas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void checkItems(Dictionary<int, List<int>> idPantallas_Controles)
        {
            try
            {
                string auxStr;
                int idPantalla;
                int idControl;
                foreach (TreeNode tn in tvWinForms_Controls.Nodes)
                {
                    // Obtengo el ID de la pantalla
                    auxStr = tn.Text.Split('|')[0].Split(':')[1];
                    idPantalla = int.Parse(auxStr.Trim());
                    if (idPantallas_Controles.Keys.Contains(idPantalla))
                    {
                        tn.Checked = true;

                        foreach (TreeNode tnChild in tn.Nodes)
                        {
                            auxStr = tnChild.Text.Split('|')[0].Split(':')[1].Trim();
                            idControl = int.Parse(auxStr);
                            if (idPantallas_Controles[idPantalla].Contains(idControl))
                                tnChild.Checked = true;
                            else
                                tnChild.Checked = false;

                        }
                    }
                    else
                        tn.Checked = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tvWinForms_Controls_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.StartsWith("Pantalla:"))
            {
                foreach (TreeNode tn in e.Node.Nodes)
                {
                    tn.Checked = e.Node.Checked;
                }
            }
            else if (e.Node.Text.StartsWith("Control:"))
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
    }
}
