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
        TimeSpan hora;
        public Prueba()
        {
            InitializeComponent();
            //hora = new TimeSpan();
            HTB.Text = "alamo \r\n perro";                        
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

        private void maskedTextBoxKeyDown1_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidarHTB(HoraTB.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(HoraTB, "No es una hora válida");
            }            
        }

        private bool ValidarHTB(string h)
        {
            DateTime dt;
            DateTimeStyles dts = new DateTimeStyles();
            return DateTime.TryParseExact(h, @"HH:mm", DateTimeFormatInfo.InvariantInfo, dts, out dt);            
        }

        private void HoraTB_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(HoraTB, "");
            hora = TimeSpan.Parse(HoraTB.Text);
            HTB.Text = hora.ToString().Substring(0,5);
        }

        private void difbtn_Click(object sender, EventArgs e)
        {            
            DateTime dti,dtf;
            TimeSpan res;
            
            dti = DateTime.ParseExact(horaini.Text, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dtf = DateTime.ParseExact(horafin.Text, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            res = dtf - dti;
                       
            result.Text = res.Hours.ToString() + ":" + res.Minutes.ToString();
            res2TB.Text = res.TotalHours.ToString();
            res3TB.Text = System.Math.Truncate(res.TotalHours).ToString();
        }      


    }
}
