using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Funcionario
    {
        private int numero;
        private string tipoFuncionario = null;
        private string nombre = null;
        private string apellido = null;
        private string ci = null;
        private string direccion = null;
        private string telefono = null;
        private PlanificacionFuncionario planificacion;

        public Funcionario(int num, string nom, string apell, string numDocumento)
        {
            numero = num;
            nombre = nom;
            apellido = apell;
            ci = numDocumento;
            planificacion = new PlanificacionFuncionario();
        }

        public int getNumero()
        {
            return numero;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellido()
        {
            return apellido;
        }

        public string getCI()
        {
            return ci;
        }

        public string getDireccion()
        {
            return direccion;
        }

        public string getTelefono()
        {
            return telefono;
        }

        public string getTipoFuncionario()
        {
            return tipoFuncionario;
        }

        public void agregarDiaPlanificacion(int idcli, int idser, DateTime diacal, string HoraIni, string HoraFin)
        {
            DiaPlanificacion dp = new DiaPlanificacion(idcli, idser, diacal, HoraIni, HoraFin);
            try
            {

                planificacion.agregarDiaPlanificado(dp);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void eliminarDiaPlanificacion(int idcli, int idser, DateTime diacal, string HoraIni, string HoraFin)
        {
            bool elimine = false;
            foreach (DiaPlanificacion d in planificacion.getPlanificacion())
            {
                if (d.getDiaCalendario().ToShortDateString() == diacal.ToShortDateString() && idcli == d.getIdCliente() && d.getIdServicio() == idser && d.getHoraMinInicio().Equals(HoraIni) && d.getHoraMinFin().Equals(HoraFin))
                {
                    planificacion.eliminarDiaPlanificado(d);
                    elimine = true;
                    break;
                }
            }
            if (!elimine)
                
                throw new Exception("El padron no tiene una planificacion en ese Dia-Hora.");
        }

        public void setEntradaPlanificacionDeFuncionarioServicioDia(int idCliente, int idServicio, DateTime fecha, string HoraIni)
        {
            try
            {
                DiaPlanificacion dp = planificacion.getDiaPlanificacion(idCliente, idServicio, fecha, HoraIni);
                dp.marcarEntrada(true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void setSalidaPlanificacionDeFuncionarioServicioDia(int idCliente, int idServicio, DateTime fecha, string HoraIni)
        {
            try
            {
                DiaPlanificacion dp = planificacion.getDiaPlanificacion(idCliente, idServicio, fecha, HoraIni);
                dp.marcarSalida(true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<DiaPlanificacion>  obtenerPlanificacionFuncionarioServicioDia(int idCliente, int idServicio, DateTime fecha)
        {
            List<DiaPlanificacion> devolver = new List<DiaPlanificacion>();
            foreach (DiaPlanificacion d in planificacion.getPlanificacion())
            {
                if (d.getDiaCalendario().ToShortDateString().Equals(fecha.ToShortDateString()) && idCliente == d.getIdCliente() && d.getIdServicio() == idServicio)
                {
                    devolver.Add(d);
                }
            }
            return devolver;
        }

        public void setHoraEntradaFuncionarioServicioDia(int idCliente, int idServicio, DateTime fecha, string HoraActual, string HoraNueva)
        {
            try
            {
                DiaPlanificacion dp = planificacion.getDiaPlanificacion(idCliente, idServicio, fecha, HoraActual);
                dp.setHoraMinInicio(HoraNueva);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void setHoraSalidaFuncionarioServicioDia(int idCliente, int idServicio, DateTime fecha, string HoraActual, string HoraNueva)
        {
            try
            {
                DiaPlanificacion dp = planificacion.getDiaPlanificacion(idCliente, idServicio, fecha, HoraActual);
                dp.setHoraMinFin(HoraNueva);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    
    }

}
