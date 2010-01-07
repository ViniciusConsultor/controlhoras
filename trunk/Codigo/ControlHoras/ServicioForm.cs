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
    public partial class ServicioForm : Form
    {
        Controlador sistema = Controlador.getControlador();
        bool modoVer;
        int ind;
        int cant;
        int[] numerosSer;

        public ServicioForm()
        {
            InitializeComponent();
            bcUC.cliPronto += new EventHandler(bcUC_cliPronto);

            modoVer = false;
            ind = 0;
            cant = 0;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            modoVer = false;
            ModoNuevo();            
        }

        private void ModoNuevo()
        {
            ClienteGB.Enabled = true;
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

            GuardarBTN.Visible = true;

            bcUC.Controls["ClienteMT"].Focus();
        }

        private void GuardarBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(bcUC.Controls["ClienteMT"].Text);
            int numSer = int.Parse(NroMTB.Text);
            sistema.addServicio(numCli, numSer, NombreTB.Text, DirTB.Text, TelTB.Text, ContactTB.Text, emailTB.Text, CelTB.Text, CelTrustTB.Text, TareasTB.Text);
        }

        private void VerBTN_Click(object sender, EventArgs e)
        {
            modoVer = true;            
            ModoVer();           
        }

        private void ModoVer()
        {
            ServicioGB.Enabled = false;
            GuardarBTN.Visible = false;
            
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
            if (modoVer)
            {
                int numCli = int.Parse(bcUC.Controls["ClienteMT"].Text);
                Cliente cli = sistema.obtenerCliente(numCli);
                List<Servicio> servicios = cli.getListaServicios();
                if (servicios.Count != 0)
                {
                    ServicioGB.Enabled = true;

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
        }

        private void AnteriorBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(bcUC.Controls["ClienteMT"].Text);
            if ((ind - 1) < 0)
                ind = cant - 1;
            else
                ind = ind - 1;

            llenarForm(numCli, numerosSer[ind]);
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {
            int numCli = int.Parse(bcUC.Controls["ClienteMT"].Text);
            ind = (ind + 1) % cant;

            llenarForm(numCli, numerosSer[ind]);
        }
    }

}
