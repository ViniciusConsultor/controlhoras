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
        bool modoNuevo;
        int ind;
        int cant;
        int[] numerosSer;

        Servicio serActual;

        public ServicioForm()
        {
            InitializeComponent();
            bcUC.cliPronto += new EventHandler(bcUC_cliPronto);

            modoNuevo = false;
            ind = 0;
            cant = 0;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            modoNuevo = true;
            LimpiarPlanilla();

            GCambiosBTN.Enabled = false;
            GNuevoBTN.Enabled = true;
        }

        private void LimpiarPlanilla()
        {
            //ClienteGB.Enabled = true;
            ServicioGB.Enabled = true;

            AnteriorBTN.Visible = false;
            PosteriorBTN.Visible = false;

            NroMTB.Text = "";
            NombreTB.Text = "";
            DirTB.Text = "";
            TelTB.Text = "";
            ContactTB.Text = "";
            emailTB.Text = "";
            CelTB.Text = "";
            CelTrustTB.Text = "";
            TareasTB.Text = "";

            NroMTB.ReadOnly = false;
            NombreTB.ReadOnly = false;
            DirTB.ReadOnly = false;
            TelTB.ReadOnly = false;
            ContactTB.ReadOnly = false;
            emailTB.ReadOnly = false;
            CelTB.ReadOnly = false;
            CelTrustTB.ReadOnly = false;
            TareasTB.ReadOnly = false;           

            //bcUC.Controls["ClienteMT"].Focus();
            NroMTB.Focus();
        }       

        private void ModoVer() // POR AHORA AL DOPE
        {
            ServicioGB.Enabled = false;            
            
            ClienteGB.Enabled = true;

            NroMTB.ReadOnly = true;
            NombreTB.ReadOnly = true;
            DirTB.ReadOnly = true;
            TelTB.ReadOnly = true;
            ContactTB.ReadOnly = true;
            emailTB.ReadOnly = true;
            CelTB.ReadOnly = true;
            CelTrustTB.ReadOnly = true;
            TareasTB.ReadOnly = true;

            bcUC.Controls["ClienteMT"].Focus();
        }

        private void bcUC_cliPronto(object sender, EventArgs e)
        {
            GCambiosBTN.Enabled = false;
            int numCli = int.Parse(bcUC.ClienteNRO);
            Cliente cli = sistema.obtenerCliente(numCli);
            List<Servicio> servicios = cli.getListaServicios();
            if (servicios.Count != 0)
            {
                ServicioGB.Enabled = true;
                GCambiosBTN.Enabled = true;
                

                cant = servicios.Count;
                numerosSer = new int[cant];
                int i = 0;
                foreach (Servicio ser in servicios)
                {
                    numerosSer[i] = ser.getNumero();
                    i++;
                }

                llenarForm(numCli, numerosSer[ind]);

                if (cant > 1)
                {
                    AnteriorBTN.Visible = true;
                    PosteriorBTN.Visible = true;
                    NroMTB.Focus();
                    NroMTB.SelectAll();
                }
            }
        }

        private void llenarForm(int numCli, int numSer)
        {
            Servicio ser = sistema.obtenerServicioCliente(numCli, numSer);
            serActual = ser;

            NroMTB.Text = ser.getNumero().ToString();
            NombreTB.Text = ser.getNombre();
            DirTB.Text = ser.getDireccion();
            TelTB.Text = ser.getTelefonos();
            ContactTB.Text = ser.getContacto();
            emailTB.Text = ser.getemail();
            CelTB.Text = ser.getCelular();
            CelTrustTB.Text = ser.getCelularTrust();
            TareasTB.Text = ser.getTareasAsignadas();
        }

        private void AnteriorBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(bcUC.ClienteNRO);
            if ((ind - 1) < 0)
                ind = cant - 1;
            else
                ind = ind - 1;

            llenarForm(numCli, numerosSer[ind]);
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {
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
            if (e.KeyCode == Keys.Enter)
            {
                if (!modoNuevo)
                    llenarForm(int.Parse(bcUC.ClienteNRO), int.Parse(NroMTB.Text));
                else
                    SendKeys.Send("{TAB}");
            }
        }

        private void GNuevoBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(bcUC.ClienteNRO);
            int numSer = int.Parse(NroMTB.Text);
            sistema.altaServicioCliente(numCli, numSer, NombreTB.Text, DirTB.Text, TelTB.Text, ContactTB.Text, emailTB.Text, CelTB.Text, CelTrustTB.Text, TareasTB.Text);

            modoNuevo = false;
            GNuevoBTN.Enabled = false;
            GCambiosBTN.Enabled = true;
            
            bcUC.Controls["ClienteMT"].Focus();
            SendKeys.Send("{ENTER}");

        }

        private void GCambiosBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(bcUC.ClienteNRO);
            int numSer = int.Parse(NroMTB.Text);
            sistema.modificarServicioCliente(numCli, numSer, NombreTB.Text, DirTB.Text, TelTB.Text, ContactTB.Text, emailTB.Text, CelTB.Text, CelTrustTB.Text, TareasTB.Text);

            /*
            serActual.setNombre(NombreTB.Text);
            serActual.setDireccion(DirTB.Text);
            serActual.setTelefonos(TelTB.Text);
            serActual.setContacto(ContactTB.Text);
            serActual.setemail(emailTB.Text);
            serActual.setCelular(CelTB.Text);
            serActual.setCelularTrust(CelTrustTB.Text);
            serActual.setTareasAsignadas(TareasTB.Text);*/
        }


       
    }

}
