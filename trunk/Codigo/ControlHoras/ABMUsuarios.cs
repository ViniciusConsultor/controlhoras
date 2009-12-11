using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;

namespace ControlHoras
{
    public partial class ABMUsuarios : Form
    {
        private Controlador sistema = Controlador.getControlador();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";

        public ABMUsuarios()
        {
            InitializeComponent();
        }

        private void ABMUsuarios_Load(object sender, EventArgs e)
        {
            cmbGrupos.SelectedIndex=0;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnCambiarPassword.Enabled = false;

            List<Funcionario> usuarios = sistema.obtenerListaFuncionarios();
            foreach (Funcionario usu in usuarios)
            {
                int n = -10;
                try
                {
                    n = dgvUsuarios.Rows.Add();
                    dgvUsuarios.Rows[n].Cells["idUsuario"].Value = usu.getNumero();
                    dgvUsuarios.Rows[n].Cells["Usuario"].Value = usu.getNombre().Substring(0,1)+usu.getApellido();
                    dgvUsuarios.Rows[n].Cells["Nombre"].Value = usu.getNombre();
                    dgvUsuarios.Rows[n].Cells["Apellido"].Value = usu.getApellido();
                    dgvUsuarios.Rows[n].Cells["Rol"].Value = "";
                    dgvUsuarios.Rows[n].Cells["Nacimiento"].Value = usu.getDireccion();
                    dgvUsuarios.Rows[n].Cells["Contraseña"].Value = usu.getCI();
                    dgvUsuarios.Rows[n].Cells["Activo"].Value = "1";
                    
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

        private void limpiarForm()
        {
            mtNacimiento.Text = "";
            mtNombre.Text = "";
            mtApellido.Text = "";
            mtUsuario.Text = "";
            mtContraseña.Text = "";
            cmbGrupos.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (mtNombre.Text != "" && mtApellido.Text != "" && mtNacimiento.Text != "__/__/____" && mtUsuario.Text != "" && mtContraseña.Text != "")
            {
                int n = -10;
                try
                {
                    char estado;
                    if (cbEstado.Checked)
                        estado = 'N';
                    else
                        estado = 'S';
                    //lblidUsuario.Text = sistema.altaUsuario(mtUsuario.Text.Trim(), mtContraseña.Text.Trim(), mtNombre.Text.Trim(), mtApellido.Text.Trim(), mtNacimiento.Value, cmbGrupos.SelectedItem.ToString().Trim(), estado).ToString();
                    n = dgvUsuarios.Rows.Add();
                    dgvUsuarios.Rows[n].Cells["idUsuario"].Value = lblidUsuario.Text;
                    dgvUsuarios.Rows[n].Cells["Usuario"].Value = mtUsuario.Text;
                    dgvUsuarios.Rows[n].Cells["Nombre"].Value = mtNombre.Text;
                    dgvUsuarios.Rows[n].Cells["Apellido"].Value = mtApellido.Text;
                    dgvUsuarios.Rows[n].Cells["Rol"].Value = cmbGrupos.SelectedItem.ToString();
                    dgvUsuarios.Rows[n].Cells["Nacimiento"].Value = mtNacimiento.Text;
                    dgvUsuarios.Rows[n].Cells["Contraseña"].Value = mtContraseña.Text;
                    dgvUsuarios.Rows[n].Cells["Activo"].Value = estado.ToString();

                    

                    limpiarForm();
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
                MessageBox.Show(this, LlenarCamposObligatorios, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }


        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            lblidUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString();
            mtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            mtApellido.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            mtNacimiento.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nacimiento"].Value.ToString();
            cmbGrupos.SelectedItem = dgvUsuarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString().Trim();
            mtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
            mtContraseña.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
            if (dgvUsuarios.Rows[e.RowIndex].Cells["Activo"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;


            mtContraseña.ReadOnly = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnCambiarPassword.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (mtNombre.Text != "" && mtApellido.Text != "" && mtNacimiento.Text != "__/__/____" && mtUsuario.Text != "" && mtContraseña.Text != "")
            {
                try
                {
                    int numFila = 0;
                    while ( dgvUsuarios.RowCount > numFila && lblidUsuario.Text != dgvUsuarios.Rows[numFila].Cells["idUsuario"].Value.ToString())
                    {
                        numFila++;
                    }    
                    if ( numFila != dgvUsuarios.RowCount )
                    {
                        char estado;
                        if (cbEstado.Checked)
                            estado = 'N';
                        else
                            estado = 'S';
                        //sistema.modificarUsuario(int.Parse(lblidUsuario.Text.Trim()), mtUsuario.Text.Trim(), mtContraseña.Text.Trim(), mtNombre.Text.Trim(), mtApellido.Text.Trim(), mtNacimiento.Value, cmbGrupos.SelectedText.Trim(), estado);
                            
                        dgvUsuarios.Rows[numFila].Cells["Nombre"].Value = mtNombre.Text;
                        dgvUsuarios.Rows[numFila].Cells["Apellido"].Value = mtApellido.Text;
                        dgvUsuarios.Rows[numFila].Cells["Rol"].Value = cmbGrupos.SelectedItem.ToString();
                        dgvUsuarios.Rows[numFila].Cells["Nacimiento"].Value = mtNacimiento.Text;
                        dgvUsuarios.Rows[numFila].Cells["Contraseña"].Value = mtContraseña.Text;
                        dgvUsuarios.Rows[numFila].Cells["Activo"].Value = estado.ToString();
                        
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = false;
                        btnCambiarPassword.Enabled = false;
                        limpiarForm();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {

            try
            {


                CambiarPasswordUsuario cpu = new CambiarPasswordUsuario(int.Parse(lblidUsuario.Text));
                cpu.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



     
    }
}
