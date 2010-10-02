using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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
        void altaCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja);
        void modificarCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja);
        //void bajaCliente(int idcliente);
        //List<Cliente> busquedaClientePorNombre(string nom);
        bool existeCliente(int numCliente);
        ClientEs obtenerCliente(int idcliente);
        List<ClientEs> obtenerClientes(bool soloActivos);
        List<ClientEs> buscarClientes(string Nombre);
        #endregion

        #region Operaciones_De_Servicios
        void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string DiaDeCobro, string NombreCobrar);
        List<SERVicIoS> obtenerServiciosCliente(int numeroCliente);
        SERVicIoS obtenerServicioCliente(int numeroCliente, int numeroServicio);
        void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string DiaDeCobro, string NombreCobrar);
        #endregion

        #region Operaciones_De_Empleados
        bool existeEmpleado(int idEmpleado);
        void altaEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, char sexo, DateTime? fechaPsicologo, DateTime? fechaNacimiento, int edad, DateTime? fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadMenoresACargo, byte[] foto, float valorHora, bool activo, DateTime? fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, int ciudad, int barrio, string codigoPostal, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime? fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime? fechaAltaBPS, bool bajaBPS, DateTime? fechaBajaBPS, string numeroCAJ, DateTime? fechaEmisionCAJ, DateTime? fechaEntregaCAJ, bool antecedentesEmpleado, string observacionesAntecedentesEmpleado, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime? fechaIngresoAntecedete, DateTime? fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime? vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica, bool capacitadoPorteArma, bool enservicioArmado, string observacionesEmpleado, string nivelEducativo, int idCargo, DateTime? fechaPagoEfectuado, DateTime? fechaPrevistaPago, String servicioActual, string turno, bool ConstanciaDomicilio, DateTime? FechaEntregaCelular);
        void modificarEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, char sexo, DateTime? fechaPsicologo, DateTime? fechaNacimiento, int edad, DateTime? fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadMenoresACargo, byte[] foto, float valorHora, bool activo, DateTime? fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, int ciudad, int barrio, string codigoPostal, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime? fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime? fechaAltaBPS, bool bajaBPS, DateTime? fechaBajaBPS, string numeroCAJ, DateTime? fechaEmisionCAJ, DateTime? fechaEntregaCAJ, bool antecedentesEmpleado, string observacionesAntecedentesEmpleado, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime? fechaIngresoAntecedete, DateTime? fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime? vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica, bool capacitadoPorteArma, bool enservicioArmado, string observacionesEmpleado, string nivelEducativo, int idCargo, DateTime? fechaPagoEfectuado, DateTime? fechaPrevistaPago, String servicioActual, string turno, bool ConstanciaDomicilio, DateTime? FechaEntregaCelular);
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
        /// <param name="CampoBusqueda">Define el atributo del Empleado por el cual buscar. Valores Posibles: Nombre, Apellido, Documento, Telefono y Direccion</param>
        /// <param name="patronBusqueda">Define el patron de busqueda</param>
        /// <returns>Devuelve una lista de los empleados que matchean con el patron en el campo especificado.</returns>
        List<EmPleadOs> buscarEmpleaos(string CampoBusqueda, string patronBusqueda);

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

        #region HorasGeneradasEscalafon
        List<HoRaSGeneraDaSEScalaFOn> obtenerHorasGeneradasServicio(int NumeroCliente, int NumeroServicio, DateTime fecha);
        void cambiarFuncionarioControlDiario(long IdHorasGeneragasEscalafon, int NroEmpleado, MotIVOsCamBiosDiARioS mtcd);
        void cambiarHoraFuncionarioControlDiario(long IdHorasGeneragasEscalafon, int NroEmpleado, string horanueva, bool Entrada, MotIVOsCamBiosDiARioS mtcd);
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
        #endregion

        bool existeClienteServicio(int NumeroCliente, int NumeroServicio);

        void altaContratoServicioCliente(int NumeroCliente, int NumeroServicio, int NumeroContrato, DateTime FechaInicio, DateTime? FechaFin, bool CostoFijo, bool HorasExtras, string Ajuste, string Observaciones, float Monto);
        bool existeContrato(int NumeroContrato);
        ContraToS obtenerContrato(int NumeroContrato);
        ContraToS obtenerContrato(int NumeroCliente, int NumeroServicio);
        void modificarContrato(int numeroContrato, DateTime FechaInicial, DateTime? FechaFinal, bool Costo, bool HorasExtras, string Ajuste, string Observaciones, float Monto);
        void altaContrato(ContraToS Contrato, List<LineAshOrAs> Lineas);
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

        int obtenerMaxIdCliente();

        #region TiposMotivoCambioDiario
        List<TipOsMotIVOCamBIoDiARio> obtenerTiposMotivoCambioDiario();
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
        List<MotIVOsCamBiosDiARioS> obtenerMotivosCambiosDiarios(int numeroCliente, int numeroServicio, int nroEmpleado, DateTime fecha);
        void altaMotivosCambiosDiarios(MotIVOsCamBiosDiARioS t);
        void modificacionMotivosCambiosDiarios(MotIVOsCamBiosDiARioS t);
        #endregion
        bool existeEscalafon(int nroCon);

        void altaEscalafon(EScalaFOn esc, List<EScalaFOneMpLeadO> lhs);

        string getNombreEmpleado(int NroEmpleado);

        string getNombreCliente(int NroCliente);

        string getNombreServicio(int NroServicio);

        EScalaFOn obtenerEscalafon(int NroEscalafon);

        void eliminarLineasEscalafon(int NroEscalafon);

        void guardarLineasEscalafon(List<EScalaFOneMpLeadO> lineas);
        void modificarEscalafon(EScalaFOn escal);

        /// <summary>
        /// Recarga el Contexto del ORM
        /// </summary>
        //public void recargarContexto();

        List<EScalaFOneMpLeadO> getHorariosEmpleado(int NroEmpleado);

        List<HoRaRioSEmPleadOs> getHorEmpleado(int NroEmpleado, string dia, int IdEscalafon);

        bool ClienteActivo(int NroCliente);

        void SetearCubierto(int NroEscalafon, bool ContCubierto);

        void SustituirEmpleado(int NroNuevoEmpleado, int NroViejoEmpleado);

        void MarcarSolapados(List<HoRaRioEScalaFOn> HorsSolapados);

        /// <summary>
        /// Crea los registros de HorasGeneradasEscalafon
        /// </summary>
        /// <param name="listaHorasGeneradas">Lista de HorasGeneradasEscalafon a guardar</param>
        /// <param name="sobreescribir">True para sobreescribir las Horas Generadas existentes con las nuevas.</param>
        void guardarGeneracionHorasEscalafon(List<HoRaSGeneraDaSEScalaFOn> listaHorasGeneradas, bool sobreescribir);

        void altaHorEmpleado(HoRaRioSEmPleadOs horario);


        HoRaRioEScalaFOn getHorario(HoRaRioSEmPleadOs h);

        void MarcarNoSolapados(List<HoRaRioEScalaFOn> HorsNOSolap);

        List<HoRaRioEScalaFOn> getHorariosEmpleadoDia(int NroEmpleado, string dia, int IdEscalafon);
    }
}
