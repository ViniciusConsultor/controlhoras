using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class HorarioXDia
    {
        private string Dia;
        private string HoraInicio;
        private string HoraFin;

        public HorarioXDia(string dia, string HInicio, string HFin)
        {

            Dia = dia;
            HoraInicio = HInicio;
            HoraFin = HFin;
        }

        public string getDia()
        {
            return Dia;
        }

        public string getHoraIni()
        {
            return HoraInicio;
        }

        public string getHoraFin()
        {
            return HoraFin;
        }

        public override bool Equals(HorarioXDia obj)
        {
            return this.Dia == obj.Dia && this.HoraFin == obj.HoraFin && this.HoraInicio == obj.HoraInicio;
        }
    }
}
