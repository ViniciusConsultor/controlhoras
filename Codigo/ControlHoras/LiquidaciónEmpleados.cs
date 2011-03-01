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

            CargoLBL.Text = tc.Nombre;

            List<DateTime> feriados = datos.ObtenerFeriados();

            Dictionary<DateTime, TimeSpan> liq = datos.LiquidarunEmpleado(9999);

            tc = tc;




        }

        
    }
}
