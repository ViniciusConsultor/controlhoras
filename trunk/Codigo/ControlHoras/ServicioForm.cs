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
    public partial class ServicioForm : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();        
        int ind;
        int cant;
        int[] numerosSer;
        String LlenarCamposObligatorios = "Debe llenar todos los campos obligatorios.";
                

        public ServicioForm()
        {
            InitializeComponent();
            bcUC.cliPronto += new EventHandler(bcUC_cliPronto);

            ind = 0;
            cant = 0;
        }

        public ServicioForm(string nroCliente)
        {
            InitializeComponent();
            bcUC.cliPronto += new EventHandler(bcUC_cliPronto);

            ind = 0;
            cant = 0;

            bcUC.ClienteNRO = nroCliente;
            CancelarBTN.PerformClick();
        }
                

        private void LimpiarPlanilla()
        {
        
            NroMTB.Text = "";
            NombreTB.Text = "";
            DirTB.Text = "";
            TelTB.Text = "";
            ContactTB.Text = "";
            emailTB.Text = "";
            CelTB.Text = "";
            CelTrustTB.Text = "";
            TareasTB.Text = "";
            
            NroMTB.Focus();
        }       

        
        private void bcUC_cliPronto(object sender, EventArgs e)
        {
            AgregarBTN.Enabled = false;
            GuardarBTN.Enabled = false;
            ContratoBTN.Enabled = false;

            AnteriorBTN.Visible = false;
            PosteriorBTN.Visible = false;
            LimpiarPlanilla();
            ServicioGB.Enabled = false;

            ind = 0;

            if (bcUC.find)
            {
                ServicioGB.Enabled = true;
                NroMTB.Focus();

                int numCli = int.Parse(bcUC.ClienteNRO);
                Cliente cli = sistema.obtenerCliente(numCli);
                List<Servicio> servicios = cli.getListaServicios();
                if (servicios.Count != 0)
                {
                    ContratoBTN.Enabled = true;

                    cant = servicios.Count;
                    numerosSer = new int[cant];
                    int i = 0;
                    foreach (Servicio ser in servicios)
                    {
                        numerosSer[i] = ser.getNumero();
                        i++;
                    }

                    llenarForm(numCli, numerosSer[ind]);

                    AgregarBTN.Enabled = false;
                    GuardarBTN.Enabled = true;

                    NroMTB.Focus();
                    NroMTB.SelectAll();

                    if (cant > 1)
                    {
                        AnteriorBTN.Visible = true;
                        PosteriorBTN.Visible = true;
                    }
                }
            }            
        }

        private void llenarForm(int numCli, int numSer)
        {
            Servicio ser = sistema.obtenerServicioCliente(numCli, numSer);
            
            NroMTB.Text = ser.getNumero().ToString();
            NombreTB.Text = ser.getNombre();
            DirTB.Text = ser.getDireccion();
            TelTB.Text = ser.getTelefonos();
            ContactTB.Text = ser.getContacto();
            emailTB.Text = ser.getemail();
            CelTB.Text = ser.getCelular();
            CelTrustTB.Text = ser.getCelularTrust();
            TareasTB.Text = ser.getTareasAsignadas();

            NroMTB.Focus();
            NroMTB.SelectAll();
        }

        private void AnteriorBTN_Click(object sender, EventArgs e)
        {
            AgregarBTN.Enabled = false;
            GuardarBTN.Enabled = true;

            int numCli = int.Parse(bcUC.ClienteNRO);
            if ((ind - 1) < 0)
                ind = cant - 1;
            else
                ind = ind - 1;

            llenarForm(numCli, numerosSer[ind]);
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {
            AgregarBTN.Enabled = false;
            GuardarBTN.Enabled = true;

            int numCli = int.Parse(bcUC.ClienteNRO);
            ind = (ind + 1) % cant;

            llenarForm(numCli, numerosSer[ind]);
        }

        private void NroMTB_Enter(object sender, EventArgs e)
        {
            NroMTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
        }

        private void NroMTB_Leave(object sender, EventArgs e)
        {
            NroMTB.BackColor = Color.White;
        }

        private void NroMTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && NroMTB.Text != "")
            { // traigo el servicio y lleno los datos de los campos.
                try
                {
                    if (sistema.existeClienteServicio(int.Parse(bcUC.ClienteNRO), int.Parse(NroMTB.Text)))
                    {
                        llenarForm(int.Parse(bcUC.ClienteNRO), int.Parse(NroMTB.Text));
                        NroMTB.Focus();
                        NroMTB.SelectAll();
                        ContratoBTN.Enabled = true;
                    }
                    else
                    {
                        ContratoBTN.Enabled = false;
                        string idservicio = NroMTB.Text;
                        LimpiarPlanilla();
                        AgregarBTN.Enabled = true;
                        GuardarBTN.Enabled = false;
                        NroMTB.Text = idservicio;
                        SendKeys.Send("{TAB}");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (NroMTB.Text == "")
            {    // Obtengo el ultimo numero de cliente + 1;
            }
        }               

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            // Chequeo Campos Obligatorios
            if (checkDatosObligatorios())
            {
                try
                {
                    int numCli = int.Parse(bcUC.ClienteNRO);
                    int numSer = int.Parse(NroMTB.Text);
                    sistema.altaServicioCliente(numCli, numSer, NombreTB.Text, DirTB.Text, TelTB.Text, ContactTB.Text, emailTB.Text, CelTB.Text, CelTrustTB.Text, TareasTB.Text);


                    DialogResult res = MessageBox.Show(this, "Desea definir el contrato ahora?", "Contrato", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.OK)
                    {
                        ContratoForm contrato = new ContratoForm(bcUC.ClienteNRO, NroMTB.Text);
                        contrato.ShowDialog(this);
                    }
                    else
                        CancelarBTN.PerformClick();
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
            if (NroMTB.Text != "" && NombreTB.Text != "")
                return true;
            else
                return false;
        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            LimpiarPlanilla();
            AgregarBTN.Enabled = true;
            GuardarBTN.Enabled = false;

            bcUC.Controls["ClienteMT"].Focus();
            SendKeys.Send("{ENTER}");
        }

        private void GuardarBTN_Click(object sender, EventArgs e)
        {
            if (checkDatosObligatorios())
            {
                try
                {
                    int numCli = int.Parse(bcUC.ClienteNRO);
                    int numSer = int.Parse(NroMTB.Text);
                    sistema.modificarServicioCliente(numCli, numSer, NombreTB.Text, DirTB.Text, TelTB.Text, ContactTB.Text, emailTB.Text, CelTB.Text, CelTrustTB.Text, TareasTB.Text);

                    CancelarBTN.PerformClick();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show(this, LlenarCamposObligatorios, "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        }

        private void ContratoBTN_Click(object sender, EventArgs e)
        {
            ContratoForm contrato = new ContratoForm(bcUC.ClienteNRO, NroMTB.Text);
            contrato.ShowDialog(this);
        
        }

       
    }

}
