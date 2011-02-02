using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IClientesServicios
    {
        #region Clientes
        // Clientes
        void altaCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja, string referencia, string diaHoraCobro, string contactoCobro, string telefonosCobro);
        void modificarCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja, string referencia, string diaHoraCobro, string contactoCobro, string telefonosCobro);
        //void bajaCliente(int idcliente);
        //List<Cliente> busquedaClientePorNombre(string nom);
        bool existeCliente(int idcliente);
        Cliente obtenerCliente(int idcliente);
        //List<Cliente> obtenerClientes(bool activos);
        
        #endregion

        
        #region Servicios
        //// Servicios
        void altaServicioCliente(int numeroCliente, int numeroServicio, string nombre,string direccion, string telefonos, string personaContacto, string email, string celular, string celularTrust, string tareasAsignadas, string observaciones, bool activo, DateTime? FechaBaja, string MotivoBaja);
        Servicio obtenerServicioCliente(int numeroCliente, int numeroServicio);
        void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string observaciones, bool activo, DateTime? FechaBaja, string MotivoBaja);
        
        //void bajaServicioCliente(int numCliente, int numServicio);                
        //List<Servicio> busquedaServicioClientePorNombre(int numCliente, string wildcardNombre);        
        //List<Servicio> obtenerServiciosCliente(int numCliente); 
        
        #endregion



        List<Cliente> buscarCliente(string Nombre);
        
        bool existeClienteServicio(int NumeroCliente, int NumeroServicio);

        void altaContratoServicioCliente(int NumeroCliente, int NumeroServicio, int NumeroContrato, DateTime FechaInicio, DateTime? FechaFin, bool CostoFijo, bool HorasExtras, string Ajuste, string Observaciones, float Monto);

        bool existeContrato(int NumeroContrato);

        void altaContrato(int NumeroContrato, ConSeguridadFisica contrato);

        int CalcNroContrato(int nroCliente, int nroServicio);

        ConSeguridadFisica getContrato(int NumeroContrato);

        void modificarContrato(int NumeroContrato, ConSeguridadFisica Contrato);

        void altaEscalafon(int numCli, int numSer, int nroCon, Escalafon es);

        void modificarEscalafon(int nroCon, Escalafon es);

        Escalafon getEscalafon(int nroEsc);

        bool EsHorarioSolapado(int IdEscalafon, int NroEmpleado, string dia, string HoraIni, string HoraFin);

        bool SustituirEmpleadoEnEscalafon(int NroNuevoEmpleado, int NroViejoEmpleado);

        void marcarSolapados(int NroEscalafon, Escalafon EscSolapados);

        
        #region GeneracionHorasDiarias
        /// <summary>
        /// Inicia una generacion de horas. Finalizar invocando finalizarGeneracionHoras
        /// </summary>
        void iniciarGeneracionHoras();

        /// <summary>
        /// Finaliza la generacion de Horas.
        /// </summary>
        /// <param name="commit">True para confirmar OK la generacion de Horas, false para Cancelar (Rollback)</param>
        /// <param name="sobreescribir">True para sobreescribir las Horas Generadas existentes en el periodo.</param>
        void finalizarGeneracionHoras(bool commit, bool sobreescribir);

        /// <summary>
        /// Genera los registros de HorasGeneradasEscalafon para un determinado servicio.
        /// </summary>
        /// <param name="NumeroCliente">NumeroCliente del cliente a generar.</param>
        /// <param name="NumeroServicio">NumeroServicio del servicio a generar.</param>
        /// <param name="Fecha">Fecha a Generar.</param>
        /// <param name="ForzarGeneracion">Si es true, se fuerza la generacion. Si es true y ya existen horasgeneradas para el Cliente-Servicio en la fecha dada, lo pasa por arriba.</param>
        void generarHorasDiaServicio(int NumeroCliente, int NumeroServicio, DateTime Fecha, bool ForzarGeneracion);

        #endregion

        #region Consolidacion
        /// <summary>
        /// Aplica un conjunto de controles del Escalafon planificado en el servicio.
        /// </summary>
        /// <param name="NumeroCliente">Numero de Cliente del Servicio.</param>
        /// <param name="NumeroServicio">Numero de Servicio a controlar.</param>
        /// <returns>Devuelve una lista de errores en caso de que hubiesen. Si no hay, devuelve null.</returns>
        List<string> ejecutarControlesEscalafonServicio(int NumeroCliente, int NumeroServicio);

        /// <summary>
        /// Aplica un conjunto de controles a todos los empleados que se encuentran en el Escalafon del Servicio.
        /// </summary>
        /// <param name="NumeroCliente">Numero de Cliente del Servicio.</param>
        /// <param name="NumeroServicio">Numero de Servicio a controlar.</param>
        /// <returns>Devuelve una lista de errores en caso de que hubiesen. Si no hay, devuelve null.</returns>
        List<string> ejecutarControlesEscalafonEmpleado(int NumeroCliente, int NumeroServicio);
        #endregion
    }
}
