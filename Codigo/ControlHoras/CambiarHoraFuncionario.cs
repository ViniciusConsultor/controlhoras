using System;
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
            if (e.KeyCode == Keys.Enter)
            {
                if (mtHoraNueva.MaskFull)
                {
                    btnAceptar.Enabled = true;
                    SendKeys.Send("{TAB}");
                }
                else
                    MessageBox.Show(this, "Debe Ingresar la hora nueva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void mtHoraNueva_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       

    }
}
