using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public interface IDatosABMTipos
    {

        #region TiposCargos
        /// <summary>
        /// Alta de un nuevo cargo con los parametros pasados
        /// </summary>
        /// <param name="nombre">Nombre del Cargo.</param>
        /// <param name="descripcion">Descripcion del Cargo.</param>
        /// <param name="cantidadHsComunes">Cantidad de Hs Comunes del Cargo.</param>
        /// <param name="tipoFacturacion">Tipo de Facturacion. MENSUAL o JORNALERO</param>
        /// <param name="cobraExtras">Cobra Hs Extras?</param>
        /// <param name="fulltime">Es FullTime?</param>
        /// <param name="inactivo">Estado del cargo. false = activo, true = inactivo.</param>
        /// <returns></returns>
        int altaCargo(string nombre, string descripcion, int cantidadHsComunes,string tipoFacturacion,bool cobraExtras, bool fulltime, bool inactivo);

        /// <summary>
        /// Modificar un Cargo existente.
        /// </summary>
        /// <param name="idCargo">Identificador del Cargo.</param>
        /// <param name="nombre">Nombre del Cargo.</param>
        /// <param name="descripcion">Descripcion del Cargo.</param>
        /// <param name="cantidadHsComunes">Cantidad de Hs Comunes del Cargo.</param>
        /// <param name="tipoFacturacion">Tipo de Facturacion. MENSUAL o JORNALERO</param>
        /// <param name="cobraExtras">Cobra Hs Extras?</param>
        /// <param name="fulltime">Es FullTime?</param>
        /// <param name="inactivo">Estado del cargo. false = activo, true = inactivo.</param>
        void modificarTipoCargo(int idCargo, string nombre, string descripcion, int cantidadHsComunes, string tipoFacturacion, bool cobraExtras, bool fulltime, bool inactivo);
        
        
        //void bajaTipoEmpleado();
        Dictionary<int, string> obtenerTiposCargos(bool soloactivos);
        List<TipOscarGoS> obtenerTiposCargosList(bool soloactivos);

        #endregion

        #region ABM_Departamentos
        int altaDepartamento(string nombreDepartamento, bool activo);
        void modificarDepartamento(int idDepartamento, string nombreDepartamento, bool activo);
        Dictionary<int, string> obtenerDepartamentos(bool activos);
        void bajaDepartamento(int idDepartamento);

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

        #region ABM_TiposEventoHistorial
        int altaTipoEventoHistorial(string descripcion, bool activo);
        void modificarTipoEventoHistorial(int idTipoEventoHistorial, string descripcion, bool activo);
        List<TipOsEventOHistOrIal> obtenerTiposEventoHistorial(bool soloactivos);

        #endregion

        #region ABM_UsuariosYGrupos
        int altaUsuario(string NombreUsuario,string Password, string Nombre, string Apellido, DateTime FechaNacimiento,bool Estado);
        void modificarUsuario(int idUsuario,string NombreUsuario, string Nombre, string Apellido, bool Estado);
        List<UsUarIoS> obtenerListaUsuarios(bool soloactivos);
        List<string> obtenerListaUserNames(bool soloactivos);
        Dictionary<int, List<int>> obtenerPermisosUsuario(string UserName);
        void modificarPermisosUsuario(string UserName, Dictionary<int, List<int>> listaPermisos);
        List<PerMisOControl> obtenerListaPermisosUsuarioPantalla(string UserName, string NombrePantalla);

        int altaGrupo(string Nombre, string Descripcion, bool estado, List<string> usuarios, Dictionary<int, List<int>> ListaIdPantallas_Controles);
        void modificarGrupo(int IdGrupo, string Nombre, string Descripcion, bool estado, List<string> usuarios, Dictionary<int, List<int>> ListaIdPantallas_Controles);
        List<GRuPOs> obtenerListaGrupos(bool soloactivos);

        #endregion

        #region ABM_TipoExtraLiquidacion
        int altaTipoExtraLiquidacion(string nombreTipoExtra, bool activo, bool llevaHs);
        void modificarTipoExtraLiquidacion(TipOExtraLiquidAcIon tipoExtra);
        List<TipOExtraLiquidAcIon> obtenerTipoExtraLiquidacion(bool activos);
        #endregion
    }
}
