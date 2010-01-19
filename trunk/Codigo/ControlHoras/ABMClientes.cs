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
    public partial class ABMClientes : Form
    {
        Controlador sistema = Controlador.getControlador();
        String LlenarCamposObligatorios = "Debe llenar todos los datos.";

        public ABMClientes()
        {
            InitializeComponent();
        }

        private void limpiarForm()
        {
            txtNumeroCliente.Text = "";
            txtNombre.Text = "";
            mtRUT.Text = mtRUT.Mask;
            mtTelefono.Text = "";
        }


        private void ABMClientes_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            List<Cliente> clientes = sistema.obtenerListaClientes();
            foreach (Cliente cli in clientes)
            {
                int n = -1;
                try
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando los Clientes. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n >= 0)
                        try
                        {
                        }
                        catch (Exception ex1)
                        {
                            MessageBox.Show(this, ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && mtRUT.Text != "" && mtTelefono.Text != "")
            {
                int n = -1;
                try
                {
                    sistema.addCliente(int.Parse(txtNumeroCliente.Text), txtNombre.Text, null, txtRUT.Text, null, null, null, mtTelefono.Text, null);

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && mtRUT.Text != "" && mtTelefono.Text != "")
            {
                try
                {                                   
                    sistema.modificarCliente(int.Parse(txtNumeroCliente.Text), txtNombre.Text, null, mtRUT.Text, null, null, null, mtTelefono.Text, null);                        
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            ServicioForm sf = new ServicioForm();
            sf.ShowDialog(this);
        }


    }
}
