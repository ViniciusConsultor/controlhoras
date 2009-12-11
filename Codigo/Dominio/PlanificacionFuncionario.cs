using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class PlanificacionFuncionario
    {
        private List<DiaPlanificacion> planificado;

        public PlanificacionFuncionario()
        {
            planificado = new List<DiaPlanificacion>();
        }

        public void agregarDiaPlanificado(DiaPlanificacion dp)
        {
            try{
                //verificarPlanificacion(dp);
                planificado.Add(dp);
            }catch (Exception e){
                throw e;
            }
        }

        public void eliminarDiaPlanificado(DiaPlanificacion drm)
        {
            planificado.RemoveAt(planificado.IndexOf(drm));
        }

        public List<DiaPlanificacion> getPlanificacion()
        {
            return planificado;
        }

        
        public DiaPlanificacion getDiaPlanificacion(int idCliente, int idServicio, DateTime fecha, string HoraIni)
        {
         
            foreach(DiaPlanificacion dp in planificado)
            {
                if (fecha.ToShortDateString() == dp.getDiaCalendario().ToShortDateString() && idCliente == dp.getIdCliente() && idServicio == dp.getIdServicio() && HoraIni == dp.getHoraMinInicio())
                    return dp;

            }
            throw new Exception("El funcionario no tiene una planificacion para el dia/cliente/servicio/horainicio");
        }

        private void verificarPlanificacion(DiaPlanificacion dnew)
        {
            foreach (DiaPlanificacion d in planificado)
            {
                if (d.getDiaCalendario() == dnew.getDiaCalendario())
                {
                    if ((DateTime.Parse(dnew.getHoraMinInicio()) < DateTime.Parse(d.getHoraMinInicio()) && System.Int32.Parse(dnew.getHoraMinFin()) <= System.Int32.Parse(d.getHoraMinInicio())) || System.Int32.Parse(dnew.getHoraMinInicio()) >= System.Int32.Parse(d.getHoraMinFin()))
                    {
                        planificado.Add(dnew);
                    }
                    else
                        throw new Exception("Error de solapamiento de horarios en el dia");
                }
            }
        }
                
    }
}
