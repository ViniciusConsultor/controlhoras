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
    public partial class Search_Clientes : Form
    {
        IClientesServicios sistema = ControladorClientesServicios.getInstance();
        public string NomCliente = "";
        public string NumCliente = "";

        public Search_Clientes()
        {
            InitializeComponent();           
        }

        private void NombreTB_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter && NombreTB.Text != "")
            {
                OKBTN.Enabled = false;
                ClientesDGV.Rows.Clear();
                List<Cliente> clies = sistema.buscarCliente(NombreTB.Text);
                 
                foreach (Cliente c in clies)
                {                
                    ClientesDGV.Rows.Add(new object[] { c.getNombre(), c.getNumero().ToString(), "OK" } );
                }               

               
            }
        }

        private void ClientesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OKBTN.Enabled = true;
            NomCliente = ClientesDGV.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            NumCliente = ClientesDGV.Rows[e.RowIndex].Cells["Nro"].Value.ToString();
        }

        
    }
}
