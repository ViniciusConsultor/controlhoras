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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>(); // sistema.obtenerListaClientes();
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
    }
}
