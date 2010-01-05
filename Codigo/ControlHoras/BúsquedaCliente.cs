using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;

namespace ControlHoras
{
    public partial class BúsquedaCliente : UserControl
    {
        Controlador controller;

        public BúsquedaCliente()
        {
            InitializeComponent();
            controller = Controlador.getControlador();
        }

        private void ClienteMT_Enter(object sender, EventArgs e)
        {
            ClienteMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
        }

        private void ClienteMT_Leave(object sender, EventArgs e)
        {
            ClienteMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
        }

        private void ClienteMT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ClienteMT.MaskCompleted)
            {
                Cliente cli = controller.obtenerCliente(int.Parse(ClienteMT.Text));
                ClienteTB.Text = cli.getNombre();
                SendKeys.Send("{TAB}");
            }
            if (e.KeyCode == Keys.F2)
            {
                // Abrir ventana de busqueda de clientes
            }
        }
        


    }
}
