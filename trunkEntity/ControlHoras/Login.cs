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
    public partial class Login : Form
    {
        private IDatos datos = null;
        int reintentos = 0;
        public string username = "";
        public int idUsuarioLogueado = -1;
        
        public Login()
        {
            InitializeComponent();
            try
            {
                datos = ControladorDatos.getInstance();
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    username = "";
                    UsUarIoS user= datos.login(txtUsuario.Text, txtPassword.Text);
                    idUsuarioLogueado = user.IDUsuario; 
                    username = txtUsuario.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Usuario o Password incorrectos.", "Error de Autenticación", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                    reintentos++;
                    if (reintentos > 3)
                    {
                        //sistema.agregarLog("Error de Autenticación. Usuario " + txtUsuario);
                    }

                    txtPassword.Text = "";
                    txtPassword.Focus();
                }

            }
            catch (Exception ex)
            {
                txtPassword.Text = "";
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (username == "" && e.CloseReason == CloseReason.None)
                e.Cancel = true;
        }
       
    }
}
