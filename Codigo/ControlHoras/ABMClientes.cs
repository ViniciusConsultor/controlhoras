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
            txtRUT.Text = "";
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
                    n = dgvClientes.Rows.Add();
                    dgvClientes.Rows[n].Cells["NumCliente"].Value = cli.getNumero();
                    dgvClientes.Rows[n].Cells["Nombre"].Value = cli.getNombre();
                    dgvClientes.Rows[n].Cells["RUT"].Value = cli.getRUT();
                    dgvClientes.Rows[n].Cells["Telefono"].Value = cli.getTelefonos();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error Cargando los Clientes. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n >= 0)
                        try
                        {
                            dgvClientes.Rows.RemoveAt(n);
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
            if (txtNombre.Text != "" && txtRUT.Text != "" && mtTelefono.Text != "")
            {
                int n = -1;
                try
                {
                    //txtNumeroCliente.Text = sistema.altaCliente(txtNombre.Text, txtApellido.Text, mtTelefono.Text).ToString();
                    n = dgvClientes.Rows.Add();
                    dgvClientes.Rows[n].Cells["NumCliente"].Value = txtNumeroCliente.Text;
                    dgvClientes.Rows[n].Cells["Nombre"].Value = txtNombre.Text;
                    dgvClientes.Rows[n].Cells["RUT"].Value = txtRUT.Text;
                    dgvClientes.Rows[n].Cells["Telefono"].Value = mtTelefono.Text;

                    sistema.addCliente(int.Parse(txtNumeroCliente.Text), txtNombre.Text, null, txtRUT.Text, null, null, null, mtTelefono.Text, null);

                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        dgvClientes.Rows.RemoveAt(n);
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
            if (txtNombre.Text != "" && txtRUT.Text != "" && mtTelefono.Text != "")
            {
                try
                {
                    int numFila = 0;
                    while (dgvClientes.RowCount > numFila && txtNumeroCliente.Text != dgvClientes.Rows[numFila].Cells["NumCliente"].Value.ToString())
                    {
                        numFila++;
                    }
                    if (numFila != dgvClientes.RowCount)
                    {
                       // sistema.modificarCliente(int.Parse(txtNumeroCliente.Text), txtNombre.Text, txtApellido.Text, mtTelefono.Text);
                        dgvClientes.Rows[numFila].Cells["Nombre"].Value = txtNombre.Text;
                        dgvClientes.Rows[numFila].Cells["RUT"].Value = txtRUT.Text;
                        dgvClientes.Rows[numFila].Cells["Telefono"].Value = mtTelefono.Text;
                      
                        btnAgregar.Enabled = true;
                        btnGuardar.Enabled = false;
                        limpiarForm();
                    }
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

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }
                txtNumeroCliente.Text = dgvClientes.Rows[e.RowIndex].Cells["NumCliente"].Value.ToString();
                txtNombre.Text = dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtRUT.Text = dgvClientes.Rows[e.RowIndex].Cells["RUT"].Value.ToString();
                mtTelefono.Text = dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception ex)
            { }
        }      

       
    }
}
