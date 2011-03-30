using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class DataExtraLiquidacion
    {
        public string descripcion { get; private set; }
        public string cuota { get; private set; }
        public int valor { get; private set; }

        public DataExtraLiquidacion()
        {
        }

        public DataExtraLiquidacion(string Desc, string Cuota, int Valor)
        {
            descripcion = Desc;
            cuota = Cuota;
            valor = Valor;
        }
    }

    public class DataEmpleadoExLiquidacion
    {
        public int NroEmpleado { get; private set; }
        public DateTime mes { get; private set; }
        public List<DataExtraLiquidacion> listaExLiqui { get; private set; }

        public DataEmpleadoExLiquidacion()
        {
            listaExLiqui = new List<DataExtraLiquidacion>();
        }

        public DataEmpleadoExLiquidacion(int nroEmp, DateTime Mes, List<DataExtraLiquidacion> lisExLiqui)
        {
            NroEmpleado = nroEmp;
            mes = Mes;
            listaExLiqui = lisExLiqui;
        }
    }
}
