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
    public partial class ABMFuncionarios : Form
    {
        private Controlador sistema = Controlador.getControlador();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";

        public ABMFuncionarios()
        {
            InitializeComponent();
        }

        private void ABMUsuarios_Load(object sender, EventArgs e)
        {
            cmbGrupos.SelectedIndex=0;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
         

            List<Funcionario> usuarios = sistema.obtenerListaFuncionarios();
            foreach (Funcionario usu in usuarios)
            {
                int n = -10;
                try
                {
                    n = dgvFuncionarios.Rows.Add();
                    dgvFuncionarios.Rows[n].Cells["idUsuario"].Value = usu.getNumero();
                    dgvFuncionarios.Rows[n].Cells["Usuario"].Value = usu.getNombre().Substring(0,1)+usu.getApellido();
                    dgvFuncionarios.Rows[n].Cells["Nombre"].Value = usu.getNombre();
                    dgvFuncionarios.Rows[n].Cells["Apellido"].Value = usu.getApellido();
                    dgvFuncionarios.Rows[n].Cells["Rol"].Value = "";
                    dgvFuncionarios.Rows[n].Cells["Nacimiento"].Value = usu.getDireccion();
                    dgvFuncionarios.Rows[n].Cells["Contraseña"].Value = usu.getCI();
                    dgvFuncionarios.Rows[n].Cells["Activo"].Value = "1";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando los Usuarios. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n >= 0)
                        try
                        {
                            dgvFuncionarios.Rows.RemoveAt(n);
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
        //    mtUsuario.Text = "";
        //    mtContraseña.Text = "";
            cmbGrupos.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (mtNombre.Text != "" && mtApellido.Text != "" && mtNacimiento.Text != "__/__/____")
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
                    n = dgvFuncionarios.Rows.Add();
                    dgvFuncionarios.Rows[n].Cells["idUsuario"].Value = lblidUsuario.Text;
                    //dgvFuncionarios.Rows[n].Cells["Usuario"].Value = mtUsuario.Text;
                    dgvFuncionarios.Rows[n].Cells["Nombre"].Value = mtNombre.Text;
                    dgvFuncionarios.Rows[n].Cells["Apellido"].Value = mtApellido.Text;
                    dgvFuncionarios.Rows[n].Cells["Rol"].Value = cmbGrupos.SelectedItem.ToString();
                    dgvFuncionarios.Rows[n].Cells["Nacimiento"].Value = mtNacimiento.Text;
                    //dgvFuncionarios.Rows[n].Cells["Contraseña"].Value = mtContraseña.Text;
                    dgvFuncionarios.Rows[n].Cells["Activo"].Value = estado.ToString();

                    

                    limpiarForm();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n >= 0)
                        try
                        {
                            dgvFuncionarios.Rows.RemoveAt(n);
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
            lblidUsuario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString();
            mtNombre.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            mtApellido.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            mtNacimiento.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Nacimiento"].Value.ToString();
            cmbGrupos.SelectedItem = dgvFuncionarios.Rows[e.RowIndex].Cells["Rol"].Value.ToString().Trim();
     //       mtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
     //       mtContraseña.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
            if (dgvFuncionarios.Rows[e.RowIndex].Cells["Activo"].Value.ToString() == "N")
                cbEstado.Checked = true;
            else
                cbEstado.Checked = false;


           // mtContraseña.ReadOnly = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
           // btnCambiarPassword.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (mtNombre.Text != "" && mtApellido.Text != "" && mtNacimiento.Text != "__/__/____" )
            {
                try
                {
                    int numFila = 0;
                    while ( dgvFuncionarios.RowCount > numFila && lblidUsuario.Text != dgvFuncionarios.Rows[numFila].Cells["idUsuario"].Value.ToString())
                    {
                        numFila++;
                    }    
                    if ( numFila != dgvFuncionarios.RowCount )
                    {
                        char estado;
                        if (cbEstado.Checked)
                            estado = 'N';
                        else
                            estado = 'S';
                        //sistema.modificarUsuario(int.Parse(lblidUsuario.Text.Trim()), mtUsuario.Text.Trim(), mtContraseña.Text.Trim(), mtNombre.Text.Trim(), mtApellido.Text.Trim(), mtNacimiento.Value, cmbGrupos.SelectedText.Trim(), estado);
                            
                        dgvFuncionarios.Rows[numFila].Cells["Nombre"].Value = mtNombre.Text;
                        dgvFuncionarios.Rows[numFila].Cells["Apellido"].Value = mtApellido.Text;
                        dgvFuncionarios.Rows[numFila].Cells["Rol"].Value = cmbGrupos.SelectedItem.ToString();
                        dgvFuncionarios.Rows[numFila].Cells["Nacimiento"].Value = mtNacimiento.Text;
     //                   dgvUsuarios.Rows[numFila].Cells["Contraseña"].Value = mtContraseña.Text;
                        dgvFuncionarios.Rows[numFila].Cells["Activo"].Value = estado.ToString();
                        
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = false;
               //         btnCambiarPassword.Enabled = false;
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
           // btnCambiarPassword.Enabled = false;
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
