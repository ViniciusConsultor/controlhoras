using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    class EscalafonEmpleado
    {
        public HorarioXDia Horario { set; get; }
        public int CantidadHsLlamadaAntesHoraInicio { set; get; }
        public enum ACargo { Empresa, Cliente }

        public ACargo ACargoDe;

        public Empleado Funcionario { set; get; }
        public Escalafon Planificacion { set; get; }


        public EscalafonEmpleado()
        {

        }

        public EscalafonEmpleado(HorarioXDia horario, int cantHsLlamadaAntesHoraInicio, ACargo aCargo, Empleado empleado, Escalafon escalafon)
        {
            this.Horario = horario;
            this.CantidadHsLlamadaAntesHoraInicio = cantHsLlamadaAntesHoraInicio;
            this.ACargoDe = aCargo;
            this.Funcionario = empleado;
            this.Planificacion = Planificacion;
        }

        public EscalafonEmpleado(string dia, string horaInicio, string horaFin, int cantHsLlamadaAntesHoraInicio, ACargo aCargo, Empleado empleado, Escalafon escalafon)
        {
            Horario = new HorarioXDia(dia,horaInicio,horaFin);
            this.CantidadHsLlamadaAntesHoraInicio = cantHsLlamadaAntesHoraInicio;
            this.ACargoDe = aCargo;
            this.Funcionario = empleado;
            this.Planificacion = Planificacion;
        }



    }
}
