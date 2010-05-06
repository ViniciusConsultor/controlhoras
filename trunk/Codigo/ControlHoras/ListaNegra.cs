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
        public ListaNegra()
        {
            InitializeComponent();
        }

        public ListaNegra(ListAnEGRa sujeto)
        {
            InitializeComponent();
            ciTB.Text = sujeto.CI;
            txtApellido.Text = sujeto.Apellidos;
            txtNombre.Text = sujeto.Nombres;
            txtMotivoBaja.Text = sujeto.MotivoRechazo;
        }
    }
}
