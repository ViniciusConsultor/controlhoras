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
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
           // bc.Controls["ClienteTB"].Text = "Alamo";


            MaskedTextBoxColumn mtbc = new MaskedTextBoxColumn();
            mtbc.HeaderText = "Lunes";
            mtbc.Mask = @"00:00   \a   00:00";
            mtbc.Width = 120;
            mtbc.ReadOnly = false;
            this.dgv.Columns.Add(mtbc);
        }
    }
}
