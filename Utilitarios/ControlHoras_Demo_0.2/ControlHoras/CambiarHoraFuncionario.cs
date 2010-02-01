﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlHoras
{
    public partial class CambiarHoraFuncionario : Form
    {
        public CambiarHoraFuncionario(int idFunc, string nomApell, string lblHoraInioFin, string HoraActual )
        {
            InitializeComponent();
            mtFuncionarioActual.Text = idFunc.ToString();
            txtNombreFuncionarioActual.Text = nomApell;
            mtHoraActual.Text = HoraActual;
            btnAceptar.Enabled = false;
        }


        public string getHoraNueva()
        {
            return mtHoraNueva.Text;
        }


        private void mtHoraNueva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && mtHoraNueva.Text != "")
            {
                    btnAceptar.Enabled = true;
            }
        }

       

    }
}
