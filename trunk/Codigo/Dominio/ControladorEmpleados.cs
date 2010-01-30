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
                datos.altaEmpleado(idEmpleado, nombre, apellido, idTipoDocumento, documento, lugarNacimiento, nacionalidad, sexo, fechaPsicologo, fechaNacimiento, fechaIngreso, telefono, celular, celularConvenio, email, estadoCivil, cantidadHijos, foto, idBanco, numeroCuenta, sueldo, activo, fechaBaja, motivoBaja, /* Segundo Tab */ idDepartamento, ciudad, direccion, entreCalles, puntoEncuentro, numeroAsuntoRENAEMSE, fechaIngresoRENAEMSE, acumulacionLaboralBPS, fechaAltaBPS, fechaBajaBPS, numeroCAJ, fechaEmisionCAJ, fechaEntregaCAJ, antecedentesPolicialesOMilitares, PolicialOMilitar, fechaIngresoAntecedete, fechaEgresoAntecedente, subEscalafon, combatiente, talleCamisa, tallePantalon, talleZapatos, talleCampera, vencimientoCarneSalud, idMutualista, idEmergenciaMedica);
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
                //datos.modificarEmpleado(idEmpleado, nombre, apellido, idTipoDocumento, documento, lugarNacimiento, nacionalidad, sexo, fechaPsicologo, fechaNacimiento, fechaIngreso, telefono, celular, celularConvenio, email, estadoCivil, cantidadHijos, foto, idBanco, numeroCuenta, sueldo, activo, fechaBaja, motivoBaja, /* Segundo Tab */ idDepartamento, ciudad, direccion, entreCalles, puntoEncuentro, numeroAsuntoRENAEMSE, fechaIngresoRENAEMSE, acumulacionLaboralBPS, fechaAltaBPS, fechaBajaBPS, numeroCAJ, fechaEmisionCAJ, fechaEntregaCAJ, antecedentesPolicialesOMilitares, PolicialOMilitar, fechaIngresoAntecedete, fechaEgresoAntecedente, subEscalafon, combatiente, talleCamisa, tallePantalon, talleZapatos, talleCampera, vencimientoCarneSalud, idMutualista, idEmergenciaMedica);
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

        #region Codigueras
        public Dictionary<int, string> obtenerTiposDocumento()
        {
            try
            {
                return datos.obtenerTiposDocumento();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerEmergenciasMedica()
        {
            try
            {
                return datos.obtenerEmergenciasMedica();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Dictionary<int, string> obtenerMutualistas()
        {
            try
            {
                return datos.obtenerMutualistas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerBancos()
        {
            try
            {
                return datos.obtenerBancos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public Dictionary<int, string> obtenerDepartamentos()
        {
            try
            {
                return datos.obtenerDepartamentos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Funciones_Auxiliares_Locales
        private Empleado convertEmpleadoDatosToEmpleadoLogica(EmPleadOs cliEmpleado)
        {
            bool act;

            Empleado empleado = new Empleado();
            //
            return empleado;
        }
        #endregion
    }
}
