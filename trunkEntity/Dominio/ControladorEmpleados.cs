using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
    public class ControladorEmpleados : IEmpleados
    {

        private IDatos datos = null;
        static private ControladorEmpleados instancia = null;

        private ControladorEmpleados()
        {
            datos = ControladorDatos.getInstance();
        }

        public static IEmpleados getInstance()
        {
            if (instancia == null)
                instancia = new ControladorEmpleados();
            return instancia;
        }

        #region Miembros de IEmpleados

        
        public void altaEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadHijos, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica)
        {
            try
            {
                throw new Exception("NO USAR EL ALTA EMPLEADO DEL SISTEMA");
                // datos.altaEmpleado(idEmpleado, nombre, apellido, idTipoDocumento, documento, lugarNacimiento, nacionalidad, sexo, fechaPsicologo, fechaNacimiento, fechaIngreso, telefono, celular, celularConvenio, email, estadoCivil, cantidadHijos, foto, idBanco, numeroCuenta, sueldo, activo, fechaBaja, motivoBaja, /* Segundo Tab */ idDepartamento, ciudad, direccion, entreCalles, puntoEncuentro, numeroAsuntoRENAEMSE, fechaIngresoRENAEMSE, acumulacionLaboralBPS, fechaAltaBPS, fechaBajaBPS, numeroCAJ, fechaEmisionCAJ, fechaEntregaCAJ, antecedentesPolicialesOMilitares, PolicialOMilitar, fechaIngresoAntecedete, fechaEgresoAntecedente, subEscalafon, combatiente, talleCamisa, tallePantalon, talleZapatos, talleCampera, vencimientoCarneSalud, idMutualista, idEmergenciaMedica);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadHijos, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica)
        {
            try
            {
                throw new Exception("NO USAR EL MODIFICAR EMPLEADO DEL SISTEMA");
                // datos.modificarEmpleado(idEmpleado, nombre, apellido, idTipoDocumento, documento, lugarNacimiento, nacionalidad, sexo, fechaPsicologo, fechaNacimiento, edad, fechaIngreso, telefono, celular, celularConvenio, email, estadoCivil, cantidadHijos, foto, idBanco, numeroCuenta, sueldo, activo, fechaBaja, motivoBaja, idDepartamento, ciudad, barrio, direccion, entreCalles, puntoEncuentro, numeroAsuntoRENAEMSE, fechaIngresoRENAEMSE, acumulacionLaboralBPS, fechaAltaBPS, fechaBajaBPS, numeroCAJ, fechaEmisionCAJ, fechaEntregaCAJ, antecedentesEmpleado, observacionesAntecedentesEmpleado, antecedentesPolicialesOMilitares, PolicialOMilitar, fechaIngresoAntecedete, fechaEgresoAntecedente, subEscalafon, combatiente, talleCamisa, tallePantalon, talleZapatos, talleCampera, vencimientoCarneSalud, idMutualista, idEmergenciaMedica,capacitadoPorteArma,enServicioArmado,observacionesEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

        public bool existeEmpleado(int idEmpleado)
        {
            try
            {
                return datos.existeEmpleado(idEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Empleado obtenerEmpleado(int idEmpleado)
        {
            try
            {
                EmPleadOs empDatos = datos.obtenerEmpleado(idEmpleado);
                return convertEmpleadoDatosToEmpleadoLogica(empDatos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //void IEmpleados.buscarEmpleado()
        //{
        //    throw new NotImplementedException();
        //}

        //List<Empleado> IEmpleados.obtenerEmpleados()
        //{
        //    throw new NotImplementedException();
        //}

        //void IEmpleados.ingresarExtraLiquidacionEmpleado()
        //{
        //    throw new NotImplementedException();
        //}

        //void IEmpleados.modificarExtraLiquidacionEmpleado()
        //{
        //    throw new NotImplementedException();
        //}

        //void IEmpleados.bajaExtraLiquidacionEmpleado()
        //{
        //    throw new NotImplementedException();
        //}

        //List<ExtraLiquidacionEmpleado> IEmpleados.obtenerExtrasLiquidacionEmpleado()
        //{
        //    throw new NotImplementedException();
        //}

        //int IEmpleados.ingresarEventoHistorialEmpleado()
        //{
        //    throw new NotImplementedException();
        //}

        //void IEmpleados.modificarEventoHistorialEmpleado()
        //{
        //    throw new NotImplementedException();
        //}

        //void IEmpleados.bajaEventoHistorialEmpleado()
        //{
        //    throw new NotImplementedException();
        //}

        //List<EventoHistorialEmpleado> IEmpleados.obtenerEventosHistorialEmpleado()
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        


        #region Funciones_Auxiliares_Locales
        private Empleado convertEmpleadoDatosToEmpleadoLogica(EmPleadOs cliEmpleado)
        {
           

                            Empleado empleado = new Empleado();/*
                try{
                    empleado.Antecedentes = false;
                }catch(Exception e){}
                if (cliEmpleado.Antecedentes == 0)
                    empleado.AntecedentesPolicialesOMilitares = false;
                else
                    empleado.AntecedentesPolicialesOMilitares = true;
                try{
                    empleado.Apellido = cliEmpleado.Apellido;
                }catch(Exception e){}
                try{
                    empleado.IdBanco = (byte) cliEmpleado.IDBanco;
                }catch(Exception e){}
                //try{
                //    empleado.Barrio = cliEmpleado.Barrio;
                //}catch(Exception e){}
                try{
                    empleado.BPS_AcumulacionLaboral = (byte) cliEmpleado.BpsaCumulacionLaboral;
                }catch(Exception e){}
                try{
                    empleado.BPS_FechaAltaEnBPS = (DateTime) cliEmpleado.BpsfEchaAlta;
                }catch(Exception e){}
                try{
                    empleado.BPS_FechaBaja = (DateTime) cliEmpleado.BpsfEchaBaja;
                }catch(Exception e){}
                try{
                    empleado.CAJ_FechaEmision = (DateTime)cliEmpleado.CajfEchaEmision;
                }catch(Exception e){}
                try{
                    empleado.CAJ_FechaEntrega = (DateTime)cliEmpleado.CajfEchaEntrega;
                }catch(Exception e){}
                try{
                    empleado.CAJ_Numero =  cliEmpleado.CajnUmero;
                }catch(Exception e){}
                try{
                    empleado.CantidadHijos = (sbyte) cliEmpleado.CantidadMenoresAcArgo;
                }catch(Exception e){}
                if (cliEmpleado.CapacitadoPortarArma == 0)
                    empleado.CapacitadoPorteArma = false;
                else
                    empleado.CapacitadoPorteArma = true;
                try{
                    empleado.Celular = cliEmpleado.Celular;
                }catch(Exception e){}
                try{
                    empleado.CelularEnConvenio = cliEmpleado.CelularenConvenio;
                }catch(Exception e){}
                try{
                    empleado.Ciudad = cliEmpleado.Ciudad;
                }catch(Exception e){}
                if (cliEmpleado.CombatienteMilitar == 0)
                        empleado.Combatiente = false;
                else
                        empleado.Combatiente = true;
                try{
                    empleado.Departamento = (short) cliEmpleado.IDDepartamento;
                }catch(Exception e){}
                try{
                    empleado.Direccion = cliEmpleado.Direccion;
                }catch(Exception e){}
                try{
                    empleado.DireccionDeEncuentro = cliEmpleado.DireccionDeEncuentro;
                }catch(Exception e){}
                try{
                    empleado.Edad = (sbyte) cliEmpleado.Edad;
                }catch(Exception e){}
                try{
                    empleado.Email = cliEmpleado.Email;
                }catch(Exception e){}
                try{
                    empleado.IdEmergenciaMedica = (byte) cliEmpleado.IDEmergenciaMedica;
                }catch(Exception e){}
                try{
                    empleado.EntreCalles = cliEmpleado.EntreCalles;
                }catch(Exception e){}
                //try{
                //    empleado.EstadoCivil = cliEmpleado.EstadoCivil;
                //}catch(Exception e){}
                //try{
                //    empleado.FechaEgreso = (DateTime) cliEmpleado.FechaBaja;
                //}catch(Exception e){}
                try{
                    empleado.FechaEgresoPolicialOMilitar = (DateTime)cliEmpleado.FechaEgresoPolicialoMilitar;
                }catch(Exception e){}
                try{
                    empleado.FechaIngreso = (DateTime)cliEmpleado.FechaIngreso;
                }catch(Exception e){}
                try{
                    empleado.FechaIngresoMesaRENAEMSE = (DateTime) cliEmpleado.RenaemsefEchaIngreso;
                }catch(Exception e){}
                try{
                    empleado.FechaIngresoPolicialOMilitar = (DateTime)cliEmpleado.FechaIngresoPolicialoMilitar;
                }catch(Exception e){}
                try{
                    empleado.FechaNacimiento = (DateTime) cliEmpleado.FechaNacimiento;
                }catch(Exception e){}
                try{
                    empleado.FechaTestPsicologico = (DateTime) cliEmpleado.FechaTestPsicologico;
                }catch(Exception e){}
                try{
                    empleado.FechaVencimientoCarneSalud = (DateTime)cliEmpleado.FechaVencimientoCarneDeSalud;
                }catch(Exception e){}
                //try{
                //    empleado.Foto = cliEmpleado.Foto;
                //}catch(Exception e){}
                try{
                    empleado.LugarNacimiento = cliEmpleado.LugarDeNacimiento;
                }catch(Exception e){}
                //try{
                //    empleado.MotivoEgreso = cliEmpleado.MotivoBaja;
                //}catch(Exception e){}
                try{
                    empleado.Mutualista = (byte) cliEmpleado.IDMutualista;
                }catch(Exception e){}
                try{
                    empleado.Nacionalidad = cliEmpleado.Nacionalidad;
                }catch(Exception e){}
                try{
                    empleado.Nombre = cliEmpleado.Nombre;
                }catch(Exception e){}
                //try{
                //    empleado.NumeroAsuntoRENAEMSE = cliEmpleado.RenaemsenUmeroAsunto;
                //}catch(Exception e){}
                try{
                    empleado.NumeroCuenta = cliEmpleado.NumeroCuenta;
                }catch(Exception e){}
                try{
                    empleado.NumeroDocumento = cliEmpleado.NumeroDocumento;
                }catch(Exception e){}
                try{
                    empleado.NumeroEmpleado = cliEmpleado.IDEmpleado;
                }catch(Exception e){}
                try{
                    empleado.Observaciones = cliEmpleado.Observaciones;
                }catch(Exception e){}
                try{
                    empleado.ObservacionesAntecedentes = cliEmpleado.ObservacionesAntecedentes;
                }catch(Exception e){}
                if (cliEmpleado.EnServicioArmado == 0)
                        empleado.ServicioArmado = false;
                else
                        empleado.ServicioArmado = false;
                //try{
                //    empleado.Sexo = char.Parse(cliEmpleado.SexO);
                //}catch(Exception e){}
                try{
                    empleado.SubEscalafon = cliEmpleado.SubEscalafonPolicial;
                }catch(Exception e){}
                try{
                    empleado.Sueldo = (float) cliEmpleado.SueldoActual;
                }catch(Exception e){}
                //try{
                //    empleado.TalleCamisa = cliEmpleado.TalleCamisa;
                //}catch(Exception e){}
                //try{
                //    empleado.TalleCampera = cliEmpleado.TalleCampera;
                //}catch(Exception e){}
                //try{
                //    empleado.TallePantalon = cliEmpleado.TallePantalon;
                //}catch(Exception e){}
                try{
                    empleado.TalleZapatos = (sbyte) cliEmpleado.TalleZapatos;
                }catch(Exception e){}
                try{
                        empleado.Telefonos = cliEmpleado.Telefonos;
                }catch(Exception e){}
                try{
                        empleado.TipoDocumento = cliEmpleado.IDTipoDocumento;
                }catch(Exception e){}
                //try
                //{
                //    empleado.Activo = cliEmpleado;
                //}
                //catch (Exception e) { }
                       */     
                return empleado;
        }
        #endregion
    }
}
