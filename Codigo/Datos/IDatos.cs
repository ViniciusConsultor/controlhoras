﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Utilidades;

namespace Datos
{
    public interface IDatos
    {
        #region Database_Metadata
        List<string> obtenerNombreTablas();
        /// <summary>
        /// Devuelve los datos correspondientes a un select de las columnas sobre la tabla.
        /// </summary>
        /// <param name="nombreTabla">Nombre de la Tabla sobre la cual ejecutar la consulta.</param>
        /// <param name="listaColumnas">Lista de nombre de columnas de la tabla</param>
        /// <param name="incluirInactivos">En true, se incluyen los valores inactivos</param>
        /// <returns>Retorna un DataSet con el resultado.</returns>
        
        DataSet obtenerDataFromTable(string nombreTabla, List<string> listaColumnas, bool incluirInactivos);
        List<string> obtenerTableColumnsName(string nombreTabla);
        string obtenerNombreBaseDatos();
        #endregion

        #region Operaciones_De_Clientes
        void altaCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja, string referencia, string diaHoraCobro, string contactoCobro, string telefonosCobro, int diaInicioFacturacion, int diaFinFacturacion);
        void modificarCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja, string referencia, string diaHoraCobro, string contactoCobro, string telefonosCobro, int diaInicioFacturacion, int diaFinFacturacion);
        //void bajaCliente(int idcliente);
        //List<Cliente> busquedaClientePorNombre(string nom);
        bool existeCliente(int numCliente);
        ClientEs obtenerCliente(int idcliente);

        /// <summary>
        /// Devuelve todos los clientes Activos e Inactivos, o solo los Activos dependiendo del valor pasado.
        /// </summary>
        /// <param name="soloActivos">True: Devuelve solo los clientes activos. False: Devuelve todos.</param>
        /// <returns></returns>
        List<ClientEs> obtenerClientes(bool soloActivos);

        /// <summary>
        /// Devuelve los clientes para Facturacion. Son los clientes activos mas los dados de baja en el mes de Facturacion.
        /// </summary>
        /// <param name="mesFacturacion">Mes correspondiente a la facturacion</param>
        /// <returns></returns>
        List<ClientEs> obtenerClientesParaFacturacion(DateTime mesFacturacion);
        
        /// <summary>
        /// Devuelve la lista de clientes que el nombre coincide con el patron pasado por parametro
        /// </summary>
        /// <param name="patronNombre"></param>
        /// <returns></returns>
        List<ClientEs> buscarClientes(string patronNombre);
        #endregion

        #region Operaciones_De_Servicios
        void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string Observaciones, bool Activo, DateTime? FechaBaja, string MotivoBaja);
        List<SERVicIoS> obtenerServiciosCliente(int numeroCliente);
        SERVicIoS obtenerServicioCliente(int numeroCliente, int numeroServicio);
        void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string Observaciones, bool activo, DateTime? FechaBaja, string MotivoBaja);
        #endregion

        #region Operaciones_De_Empleados
        bool existeEmpleado(int idEmpleado);
        void altaEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, char sexo, DateTime? fechaPsicologo, DateTime? fechaNacimiento, int edad, DateTime? fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadMenoresACargo, byte[] foto, float valorHora, bool activo, DateTime? fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, int ciudad, int barrio, string codigoPostal, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime? fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime? fechaAltaBPS, bool bajaBPS, DateTime? fechaBajaBPS, string numeroCAJ, DateTime? fechaEmisionCAJ, DateTime? fechaEntregaCAJ, bool antecedentesEmpleado, string observacionesAntecedentesEmpleado, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime? fechaIngresoAntecedete, DateTime? fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime? vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica, bool capacitadoPorteArma, bool enservicioArmado, string observacionesEmpleado, string nivelEducativo, int idCargo, DateTime? fechaPagoEfectuado, DateTime? fechaPrevistaPago, String servicioActual, string turno, bool ConstanciaDomicilio, DateTime? FechaEntregaCelular, bool PerteneceASindicato, bool NoLlevaTicketsAlimentacion);
        void modificarEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, char sexo, DateTime? fechaPsicologo, DateTime? fechaNacimiento, int edad, DateTime? fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadMenoresACargo, byte[] foto, float valorHora, bool activo, DateTime? fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, int ciudad, int barrio, string codigoPostal, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime? fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime? fechaAltaBPS, bool bajaBPS, DateTime? fechaBajaBPS, string numeroCAJ, DateTime? fechaEmisionCAJ, DateTime? fechaEntregaCAJ, bool antecedentesEmpleado, string observacionesAntecedentesEmpleado, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime? fechaIngresoAntecedete, DateTime? fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime? vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica, bool capacitadoPorteArma, bool enservicioArmado, string observacionesEmpleado, string nivelEducativo, int idCargo, DateTime? fechaPagoEfectuado, DateTime? fechaPrevistaPago, String servicioActual, string turno, bool ConstanciaDomicilio, DateTime? FechaEntregaCelular, bool PerteneceASindicato,bool NoLlevaTicketsAlimentacion);
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
        /// Devuelve True si el empleado tiene algun evento que tenga FechaInicio anterior o igual a Fecha y FechaFin mayor o igual a Fecha.
        /// </summary>
        /// <param name="NroEmpleado">Nro del Empleado.</param>
        /// <param name="Fecha">Fecha a consultar.</param>
        /// <returns>Devuelve TRUE si el empleado tiene algun evento en el historial que caiga en esta Fecha. FALSE en otro caso.</returns>
        bool empleadoTieneEventosHistorialEnFecha(int NroEmpleado, DateTime Fecha);

        /// <summary>
        /// Agrega un nuevo extra a la liquidacion del empleado para la fecha correspondiente
        /// </summary>
        /// <param name="idEmpleado">Numero del Empleado a modificar el extra</param>
        /// <param name="fecha">Fecha a la que corresponde el extra liquidacion</param>
        /// <param name="descripcion">Descripcion del extra</param>
        /// <param name="signoPositivo">Signo del extra, si es Positivo o Negativo</param>
        /// <param name="valor">Valor del extra</param>
        /// <param name="cantidadCuotas">Cuotas del extra</param>
        /// <param name="UserName">UserName del Usuario que da de alta el ExtraLiquidacion</param>
        /// <param name="IdTipoExtraLiquidacion">Identificador del TipoExtraLiquidacion seleccionado</param>
        /// <param name="CantHs_LlevaHs">Cantidad de Hs representada en Comunes a agregar al empleado</param>
        /// <param name="Porcentaje">Porcentaje del extra</param>
        int agregarExtraLiquidacionEmpleado(int idEmpleado, DateTime fecha, string descripcion, bool signoPositivo, float valor, int cantidadCuotas, string UserName, int IdTipoExtraLiquidacion, TimeSpan CantHs_LlevaHs, decimal Porcentaje);

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
        List<CuOtAsExtrasLiquidAcIon> obtenerCuotasExtrasLiquidacionEmpleado(int idEmpleado, DateTime mesCorrespondiente);

        /// <summary>
        /// Devuelve el identificador del empleado activo, siguiente al pasado por parametro.
        /// </summary>
        /// <param name="idEmpleado">Identificador del empleado activo anterior al solicitado</param>
        /// <returns>Retorna el identificador del proximo empleado activo al idEmpleado. Si no hay proximo retorna null</returns>
        int? obtenerProximoIdEmpleadoActivo(int idEmpleado);


        /// <summary>
        /// Devuelve el identificador del empleado activo, previo al pasado por parametro.
        /// </summary>
        /// <param name="idEmpleado">Identificador del empleado activo posterior al solicitado</param>
        /// <returns>Retorna el identificador del empleado activo previo al idEmpleado. Si no hay previo retorna null</returns>
        int? obtenerPrevioIdEmpleadoActivo(int idEmpleado);

        /// <summary>
        /// Busca todos los empleados que cumplan con el patronBusqueda en el dato CampoBusqueda
        /// </summary>
        /// <param name="CampoBusqueda">Define el atributo del Empleado por el cual buscar. Valores Posibles: TODOS, Nombre, Apellido, Documento, Telefono y Direccion</param>
        /// <param name="patronBusqueda">Define el patron de busqueda</param>
        /// <param name="incluirIncativos">True para incluir los inactivos en la busqueda.</param>
        /// <returns>Devuelve una lista de los empleados que matchean con el patron en el campo especificado.</returns>
        List<EmPleadOs> buscarEmpleados(string CampoBusqueda, string patronBusqueda, bool incluirIncativos);

        /// <summary>
        /// Cambia el Numero del Empleado identificado por el NumeroActual por el Numero NumeroEmpleadoNuevo
        /// </summary>
        /// <param name="NumeroActual">Numero Actual del Empleado al cual se le quiere cambiar el Numero</param>
        /// <param name="NumeroEmpleadoNuevo">Nuevo Nuevo del Empleado que se quiere setear</param>
        void cambiarNumeroEmpleado(int NumeroActual, int NumeroEmpleadoNuevo);
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

        #region ControlDiario
        void quitarFuncionarioControlDiario(long IdHorasGeneragasEscalafon, MotIVOsCamBiosDiARioS mtcd);
        void cambiarFuncionarioControlDiario(long IdHorasGeneragasEscalafon,int NroEmpleado, MotIVOsCamBiosDiARioS mtcd);
        void cambiarHoraFuncionarioControlDiario(long IdHorasGeneragasEscalafon,int NroEmpleado, DateTime horanueva, bool Entrada, MotIVOsCamBiosDiARioS mtcd);
        bool diaCerradoControlDiario(DateTime fecha);
        void cerrarControlDiario(DateTime fecha);
        #endregion

        #region HorasGeneradasEscalafon
        List<HoRaSGeneraDaSEScalaFOn> obtenerHorasGeneradasServicio(int NumeroCliente, int NumeroServicio, DateTime fecha);
         /// <summary>
        /// Agrega un nuevo funcionario con un horario determinado a un HorasGeneradasEscalafon de un cliente servicio de un dia determinado aplicando los controles necesarios para su alta.
        /// </summary>
        /// <param name="horaGeneradaEscalafon">La horaGeneradaEscalafon a dar de alta sin el Identificador y el Motivo.</param>
        /// <param name="motivoCambio">El MotivoCambioDiario correspondiente al motivo del cambio.</param>
        /// <returns>El Identificador del alta de HorarioEscalafonEmpleado</returns>
        long agregarEmpleadoHoraGeneradaEscalafon(HoRaSGeneraDaSEScalaFOn horaGeneradaEscalafon, MotIVOsCamBiosDiARioS motivoCambio);
        
        /// <summary>
        /// Retorna la lista de HorasGeneradasEscalafon del empledo correspondiente a la fecha fechaCorresponde
        /// </summary>
        /// <param name="nroEmpleado">Identificador del Empleado</param>
        /// <param name="fechaCorresponde">Fecha Correspondiente al dia que se quieren los datos.</param>
        /// <returns>Lista de HorasGeneradasEscalafon</returns>
        List<HoRaSGeneraDaSEScalaFOn> obtenerHorasGeneradasEscalafonEmpleado(uint nroEmpleado,DateTime fechaCorresponde);

        /// <summary>
        /// Crea los registros de HorasGeneradasEscalafon
        /// </summary>
        /// <param name="listaHorasGeneradas">Lista de HorasGeneradasEscalafon a guardar</param>
        /// <param name="sobreescribir">True para sobreescribir las Horas Generadas existentes con las nuevas.</param>
        void guardarGeneracionHorasEscalafon(List<HoRaSGeneraDaSEScalaFOn> listaHorasGeneradas, bool sobreescribir);
        
        #endregion

        #region ClientesServicios
        
        bool existeClienteServicio(int NumeroCliente, int NumeroServicio);
        int obtenerMaxIdCliente();
        string getNombreCliente(int NroCliente);
        string getNombreServicio(int NroCliente, int NroServicio);
        bool ClienteActivo(int NroCliente);
        bool esServicioActivo(int nroCliente, int nroServicio);
        
        DataFacturacion facturarClienteServicio(int NumeroCliente, int NroServicio,DateTime DiaInicioFacturacion,DateTime DiaFinFacturacion);
        
        #endregion
        
        void altaContratoServicioCliente(int NumeroCliente, int NumeroServicio, int NumeroContrato, DateTime FechaInicio, DateTime? FechaFin, bool CostoFijo, bool HorasExtras, string Ajuste, string Observaciones, float Monto);
        bool existeContrato(int NumeroContrato);
        ContraToS obtenerContrato(int NumeroContrato);
        ContraToS obtenerContrato(int NumeroCliente, int NumeroServicio);
        void modificarContrato(int numeroContrato, DateTime FechaInicial, DateTime? FechaFinal, bool Costo, bool HorasExtras, bool PagaDescanso, string Ajuste, string Observaciones, float Monto, int? PagarExtrasDespuesDeHs, bool HsExtrasDet, string[] HsExtrasPorDia);
        void altaContrato(ContraToS Contrato, List<LineAshOrAs> Lineas, HoRaSComUnescoNtRatOs HorasComunesPorDia);
        void eliminarLineasContrato(int NumeroContrato);
        void guardarLineasContrato(List<LineAshOrAs> Lineas);
        
        bool existeEmpleadoCI(string CI, out EmPleadOs empleado);
        List<ConsultAsEmPleadOs> obtenerConsultasEmpleados(bool soloactivos);
        List<ConsultAsClientEs> obtenerConsultasClientes(bool soloactivos);
        DataSet ejecutarConsultaEmpleado(int numeroConsultaEmpleado, Dictionary<string,string> parametrosConsulta);
        DataSet ejecutarConsultaCliente(int numeroConsultaCliente, Dictionary<string, string> parametrosConsulta);

        #region ListaNegra
        void altaListaNegra(string CI, string apellidos, string nombres, string motivo);
        void modificarListaNegra(string CI, string apellidos, string nombres, string motivo);
        bool existeEmpleadoListaNegra(string CI, out ListAnEGRa empleado);
        void BajaListaNegra(string CI);
        void altaEmpleadoDesdeListaNegra(string CI, string nroEmpleado, string apellidos, string nombres, string observaciones);
        #endregion

        #region TiposMotivoCambioDiario
        List<TipOsMotIVOCamBIoDiARio> obtenerTiposMotivoCambioDiario(bool soloactivos);
        void altaTipoMotivoCambioDiario(TipOsMotIVOCamBIoDiARio t);
        void modificacionTipoMotivoCambioDiario(TipOsMotIVOCamBIoDiARio t);
        void bajaTipoMotivoCambioDiario(TipOsMotIVOCamBIoDiARio t);
        #endregion

        #region MotivosCambioDiario
        /// <summary>
        /// Devuelve la lista de MotivosCambioDiarios de un empleado en determinado cliente. 
        /// </summary>
        /// <param name="numeroCliente">NumeroCliente del Cliente</param>
        /// <param name="numeroServicio">NumeroServicio del Servicio</param>
        /// <param name="numeroServicio">Numero del Empleado</param>
        /// <param name="fecha">Fecha del dia que se quiere obtener los motivos de cambios. Si es null se obtienen todos.</param>
        /// <returns>Lista de MotivosCambiosDiarios</returns>
        List<MotIVOsCamBiosDiARioS> obtenerMotivosCambiosDiarios(int? numeroCliente, int? numeroServicio, int? nroEmpleado, DateTime fecha);
        void altaMotivosCambiosDiarios(MotIVOsCamBiosDiARioS t);
        void modificacionMotivosCambiosDiarios(MotIVOsCamBiosDiARioS t);
        #endregion

        string getNombreEmpleado(int NroEmpleado);

        #region Escalafon

        /// <summary>
        /// Devuelve True si existe el escalafon para el Nro de Contrato dado.
        /// </summary>
        /// <param name="NumeroContrato">Numero del Contrato a chequear si tiene el escalafon</param>
        /// <returns>True si existe el escalafon. False en caso contrario</returns>
        bool existeEscalafon(int NumeroContrato);
        
        
        void altaEscalafon(EScalaFOn esc, List<EScalaFOneMpLeadO> lhs);
        EScalaFOn obtenerEscalafon(int NroEscalafon);
        /// <summary>
        /// Devuelve el escalafón con el identificador NroEscalafon
        /// </summary>
        /// <param name="NroEscalafon">Identificador del Escalafon a devolver</param>
        /// <param name="conAsociaciones">True: Devuelve el Escalafon con sus asociaciones. False: Devuelve sin las asociaciones.</param>
        /// <returns>Escalafon con el identificador NroEscalafon</returns>
        EScalaFOn obtenerEscalafon(int NroEscalafon, bool conAsociaciones);
        void eliminarLineasEscalafon(int NroEscalafon);
        void guardarLineasEscalafon(List<EScalaFOneMpLeadO> lineas);
        void modificarEscalafon(EScalaFOn escal);

        /// <summary>
        /// Devuelve la cantidad de Funcionarios Activos que no estan asignados a ningun servicio para la fecha dad
        /// </summary>
        /// <param name="Fecha"></param>
        /// <returns></returns>
        int obtenerCantidadFuncionariosActivosSinAsignar(DateTime Fecha);
        
        /// <summary>
        /// Cierra los escalafones de todas las fechas del rango de fecha dado.
        /// </summary>
        /// <param name="fechaDesde">Primer fecha a cerrar</param>
        /// <param name="fechaHasta">Ultima fecha a cerrar</param>
        void cerrarEscalafones(DateTime fechaDesde, DateTime fechaHasta);

        /// <summary>
        /// Devuelve True si ya esta cerrado el escalafon para la fecha
        /// </summary>
        /// <param name="fecha">Fecha a consultar</param>
        /// <returns></returns>
        bool tieneEscalafonCerrado(DateTime fecha);

        /// <summary>
        /// Devuelve true si el servicio tiene generado el escalafon para la fecha dada.
        /// </summary>
        /// <param name="NumeroCliente">Numero de Cliente</param>
        /// <param name="NumeroServicio">Numero del Servicio del Cliente</param>
        /// <param name="Fecha">Fecha a chequear si existen horasgeneradas</param>
        /// <returns>True si tiene el escalafon generado, False en caso contrario</returns>
        bool tieneEscalafonGenerado(int NumeroCliente, int NumeroServicio, DateTime Fecha);
        #endregion

        /// <summary>
        /// Recarga el Contexto del ORM
        /// </summary>
        void recargarContexto();

        List<EScalaFOneMpLeadO> getHorariosEmpleado(int NroEmpleado);

        List<HoRaRioEScalaFOn> getHorEmpleado(int NroEmpleado, string dia, int IdEscalafon);

        void SetearCubierto(int NroEscalafon, bool ContCubierto);

        void SustituirEmpleado(int NroNuevoEmpleado, int NroViejoEmpleado);

        void MarcarSolapados(List<HoRaRioEScalaFOn> HorsSolapados);

        
        void MarcarNoSolapados(List<HoRaRioEScalaFOn> HorsNOSolap);

        List<HoRaRioEScalaFOn> getHorariosEmpleadoDia(int NroEmpleado, string dia, int IdEscalafon);

       

        #region Usuarios
        /// <summary>
        /// Realiza el logueo de un usuario
        /// </summary>
        /// <param name="UserName">Nombre de Usuario</param>
        /// <param name="Password">Contrasena del Usuario</param>
        /// <returns>IdUsuario del Usuario logueado.</returns>
        UsUarIoS login(string UserName, string Password);

        /// <summary>
        /// Realiza el logout del usuario logueado.
        /// </summary>
        void logout();

        /// <summary>
        /// Devuelve el IdUsuario del Usuario Logueado. Si no hay ningun usuario logueado lanza una excepcion.
        /// </summary>
        /// <returns>IdUsuario del Usuario logueado.</returns>
        int obtenerIdUsuarioLogueado();

        /// <summary>
        /// Realiza el cambio de Contrasena del Usuario con identificado IdUsuario.
        /// </summary>
        /// <param name="IdUsuario">Identificador del Usuario</param>
        /// <param name="NewPassword">Contrasena nueva</param>
        /// <param name="OldPassword">Contrasena actual</param>
        /// <param name="force">Boolean. Si es True, no se chequea que la OldPassword sea igual a la que esta en la BD</param>
        void cambiarPasswordUsuario(int IdUsuario, string NewPassword, string OldPassword, bool force);
        #endregion

        #region PermisosUsuarios_PantallasWinForms_PermisoControl
        /// <summary>
        /// Devuelve una Lista de PantallaWinForm
        /// </summary>
        /// <param name="soloactivos">Si es True, solo devuelve las Activas, de lo contrario devuelve todas.</param>
        /// <returns></returns>
        List<PantAllAwInForm> obtenerPantallasWinForms(bool soloactivos);
        
        #endregion

        #region LiquidacionEmpleados
        void LiquidarEmpleados(DateTime inicio, DateTime fin);

        void empleadosLiquidados(out DataTable empleados);

        /// <summary>
        /// Guarda los Clientes y Empleados seleccionados a los que se agregara Hs Comunes adicionales.
        /// </summary>
        /// <param name="lista">Lista de HsComunesAdicionalesLiquidacionEmpleado a guardar.</param>
        void guardarHsComunesAdicionalesLiquidacionEmpleados(List<HsComUnEsAdICIonAleSLiquidAcIonEmPleadO> lista);

        /// <summary>
        /// Devuelve la lista de Clientes y/o empleados con HsAdicionalesComunes seleccionados. Si los valores pasados son null, devuelve todos, sino devuelve los que cumplan con los valores pasados.
        /// </summary>
        /// <param name="ClienteOEmpleado">Valores posibles "CLIENTE", "EMPLEADO" o null. Si es null se devuelven todos.</param>
        /// <param name="ValorClienteEmpleado">Valores posibles "NroCliente - NroServicio" si es CLIENTE, "NroEmpleado" si es EMPLEADO o null. Si es null se devuelven todos.</param>
        /// <returns>Una lista de un elemento o vacia para el caso de parametros no null. Lista de elemenos para null, null</returns>
        List<HsComUnEsAdICIonAleSLiquidAcIonEmPleadO> obtenerHsComunesAdicionalesLiquidacionEmpleados(String ClienteOEmpleado, String ValorClienteEmpleado);
        #endregion
        TipOscarGoS obtenerCargo(int idCargo);

        List<DateTime> ObtenerFeriados();

        List<DataDiaFacturacion> LiquidarUnEmpleado(EmPleadOs empleado, TipOscarGoS tc);

        bool existeEmpleadoLiquidado(int NroEmpleado);

        DataEmpleadoExLiquidacion obtenerExLiquidacionEmpleado(int NroEmpleado, DateTime Mes);

        //List<MotIVOsCamBiosDiARioS> obtenerMotivosCambiosDiarios2(int NroEmpleado, DateTime Fecha);

        List<int> obtenerObsCambios(int NroEmpleado, DateTime Mes);

        DataEventosHE obtenerEventosHistEmpleado(int NroEmpleado, DateTime Mes);

        List<HoRaSGeneraDaSEScalaFOn> obtenerDescansos(int NroEmpleado, DateTime Mes);

        void CalcularDescansos();

        HoRaSComUnescoNtRatOs obtenerHorasExtrasContrato(uint IdContrato);
    }
}
