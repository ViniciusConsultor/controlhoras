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
    public partial class ProgressBarShow : Form
    {

        public ProgressBarShow()
        {
            InitializeComponent();
        }

        public ProgressBarShow(int MinValue, int MaxValue)
        {
            InitializeComponent();
            progressBar.Minimum = MinValue;
            progressBar.Maximum = MaxValue;
        }

        public void aumentar()
        {
            if (progressBar.Value > progressBar.Maximum)
                throw new Exception("No se puede aumentar mas. Ya se llego al valor maximo.");
            progressBar.Increment(1);
            Application.DoEvents();
        }

    }
}
