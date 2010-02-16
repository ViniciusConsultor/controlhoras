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

        protected void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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



            if (!ValidarTB(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "No es una fecha válida");
            }            
        }

        private bool ValidarTB(string fecha)
        {
            DateTime dt;
            DateTimeStyles dts = new DateTimeStyles();

            return DateTime.TryParseExact(fecha, @"dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo, dts, out dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prueba p = new Prueba();
            p.Show();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        


    }
}
