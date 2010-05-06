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
    public partial class ABMLNegra : Form
    {        
        static ABMLNegra ventana = null;
        
        String LlenarCamposObligatorios = "Debe llenar todos los campos obligatorios";
        private IDatos datos;


        private ABMLNegra()
        {
            InitializeComponent();

            try
            {
                datos = ControladorDatos.getInstance();
            }
            catch (Exception ex1)
            {
                
                throw ex1;
            }

            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;            
        }

        public static ABMLNegra getVentana()
        {
            if (ventana == null)
                ventana = new ABMLNegra();
            return ventana;
        }

        private void limpiarForm()
        {
            ciTB.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtMotivoBaja.Text = "";
            ciTB.Focus();
        }

        private void ABMLNegra_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;             
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ciTB.Text != "" && txtMotivoBaja.Text != "")
            {
                try
                {   
                    // Modifica el valor en la base de datos
                    datos.modificarListaNegra(ciTB.Text, txtApellido.Text, txtNombre.Text, txtMotivoBaja.Text);

                    btnAgregar.Enabled = true;
                    btnGuardar.Enabled = false;
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ciTB.Text != "" && txtMotivoBaja.Text != "")
            {
                try
                {
                    // Doy de alta en la base de datos
                    datos.altaListaNegra(ciTB.Text, txtApellido.Text, txtNombre.Text, txtMotivoBaja.Text);

                    limpiarForm();
                }
                catch (Exception ex)
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
            btnGuardar.Enabled = false;
            ciTB.Focus();
        }        

        private void ABMLNegra_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        private void ciTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (ciTB.MaskCompleted && (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab))
            {
                // Busco si existe un empleado con esta cédula
                ListAnEGRa sujeto;
                try
                {
                    if (datos.existeEmpleadoListaNegra(ciTB.Text, out sujeto))
                    {
                        //empleado = datos.obtenerEmpleado(int.Parse(mtNumeroEmpleado.Text));
                        if (sujeto.Activo == 1)
                        {
                            btnAgregar.Enabled = false;
                            btnGuardar.Enabled = true;

                            txtApellido.Text = sujeto.Apellidos;
                            txtNombre.Text = sujeto.Nombres;
                            txtMotivoBaja.Text = sujeto.MotivoRechazo;
                        }                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre.Text = TranfaTitulo(txtNombre.Text);
        }

        private string TranfaTitulo(string ori)
        {
            if (ori.Length > 1)
            {
                string dest = ori.Trim();
                int esp = dest.LastIndexOf(" ");
                string aux = (esp + 2 < dest.Length) ? dest.Substring(esp + 2).ToLower() : "?";
                if (esp == -1)
                    return dest.Substring(0, 1).ToUpper() + dest.Substring(1).ToLower();
                else
                    return dest.Substring(0, 1).ToUpper() + dest.Substring(1, esp).ToLower() + dest.Substring(esp + 1, 1).ToUpper() + aux;
            }
            else
                return ori;
        }
        
    }
}
