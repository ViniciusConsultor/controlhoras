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

        public CambiarHoraFuncionario(int idFunc, string nomApell, string lblHoraInioFin, DateTime horaEntradaActual,DateTime horaFinActual,bool cambiaEntrada)
        {
            InitializeComponent();
            ChangeEntrada = cambiaEntrada;
            HoraEntradaActual = horaEntradaActual;
            HoraSalidaActual = horaFinActual;
            lblHora.Text = lblHoraInioFin;
            mtFuncionarioActual.Text = idFunc.ToString();
            txtNombreFuncionarioActual.Text = nomApell;
            if (ChangeEntrada)
                mtHoraActual.Text = HoraEntradaActual.ToString();
            else
                mtHoraActual.Text = horaFinActual.ToString();
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
                        if (ChangeEntrada && (HoraSalidaActual.Subtract(HoraNueva).Days > 1 ||HoraSalidaActual.Subtract(HoraNueva).Days < 0))
                        {
                            throw new Exception("La diferencia de Fecha/Hora de Entrada con la Fecha/Hora de Salida no puede ser negativa o tener mas de un dia.\nLa Fecha/Hora de Salida Actual es "+HoraSalidaActual.ToString("dd/MM/yyyy HH:mm"));
                        }
                        if (!ChangeEntrada && HoraNueva <= HoraEntradaActual)
                        {
                            throw new Exception("La Fecha/Hora de Salida no puede ser mayor o igual a la Fecha/Hora de Entrada.\nLa Fecha/Hora de Entrada Actual es "+HoraEntradaActual.ToString("dd/MM/yyyy HH:mm"));
                        }
                        if (!ChangeEntrada && (HoraNueva.Subtract(HoraEntradaActual).Days > 1 ||HoraNueva.Subtract(HoraEntradaActual).Days < 0))
                        {
                            throw new Exception("La diferencia de Fecha/Hora de Salida con la Fecha/Hora de Entrada no puede ser negativa o tener mas de un dia.\nLa Fecha/Hora de Entrada Actual es "+HoraEntradaActual.ToString("dd/MM/yyyy HH:mm"));
                        }
                        btnAceptar.Enabled = true;
                        SendKeys.Send("{TAB}");
                    }
                    else
                        MessageBox.Show(this, "Debe Ingresar la hora nueva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(this, exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void mtHoraNueva_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       

    }
}
