using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public interface IEmpleados
    {

        #region Empleado
        void altaEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadHijos, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica);
        void modificarEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadHijos, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica);
        bool existeEmpleado(int idEmpleado);
        Empleado obtenerEmpleado(int idEmpleado);
        //void buscarEmpleado();
            //List<Empleado> obtenerEmpleados(bool activos);
        #endregion

        Dictionary<int,string> obtenerTiposDocumento();
        Dictionary<int, string> obtenerEmergenciasMedica();
        Dictionary<int, string> obtenerMutualistas();
        Dictionary<int, string> obtenerBancos();
        Dictionary<int, string> obtenerDepartamentos();


        //#region ExtraLiquidacion
        //    void ingresarExtraLiquidacionEmpleado();
        //    void modificarExtraLiquidacionEmpleado();
        //    void bajaExtraLiquidacionEmpleado();
        //    List<ExtraLiquidacionEmpleado> obtenerExtrasLiquidacionEmpleado();
        //#endregion

        //#region EventoHistorial
        //    int ingresarEventoHistorialEmpleado();
        //    void modificarEventoHistorialEmpleado();
        //    void bajaEventoHistorialEmpleado();
        //    List<EventoHistorialEmpleado> obtenerEventosHistorialEmpleado();
        //#endregion
    }
}
