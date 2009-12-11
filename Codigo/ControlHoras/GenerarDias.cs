using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dominio;

namespace ControlHoras
{
    public partial class GenerarDias : Form
    {
        private DataGridView dg;
        private Controlador ctr = null;
        private int cli;
        private int ser;

        public GenerarDias()
        {
            InitializeComponent();
            ctr = Controlador.getControlador();
            FechaINI.Focus();
        }

        public GenerarDias(int cli, int ser, DataGridView dgv)
        {
            InitializeComponent();
            ctr = Controlador.getControlador();
            FechaINI.Focus();

            this.cli = cli;
            this.ser = ser;

            dg = dgv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fi = DateTime.Parse(FechaINI.Text);
                DateTime ff = DateTime.Parse(FechaFIN.Text);
                //TimeSpan rest = ff - fi;
                int h = (ff - fi).Days;
                PruTXT.Text = h.ToString();


                int cantfila = dg.RowCount;
                Funcionario func;
                string hi;
                string hf;

                string pru;
                for (int x = 0; x < cantfila; x++)
                {
                    pru = dg.Rows[x].Cells[9].Value.ToString();

                    h = int.Parse(dg.Rows[x].Cells[9].Value.ToString());

                    func = ctr.obtenerFuncionario(h);

                    for (DateTime dt = fi; dt <= ff; dt = dt.AddDays(1))
                    {
                        hi = dg.Rows[x].Cells[h = convdias(dt.DayOfWeek)].Value.ToString();
                        if (hi != "N/T")
                        {
                            hf = dg.Rows[x + 1].Cells[h = convdias(dt.DayOfWeek)].Value.ToString();
                            func.agregarDiaPlanificacion(cli, ser, dt, hi, hf);
                        }

                    }

                    x++;
                    x++;
                }
                MessageBox.Show(this, "Las horas se generaron correctamente. Periodo " + FechaINI.Text + " - " + FechaFIN.Text, "Generacion de Horas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error Generando las horas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FechaINI_Enter(object sender, EventArgs e)
        {
            FechaINI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
        }

        private void FechaINI_Leave(object sender, EventArgs e)
        {
            FechaINI.BackColor = Color.White;
        }

        private void FechaINI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FechaINI.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (FechaINI.Text == "")
                {
                    FechaINI.Text = System.DateTime.Now.ToShortDateString();
                }
                FechaINI.TextMaskFormat = MaskFormat.IncludeLiterals;
                SendKeys.Send("{TAB}");
            }
        }

        private void FechaFIN_Enter(object sender, EventArgs e)
        {
            FechaFIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(170)))));
        }

        private void FechaFIN_Leave(object sender, EventArgs e)
        {

        }

        private void FechaFIN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FechaFIN.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                if (FechaFIN.Text == "")
                {
                    FechaFIN.Text = System.DateTime.Now.ToShortDateString();
                }
                FechaFIN.TextMaskFormat = MaskFormat.IncludeLiterals;
                SendKeys.Send("{TAB}");
            }
        }


        private int convdias(DayOfWeek day)
        {
            int i=0;
            switch (day)
            {
                case DayOfWeek.Monday:
                    i = 1;
                    break;
                case DayOfWeek.Tuesday:
                    i = 2;
                    break;
                case DayOfWeek.Wednesday:
                    i = 3;
                    break;
                case DayOfWeek.Thursday:
                    i = 4;
                    break;
                case DayOfWeek.Friday:
                    i = 5;
                    break;
                case DayOfWeek.Saturday:
                    i = 6;
                    break;
                case DayOfWeek.Sunday:
                    i = 7;
                    break;
            }
            return i;                              
            
        }



    }
}
