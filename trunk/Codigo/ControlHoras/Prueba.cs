using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace ControlHoras
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
          

                                    
        }

        protected void textBox1_Validating(object sender,
   System.ComponentModel.CancelEventArgs e)
        {
            /*try
            {              
                int x = Int32.Parse(textBox1.Text);
                errorProvider1.SetError(textBox1, "");
            }
            catch (Exception ex)
            {               
                errorProvider1.SetError(textBox1, "Not an integer value.");
            }*/

            DateTime dt;
            DateTimeStyles dts = new DateTimeStyles();

            if (DateTime.TryParseExact(textBox1.Text, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo, dts, out dt))
                errorProvider1.SetError(textBox1, "");
            else
                errorProvider1.SetError(textBox1, "No es una fecha");

        }

        


    }
}
