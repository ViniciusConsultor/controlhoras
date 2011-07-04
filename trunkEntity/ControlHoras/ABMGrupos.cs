using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using System.Collections;

namespace ControlHoras
{
    public partial class ABMGrupos : Form
    {
        IDatos datos;
        IDatosABMTipos datosabm;
        // Como no pude mantener la lista de usuarios en la grilla lo mantengo en este diccionario.
        Dictionary<int, List<string>> dicUsuariosPorGrupo;
        Dictionary<int,Dictionary<int,List<int>>> dicPermisosPorGrupo;

        public ABMGrupos()
        {
            InitializeComponent();
        }

        private void ABMGrupos_Load(object sender, EventArgs e)
        {
            List<string> listaUsuarios;
            try
            {
                ucPermisosUsuarios1.cargarDatos();
                datos = ControladorDatos.getInstance();
                datosabm = DatosABMTipos.getInstance();
                dgvGrupos.Rows.Clear();
                
                List<GRuPOs> grupos = datosabm.obtenerListaGrupos(false);
                dicUsuariosPorGrupo = new Dictionary<int, List<string>>();
                dicPermisosPorGrupo = new Dictionary<int,Dictionary<int,List<int>>>();
                foreach (GRuPOs grp in grupos)
                {
                    int n = -10;
                    try
                    {
                        n = dgvGrupos.Rows.Add();
                        dgvGrupos.Rows[n].Cells["IdGrupo"].Value = grp.IDGrupo;
                        dgvGrupos.Rows[n].Cells["Nombre"].Value = grp.Nombre;
                        dgvGrupos.Rows[n].Cells["Descripcion"].Value = grp.Descripcion;
                        if (grp.Activo ==1)
                            dgvGrupos.Rows[n].Cells["Activo"].Value = "S";
                        else
                            dgvGrupos.Rows[n].Cells["Activo"].Value = "N";
                        listaUsuarios = new List<string>();
                        foreach (UsUarIoSGRuPOs ug in grp.UsUarIoSGRuPOs.ToList())
                        {
                            listaUsuarios.Add(ug.UsUarIoS.UserName);
                        }
                        dicUsuariosPorGrupo.Add(grp.IDGrupo, listaUsuarios);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Error Cargando los Grupos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (n >= 0)
                            try
                            {
                                dgvGrupos.Rows.RemoveAt(n);
                            }
                            catch (Exception ex1)
                            {
                                MessageBox.Show(this, ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                }

                List<string> usernames= datosabm.obtenerListaUserNames(true);
                checkListUsuarios.BeginUpdate();
                checkListUsuarios.DataSource = usernames;
                checkListUsuarios.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiarForm()
        {
            lblIdGrupo.Text = "";
            txtDescripcion.Text ="";
            txtNombre.Text="";
            checkListUsuarios.ClearSelected();
            while(checkListUsuarios.CheckedIndices.Count > 0)
                checkListUsuarios.SetItemChecked(checkListUsuarios.CheckedIndices[0], false);
            ucPermisosUsuarios1.checkItems(new Dictionary<int, List<int>>());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtDescripcion.Text != "")
                {
                    IEnumerator iter = checkListUsuarios.CheckedItems.GetEnumerator();
                    List<string> usuarios = new List<string>();
                    while(iter.MoveNext())
                    {
                        usuarios.Add(iter.Current.ToString());
                    }

                    Dictionary<int,List<int>> idPantallas_idControles = ucPermisosUsuarios1.obtenerPantallasYControlesSeleccionados();

                    int idgrupo = datosabm.altaGrupo(txtNombre.Text, txtDescripcion.Text, !cbEstado.Checked, usuarios, idPantallas_idControles);

                    int numFila = dgvGrupos.Rows.Add();
                    dgvGrupos.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                    dgvGrupos.Rows[numFila].Cells["Descripcion"].Value = txtDescripcion.Text;
                    dgvGrupos.Rows[numFila].Cells["Activo"].Value = cbEstado.Checked;
                    dicUsuariosPorGrupo.Add(idgrupo, usuarios);
                    dicPermisosPorGrupo.Add(idgrupo,idPantallas_idControles);

                    limpiarForm();

                }else
                    MessageBox.Show(this, "El nombre y la descripcion no pueden ser vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtDescripcion.Text != "")
                {
                    IEnumerator iter = checkListUsuarios.SelectedItems.GetEnumerator();
                    List<string> usuarios = new List<string>();
                    while (iter.MoveNext())
                    {
                        usuarios.Add(iter.Current.ToString());
                    }

                    Dictionary<int, List<int>> idPantallas_idControles = ucPermisosUsuarios1.obtenerPantallasYControlesSeleccionados();
                    int idgrupoTemp = int.Parse(lblIdGrupo.Text);
                    datosabm.modificarGrupo(idgrupoTemp, txtNombre.Text, txtDescripcion.Text, !cbEstado.Checked, usuarios, idPantallas_idControles);

                    dicPermisosPorGrupo[idgrupoTemp] = idPantallas_idControles;
                    dicUsuariosPorGrupo[idgrupoTemp] = usuarios;

                    limpiarForm();
                    btnAgregar.Enabled = true;
                    btnGuardar.Enabled = false;

                }
                else
                    MessageBox.Show(this, "El nombre y la descripcion no pueden ser vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGrupos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblIdGrupo.Text = dgvGrupos.Rows[e.RowIndex].Cells["IdGrupo"].Value.ToString();
                int idGrupoTemp = int.Parse(lblIdGrupo.Text);
                txtNombre.Text = dgvGrupos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvGrupos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                if (dgvGrupos.Rows[e.RowIndex].Cells["Activo"].Value.ToString() == "S")
                    cbEstado.Checked = false;
                else
                    cbEstado.Checked = true;

                foreach(string username in dicUsuariosPorGrupo[idGrupoTemp])
                {
                    checkListUsuarios.SetItemChecked(checkListUsuarios.Items.IndexOf(username),true);
                }

                if(dicPermisosPorGrupo.Keys.Contains(idGrupoTemp))
                    ucPermisosUsuarios1.checkItems(dicPermisosPorGrupo[idGrupoTemp]);

                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
