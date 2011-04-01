using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class DataEventoHistEmpleado
    {
        public DateTime inicio { get; private set; }
        public DateTime fin { get; private set; }
        public string tipo { get; private set; }
        public string desc { get; private set; }

        public DataEventoHistEmpleado()
        {
        }

        public DataEventoHistEmpleado(DateTime ini, DateTime Fin, string Tipo, string Desc)
        {
            inicio = ini;
            fin = Fin;
            tipo = Tipo;
            desc = Desc;
        }
    }

    public class DataEventosHE
    {
        public int NroEmpleado { get; private set; }
        public List<DataEventoHistEmpleado> listaEventos { get; private set; }

        public DataEventosHE()
        {
            listaEventos = new List<DataEventoHistEmpleado>();
        }

        public DataEventosHE(int NroEmp, List<DataEventoHistEmpleado> eventos)
        {
            NroEmpleado = NroEmp;
            listaEventos = eventos;
        }
    }     
    
}
