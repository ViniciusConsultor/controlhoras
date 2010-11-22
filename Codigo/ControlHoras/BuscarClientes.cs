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
    public partial class BuscarClientes : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();
        public string NomCliente = "";
        public string NumCliente = "";
        public string NomFantasia = "";

        public BuscarClientes()
        {
            InitializeComponent();           
        }

        private void NombreTB_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter && NombreTB.Text != "")
            {
                OKBTN.Enabled = false;
                btnBuscar.PerformClick();
                 
                               
            }
        }

        private void ClientesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OKBTN.Enabled = true;
            NomCliente = ClientesDGV.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            NumCliente = ClientesDGV.Rows[e.RowIndex].Cells["Nro"].Value.ToString();
            NomFantasia = ClientesDGV.Rows[e.RowIndex].Cells["NombreFantasia"].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClientesDGV.Rows.Clear();
            try
            {
                List<Cliente> clies = sistema.buscarCliente(NombreTB.Text);
                foreach (Cliente c in clies)
                {
                    ClientesDGV.Rows.Add(new object[] { c.getNumero().ToString(),c.getNombre(),c.getNombreFantasia(), "OK" });
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClientesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OKBTN.PerformClick();
        }

        
    }
}
