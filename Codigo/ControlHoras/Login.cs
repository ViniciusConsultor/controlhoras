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
    public partial class Login : Form
    {
        private Controlador sistema = null;
        int reintentos = 0;
        string username = "";   
        
        public Login()
        {
            InitializeComponent();
            sistema = Controlador.getControlador();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    username = txtUsuario.Text;
                    VentanaPrincipal vp = new VentanaPrincipal();//txtUsuario.Text,this);
                    vp.Show();
                    this.Visible = false;
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
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
