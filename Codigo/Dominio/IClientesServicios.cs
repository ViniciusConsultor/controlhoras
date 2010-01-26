﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IClientesServicios
    {
        #region Clientes
        // Clientes
        void altaCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime fecAlta, DateTime fecBaja, string motivo);
        //void modificarCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime fecAlta, DateTime fecBaja, string motivo);
        //void bajaCliente(int idcliente);
        //List<Cliente> busquedaClientePorNombre(string nom);
        bool existeCliente(int idcliente);
        Cliente obtenerCliente(int idcliente);
        //List<Cliente> obtenerClientes(bool activos);
        
        #endregion

        Servicio obtenerServicioCliente(int numeroCliente, int numeroServicio);
        //#region Servicios
        //// Servicios
        void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre,string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas);
        //void bajaServicioCliente(int numCliente, int numServicio);
        //void modificacionServicioCliente(int numCliente, int numServicio);
        //List<Servicio> busquedaServicioClientePorNombre(int numCliente, string wildcardNombre);
        //Servicio obtenerServicioCliente(int numCliente, int numServicio);
        //List<Servicio> obtenerServiciosCliente(int numCliente); 
        //#endregion
    }
}