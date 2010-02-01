using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class DiaPlanificacion
    {
        private DateTime DiaCalendario;
        private int IdServicio;
        private int IdCliente;
        private string HoraMinIni; // Formato HHMM
        private string HoraMinFin; // Formato HHMM
        private bool EntradaMarcada;
        private bool SalidaMarcada;

       
        public DiaPlanificacion(int idcli, int idser, DateTime diaCal, string hmini, string hmfin)
        {
            IdCliente = idcli;
            IdServicio = idser;
            DiaCalendario = diaCal;
            HoraMinIni = hmini;
            HoraMinFin = hmfin;
            EntradaMarcada = false;
            SalidaMarcada = false;

        }

        public int getIdCliente()
        {
            return IdCliente;
        }
        public int getIdServicio()
        {
            return IdServicio;
        }

        public DateTime getDiaCalendario()
        {
            return DiaCalendario;
        }

        public String getHoraMinInicio()
        {
            return HoraMinIni;
        }

        public void setHoraMinInicio(string horamin)
        {
            HoraMinIni = horamin;
        }


        public String getHoraMinFin()
        {
            return HoraMinFin;
        }

        public void setHoraMinFin(string horamin)
        {
            HoraMinFin = horamin;
        }

        public bool getSalidaMarcada()
        {
            return SalidaMarcada;
        }

        public void marcarSalida(bool sal)
        {
            SalidaMarcada = sal;
        }

        public bool getEntradaMarcada()
        {
            return EntradaMarcada;
        }
        
        public void marcarEntrada(bool sal)
        {
            EntradaMarcada = sal;
        }

        
    }
}
