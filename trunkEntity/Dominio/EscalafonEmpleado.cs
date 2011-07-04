using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class EscalafonEmpleado
    {
        public int NroEmpleado { set; get; }
        public string CodigoPuesto { set; get; }
        public int CantidadHsLlamadaAntesHoraInicio { set; get; }

        public string AcargoDe;
        public bool Solapa;
        
        public List<HorarioEscalafon> Horario;

        //public enum ACargo { Empresa, Cliente }
        //public ACargo ACargoDe;

        /*      
        public EscalafonEmpleado()
        {

        }

        public EscalafonEmpleado(HorarioXDia horario, int cantHsLlamadaAntesHoraInicio, ACargo aCargo, Empleado empleado, Escalafon escalafon)
        {
            
            this.CantidadHsLlamadaAntesHoraInicio = cantHsLlamadaAntesHoraInicio;
            this.ACargoDe = aCargo;
            this.Funcionario = empleado;
            this.Planificacion = Planificacion;
            this.Horario = horario;
        }

        public EscalafonEmpleado(string dia, string horaInicio, string horaFin, int cantHsLlamadaAntesHoraInicio, ACargo aCargo, Empleado empleado, Escalafon escalafon)
        {
            Horario = new HorarioXDia(dia,horaInicio,horaFin);
            this.CantidadHsLlamadaAntesHoraInicio = cantHsLlamadaAntesHoraInicio;
            this.ACargoDe = aCargo;
            this.Funcionario = empleado;
            this.Planificacion = Planificacion;
        }
        
        */



    }
}
