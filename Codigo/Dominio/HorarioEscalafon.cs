using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class HorarioEscalafon
    {      
        private string Dia;
        private string HoraInicio;
        private string HoraFin;
        private int TipoDia;

        public HorarioEscalafon(string dia, string HInicio, string HFin)
        {
            Dia = dia;
            HoraInicio = HInicio;
            HoraFin = HFin;
            TipoDia = 0;
        }

        public HorarioEscalafon(string dia, string tipoDia)
        {
            Dia = dia;
            switch (tipoDia)
            {
                case "Descanso":
                    TipoDia = 1;
                    break;
                case "Licencia":
                    TipoDia = 2;
                    break;
            }
        }

        public HorarioEscalafon(string dia, int tipoDia)
        {
            Dia = dia;
            TipoDia = tipoDia;
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

        public int getTipoDia()
        {
            return TipoDia;
        }

        public bool EsLaborable()
        {
            return (TipoDia == 0);
        }
    }
}
