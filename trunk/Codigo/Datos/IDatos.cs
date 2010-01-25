using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public interface IDatos
    {
        void altaCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime fecAlta, DateTime fecBaja, string motivo);
        //void modificarCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime fecAlta, DateTime fecBaja, string motivo);
        //void bajaCliente(int idcliente);
        //List<Cliente> busquedaClientePorNombre(string nom);
        bool existeCliente(int numCliente);
        ClientEs obtenerCliente(int idcliente);
        //List<Cliente> obtenerClientes(bool activos);

        void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas);
        List<SERVicIoS> obtenerServiciosCliente(int numCliente);
    }
}
