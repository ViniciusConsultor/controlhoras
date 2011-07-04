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
    public partial class ABMUsuarios : Form
    {
        private IDatosABMTipos datos = DatosABMTipos.getInstance();
        String LlenarCamposObligatorios = "Debe llenar todos los campos obligatorios.";

        public ABMUsuarios()
        {
            InitializeComponent();
        }

        private void ABMUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnCambiarPassword.Enabled = false;
                btnPermisos.Enabled = false;

                List<UsUarIoS> usuarios = datos.obtenerListaUsuarios(false);
                foreach (UsUarIoS usu in usuarios)
                {
                    int n = -10;
                    try
                    {
                        n = dgvUsuarios.Rows.Add();
                        dgvUsuarios.Rows[n].Cells["idUsuario"].Value = usu.IDUsuario;
                        dgvUsuarios.Rows[n].Cells["Usuario"].Value = usu.UserName;
                        dgvUsuarios.Rows[n].Cells["Nombre"].Value = usu.Nombre;
                        dgvUsuarios.Rows[n].Cells["Apellido"].Value = usu.Apellido;
                        dgvUsuarios.Rows[n].Cells["FechaCreacion"].Value = usu.FechaCreacion.ToShortDateString();
                        dgvUsuarios.Rows[n].Cells["Activo"].Value = usu.Activo;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Error Cargando los Usuarios. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (n >= 0)
                            try
                            {
                                dgvUsuarios.Rows.RemoveAt(n);
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
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarForm()
        {
            mtFecha.Text = "";
            mtNombre.Text = "";
            mtApellido.Text = "";
            mtUsuario.Text = "";
            mtContraseña.Text = "";
            cbEstado.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (mtNombre.Text != "" && mtApellido.Text != "" && /*mtFecha.Text != "__/__/____" &&*/ mtUsuario.Text != "" && mtContraseña.Text != "")
            {
                DateTime FechaCreacion = DateTime.Now;
                int n = -10;
                try
                {
                    lblidUsuario.Text = datos.altaUsuario(mtUsuario.Text.Trim(), mtContraseña.Text.Trim(), mtNombre.Text.Trim(), mtApellido.Text.Trim(), FechaCreacion, !cbEstado.Checked).ToString();
                    n = dgvUsuarios.Rows.Add();
                    dgvUsuarios.Rows[n].Cells["idUsuario"].Value = lblidUsuario.Text;
                    dgvUsuarios.Rows[n].Cells["Usuario"].Value = mtUsuario.Text;
                    dgvUsuarios.Rows[n].Cells["Nombre"].Value = mtNombre.Text;
                    dgvUsuarios.Rows[n].Cells["Apellido"].Value = mtApellido.Text;
                    dgvUsuarios.Rows[n].Cells["FechaCreacion"].Value = FechaCreacion;
                    if (cbEstado.Checked)
                        dgvUsuarios.Rows[n].Cells["Activo"].Value = 'N';
                    else
                        dgvUsuarios.Rows[n].Cells["Activo"].Value = 'S';

                    btnCancelar.PerformClick();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n >= 0)
                        try
                        {
                            dgvUsuarios.Rows.RemoveAt(n);
                        }
                        catch (Exception ex2)
                        {
                            MessageBox.Show(this, ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Error Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (mtNombre.Text != "" && mtApellido.Text != "" && mtFecha.Text != "__/__/____" && mtUsuario.Text != "")
            {
                 DateTime FechaCreacion;
                 if (DateTime.TryParse(mtFecha.Text, out FechaCreacion))
                 {
                     try
                     {
                         int numFila = 0;
                         while (dgvUsuarios.RowCount > numFila && lblidUsuario.Text != dgvUsuarios.Rows[numFila].Cells["idUsuario"].Value.ToString())
                         {
                             numFila++;
                         }
                         if (numFila != dgvUsuarios.RowCount)
                         {

                             datos.modificarUsuario(int.Parse(lblidUsuario.Text), mtUsuario.Text.Trim(), mtNombre.Text.Trim(), mtApellido.Text.Trim(), !cbEstado.Checked);

                             dgvUsuarios.Rows[numFila].Cells["Nombre"].Value = mtNombre.Text;
                             dgvUsuarios.Rows[numFila].Cells["Apellido"].Value = mtApellido.Text;
                             dgvUsuarios.Rows[numFila].Cells["Usuario"].Value = mtUsuario.Text;
                             if (cbEstado.Checked)
                                 dgvUsuarios.Rows[numFila].Cells["Activo"].Value = 'N';
                             else
                                 dgvUsuarios.Rows[numFila].Cells["Activo"].Value = 'S';

                             btnCancelar.PerformClick();
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
                 else
                     MessageBox.Show(this, "Formato de Fecha Incorrecto", "Error Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnCambiarPassword.Enabled = false;
            mtContraseña.Enabled = true;
            btnPermisos.Enabled = false;
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {

            try
            {
                CambiarPasswordUsuario cpu = new CambiarPasswordUsuario(int.Parse(lblidUsuario.Text));
                cpu.StartPosition = FormStartPosition.CenterParent;
                cpu.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                lblidUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString();
                mtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                mtApellido.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                mtFecha.Text = dgvUsuarios.Rows[e.RowIndex].Cells["FechaCreacion"].Value.ToString();
                mtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
                //mtContraseña.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
                if (dgvUsuarios.Rows[e.RowIndex].Cells["Activo"].Value.ToString() == "N")
                    cbEstado.Checked = true;
                else
                    cbEstado.Checked = false;


                mtContraseña.Enabled = false;
                mtFecha.ReadOnly = true;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnPermisos.Enabled = true;
                btnCambiarPassword.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            try
            {
                ABMGrupos grupos = new ABMGrupos();
                grupos.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            try
            {
                PermisosUsuario perms = new PermisosUsuario(mtUsuario.Text);
                perms.StartPosition = FormStartPosition.CenterParent;
                perms.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



     
    }
}
