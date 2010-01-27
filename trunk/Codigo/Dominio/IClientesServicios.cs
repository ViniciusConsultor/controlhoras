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
        void altaCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime fechaAlta, DateTime fechaBaja, string motivoBaja);
        void modificarCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime fechaAlta, DateTime fechaBaja, string motivoBaja);
        //void bajaCliente(int idcliente);
        //List<Cliente> busquedaClientePorNombre(string nom);
        bool existeCliente(int idcliente);
        Cliente obtenerCliente(int idcliente);
        //List<Cliente> obtenerClientes(bool activos);
        
        #endregion

        
        #region Servicios
        //// Servicios
        void altaServicioCliente(int numeroCliente, int numeroServicio, string nombre,string direccion, string telefonos, string personaContacto, string email, string celular, string celularTrust, string tareasAsignadas);//, bool activo);
        Servicio obtenerServicioCliente(int numeroCliente, int numeroServicio);
        void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas);
        
        //void bajaServicioCliente(int numCliente, int numServicio);                
        //List<Servicio> busquedaServicioClientePorNombre(int numCliente, string wildcardNombre);        
        //List<Servicio> obtenerServiciosCliente(int numCliente); 
        
        #endregion

        
    }
}
