using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbLinq;
using DbLinq.MySql;
using DbLinq.Data.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using Excepciones;

namespace Datos
{
    public class ControladorDatos : IDatos
    {
        private TrustDb database = null;
        private static IDatos instance = null;


        private ControladorDatos()
        {
            database = getConexion();

            // MySqlConnection myconn; 
            //while (true)
            //{
            // var builder = new MySqlConnectionStringBuilder()
            //  {
            //      Server = "localhost",
            //      Port = 3306,
            //      UserID = "jgarat",
            //      Password = "jgarat",
            //      Database = "trustdb"
            //  };
            // try
            // {
            //     myconn = new MySqlConnection(builder.ConnectionString.ToString());
            //     myconn.Open();
            //     System.Console.WriteLine("Se conecto!!!!!");
            //     myconn.Close();
            // }
            // catch (MySqlException myex)
            // {
            //     System.Console.WriteLine(myex.Message);
            //     System.Console.WriteLine(myex.InnerException.ToString());
            // }
            //}


        }

        public static IDatos getInstance()//(string StringConnection)
        {
            if (instance == null)
                instance = new ControladorDatos(); //(string StringConnection)
            return instance;
        }



        public TrustDb getConexion()//(string StringConnection)
        {
            var builder = new MySqlConnectionStringBuilder() //(StringConnection)
            {
                Server = "localhost",
                Port = 3306,
                UserID = "root",
                Password = "desdere",
                Database = "trustdb",
                Pooling = true,
                MinimumPoolSize = 5,
                MaximumPoolSize = 20,
                ConnectionLifeTime = 0
            };

            var conn = new MySqlConnection(builder.ToString());
            TrustDb context = new TrustDb(conn, new DbLinq.MySql.MySqlVendor());
            return context;
        }


