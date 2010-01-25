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
    public partial class ListadoClientes : Form
    {
        private Controlador s = Controlador.getControlador();
          

        public ListadoClientes()
        {
            InitializeComponent();
            List<Cliente> lst;
            lst = new List<Cliente>(); //lst = s.obtenerListaClientes();
            foreach (Cliente l in lst)
            {
                ListViewItem item = lvClientes.Items.Add(l.getNumero().ToString());
                item.SubItems.Add(l.getNombre());                
            }
    
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                string id = lvClientes.SelectedItems[0].SubItems[0].Text;
                string nom = lvClientes.SelectedItems[0].SubItems[1].Text;
                string ape = lvClientes.SelectedItems[0].SubItems[2].Text;
                // Setear el cliente seleccionado en el Owner
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
