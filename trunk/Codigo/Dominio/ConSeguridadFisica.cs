using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ConSeguridadFisica: Contrato
    {
        private bool PagaHorasExtra;
        private int TotalHorasNormales;
        private int TotalHorasExtras;
        private int TotalVigilantes; //no me acuerdo que es esto
        private List<LineaDeHoras> Lineas;

        public ConSeguridadFisica(bool horasext, int tothnormales, int tothextras, int totvigilantes, DateTime fechaini, DateTime? fechafin, string ajuste, string obs, bool fijo, float costo)
            : base(fechaini, fechafin, ajuste, obs, fijo, costo)
        {
            PagaHorasExtra = horasext;
            TotalHorasNormales = tothnormales;
            TotalHorasExtras = tothextras;
            TotalVigilantes = totvigilantes;

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
    }
}
