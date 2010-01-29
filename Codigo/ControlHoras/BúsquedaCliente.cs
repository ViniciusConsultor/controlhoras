using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace ControlHoras
{
    public partial class BúsquedaCliente : UserControl
    {
        //Controlador controller;
        IClientesServicios sistema;// = ControladorClientesServicios.getInstance();

       


        public event EventHandler cliPronto;

        public string ClienteNRO
        {
            get
            {
                return ClienteMT.Text;
            }

            set
            {
                ClienteMT.Text = value;
            }
        }
        
        

 

        public BúsquedaCliente()
        {
            InitializeComponent();
            //controller = Controlador.getControlador();
            sistema = ControladorClientesServicios.getInstance();
        }

        private void ClienteMT_Enter(object sender, EventArgs e)
        {
            ClienteMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
        }

        private void ClienteMT_Leave(object sender, EventArgs e)
        {
            ClienteMT.BackColor = Color.White;
        }

        private void ClienteMT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ClienteMT.MaskCompleted)
            {
                Cliente cli = sistema.obtenerCliente(int.Parse(ClienteMT.Text));
                ClienteTB.Text = cli.getNombre();
                //SendKeys.Send("{TAB}");

                cliPronto(sender, e); //Acá disparamos el evento para que sea atrapado por el WinForm que contiente este CONTROL DE USUARIO
            }
            else
                if (e.KeyCode == Keys.F2)
                {
                    Search_Clientes sear = new Search_Clientes();
                    DialogResult res = sear.ShowDialog(this);

                    if (res == DialogResult.OK)
                    {
                        ClienteMT.Text = sear.NumCliente;
                        ClienteMT.Focus();
                        SendKeys.Send("{ENTER}");
                    }
                }
        }
        


    }
}
