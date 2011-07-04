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
        private bool ChangeEntrada = false;
        private DateTime HoraEntradaActual;
        private DateTime HoraSalidaActual;
        private DateTime HoraNueva;
        private bool cerrar = false;

        public CambiarHoraFuncionario(int idFunc, string nomApell, string lblHoraIncioFin, DateTime horaEntradaActual,DateTime horaFinActual,bool cambiaEntrada)
        {
            InitializeComponent();
            ChangeEntrada = cambiaEntrada;
            HoraEntradaActual = horaEntradaActual;
            HoraSalidaActual = horaFinActual;
            lblHora.Text = lblHoraIncioFin;
            mtFuncionarioActual.Text = idFunc.ToString();
            txtNombreFuncionarioActual.Text = nomApell;
            if (ChangeEntrada)
                mtHoraActual.Text = HoraEntradaActual.ToString(@"dd/MM/yyyy HH:mm");
            else
                mtHoraActual.Text = horaFinActual.ToString(@"dd/MM/yyyy HH:mm");
            dtpFechaNueva.Value = DateTime.Parse(mtHoraActual.Text);
            btnAceptar.Enabled = false;
        }


        public DateTime getFechaHoraNueva()
        {

            return HoraNueva;
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
            }
            
        }

        private void mtHoraNueva_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtHoraNueva.MaskFull)
                {
                    int Horas = TimeSpan.Parse(mtHoraNueva.Text).Hours;
                    int Mins = TimeSpan.Parse(mtHoraNueva.Text).Minutes;
                    HoraNueva = new DateTime(dtpFechaNueva.Value.Year, dtpFechaNueva.Value.Month, dtpFechaNueva.Value.Day, Horas, Mins, 0);
                    if (ChangeEntrada && HoraNueva >= HoraSalidaActual)
                    {
                        throw new Exception("La Fecha/Hora de Entrada no puede ser mayor o igual a la Fecha/Hora de Salida.\nLa Fecha/Hora de Salida Actual es " + HoraSalidaActual.ToString("dd/MM/yyyy HH:mm"));
                    }
                    else if (ChangeEntrada && (HoraSalidaActual.Subtract(HoraNueva).Days > 1 || HoraSalidaActual.Subtract(HoraNueva).Days < 0))
                    {
                        throw new Exception("La diferencia de Fecha/Hora de Entrada con la Fecha/Hora de Salida no puede ser negativa o tener mas de un dia.\nLa Fecha/Hora de Salida Actual es " + HoraSalidaActual.ToString("dd/MM/yyyy HH:mm"));
                    }
                    else if (!ChangeEntrada && HoraNueva <= HoraEntradaActual)
                    {
                        throw new Exception("La Fecha/Hora de Salida no puede ser mayor o igual a la Fecha/Hora de Entrada.\nLa Fecha/Hora de Entrada Actual es " + HoraEntradaActual.ToString("dd/MM/yyyy HH:mm"));
                    }
                    else if (!ChangeEntrada && (HoraNueva.Subtract(HoraEntradaActual).Days > 1 || HoraNueva.Subtract(HoraEntradaActual).Days < 0))
                    {
                        throw new Exception("La diferencia de Fecha/Hora de Salida con la Fecha/Hora de Entrada no puede ser negativa o tener mas de un dia.\nLa Fecha/Hora de Entrada Actual es " + HoraEntradaActual.ToString("dd/MM/yyyy HH:mm"));
                    }

                    if (HoraNueva.Minute % 30 != 0)
                    {
                        throw new Exception("La Hora nueva debe ser con 0 o 30 minutos.");
                    }
                    cerrar = true;
                }
                else
                    MessageBox.Show(this, "Debe Ingresar la hora nueva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(this, exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CambiarHoraFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrar)
                e.Cancel = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cerrar = true;
        }

       

    }
}
