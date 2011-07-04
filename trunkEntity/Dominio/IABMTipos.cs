using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IABMTipos
    {

        #region TipoEmpleado
        int altaTipoEmpleado();
        void modificacionTipoEmpleado();
        void bajaTipoEmpleado();
        List<TipoEmpleado> obtenerTiposEmpleado();

        #endregion

        #region ABM_Departamentos
        int altaDepartamento(string nombreDepartamento, bool activo);
        void modificarDepartamento(int idDepartamento, string nombreDepartamento, bool activo);
        Dictionary<int, string> obtenerDepartamentos(bool activos);
        void bajaDepartamento(int idDepartamento);

        #endregion

        #region ABM_Ciudades
        int altaCiudad(string nombreCiudad, bool activo);
        void modificarCiudad(int idCiudad, string nombreCiudad, bool activo);
        Dictionary<int, string> obtenerCiudades(bool activos);
        void bajaCiudad(int idCiudad);

        #endregion

        #region ABM_Barrios
        int altaBarrio(string nombreBarrio, bool activo);
        void modificarBarrio(int idBarrio, string nombreBarrio, bool activo);
        Dictionary<int, string> obtenerBarrios(bool activos);
        void bajaBarrio(int idBarrio);

        #endregion

        #region ABM_Bancos
        int altaBanco(string nombreBanco, bool activo);
        void modificarBanco(int idBanco, string nombreBanco, bool activo);
        Dictionary<int, string> obtenerBancos(bool activos);
        void bajaBanco(int idBanco);
        #endregion

        #region ABM_Mutualistas
        int altaMutualista(string nombreMutualista, bool activo);
        void modificarMutualista(int idMutualista, string nombreMutualista, bool activo);
        Dictionary<int, string> obtenerMutualistas(bool activos);
        void bajaMutualista(int idMutualista);
        #endregion

        #region ABM_EmergenciasMedica
        int altaEmergenciaMedica(string nombreEmergenciaMedica, bool activo);
        void modificarEmergenciaMedica(int idEmergenciaMedica, string nombreEmergenciaMedica, bool activo);
        Dictionary<int, string> obtenerEmergenciaMedicas(bool activos);
        void bajaEmergenciaMedica(int idEmergenciaMedica);
        #endregion

        #region ABM_TiposDocumentos
        int altaTipoDocumento(string nombreTipoDocumento, bool activo);
        void modificarTipoDocumento(int idTipoDocumento, string nombreTipoDocumento, bool activo);
        Dictionary<int, string> obtenerTipoDocumentos(bool activos);
        void bajaTipoDocumento(int idTipoDocumento);
        #endregion

    }
}
