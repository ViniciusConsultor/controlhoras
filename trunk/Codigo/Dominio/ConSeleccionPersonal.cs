using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    class ConSeleccionPersonal: Contrato
    {        
        private bool Puntual;
        private bool PlanillaTrust;
        private string DescripPerfil;

        public ConSeleccionPersonal(bool punt, bool planillaenTrust, string descPerfil, DateTime fechaini, DateTime fechafin, string ajuste, string obs, bool fijo, float costo)
            : base(fechaini, fechafin, ajuste, obs, fijo, costo)
        {
            Puntual = punt;
            PlanillaTrust = planillaenTrust;
            DescripPerfil = descPerfil;
        }

        public bool esPuntual()
        {
            return Puntual;
        }

        public bool PlanillaEnTrust()
        {
            return PlanillaTrust;
        }

        public string getDescripcionPerfil()
        {
            return DescripPerfil;
        }

        public void setDescripcionPerfil(string desc)
        {
            DescripPerfil = desc;
        }
    
    }
}
