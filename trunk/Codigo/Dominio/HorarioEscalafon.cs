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
        private bool Solapa;

        public HorarioEscalafon(string dia, string HInicio, string HFin, bool solapa)
        {
            Dia = dia;
            HoraInicio = HInicio;
            HoraFin = HFin;
            TipoDia = 0;
            Solapa = solapa;
        }

        public HorarioEscalafon(string dia, string tipoDia)
        {
            Dia = dia;
            switch (tipoDia)
            {
                case "EnOtroServ":
                    TipoDia = 1;
                    break;
                case "Descanso":
                    TipoDia = 2;
                    break;
                case "Licencia":
                    TipoDia = 3;
                    break;
            }
            Solapa = false;
        }

        public HorarioEscalafon(string dia, int tipoDia)
        {
            Dia = dia;
            TipoDia = tipoDia;
            Solapa = false;
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

        public bool Solapea()
        {
            return Solapa;
        }
    }
}
