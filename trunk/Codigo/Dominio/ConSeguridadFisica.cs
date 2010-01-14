using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    class ConSeguridadFisica: Contrato
    {
        private bool PagaHorasExtra;
        private int TotalHorasNormales;
        private int TotalHorasExtras;
        private int TotalVigilantes; //no me acuerdo que es esto
        private List<LineaDeHoras> Horario;

        public ConSeguridadFisica(bool horasext, int tothnormales, int tothextras, int totvigilantes, DateTime fechaini, DateTime fechafin, string ajuste, string obs, bool fijo, float costo)
            : base(fechaini, fechafin, ajuste, obs, fijo, costo)
        {
            PagaHorasExtra = horasext;
            TotalHorasNormales = tothnormales;
            TotalHorasExtras = tothextras;
            TotalVigilantes = totvigilantes;
        }
    }
}
