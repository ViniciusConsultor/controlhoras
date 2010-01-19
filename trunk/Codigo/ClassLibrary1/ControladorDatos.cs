using System;
using System.Collections.Generic;
using System.Linq;
using ALinq;
using ALinq.MySQL;
using System.Text;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ControladorDatos
    {
        private DataContext conexion = null;
        private static ControladorDatos instance = null;


        private ControladorDatos()
        {
            try
            {
                conexion = getConexion();
                conexion.Connection.Open();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me.Message);
            }
        }
        
        public static ControladorDatos getInstance()
        {
            if (instance == null)
                instance = new ControladorDatos();
            return instance;
        }

        

        public ALinq.DataContext getConexion()
        {
            var builder = new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Port = 3306,
                UserID = "jgarat",
                Password = "jgarat",
                Database = "trustdb"
            };
            var conn = new MySqlConnection(builder.ToString());
            var context = new ALinq.DataContext(conn,
                                        typeof(ALinq.MySQL.MySqlProvider));

            return context;
        }


        public void addCliente(int numCliente, string nombre, string nomFantasia, string rut, string email, string dir, string dirCobro, string tels, string fax, bool activo)
        {
            Table<Cliente> tablaCliente = conexion.GetTable<Cliente>();
            
            var cliente = new Cliente();
            cliente.NumeroCliente = numCliente;
            cliente.Nombre = nombre;
            cliente.NombreFantasia = nomFantasia;
            cliente.RUT = rut;
            cliente.Email = email;
            cliente.Direccion = dir;
            cliente.DireccionDeCobro = dirCobro;
            cliente.Telefonos = tels;
            cliente.Fax = fax;
            if (activo == true)
                cliente.Activo = 0;
            else
                cliente.Activo = 1;

            tablaCliente.InsertOnSubmit(cliente);

            try
            {
                conexion.SubmitChanges();
            }
            catch (MySqlException me)
            {
                throw me;
            }
        }

        public void modifyCliente(int numCliente, string nombre, string nomFantasia, string rut, string email, string dir, string dirCobro, string tels, string fax, bool activo)
        {
            try
            {
                Cliente cli = (from c in conexion.GetTable<Cliente>()
                               where c.NumeroCliente == numCliente
                               select c).Single<Cliente>();
                cli.Nombre = nombre;
                cli.NombreFantasia = nomFantasia;
                cli.RUT = rut;
                cli.Email = email;
                cli.Direccion = dir;
                cli.DireccionDeCobro = dirCobro;
                cli.Telefonos = tels;
                cli.Fax = fax;
                if (activo)
                    cli.Activo = 0;
                else
                    cli.Activo = 1;

                conexion.SubmitChanges();

            }
            catch (MySqlException me)
            {
                throw me;
            }
        }

        public List<Cliente> obtenerClientes()
        {
            List<Datos.Cliente> listClientes = new List<Cliente>();
            
            try
            {
                Table<Cliente> tablaCliente = conexion.GetTable<Cliente>();
                var lclientes = from cli in tablaCliente
                                select cli;
                foreach (Cliente cli in lclientes)
                    listClientes.Add(cli);
                return listClientes;
            }
            catch (MySqlException me)
            {
                throw me;
            }
        }
    }
}