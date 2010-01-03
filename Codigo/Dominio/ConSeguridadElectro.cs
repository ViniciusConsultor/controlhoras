using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class ConSeguridadElectro: Contrato 
    {
        private bool Puntual;

        public ConSeguridadElectro(bool punt, DateTime fechaini, DateTime fechafin, string ajuste, string obs, bool fijo, float costo)
            : base(fechaini, fechafin, ajuste, obs, fijo, costo)
        {
            Puntual = punt;            
        }

        public bool esPuntual()
        {
            return Puntual;
        }
    }
}
