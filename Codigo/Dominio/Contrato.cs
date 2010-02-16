using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public abstract class Contrato
    {
        protected DateTime FechaInicio;
        protected DateTime? FechaFin;
        protected string Ajuste;
        protected string Observaciones;
        protected bool CostoFijo;
        protected float Costo;

        public Contrato(DateTime FechaIni, DateTime? FechaF, string ajuste, string obs, bool fijo, float costo)
        {
            FechaInicio = FechaIni;
            FechaFin = FechaF;
            Ajuste = ajuste;
            Observaciones = obs;
            CostoFijo = fijo;
            Costo = costo;
        }
    }

    
}
