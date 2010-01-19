using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Dominio
{
    public class Controlador
    {
        private static Controlador controller = null;
        private List<Cliente> Clientes;

        private Datos.ControladorDatos datos = ControladorDatos.getInstance();

        //private List<Funcionario> Funcionarios;


        private Controlador()
        {
            Clientes = new List<Cliente>();
            //Funcionarios = new List<Empleado>();

            insertarClientes();
            //insertarFuncionarios();
            
        }

        public static Controlador getControlador()
        {
            if (controller == null)
                controller = new Controlador();
            return controller;
        }

        //public List<Funcionario> obtenerFuncionariosControlDiaClienteServicio(int idCliente, int idServicio, DateTime fecha)
        //{
        //    List<Funcionario> listFuncs = new List<Funcionario>();
        //    List<DiaPlanificacion> listdp = new List<DiaPlanificacion>();
        //    foreach (Funcionario f in obtenerListaFuncionarios())
        //    {
        //        listdp = f.obtenerPlanificacionFuncionarioServicioDia(idCliente, idServicio, fecha);
        //        if (listdp.Count() > 0)
        //            listFuncs.Add(f);
        //    }

        //    return listFuncs;

        //}

        private void insertarClientes()
        {
            Cliente nuevo = new Cliente(1000, "Cliente1");
            Servicio s = new Servicio(0, 1000, "Servicio1-1");
            nuevo.addServicio(s);
            s = new Servicio(1, 1000, "Servicio1-2");
            nuevo.addServicio(s);
            Clientes.Add(nuevo);

            nuevo = new Cliente(1001, "Cliente2");
            s = new Servicio(0, 1001, "Servicio2-1");
            nuevo.addServicio(s);
            s = new Servicio(1, 1002, "Servicio2-2");
            nuevo.addServicio(s);
            Clientes.Add(nuevo);

            nuevo = new Cliente(1002, "Cliente3");
            s = new Servicio(0, 1002, "Servicio3-1");
            nuevo.addServicio(s);
            s = new Servicio(1, 1002, "Servicio3-2");
            Clientes.Add(nuevo);
            nuevo.addServicio(s);
        }

//        private void insertarFuncionarios()
//        {
//            Funcionario fun = new Funcionario(0001, "Jose", "Perez", "12345678");
///*            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now, "08:00", "18:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(1), "08:00", "18:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(2), "08:00", "18:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(3), "08:00", "18:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(4), "08:00", "18:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(5), "08:00", "18:00");
//  */          Funcionarios.Add(fun);

//            fun = new Funcionario(0002, "Pedro", "Romani", "12345678");
// /*           fun.agregarDiaPlanificacion(1000, 0, DateTime.Now, "08:00", "12:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(1), "08:00", "12:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(2), "08:00", "12:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(3), "08:00", "12:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(4), "08:00", "12:00");
//            fun.agregarDiaPlanificacion(1000, 0, DateTime.Now.AddDays(5), "08:00", "12:00");
//   */         Funcionarios.Add(fun);

//            fun = new Funcionario(0003, "Juan", "Solari", "12345678");
//            Funcionarios.Add(fun);

//            fun = new Funcionario(0004, "Jorge", "Perrune", "12345678");
//            Funcionarios.Add(fun);

//            fun = new Funcionario(0005, "Roberto", "Simpson", "12345678");
//            Funcionarios.Add(fun);

//            fun = new Funcionario(0006, "Martin", "Gonzalez", "12345678");
//            Funcionarios.Add(fun);

//            fun = new Funcionario(0007, "Rodrigo", "Fernandez", "12345678");
//            Funcionarios.Add(fun);

//            fun = new Funcionario(0008, "Pablo", "Nuñez", "12345678");
//            Funcionarios.Add(fun);

//        }

        public Cliente obtenerCliente(int numCliente){
            foreach(Cliente c in Clientes)
            {
                if (c.getNumero() == numCliente)
                    return c;               
            }
            return null;
        }

        public Servicio obtenerServicioCliente(int numCliente, int numServicio)
        {
            foreach(Cliente c in Clientes)
            {
                if (c.getNumero()==numCliente)
                {
                    List<Servicio> ser = c.getListaServicios();
                    foreach(Servicio s in ser)
                    {
                        if (s.getNumero()==numServicio)
                            return s;
                    }
                }
            }
            return null;
        }

        //public Funcionario obtenerFuncionario(int numFun)
        //{
        //    foreach (Funcionario f in Funcionarios)
        //    {
        //        if (f.getNumero() == numFun)
        //            return f;
        //    }
        //    return null;
        //}

        //public List<Funcionario> obtenerListaFuncionarios()
        //{
        //    return Funcionarios;
        //}

        public List<Cliente> obtenerListaClientes()
        {
            List<Cliente> listClientes = new List<Cliente>();
            try
            {
                foreach (Datos.Cliente clidb in datos.obtenerClientes())
                {
                    Cliente newcli = new Cliente(clidb.NumeroCliente, clidb.Nombre, clidb.RUT, clidb.Telefonos);
                    listClientes.Add(newcli);
                }
                return listClientes;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void addCliente(int numero, string nombre, string nombreFant, string RUT, string email, string dir, string dirCobro, string telefonos, string fax)
        {
            //Cliente cli = new Cliente(numero, nombre, RUT, telefonos);
            //Clientes.Add(cli);
            nombreFant = "Fantasia"+nombre;
            email = "noemail@dominio.com";
            dir = "nodireccion";
            dirCobro = "noDirCobro";
            fax = "00000000";
            try
            {
                datos.addCliente(numero, nombre, nombreFant, RUT, email, dir, dirCobro, telefonos, fax, true);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void modificarCliente(int numero, string nombre, string nombreFant, string RUT, string email, string dir, string dirCobro, string telefonos, string fax)
        {
            nombreFant = "FantasiaModif" + nombre;
            email = "noemail@dominio.com";
            dir = "nodireccionModif";
            dirCobro = "noDirCobroModif";
            fax = "000000001";
            try
            {
                datos.modifyCliente(numero, nombre, nombreFant, RUT, email, dir, dirCobro, telefonos, fax, true);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void addServicio(int numCli, int numSer, string nombre, string dir, string tel, string con, string mail, string cel, string celt, string tareas)
        {
            Cliente cli = obtenerCliente(numCli);
            Servicio ser = new Servicio(numSer, nombre, dir, tel, con, mail, cel, celt, tareas);
            cli.addServicio(ser);
        }       

    }
}
