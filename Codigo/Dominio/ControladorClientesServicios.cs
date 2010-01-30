using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
    public class ControladorClientesServicios : IClientesServicios
    {

        private static ControladorClientesServicios instancia = null;
        private IDatos datos;

        private ControladorClientesServicios()
        {
            try
            {
                datos = ControladorDatos.getInstance();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ControladorClientesServicios getInstance()
        {
            if (instancia == null)
                instancia = new ControladorClientesServicios();
            return instancia;
        }

        public void altaCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime fecAlta, DateTime fecBaja, string motivo)
        {
            try
            {
                datos.altaCliente(num, nom, nomFant, rut, email, dir, dirCobro, telefono, fax, activo, fecAlta, fecBaja, motivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool existeCliente(int idcliente)
        {
            try
            {
                return datos.existeCliente(idcliente);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void modificarCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime fecAlta, DateTime fecBaja, string motivo)
        {
            try
            {
                datos.modificarCliente(num, nom, nomFant, rut, email, dir, dirCobro, telefono, fax, activo, fecAlta, fecBaja, motivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void bajaCliente(int idcliente)
        {
        }

        public List<Cliente> busquedaClientePorNombre(string nom)
        {
            return new List<Cliente>();
        }

        public Cliente obtenerCliente(int idcliente)
        {
            try
            {
                ClientEs c = datos.obtenerCliente(idcliente);
                Cliente cli = convertClienteDatosToClienteLogica(c);
                return cli;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Cliente> obtenerClientes(bool activos)
        {
            return new List<Cliente>();
        }
        
        public Servicio obtenerServicioCliente(int numeroCliente, int numeroServicio)
        {
            try
            {
                Servicio serv = null;
                List<SERVicIoS> cliServiciosDatos = datos.obtenerServiciosCliente(numeroCliente);
                foreach(SERVicIoS s in cliServiciosDatos)
                {
                    if (s.NumeroServicio == numeroServicio)
                        serv = convertServicioDatosToServicioLogica(s);
                }
                return serv;
            }catch(Exception e)
            {
                throw e;
            }
        }


        private Cliente convertClienteDatosToClienteLogica(ClientEs cliDatos)
        {
            List<SERVicIoS> cliServiciosDatos = datos.obtenerServiciosCliente((int)cliDatos.NumeroCliente);
            List<Servicio> listServs = new List<Servicio>();
            bool act;
            Servicio servicio;
            foreach(SERVicIoS ser in cliServiciosDatos)
            {
                servicio = convertServicioDatosToServicioLogica(ser);
                listServs.Add(servicio);
            }
            if (cliDatos.Activo == 1)
                act = true;
            else
                act = false;

            Cliente tdcli = new Cliente((int)cliDatos.NumeroCliente, cliDatos.Nombre, cliDatos.NombreFantasia, cliDatos.Rut, cliDatos.Email, cliDatos.Direccion, cliDatos.DireccionDeCobro, cliDatos.Telefonos, cliDatos.Fax, act, (DateTime)cliDatos.FechaAlta, (DateTime)cliDatos.FechaBaja, cliDatos.MotivoBaja, listServs);
            return tdcli;
        }

        private Servicio convertServicioDatosToServicioLogica(SERVicIoS ser)
        {
         
            Servicio servicio;
            bool act;
            try
             {
                if (ser.Activo == 1)
                        act = true;
                    else
                        act = false;
                    servicio = new Servicio((int)ser.NumeroServicio, ser.Nombre, ser.Direccion, ser.Telefonos, ser.PersonaContacto, ser.Email, ser.Celular, ser.CelularTrust, ser.TareasAsignadas, act, (DateTime) ser.FechaAlta, (DateTime)ser.FechaBaja, ser.MotivoBaja);
                    return servicio;
             }catch(Exception ex)
             {
                 throw ex;
             }
        }

        public void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas)
        {
            try
            {
                datos.altaServicioCliente(numeroCliente, numeroServicio, Nombre, Direccion, Telefonos, Contacto, email, Celular, CelularTrust, Tareas);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas)
        {
            try
            {
                datos.modificarServicioCliente(numeroCliente, numeroServicio, Nombre, Direccion, Telefonos, Contacto, email, Celular, CelularTrust, Tareas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public List<Cliente> buscarCliente(string Nombre)
        {
            try
            {
                Cliente cli = null;
                List<Cliente> clientes = new List<Cliente>();
                List<ClientEs> clies = datos.buscarClientes(Nombre);
                foreach (ClientEs c in clies)
                {
                    cli = convertClienteDatosToClienteLogica(c);
                    clientes.Add(cli);                        
                }
                return clientes;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }



        


        public bool existeClienteServicio(int NumeroCliente, int NumeroServicio)
        {
            try
            {
                return datos.existeClienteServicio(NumeroCliente, NumeroServicio);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
    }
}
