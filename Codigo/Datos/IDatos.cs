﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Datos
{
    public interface IDatos
    {
        List<string> obtenerNombreTablas();
        /// <summary>
        /// Devuelve los datos correspondientes a un select de las columnas sobre la tabla.
        /// </summary>
        /// <param name="nombreTabla">Nombre de la Tabla sobre la cual ejecutar la consulta.</param>
        /// <param name="listaColumnas">Lista de nombre de columnas de la tabla</param>
        /// <returns>Retorna un DataSet con el resultado.</returns>
        DataSet obtenerDataFromTable(string nombreTabla, List<string> listaColumnas);
        List<string> obtenerTableColumnsName(string nombreTabla);
        string obtenerNombreBaseDatos();
        
        #region Operaciones_De_Clientes
        void altaCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime fechaAlta, DateTime fechaBaja, string motivoBaja);
        void modificarCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime fechaAlta, DateTime fechaBaja, string motivoBaja);
        //void bajaCliente(int idcliente);
        //List<Cliente> busquedaClientePorNombre(string nom);
        bool existeCliente(int numCliente);
        ClientEs obtenerCliente(int idcliente);
        //List<Cliente> obtenerClientes(bool activos);
        List<ClientEs> buscarClientes(string Nombre);
        #endregion

        #region Operaciones_DeServicios
        void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas);
        List<SERVicIoS> obtenerServiciosCliente(int numCliente);

        void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas);
        #endregion

        #region Operaciones_De_Empleados
        void altaEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, int edad, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadMenoresACargo, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string barrio, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesEmpleado, string observacionesAntecedentesEmpleado, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica, bool capacitadoPorteArma, bool enservicioArmado, string observacionesEmpleado);
        bool existeEmpleado(int idEmpleado);
        void modificarEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, int edad, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadMenoresACargo, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string barrio, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesEmpleado, string observacionesAntecedentesEmpleado, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica, bool capacitadoPorteArma, bool enservicioArmado, string observacionesEmpleado);
        EmPleadOs obtenerEmpleado(int idEmpleado);
        /// <summary>
        /// Obtiene el IdEmpleado mas alto existente.
        /// </summary>
        /// <returns>Devuelve el Identificador mas alto de los empleados existentes.</returns>
        int obtenerMaxIdEmpleado();

        /// <summary>
        /// Agrega un evento al historial del empleado.
        /// </summary>
        /// <param name="idEmpleado">El numero de Empleado</param>
        /// <param name="fechaInicioEvento">Fecha de Inicio del Evento</param>
        /// <param name="fechaFinEvento">Fecha de Fin del Evento</param>
        /// <param name="tipoEventoHistorial">Identificador del Tipo de Evento</param>
        /// <param name="descripcionEvento">Descripcion del Evento</param>
        /// <returns></returns>
        int agregarEventoHistorialEmpleado(int idEmpleado, DateTime fechaInicioEvento, DateTime fechaFinEvento, int tipoEventoHistorial, string descripcionEvento);
        
        /// <summary>
        /// Modifica un evento del historial del empleado
        /// </summary>
        /// <param name="idEventoHistorialEmpleado">Identificador del evento</param>
        /// <param name="idEmpleado">Numero del Empleado</param>
        /// <param name="fechaInicioEvento">Fecha de Inicio del Evento</param>
        /// <param name="fechaFinEvento">Fecha de Fin del Evento</param>
        /// <param name="idTipoEventoHistorial">Identificador del Tipo de Evento</param>
        /// <param name="descripcionHistorial">Descripcion del Evento</param>
        void modificarEventoHistorialEmpleado(int idEventoHistorialEmpleado, int idEmpleado, DateTime fechaInicioEvento,DateTime fechaFinEvento,int idTipoEventoHistorial,string descripcionHistorial);

        /// <summary>
        /// Elimina el Evento de identificador idEventoHistorialEmpledo del Historial del Empleado. Realiza un borrado logico.
        /// </summary>
        /// <param name="idEventoHistorialEmpleado">Identificador del Evento en el Historial del Empleado.</param>
        /// <param name="idEmpleado">Identificador del Empleado.</param>
        void eliminarEventoHistorialEmpleado(int idEventoHistorialEmpleado, int idEmpleado);

        /// <summary>
        /// Devuelve la lista de los Eventos del Historial del Empleado.
        /// </summary>
        /// <param name="idEmpleado">Identificador del Empleado.</param>
        /// <returns></returns>
        List<EventOsHistOrIalEmPleadO> obtenerEventosHistorialEmpleado(int idEmpleado);

        /// <summary>
        /// Agrega un nuevo extra a la liquidacion del empleado para la fecha correspondiente
        /// </summary>
        /// <param name="idEmpleado">Numero del Empleado a modificar el extra</param>
        /// <param name="fecha">Fecha a la que corresponde el extra liquidacion</param>
        /// <param name="descripcion">Descripcion del extra</param>
        /// <param name="signoPositivo">Signo del extra, si es Positivo o Negativo</param>
        /// <param name="valor">Valor del extra</param>
        /// <param name="cantidadCuotas">Cuotas del extra</param>
        int agregarExtraLiquidacionEmpleado(int idEmpleado, DateTime fecha, string descripcion, bool signoPositivo, float valor, int cantidadCuotas);

        /// <summary>
        /// Modifica un Extra de la liquidacion del empleado
        /// </summary>
        /// <param name="idEmpleado">Numero del Empleado a modificar el extra</param>
        /// <param name="idExtraLiquidacionEmpleado">Identificador del extra liquidacion a modificar</param>
        /// <param name="fecha">Fecha a la que corresponde el extra liquidacion</param>
        /// <param name="descripcion">Descripcion del extra</param>
        /// <param name="signoPositivo">Signo del extra, si es Positivo o Negativo</param>
        /// <param name="valor">Valor del extra</param>
        /// <param name="cantidadCuotas">Cuotas del extra</param>
        void modificarExtraLiquidacionEmpleado(int idEmpleado, int idExtraLiquidacionEmpleado, DateTime fecha,string descripcion,bool signoPositivo, float valor, int cantidadCuotas);


        /// <summary>
        /// Elimina un extra liquidacion del empleado
        /// </summary>
        /// <param name="idEmpleado">Numero del Empleado a modificar el extra</param>
        /// <param name="idExtraLiquidacionEmpleado">Identificador del extra liquidacion a modificar</param>
        /// <param name="mesCorrespondiente">El mes actual seleccionado por el usuario</param>
        void eliminarExtraLiquidacionEmpleado(int idEmpleado, int idExtraLiquidacionEmpleado, DateTime mesCorrespondiente);

        /// <summary>
        /// Obtiene los extras de liquidacion del empleado para el mes correspondiente
        /// </summary>
        /// <param name="idEmpleado">Numero del Empleado a modificar el extra.</param>
        /// <param name="mesCorrespondiente">Mes para el cual se quiere obtener los extras.</param>
        /// <returns></returns>
        List<ExtrasLiquidAcIonEmPleadO> obtenerExtrasLiquidacionEmpleado(int idEmpleado, DateTime mesCorrespondiente);
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



        bool existeClienteServicio(int NumeroCliente, int NumeroServicio);

        void altaContratoServicioCliente(int NumeroCliente, int NumeroServicio, int NumeroContrato, DateTime FechaInicio, DateTime? FechaFin, bool CostoFijo, bool HorasExtras, string Ajuste, string Observaciones, float Monto);

        bool existeContrato(int NumeroContrato);

        ContraToS obtenerContrato(int NumeroContrato);

        void modificarContrato(int numeroContrato, DateTime FechaInicial, DateTime? FechaFinal, bool Costo, bool HorasExtras, string Ajuste, string Observaciones, float Monto);

        void altaContrato(ContraToS Contrato, List<LineAshOrAs> Lineas);
    }
}