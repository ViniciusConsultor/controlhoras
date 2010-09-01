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
            if (!ValidarHTB(Hini1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Hini1, "No es una hora válida");
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
            errorProvider1.SetError(Hini1, "");
            hora = TimeSpan.Parse(Hini1.Text);
            HTB.Text = hora.ToString().Substring(0,5);
        }

        private void difbtn_Click(object sender, EventArgs e)
        {
            if (HorariosSolapados(Hini1.Text, Hfin1.Text, Hini2.Text, Hfin2.Text))
                result.Text = "SE CRUZAN";
            else
                result.Text = "NO SE CRUZAN";

        }

        private bool HorariosSolapados(string hi1, string hf1, string hi2, string hf2)
        {
            DateTime dti1, dtf1, dti2, dtf2;

            dti1 = DateTime.ParseExact(hi1, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dtf1 = DateTime.ParseExact(hf1, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dti2 = DateTime.ParseExact(hi2, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dtf2 = DateTime.ParseExact(hf2, @"HH:mm", DateTimeFormatInfo.InvariantInfo);

            if (dti2 < dtf1 && dtf2 > dti1)
                return true;
            else
                return false;
        }

        private void CalcDiff()
        {
            DateTime dti, dtf;
            TimeSpan res;

            dti = DateTime.ParseExact(Hini1.Text, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dtf = DateTime.ParseExact(Hfin1.Text, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            res = dtf - dti;

            result.Text = res.Hours.ToString() + ":" + res.Minutes.ToString();
            res2TB.Text = res.TotalHours.ToString();
            res3TB.Text = System.Math.Truncate(res.TotalHours).ToString();
        }      


    }
}
