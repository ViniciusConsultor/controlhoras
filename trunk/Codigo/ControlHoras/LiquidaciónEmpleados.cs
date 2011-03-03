using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace ControlHoras
{
    public partial class LiquidaciónEmpleados : Form
    {
        IDatos datos;
        DataTable empleados;
        List<DateTime> feriados;
        int cant, ind;

        public LiquidaciónEmpleados()
        {
            InitializeComponent();

            try
            {
                datos = ControladorDatos.getInstance();
                feriados = datos.ObtenerFeriados();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MesDTP.CustomFormat = @"MMMM/yyyy";
            MesDTP.Format = DateTimePickerFormat.Custom;
            MesDTP.Value = DateTime.Now.AddMonths(-1);
        }

        private void LiquidarBTN_Click(object sender, EventArgs e)
        {            
            DateTime inicio, fin, aux;
            
            inicio = new DateTime(MesDTP.Value.Year, MesDTP.Value.Month, 1);
            aux = new DateTime(MesDTP.Value.Year, MesDTP.Value.AddMonths(1).Month, 1);
            fin = aux.AddDays(-1);

            try
            {
                datos.LiquidarEmpleados(inicio, fin);
                datos.empleadosLiquidados(out empleados);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al efectuar la liquidación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
            cant = empleados.Rows.Count;
            if (cant == 0)
                MessageBox.Show("No existen horas registradas para: " + MesDTP.Value.ToString(@"MMMM/yyyy"), "No hay datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (cant > 1)
                {
                    AnteriorBTN.Visible = true;
                    PosteriorBTN.Visible = true;
                }
                ind = 0;
                CargarEmpleado();
            }
        }

        private void CargarEmpleado()
        {
            int nroEmp, numf, sep = 0;
            TimeSpan hc, he;
            DateTime auxdt = DateTime.Today;
            DateTime aux2;

            LiquidacionDGV.Rows.Clear();
            
            nroEmp = int.Parse(empleados.Rows[ind].ItemArray[0].ToString());

            try
            {
                EmPleadOs emp = datos.obtenerEmpleado(nroEmp);
                TipOscarGoS tc = datos.obtenerCargo((int)emp.IDCargo);

                EmpleadoLBL.Text = emp.NroEmpleado.ToString() + " - " + emp.Apellido + ", " + emp.Nombre;
                CargoLBL.Text = tc.Nombre;

                bool cobraextra = (tc.CobraHsExtras == 1);

                Dictionary<DateTime, TimeSpan> liq = datos.LiquidarunEmpleado(nroEmp);
                Dictionary<DateTime, TimeSpan>.Enumerator iter = liq.GetEnumerator();

                while (iter.MoveNext())
                {
                    numf = LiquidacionDGV.Rows.Add();
                    aux2 = new DateTime(2000, iter.Current.Key.Month, iter.Current.Key.Day);
                    if (feriados.Contains(aux2))
                        sep = 2;
                    else
                        sep = 0;
                    //sep = (feriados.Contains(iter.Current.Key))?2:0;
                    CalcularHsExtras(cobraextra, (int)tc.CantidadHsComunes, iter.Current.Value, out hc, out he);
                    LiquidacionDGV.Rows[numf].Cells[0].Value = iter.Current.Key.Day.ToString();
                    LiquidacionDGV.Rows[numf].Cells[1 + sep].Value = (auxdt + hc).ToString("HH:mm");
                    LiquidacionDGV.Rows[numf].Cells[2 + sep].Value = (auxdt + he).ToString("HH:mm");
                }

                CalcularTotales();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void CalcularTotales()
        {
            TimeSpan hsc, hsex, hsfe, hsfeex;
            hsc = hsex = hsfe = hsfeex = new TimeSpan(0);
            for (int i = 0; i < LiquidacionDGV.Rows.Count; i++)
            {
                hsc = hsc + new TimeSpan(int.Parse((LiquidacionDGV.Rows[i].Cells[1].Value ?? "00:00").ToString().Split(':').ElementAt(0)), int.Parse((LiquidacionDGV.Rows[i].Cells[1].Value ?? "00:00").ToString().Split(':').ElementAt(1)), 0);
                hsex = hsex + new TimeSpan(int.Parse((LiquidacionDGV.Rows[i].Cells[2].Value ?? "00:00").ToString().Split(':').ElementAt(0)), int.Parse((LiquidacionDGV.Rows[i].Cells[2].Value ?? "00:00").ToString().Split(':').ElementAt(1)), 0);
                hsfe = hsfe + new TimeSpan(int.Parse((LiquidacionDGV.Rows[i].Cells[3].Value??"00:00").ToString().Split(':').ElementAt(0)), int.Parse((LiquidacionDGV.Rows[i].Cells[3].Value??"00:00").ToString().Split(':').ElementAt(1)), 0);
                hsfeex = hsfeex + new TimeSpan(int.Parse((LiquidacionDGV.Rows[i].Cells[4].Value ?? "00:00").ToString().Split(':').ElementAt(0)), int.Parse((LiquidacionDGV.Rows[i].Cells[4].Value ?? "00:00").ToString().Split(':').ElementAt(1)), 0);                
            }
            
            HsComunesTB.Text = impHora(hsc);
            HsExtraTB.Text = impHora(hsex);
            HsFeriadoTB.Text = impHora(hsfe);
            HsFerExtTB.Text = impHora(hsfeex);
        }


        

        private void CalcularHsExtras(bool cobraextras, int cantHscomun, TimeSpan HsTotal, out TimeSpan HsComun, out TimeSpan HsExtras)
        {
            HsComun = HsTotal;
            HsExtras = new TimeSpan(0);
            TimeSpan aux = new TimeSpan(cantHscomun,0,0);
            if (cobraextras && HsTotal > aux)
            {
                HsComun = aux;
                HsExtras = HsTotal - aux;
            }
        }

        private void AnteriorBTN_Click(object sender, EventArgs e)
        {
            if ((ind - 1) < 0)
                ind = cant - 1;
            else
                ind = ind - 1;
            CargarEmpleado();
        }

        private void PosteriorBTN_Click(object sender, EventArgs e)
        {
            ind = (ind + 1) % cant;
            CargarEmpleado();
        }


        private string impHora(TimeSpan h)
        {
            return System.Math.Abs(System.Math.Truncate(h.TotalHours)).ToString() + ":" + System.Math.Abs(h.Minutes).ToString();
        }
        
    }
}
