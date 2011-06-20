using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ConSeguridadFisica: Contrato
    {
        private bool PagaDescanso;
        private bool PagaHorasExtra;
        private int TotalHorasNormales;
        private int TotalHorasExtras;
        private int TotalVigilantes; //no me acuerdo que es esto
        private int? PagarExtrasDespuesDeHs;
        private List<LineaDeHoras> Lineas;

        public ConSeguridadFisica(bool pDescanso, bool horasext, int tothnormales, int tothextras, int totvigilantes, DateTime fechaini, DateTime? fechafin, string ajuste, string obs, bool fijo, float costo)
            : base(fechaini, fechafin, ajuste, obs, fijo, costo)
        {
            PagaDescanso = pDescanso;
            PagaHorasExtra = horasext;
            TotalHorasNormales = tothnormales;
            TotalHorasExtras = tothextras;
            TotalVigilantes = totvigilantes;
            PagarExtrasDespuesDeHs = null;
            Lineas = new List<LineaDeHoras>();
        }

        public ConSeguridadFisica(bool pDescanso, bool horasext, int tothnormales, int tothextras, int totvigilantes, DateTime fechaini, DateTime? fechafin, string ajuste, string obs, bool fijo, float costo, int? pagarExtrasDespuesDe)
            : base(fechaini, fechafin, ajuste, obs, fijo, costo)
        {
            PagaDescanso = pDescanso;
            PagaHorasExtra = horasext;
            TotalHorasNormales = tothnormales;
            TotalHorasExtras = tothextras;
            TotalVigilantes = totvigilantes;
            PagarExtrasDespuesDeHs = pagarExtrasDespuesDe;
            Lineas = new List<LineaDeHoras>();
        }

        public DateTime getFechaIni()
        {
            return FechaInicio;
        }

        public DateTime? getFechaFin()
        {
            return FechaFin;
        }

        public string getAjuste()
        {
            return Ajuste;
        }

        public string getObservaciones()
        {
            return Observaciones;
        }

        public bool GetCostoFijo()
        {
            return CostoFijo;
        }

        public float getMonto()
        {
            return Costo;
        }

        public bool getHorasExtras()
        {
            return PagaHorasExtra;
        }

        public bool getPagaDescanso()
        {
            return PagaDescanso;
        }

        public int getHorasNormales()
        {
            return TotalHorasNormales;
        }

        public int getTotHorasExtras()
        {
            return TotalHorasExtras;
        }

        public int getVigilantes()
        {
            return TotalVigilantes;
        }

        public List<LineaDeHoras> getLineas()
        {
            return Lineas;
        }

        public void addLinea(LineaDeHoras linea)
        {
            Lineas.Add(linea);
        }

        public int? getPagarExtrasDespuesDeHs()
        {
            return PagarExtrasDespuesDeHs;
        }

        public void setPagarExtrasDespuesDeHs(int? cantHs)
        {
            PagarExtrasDespuesDeHs = cantHs;
        }

        public TimeSpan[] getTotalesHoras()
        {
            TimeSpan a = new TimeSpan(0,0,0);
            TimeSpan [] horas = new TimeSpan[7] {a,a,a,a,a,a,a};
            foreach (LineaDeHoras l in Lineas)
            {
                foreach (HorarioXDia h in l.getHorario())
                {
                    horas[toint(h.getDia())] = horas[toint(h.getDia())] + TimeSpan.FromTicks(h.getCantHoras().Ticks * l.getCantEmp());
                }
            }
            return horas;
        }

        private int toint(string dia)
        {
            switch (dia)
            {
                case "Lunes":
                    return 0;
                case "Martes":
                    return 1;
                case "Miercoles":
                    return 2;
                case "Jueves":
                    return 3;
                case "Viernes":
                    return 4;
                case "Sabado":
                    return 5;
                case "Domingo":
                    return 6;
            }
            return -1;            
        }
    }
}
