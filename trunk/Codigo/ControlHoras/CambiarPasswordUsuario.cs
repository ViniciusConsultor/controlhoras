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
    public partial class CambiarPasswordUsuario : Form
    {
        Controlador sistema = null;
        int iduser = 0;
        
        public CambiarPasswordUsuario(int idusuario)
        {
            InitializeComponent();
            sistema = Controlador.getControlador();
            iduser = idusuario;
        }

        private void CambiarPasswordUsuario_Load(object sender, EventArgs e)
        {
            if (this.Owner.Name == "Ventana Principal")
            {
                lblPassActual.Visible = true;
                txtPassActual.Visible = true;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == txtPasswordConfirm.Text)
                    if (txtPassActual.Visible)
                    {
                        //sistema.login(((VentanaPrincipal)this.Owner).getUsuarioLogueado(), txtPassActual.Text);
                    }
                    else
                    {
                        //sistema.cambiarPasswordUsuario(iduser, txtPassword.Text);
                        MessageBox.Show("Password cambiada con exito.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                else
                    MessageBox.Show(this, "La password nueva no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
