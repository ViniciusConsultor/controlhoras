using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Utilidades
{
    public class DataDiaFacturacion
    {
        public DateTime Dia { get; private set; }
        public TimeSpan HsComunes { get; private set; }
        public TimeSpan HsExtras { get; private set; }

        public DataDiaFacturacion()
        {
        }

        public DataDiaFacturacion(DateTime dia, TimeSpan hsComunes, TimeSpan hsExtras)
        {
            Dia = dia;
            HsComunes = hsComunes;
            HsExtras = hsExtras;
        }
    }

    public class DataFacturacion
    {
        // Dia y Lista con HsComunes y HsExtras
        public List<DataDiaFacturacion> ListaDiaFacturacion { get; private set; }
        public TimeSpan TotalHsComunes { get; private set; }
        public TimeSpan TotalHsExtras { get; private set; }
        public int NroCliente { get; private set; }
        public int NroServicio { get; private set; }

        public DataFacturacion()
        {
            ListaDiaFacturacion = new List<DataDiaFacturacion>();
            
        }

        public DataFacturacion(int nroCliente, int nroServicio, List<DataDiaFacturacion> listaDiaFacturacion, TimeSpan totalHsComunes, TimeSpan totalHsExtras)
        {
            NroCliente = nroCliente;
            NroServicio = nroServicio;
            ListaDiaFacturacion = listaDiaFacturacion;
            TotalHsComunes = totalHsComunes;
            TotalHsExtras = totalHsExtras;
        }

    }
}
