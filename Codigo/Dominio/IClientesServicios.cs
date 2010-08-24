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
        void altaCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja);
        void modificarCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja);
        //void bajaCliente(int idcliente);
        //List<Cliente> busquedaClientePorNombre(string nom);
        bool existeCliente(int idcliente);
        Cliente obtenerCliente(int idcliente);
        //List<Cliente> obtenerClientes(bool activos);
        
        #endregion

        
        #region Servicios
        //// Servicios
        void altaServicioCliente(int numeroCliente, int numeroServicio, string nombre,string direccion, string telefonos, string personaContacto, string email, string celular, string celularTrust, string tareasAsignadas, string DiaDeCobro, string NombreCobrar);//, bool activo);
        Servicio obtenerServicioCliente(int numeroCliente, int numeroServicio);
        void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string DiaDeCobro, string NombreCobrar);
        
        //void bajaServicioCliente(int numCliente, int numServicio);                
        //List<Servicio> busquedaServicioClientePorNombre(int numCliente, string wildcardNombre);        
        //List<Servicio> obtenerServiciosCliente(int numCliente); 
        
        #endregion



        List<Cliente> buscarCliente(string Nombre);
        
        bool existeClienteServicio(int NumeroCliente, int NumeroServicio);

        void altaContratoServicioCliente(int NumeroCliente, int NumeroServicio, int NumeroContrato, DateTime FechaInicio, DateTime? FechaFin, bool CostoFijo, bool HorasExtras, string Ajuste, string Observaciones, float Monto);

        bool existeContrato(int NumeroContrato);

        void altaContrato(int NumeroContrato, ConSeguridadFisica contrato);

        ConSeguridadFisica getContrato(int NumeroContrato);

        void modificarContrato(int NumeroContrato, ConSeguridadFisica Contrato);

        void altaEscalafon(int numCli, int numSer, int nroCon, Escalafon es);

        void modificarEscalafon(int nroCon, Escalafon es);

        Escalafon getEscalafon(int nroEsc);
    }
}
