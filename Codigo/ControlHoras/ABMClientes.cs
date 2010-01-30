using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;
using Excepciones;

namespace ControlHoras
{
    public partial class ABMClientes : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();
        Cliente cliente;
        String LlenarCamposObligatorios = "Debe llenar todos los campos obligatorios.";

        public ABMClientes()
        {
            InitializeComponent();
        }

        private void limpiarForm()
        {
            lblEstadoCliente.Text = "";
            cbNoActivo.Checked = false;
            txtMotivoBaja.Text = "";

            // Para los controles fuera del GroupBox, los recorro todos y si son tipo TextBox o MaskedTextBox los limpio.
            int iter = 0;
            string tipoDelControl;
            while (iter < this.Controls.Count)
            {
                tipoDelControl = this.Controls[iter].GetType().ToString();
                if (tipoDelControl == "ControlHoras.TextBoxKeyDown" || tipoDelControl == "ControlHoras.MaskedTextBoxKeyDown")
                    this.Controls[iter].Text = "";

                iter++;
            }
        }


        private void ABMClientes_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnServicios.Enabled = false;
            lblEstadoCliente.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Chequeo Campos Obligatorios
            if (checkDatosObligatorios())
            {
                bool checkActivo = true;
                DateTime dtpBaja = DateTime.MinValue.AddDays(1);
                if (cbNoActivo.Checked)
                {
                    checkActivo = false;
                    dtpBaja = dtpFechaBaja.Value;
                }

                try
                {
                    sistema.altaCliente(int.Parse(mtCliente.Text), txtNombre.Text, txtNombreFantasia.Text, mtRUT.Text,txtEmail.Text,txtDireccion.Text,txtDireccionCobro.Text,txtTelefonos.Text,txtFax.Text,checkActivo, dtpFechaAlta.Value ,dtpBaja, txtMotivoBaja.Text);

                    DialogResult res = MessageBox.Show(this, "Desea agregar servicios ahora?", "Servicios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.OK)
                    {
                        ServicioForm ser = new ServicioForm(mtCliente.Text);
                        ser.ShowDialog(this);
                    }
                    else
                        btnCancelar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkDatosObligatorios())
            {
                
                bool checkActivo = true;
                
                if (cbNoActivo.Checked)
                    checkActivo = false;
                
                try
                {
                    sistema.modificarCliente(int.Parse(mtCliente.Text), txtNombre.Text, txtNombreFantasia.Text, mtRUT.Text, txtEmail.Text, txtDireccion.Text, txtDireccionCobro.Text, txtTelefonos.Text, txtFax.Text, checkActivo, dtpFechaAlta.Value, dtpFechaBaja.Value, txtMotivoBaja.Text);
                    btnCancelar.PerformClick();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
       }

        private bool checkDatosObligatorios()
        {
            if (mtCliente.MaskCompleted && txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                if (!cbNoActivo.Checked || txtMotivoBaja.Text != "")
                    return true;
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            btnAgregar.Enabled = true;
            btnGuardar.Enabled = false;
            btnServicios.Enabled = false;
            lblEstadoCliente.Text = "";
            mtCliente.Focus();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            ServicioForm sf = new ServicioForm(mtCliente.Text);
            sf.ShowDialog(this);
        }

        private void cbNoActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoActivo.Checked)
            {
                dtpFechaBaja.Enabled = true;
                txtMotivoBaja.Enabled = true;
            }
            else
            {
                dtpFechaBaja.Enabled = false;
                txtMotivoBaja.Enabled = false;
            }
        }

        private void mtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (mtCliente.MaskCompleted && e.KeyCode == Keys.Enter)
            { // traigo el cliente y lleno los datos de los campos.
                try
                {
                    if (sistema.existeCliente(int.Parse(mtCliente.Text)))
                    {
                        cliente = sistema.obtenerCliente(int.Parse(mtCliente.Text));
                        cargarCliente(cliente);
                    }
                    else
                    {
                        string idcliente = mtCliente.Text;
                        btnCancelar.PerformClick();
                        mtCliente.Text = idcliente;
                        //SendKeys.Send("ENTER");
                    }

                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (e.KeyCode == Keys.F2)
                {
                    Search_Clientes sear = new Search_Clientes();
                    DialogResult res = sear.ShowDialog(this);

                    if (res == DialogResult.OK)
                    {
                        mtCliente.Text = sear.NumCliente;
                        mtCliente.Focus();
                        SendKeys.Send("{ENTER}");
                    }
                }
                else if (mtCliente.Text == "")
                {    // Obtengo el ultimo numero de cliente + 1;
                }
            }
            
        }


        private void cargarCliente(Cliente cli)
        {
            try
            {

                mtCliente.Text = cli.getNumero().ToString();
                txtNombre.Text = cli.getNombre();
                txtNombreFantasia.Text = cli.getNombreFantasia();
                mtRUT.Text = cli.getRUT();
                txtEmail.Text = cli.getEmail();
                txtDireccion.Text = cli.getDireccion();
                txtDireccionCobro.Text = cli.getDireccionCobro();
                txtTelefonos.Text = cli.getTelefonos();
                txtFax.Text = cli.getFax();
                dtpFechaAlta.Text = cli.getFechaAlta().ToShortDateString();
                if (!cli.getActivo())
                {
                    cbNoActivo.Checked = true;
                    dtpFechaBaja.Value = cli.getFechaBaja();
                    txtMotivoBaja.Text = cli.getMotivoBaja();
                }
                // Habilito Botones en la barra
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = true;
                btnServicios.Enabled = true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw ex;
            }

        }

    }
}
