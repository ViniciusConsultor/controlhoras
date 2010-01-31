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
    public partial class ContratoForm : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();

        int idser;
        int ind;
        int cant;
        int[] numerosSer;        

        public ContratoForm()
        {
            InitializeComponent();
                       
            InicializarCargaHorariaDGV();            
            CostoCB.SelectedIndex = 0;
            bcUC.cliPronto += new EventHandler(bcUC_cliPronto);
            idser = -1;
        }

        public ContratoForm(string idCliente, string idServicio)
        {
            InitializeComponent();

            InicializarCargaHorariaDGV();
            CostoCB.SelectedIndex = 0;
            ind = 0;
            cant = 0;
            bcUC.cliPronto += new EventHandler(bcUC_cliPronto);

            bcUC.ClienteNRO = idCliente;
            idser = int.Parse(idServicio);
        }

        private void InicializarCargaHorariaDGV()
        {
            MaskedTextBoxColumn mtbc;

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Lunes";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Martes";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Miercoles";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Jueves";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Viernes";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Sabado";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);

            mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Domingo";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 86;
            //mtbc.ReadOnly = false;
            //mtbc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.CargaHorariaDGV.Columns.Add(mtbc);
        }

        private void CostoCB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CostoCB.SelectedItem.ToString() == "fijo")
                MontoTB.ReadOnly = false;
            else
                MontoTB.ReadOnly = true;
        }

        private void FinCKB_CheckedChanged(object sender, EventArgs e)
        {
            if (FinCKB.Checked)
                FfinDTP.Enabled = true;
            else
                FfinDTP.Enabled = false;
        }

        private void bcUC_cliPronto(object sender, EventArgs e)
        {            
            AnteriorBTN.Visible = false;
            PosteriorBTN.Visible = false;
            //LimpiarPlanilla();
            ServicioGB.Enabled = false;

            ind = 0;

            if (bcUC.find)
            {
                ServicioGB.Enabled = true;
                //NroMTB.Focus();

                int numCli = int.Parse(bcUC.ClienteNRO);
                Cliente cli = sistema.obtenerCliente(numCli);
                List<Servicio> servicios = cli.getListaServicios();
                if (servicios.Count != 0)
                {
                    //NombreTB.Text = servicios[0].getNombre();
                    
                    cant = servicios.Count;
                    numerosSer = new int[cant];                    
                    int i = 0;
                    foreach (Servicio ser in servicios)
                    {
                        numerosSer[i] = ser.getNumero();
                        if (ser.getNumero() == idser)
                            ind = i;

                        i++;
                    }
                                        
                    
                    llenarForm(numCli, numerosSer[ind]);

                    
                    //NroMTB.Focus();
                    //NroMTB.SelectAll();

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
        }

        private void AnteriorBTN_Click(object sender, EventArgs e)
        {            
            int numCli = int.Parse(bcUC.ClienteNRO);
            if ((ind - 1) < 0)
                ind = cant - 1;
            else
                ind = ind - 1;

            //NombreTB.Text = nombresSer[ind];
            llenarForm(numCli, numerosSer[ind]);
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {    
            int numCli = int.Parse(bcUC.ClienteNRO);
            ind = (ind + 1) % cant;

            //NombreTB.Text = nombresSer[ind];
            llenarForm(numCli, numerosSer[ind]);
        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            //LimpiarPlanilla();

            bcUC.Controls["ClienteMT"].Focus();
            SendKeys.Send("{ENTER}");
        }

        private void ContratoForm_Shown(object sender, EventArgs e)
        {
            if (bcUC.Controls["ClienteMT"].Text != "")
            {
                bcUC.Controls["ClienteMT"].Focus();
                SendKeys.Send("{ENTER}");
            }
        }    
       
              
    }
}
