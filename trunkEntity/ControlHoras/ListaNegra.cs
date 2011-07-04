using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace ControlHoras
{
    public partial class ListaNegra : Form
    {
        public string Apellidos;
        public string Nombres;
        public string Motivo;
        public string FechaAlta;

        public ListaNegra()
        {
            InitializeComponent();
        }

        public ListaNegra(ListAnEGRa sujeto)
        {
            InitializeComponent();
            ciTB.Text = sujeto.CI;
            txtApellido.Text = Apellidos = sujeto.Apellidos;
            txtNombre.Text = Nombres = sujeto.Nombres;
            txtMotivoBaja.Text = Motivo = sujeto.MotivoRechazo;
            FechaAltaTB.Text = FechaAlta = sujeto.FechaAlta.Value.ToString(@"dd/MM/yyyy");                        
        }

        private void ListaNegra_Shown(object sender, EventArgs e)
        {
            CancelarBTN.Focus();
        }
    }
}
