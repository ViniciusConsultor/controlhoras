using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class LineaDeHoras
    {
        private string Puesto;
        private bool Armado;
        private float CostoHora;
        private List<HorarioXDia> Horario;
        private int CantidadEmpleado;
        private int CantidadHsNormales;
        private int CantidadHSExtras;

        public LineaDeHoras(string puesto, bool arm, float costoh, int cantE, int cantHS, int cantHSE)
        {
            Puesto = puesto;
            Armado = arm;
            CostoHora = costoh;
            CantidadEmpleado = cantE;
            CantidadHsNormales = cantHS;
            CantidadHSExtras = cantHSE;

            Horario = new List<HorarioXDia>();
        }

        public string getPuesto()
        {
            return Puesto;
        }

        public bool getArmado()
        {
            return Armado;
        }

        public float getCostoH()
        {
            return CostoHora;
        }

        public int getCantEmp()
        {
            return CantidadEmpleado;
        }

        public int getCantHS()
        {
            return CantidadHsNormales;
        }

        public int getCantHE()
        {
            return CantidadHSExtras;
        }

        public List<HorarioXDia> getHorario()
        {
            return Horario;
        }

        public void addDia(HorarioXDia hor)
        {
            Horario.Add(hor);
        }
    }
}
