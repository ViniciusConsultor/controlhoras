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
        DataTable empleados, liq;
        int cant, ind;

        public LiquidaciónEmpleados()
        {
            InitializeComponent();

            try
            {
                datos = ControladorDatos.getInstance();
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
            int nroEmp;
            DateTime inicio, fin, aux;
            
            inicio = new DateTime(MesDTP.Value.Year, MesDTP.Value.Month, 1);
            aux = new DateTime(MesDTP.Value.Year, MesDTP.Value.AddMonths(1).Month, 1);
            fin = aux.AddDays(-1);

            datos.LiquidarEmpleados(inicio, fin);

            ind = 0;
            datos.empleadosLiquidados(out empleados);

            nroEmp = int.Parse(empleados.Rows[ind].ItemArray[0].ToString());

            EmPleadOs emp = datos.obtenerEmpleado(nroEmp);

            EmpleadoLBL.Text = emp.NroEmpleado.ToString() + " - " + emp.Apellido + ", " + emp.Nombre;

            TipOscarGoS tc = datos.obtenerCargo((int)emp.IDCargo);
            bool cobraextra = (tc.CobraHsExtras == 1);
            CargoLBL.Text = tc.Nombre;

            List<DateTime> feriados = datos.ObtenerFeriados();

            TimeSpan hc, he;
            DateTime auxdt = DateTime.Today;
            int numf, sep=0;
            Dictionary<DateTime, TimeSpan> liq = datos.LiquidarunEmpleado(nroEmp);
            Dictionary<DateTime, TimeSpan>.Enumerator iter = liq.GetEnumerator();

            while (iter.MoveNext())
            {
                numf = LiquidacionDGV.Rows.Add();
                if (feriados.Contains(iter.Current.Key))
                    sep = 2;
                else
                    sep = 0;
                //sep = (feriados.Contains(iter.Current.Key))?2:0;
                CalcularHsExtras(cobraextra, (int)tc.CantidadHsComunes, iter.Current.Value, out hc, out he);
                LiquidacionDGV.Rows[numf].Cells[0].Value = iter.Current.Key.Day.ToString();
                LiquidacionDGV.Rows[numf].Cells[1 + sep].Value = (auxdt + hc).ToString("HH:mm");
                LiquidacionDGV.Rows[numf].Cells[2 + sep].Value = (auxdt + he).ToString("HH:mm");
            }
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
          

        
    }
}
