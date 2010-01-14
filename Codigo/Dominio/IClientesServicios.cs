using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    interface IClientesServicios
    {
        #region Clientes
        // Clientes
        int altaCliente();
        void modificacionCliente();
        void bajaCliente();
        void busquedaCliente();
        List<Cliente> obtenerClientes();
        
        #endregion

        #region Servicios
        // Servicios
        int altaServicio();
        void bajaServicio();
        void modificacionServicio();
        void busquedaServicio();
        List<Servicio> obtenerServicios(); 
        #endregion
    }
}
