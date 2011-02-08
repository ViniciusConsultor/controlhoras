using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Datos;

namespace ControlHoras
{
    public partial class CambiarPasswordUsuario : Form
    {
        IDatos datos = null;
        int iduser = 0;
        bool forceChange = true;
        
        public CambiarPasswordUsuario(int idusuario)
        {
            InitializeComponent();
            datos = ControladorDatos.getInstance();
            iduser = idusuario;
        }

        private void CambiarPasswordUsuario_Load(object sender, EventArgs e)
        {
            if (this.Owner.Name == "VentanaPrincipal")
            {
                lblPassActual.Visible = true;
                txtPassActual.Visible = true;
                forceChange = false;
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
                if (txtPassword.Text != "")
                {
                    if (txtPassword.Text == txtPasswordConfirm.Text)
                    {
                        datos.cambiarPasswordUsuario(iduser, txtPassword.Text, txtPassActual.Text, forceChange);
                        MessageBox.Show("Password cambiada con exito.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show(this, "La password nueva no coincide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else
                    MessageBox.Show(this, "La password no puede quedar en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
