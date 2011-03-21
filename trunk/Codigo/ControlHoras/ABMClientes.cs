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
//using Excepciones;
using System.Globalization;

namespace ControlHoras
{
    public partial class ABMClientes : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();
        Cliente cliente;
        private IDatos datos;

        private string fechaMask = @"  /  /";
        String LlenarCamposObligatorios = "Debe llenar todos los campos obligatorios.";
        static ABMClientes ventana = null;
        public static ABMClientes getVentana()
        {
            if (ventana == null)
                ventana = new ABMClientes();
            return ventana;
        }


        private ABMClientes()
        {
            InitializeComponent();

            try
            {
                datos = ControladorDatos.getInstance();
            }
            catch (Exception ex)
            { 
                
                throw ex;
            }
        }

        private void limpiarForm()
        {
            txtTelefonoCobro.Text = "";
            txtReferencia.Text = "";
            txtNombreParaCobrar.Text = "";
            txtDiaHoraCobro.Text = "";
            txtDireccionCobro.Text = "";
            lblEstadoCliente.Text = "";
            cbNoActivo.Checked = false;
            txtMotivoBaja.Text = "";
            mtDiaFinFacturacion.Text = "";
            mtDiaInicioFacturacion.Text = "";
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
            //dtpFechaAlta.Text = DateTime.Now.ToString();
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
                DateTime? dtpAlta;
                DateTime? dtpBaja = null; //= DateTime.MinValue.AddDays(1);

                if (dtpFechaAlta.Text == fechaMask)
                    dtpAlta = null;
                else
                    dtpAlta = DateTime.ParseExact(dtpFechaAlta.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (cbNoActivo.Checked)
                {
                    checkActivo = false;                    
                    if (dtpFechaBaja.Text == fechaMask)
                        dtpBaja = null;
                    else
                        dtpBaja = DateTime.ParseExact(dtpFechaBaja.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                }

                try
                {
                    if (mtDiaInicioFacturacion.Text == "")
                        mtDiaInicioFacturacion.Text = "1";
                    if (mtDiaFinFacturacion.Text == "")
                        mtDiaFinFacturacion.Text = "31";
                    int diaInicio = int.Parse(mtDiaInicioFacturacion.Text);
                    int diaFin = int.Parse(mtDiaFinFacturacion.Text);
                    if (diaInicio > 31 || diaInicio < 1)
                        MessageBox.Show(this, "Dia Inicio de Facturacion debe ser entre 1 y 31", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (diaFin > 31 || diaInicio < 1)
                        MessageBox.Show(this, "Dia Fin de Facturacion debe ser entre 1 y 31", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        sistema.altaCliente(int.Parse(mtCliente.Text), txtNombre.Text, txtNombreFantasia.Text, mtRUT.Text, txtEmail.Text, txtDireccion.Text, txtDireccionCobro.Text, txtTelefonos.Text, txtFax.Text, checkActivo, dtpAlta, dtpBaja, txtMotivoBaja.Text, txtReferencia.Text, txtDiaHoraCobro.Text, txtNombreParaCobrar.Text, txtTelefonoCobro.Text, diaInicio, diaFin);

                        DialogResult res = MessageBox.Show(this, "Desea agregar servicios ahora?", "Servicios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.OK)
                        {
                            ServicioForm ser = new ServicioForm(mtCliente.Text);
                            ser.ShowDialog(this);
                        }
                        else
                            btnCancelar.PerformClick();
                    }
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
                DateTime? dtpAlta;
                DateTime? dtpBaja = null;

                if (dtpFechaAlta.Text == fechaMask)
                    dtpAlta = null;
                else
                    dtpAlta = DateTime.ParseExact(dtpFechaAlta.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

                if (cbNoActivo.Checked)
                {
                    checkActivo = false;
                    if (dtpFechaBaja.Text == fechaMask)
                        dtpBaja = null;
                    else
                        dtpBaja = DateTime.ParseExact(dtpFechaBaja.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
                }
                
                try
                {
                    sistema.modificarCliente(int.Parse(mtCliente.Text), txtNombre.Text, txtNombreFantasia.Text, mtRUT.Text, txtEmail.Text, txtDireccion.Text, txtDireccionCobro.Text, txtTelefonos.Text, txtFax.Text, checkActivo, dtpAlta, dtpBaja, txtMotivoBaja.Text, txtReferencia.Text, txtDiaHoraCobro.Text, txtNombreParaCobrar.Text, txtTelefonoCobro.Text, int.Parse(mtDiaInicioFacturacion.Text), int.Parse(mtDiaFinFacturacion.Text));
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
            if (mtCliente.Text != "" && txtNombre.Text != "" && txtTelefonos.Text != "")
            {
                if (!cbNoActivo.Checked || txtMotivoBaja.Text != "")
                    return true;
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarForm();
            dtpFechaAlta.Text = DateTime.Now.ToString();
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
                dtpFechaBaja.Text = DateTime.Today.ToString(); ;
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
            if (mtCliente.Text != "" && e.KeyCode == Keys.Enter)
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
                    btnBuscarCliente.PerformClick();
                }
                else if (mtCliente.Text == "" && e.KeyCode == Keys.Enter)
                {    // Obtengo el ultimo numero de cliente + 1;
                    mtCliente.Text = (datos.obtenerMaxIdCliente() + 1).ToString();
                    
                    string idcliente = mtCliente.Text;
                    btnCancelar.PerformClick();
                    mtCliente.Text = idcliente;
                    
                    btnAgregar.Enabled = true;
                    btnGuardar.Enabled = false;
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
                txtReferencia.Text = cli.getReferencia();
                txtTelefonoCobro.Text = cli.getTelefonosCobro();
                txtNombreParaCobrar.Text = cli.getContactoCobro();
                txtDiaHoraCobro.Text = cli.getDiaHoraCobro();
                txtTelefonos.Text = cli.getTelefonos();
                txtFax.Text = cli.getFax();
                dtpFechaAlta.Text = cli.getFechaAlta().ToString();
                mtDiaInicioFacturacion.Text = cli.getDiaInicioFacturacion().ToString();
                mtDiaFinFacturacion.Text = cli.getDiaFinFacturacion().ToString();
                if (!cli.getActivo())
                {
                    cbNoActivo.Checked = true;
                    dtpFechaBaja.Text = cli.getFechaBaja().ToString();
                    txtMotivoBaja.Text = cli.getMotivoBaja();
                    lblEstadoCliente.ForeColor = Color.Red;
                    lblEstadoCliente.Text = "Inactivo";
                }
                else
                {
                    cbNoActivo.Checked = false;
                    dtpFechaBaja.Text = "";
                    txtMotivoBaja.Text = "";
                    lblEstadoCliente.ForeColor = Color.LimeGreen;
                    lblEstadoCliente.Text = "Activo";
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

        private void ABMClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventana = null;
        }

        private bool ValidarFecha(string fecha)
        {
            DateTime dt;
            DateTimeStyles dts = new DateTimeStyles();

            if (fecha == fechaMask)
                return true;
            else
                return DateTime.TryParseExact(fecha, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo, dts, out dt);
        }

        private void dtpFechaAlta_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaAlta.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaAlta, "No es una fecha válida");
            }
        }

        private void dtpFechaAlta_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaAlta, "");
        }

        private void dtpFechaBaja_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarFecha(dtpFechaBaja.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpFechaBaja, "No es una fecha válida");
            }
        }

        private void dtpFechaBaja_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtpFechaBaja, "");
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientes sear = new BuscarClientes();
            DialogResult res = sear.ShowDialog(this);

            if (res == DialogResult.OK)
            {
                mtCliente.Text = sear.NumCliente;
                mtCliente.Focus();
                SendKeys.Send("{ENTER}");
            }
        }
      
    }
}