        public void altaCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime fecAlta, DateTime fecBaja, string motivo)
        {
            ClientEs cliente = null;
            DbLinq.Data.Linq.Table<ClientEs> tablaCliente;
            try
            {
                tablaCliente = database.GetTable<ClientEs>();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            try
            {
                cliente = new ClientEs();
                cliente.NumeroCliente = (uint)num;
                cliente.Nombre = nom;
                cliente.NombreFantasia = nomFant;
                cliente.Rut = rut;
                cliente.Email = email;
                cliente.Direccion = dir;
                cliente.DireccionDeCobro = dirCobro;
                cliente.Telefonos = telefono;
                cliente.Fax = fax;
                cliente.FechaAlta = fecAlta;
                cliente.FechaBaja = fecBaja;
                cliente.MotivoBaja = motivo;
                if (activo)
                    cliente.Activo = 1;
                else
                    cliente.Activo = 0;

                tablaCliente.InsertOnSubmit(cliente);

                database.SubmitChanges();
            }
            catch (MySqlException ex)
            {
                //database.ClientEs.Remove
                throw ex;
            }



        }


        public ClientEs obtenerCliente(int idcliente)
        {

            try
            {

                Table<ClientEs> tablaCliente = database.GetTable<ClientEs>();
                var cli = (from clireg in tablaCliente
                           where clireg.NumeroCliente == idcliente
                           select clireg);
                if (cli.Count<ClientEs>() == 0)
                    throw new NoExisteException("No existe el cliente con idCliente " + idcliente);

                return cli.Single<ClientEs>();
            }
            catch (ArgumentNullException anex)
            {
                throw new NoExisteException(anex.Message, anex.InnerException);
            }
            catch (InvalidOperationException ioex)
            {
                throw ioex;
            }
            catch (Exception me)
            {
                throw me;
            }
        }

        public bool existeCliente(int idcliente)
        {
            try
            {

                Table<ClientEs> tablaCliente = database.GetTable<ClientEs>();
                var cli = (from clireg in tablaCliente
                           where clireg.NumeroCliente == idcliente
                           select clireg);
                if (cli.Count<ClientEs>() == 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                // MySQLException = Access Denied  Codigo = 1045
            }
        }

        public List<SERVicIoS> obtenerServiciosCliente(int NumeroCliente)
        {
            try
            {
                List<SERVicIoS> servsCli = (from servreg in database.GetTable<SERVicIoS>()
                                            where servreg.NumeroCliente == NumeroCliente
                                            select servreg).ToList<SERVicIoS>();
                return servsCli;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas)
        {
            SERVicIoS ser = null;
            try
            {
                DbLinq.Data.Linq.Table<SERVicIoS> tablaServicios = database.GetTable<SERVicIoS>();

                ser = new SERVicIoS();
                ser.NumeroCliente = (uint)numeroCliente;
                ser.NumeroServicio = (uint)numeroServicio;
                ser.Nombre = Nombre;
                ser.Email = email;
                ser.Direccion = Direccion;
                ser.Telefonos = Telefonos;
                ser.PersonaContacto = Contacto;
                ser.Celular = Celular;
                ser.CelularTrust = CelularTrust;
                ser.TareasAsignadas = Tareas;
                ser.FechaAlta = DateTime.Now;
                ser.FechaBaja = DateTime.MinValue.AddDays(1);
                ser.MotivoBaja = null;
                //if (activo)
                ser.Activo = 1;
                //else
                //    ser.Activo = 0;

                tablaServicios.InsertOnSubmit(ser);

                database.SubmitChanges();
            }
            catch (MySqlException ex)
            {
                //database.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues);
                // database.Connection.Close();
                if (ex.Number == 1062)
                {
                    // int index = database.GetChangeSet().Inserts.IndexOf(cliente);
                    // database.GetChangeSet().Inserts.RemoveAt(index);
                    database.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                }
                throw ex;
            }
        }

        public void modificarCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime fechaAlta, DateTime fechaBaja, string motivoBaja)
        {
            try
            {

                Table<ClientEs> tablaCliente = database.GetTable<ClientEs>();
                ClientEs cli = (from clireg in tablaCliente
                                where clireg.NumeroCliente == numeroCliente
                                select clireg).Single<ClientEs>();

                cli.Nombre = nombre;
                cli.NombreFantasia = nombreFantantasia;
                cli.Rut = rut;
                cli.Email = email;
                cli.Direccion = direccion;
                cli.DireccionDeCobro = direccionCobro;
                cli.Telefonos = telefono;
                cli.Fax = fax;
                cli.FechaAlta = fechaAlta;
                cli.FechaBaja = fechaBaja;
                cli.MotivoBaja = motivoBaja;
                if (activo)
                    cli.Activo = 1;
                else
                    cli.Activo = 0;
                database.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        public void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas)
        {
            try
            {
                Table<SERVicIoS> tablaServicios = database.GetTable<SERVicIoS>();

                var ser = (from s in tablaServicios
                           where (s.NumeroCliente == numeroCliente
                           && s.NumeroServicio == numeroServicio)
                           select s).Single();

                ser.Nombre = Nombre;
                ser.Email = email;
                ser.Direccion = Direccion;
                ser.Telefonos = Telefonos;
                ser.PersonaContacto = Contacto;
                ser.Celular = Celular;
                ser.CelularTrust = CelularTrust;
                ser.TareasAsignadas = Tareas;

                database.SubmitChanges();
            }
            catch (MySqlException ex)
            {
                //database.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues);
                // database.Connection.Close();
                if (ex.Number == 1062)
                {
                    // int index = database.GetChangeSet().Inserts.IndexOf(cliente);
                    // database.GetChangeSet().Inserts.RemoveAt(index);
                    database.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                }
                throw ex;
            }
        }

        public List<ClientEs> buscarClientes(string Nombre)
        {
            try
            {
                List<ClientEs> clies = (from varcli in database.GetTable<ClientEs>()
                                        where varcli.Nombre.Contains(Nombre)
                                        select varcli).ToList<ClientEs>();
                return clies;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }

        public void altaEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadHijos, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica)
        {
            Table<EmPleadOs> tablaEmpleados;
            try
            {
                tablaEmpleados = database.GetTable<EmPleadOs>();
            
                EmPleadOs emp = new EmPleadOs();

                emp.IDEmpleado = (uint)idEmpleado;
                emp.Nombre = nombre;
                emp.Apellido = apellido;
                emp.IDTipoDocumento = (sbyte)idTipoDocumento;
                emp.NumeroDocumento = documento;
                emp.SexO = sexo.ToString();
                emp.IDDepartamento = (sbyte) idDepartamento;
                emp.Ciudad = ciudad;
                //emp.Barrio = BarrioS;
                emp.Direccion = direccion;
                emp.DireccionDeEncuentro = puntoEncuentro;
                emp.EntreCalles = entreCalles;
                emp.Telefonos = telefono;
                emp.Celular = celular;
                emp.CelularenConvenio = celularConvenio;
                emp.EstadoCivil = estadoCivil;
                emp.Email = email;
                emp.Foto = foto;
                //emp.Edad = edad;
                emp.FechaNacimiento = fechaNacimiento;
                emp.LugarDeNacimiento = lugarNacimiento;
                emp.Nacionalidad = nacionalidad;
                emp.FechaIngreso = fechaIngreso;
                //emp.FechaVencimientoCarneDeSalud = fechaVencimientoCarneDeSalud;
                emp.IDMutualista = (byte)idMutualista;
                emp.IDEmergenciaMedica = (byte)idEmergenciaMedica;
                emp.CantidadHijos = (sbyte) cantidadHijos;
                emp.TalleCamisa = talleCamisa;
                emp.TalleZapatos = talleZapatos;
                emp.TallePantalon = tallePantalon;
                emp.TalleCampera = talleCampera;
                emp.FechaBaja = fechaBaja;
                emp.MotivoBaja = motivoBaja;
               // emp.CapacitadoPortarArma = capacitadoPorteArma;
               // emp.EnServicioArmado = enservicioArmado;
               // emp.Antecedentes = (sbyte)antecedentesPolicialesOMilitares;
               // emp.ObservacionesAntecedentes = observacionesAntecedentes;
                emp.SueldoActual = (decimal)sueldo;
                emp.IDBanco = (byte) idBanco;
                emp.NumeroCuenta = numeroCuenta;
               // emp.Observaciones = observaciones;
                emp.CajnUmero = numeroCAJ;
                emp.CajfEchaEmision = fechaEmisionCAJ;
                emp.CajfEchaEntrega = fechaEntregaCAJ;
                emp.BpsaCumulacionLaboral = (byte) acumulacionLaboralBPS;
                emp.BpsfEchaAlta = fechaAltaBPS;
                emp.BpsfEchaBaja = fechaBajaBPS;
                emp.FechaTestPsicologico = fechaPsicologo;
                if (antecedentesPolicialesOMilitares)
                    emp.PolicialesoMilitar = 1;
                else
                    emp.PolicialesoMilitar = 0;

                emp.FechaIngresoPolicialoMilitar = fechaIngresoAntecedete;
                emp.FechaEgresoPolicialoMilitar = fechaEgresoAntecedente;
                emp.SubEscalafonPolicial = subEscalafon;
                if (combatiente)
                    emp.CombatienteMilitar = 1;
                else
                    emp.CombatienteMilitar = 0;
                emp.RenaemsefEchaIngreso = fechaIngresoRENAEMSE;
                emp.RenaemsenUmeroAsunto = numeroAsuntoRENAEMSE;


                
                

                
                tablaEmpleados.InsertOnSubmit(emp);
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


     

        public bool existeClienteServicio(int NumeroCliente, int NumeroServicio)
        {
            try
            {                
                var ser = (from serreg in database.GetTable<SERVicIoS>()
                           where serreg.NumeroCliente == NumeroCliente
                           && serreg.NumeroServicio == NumeroServicio
                           select serreg);
                if ( ser.Count<SERVicIoS>() == 0)
                    return false;               

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                // MySQLException = Access Denied  Codigo = 1045
            }
        }

        

        public void modificarEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadHijos, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica)
        {
        }

        public bool existeEmpleado(int idEmpleado)
        {
            Table<EmPleadOs> tabla;
            try
            {

                tabla = database.GetTable<EmPleadOs>();
                var cli = (from clireg in tabla
                           where clireg.IDEmpleado == idEmpleado
                           select clireg);
                if (cli.Count<EmPleadOs>() == 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                // MySQLException = Access Denied  Codigo = 1045
            }
        }


        public EmPleadOs obtenerEmpleado(int idEmpleado)
        {
            try
            {

                Table<EmPleadOs> tabla = database.GetTable<EmPleadOs>();
                var cli = (from clireg in tabla
                           where clireg.IDEmpleado == idEmpleado
                           select clireg);
                if (cli.Count<EmPleadOs>() == 0)
                    throw new NoExisteException("No existe el empleado con IdEmpleado " + idEmpleado);

                return cli.Single<EmPleadOs>();
            }
            catch (ArgumentNullException anex)
            {
                throw new NoExisteException(anex.Message, anex.InnerException);
            }
            catch (InvalidOperationException ioex)
            {
                throw ioex;
            }
            catch (Exception me)
            {
                throw me;
            }
        }


        #region Codigureas
        public Dictionary<int, string> obtenerTiposDocumento()
        {
            Dictionary<int, string> result;
            Table<TipOsDocumentO> tabla;
            try
            {
                tabla = database.GetTable<TipOsDocumentO>();

                result = new Dictionary<int, string>();         
                foreach(var l in tabla.ToList())
                {
                    result.Add(l.IDTipoDocumento, l.Nombre);
                }
                return result;
                
            }catch(Exception ex)
            {
                throw ex;
            }

        }
        public Dictionary<int, string> obtenerEmergenciasMedica()
        {
            Dictionary<int, string> result;
            Table<EmergeNcIasMedicA> tabla;
            try
            {
                tabla = database.GetTable<EmergeNcIasMedicA>();
                result = new Dictionary<int, string>();
                foreach (var l in tabla.ToList())
                {
                    result.Add(l.IDEmergenciaMedica, l.Nombre);
                }
                return result;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<int, string> obtenerMutualistas()
        {
            Dictionary<int, string> result;
            Table<MutualIsTAs> tabla;
            try
            {
                tabla = database.GetTable<MutualIsTAs>();
                result = new Dictionary<int, string>();
                foreach (var l in tabla.ToList())
                {
                    result.Add(l.IDMutualista, l.Nombre);
                }
                return result;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerBancos()
        {
            Dictionary<int, string> result;
            Table<BanCos> tabla;
            try
            {
                tabla = database.GetTable<BanCos>();
                result = new Dictionary<int, string>();
                foreach (var l in tabla.ToList())
                {
                    result.Add(l.IDBanco, l.Nombre);
                }
                return result;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerDepartamentos()
        {
            Dictionary<int, string> result;
            Table<DepartAmenToS> tabla;
            try
            {
                tabla = database.GetTable<DepartAmenToS>();
                result = new Dictionary<int, string>();
                foreach (var l in tabla.ToList())
                {
                    result.Add(l.IDDepartamento, l.Nombre);
                }
                return result;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }

}