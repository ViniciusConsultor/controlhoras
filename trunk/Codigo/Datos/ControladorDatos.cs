﻿using System;
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
                UserID = "jgarat",
                Password = "jgarat",
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

        #region ABM_Cliente
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
        #endregion

        #region ServicioCliente
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
        #endregion

        #region ABM_Empleados
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
                emp.IDDepartamento = (sbyte)idDepartamento;
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
                emp.CantidadHijos = (sbyte)cantidadHijos;
                emp.TalleCamisa = talleCamisa;
                if (talleZapatos != "")
                    emp.TalleZapatos = (sbyte)int.Parse(talleZapatos);
                else
                    emp.TalleZapatos = null;
                emp.TallePantalon = tallePantalon;
                emp.TalleCampera = talleCampera;
                emp.FechaBaja = fechaBaja;
                emp.MotivoBaja = motivoBaja;
                // emp.CapacitadoPortarArma = capacitadoPorteArma;
                // emp.EnServicioArmado = enservicioArmado;
                // emp.Antecedentes = (sbyte)antecedentesPolicialesOMilitares;
                // emp.ObservacionesAntecedentes = observacionesAntecedentes;
                emp.SueldoActual = sueldo;
                emp.IDBanco = (byte)idBanco;
                emp.NumeroCuenta = numeroCuenta;
                // emp.Observaciones = observaciones;
                emp.CajnUmero = numeroCAJ;
                emp.CajfEchaEmision = fechaEmisionCAJ;
                emp.CajfEchaEntrega = fechaEntregaCAJ;
                emp.BpsaCumulacionLaboral = (byte)acumulacionLaboralBPS;
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
        public void modificarEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadHijos, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica)
        {
            Table<EmPleadOs> tablaEmpleados;
            try
            {
                tablaEmpleados = database.GetTable<EmPleadOs>();

                EmPleadOs emp = (from reg in tablaEmpleados
                                 where reg.IDEmpleado == idEmpleado
                                 select reg).Single();


                emp.Nombre = nombre;
                emp.Apellido = apellido;
                emp.IDTipoDocumento = (sbyte)idTipoDocumento;
                emp.NumeroDocumento = documento;
                emp.SexO = sexo.ToString();
                emp.IDDepartamento = (sbyte)idDepartamento;
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
                emp.CantidadHijos = (sbyte)cantidadHijos;
                emp.TalleCamisa = talleCamisa;
                if (talleZapatos != "")
                    emp.TalleZapatos = (sbyte)int.Parse(talleZapatos);
                else
                    emp.TalleZapatos = null;
                emp.TallePantalon = tallePantalon;
                emp.TalleCampera = talleCampera;
                emp.FechaBaja = fechaBaja;
                emp.MotivoBaja = motivoBaja;
                // emp.CapacitadoPortarArma = capacitadoPorteArma;
                // emp.EnServicioArmado = enservicioArmado;
                // emp.Antecedentes = (sbyte)antecedentesPolicialesOMilitares;
                // emp.ObservacionesAntecedentes = observacionesAntecedentes;
                emp.SueldoActual = sueldo;
                emp.IDBanco = (byte)idBanco;
                emp.NumeroCuenta = numeroCuenta;
                // emp.Observaciones = observaciones;
                emp.CajnUmero = numeroCAJ;
                emp.CajfEchaEmision = fechaEmisionCAJ;
                emp.CajfEchaEntrega = fechaEntregaCAJ;
                emp.BpsaCumulacionLaboral = (byte)acumulacionLaboralBPS;
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


                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        #endregion

        #region ABM_Departamentos
        public int altaDepartamento(string nombreDepartamento, bool activo)
        {
            try
            {
                Table<DepartAmenToS> tabla = database.GetTable<DepartAmenToS>();
                DepartAmenToS dep = new DepartAmenToS();

                dep.Nombre = nombreDepartamento;

                tabla.InsertOnSubmit(dep);
                database.SubmitChanges();
                return dep.IDDepartamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void modificarDepartamento(int idDepartamento, string nombreDepartamento, bool activo)
        {
            try
            {
                Table<DepartAmenToS> tabla = database.GetTable<DepartAmenToS>();
                DepartAmenToS dep = (from reg in tabla
                                     where reg.IDDepartamento == idDepartamento
                                     select reg).Single();

                dep.Nombre = nombreDepartamento;
                //dep.Activo = activo;
                
                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<int, string> obtenerDepartamentos(bool soloActivos)
        {
            Dictionary<int, string> result;
            Table<DepartAmenToS> tabla;
            try
            {
                tabla = database.GetTable<DepartAmenToS>();
                result = new Dictionary<int, string>();
                List<DepartAmenToS> listRes;
                if (!soloActivos)
                    listRes = tabla.ToList<DepartAmenToS>();
                else
                    listRes = tabla.ToList<DepartAmenToS>();
                //listRes = (from reg in tabla
                //           where reg.activo == 1
                //           select reg).ToList<DepartAmenToS>();

                foreach (DepartAmenToS l in listRes)
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
        public void bajaDepartamento(int idDepartamento)
        { }

        #endregion

        #region ABM_Bancos
        public int altaBanco(string nombreBanco, bool activo)
        {
            try
            {
                Table<BanCos> tabla = database.GetTable<BanCos>();
                BanCos dep = new BanCos();

                dep.Nombre = nombreBanco;

                tabla.InsertOnSubmit(dep);
                database.SubmitChanges();
                return dep.IDBanco;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarBanco(int idBanco, string nombreBanco, bool activo)
        {
            try
            {
                Table<BanCos> tabla = database.GetTable<BanCos>();
                BanCos dep = (from reg in tabla
                                     where reg.IDBanco == idBanco
                                     select reg).Single();

                dep.Nombre = nombreBanco;
                //dep.Activo = activo;

                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<int, string> obtenerBancos(bool soloActivos)
        {
            Dictionary<int, string> result;
            Table<BanCos> tabla;
            
            try
            {
                tabla = database.GetTable<BanCos>();
                result = new Dictionary<int, string>();
                List<BanCos> listRes;
                if (!soloActivos)
                    listRes = tabla.ToList<BanCos>();
                else
                    listRes = tabla.ToList<BanCos>();
                //listRes = (from reg in tabla
                //           where reg.activo == 1
                //           select reg).ToList<BanCos>();

                foreach (BanCos l in listRes)
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
        public void bajaBanco(int idBanco)
        { }
        #endregion

        #region ABM_Mutualistas
        public int altaMutualista(string nombreMutualista, bool activo)
        {
            try
            {
                Table<MutualIsTAs> tabla = database.GetTable<MutualIsTAs>();
                MutualIsTAs dep = new MutualIsTAs();

                dep.Nombre = nombreMutualista;

                tabla.InsertOnSubmit(dep);
                database.SubmitChanges();
                return dep.IDMutualista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarMutualista(int idMutualista, string nombreMutualista, bool activo)
        {
            try
            {
                Table<MutualIsTAs> tabla = database.GetTable<MutualIsTAs>();
                MutualIsTAs dep = (from reg in tabla
                                     where reg.IDMutualista == idMutualista
                                     select reg).Single();

                dep.Nombre = nombreMutualista;
                //dep.Activo = activo;

                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<int, string> obtenerMutualistas(bool soloActivos)
        {
            Dictionary<int, string> result;
            Table<MutualIsTAs> tabla;
            try
            {
                tabla = database.GetTable<MutualIsTAs>();
                result = new Dictionary<int, string>();
                List<MutualIsTAs> listRes;
                if (!soloActivos)
                    listRes = tabla.ToList<MutualIsTAs>();
                else
                    listRes = tabla.ToList<MutualIsTAs>();
                //listRes = (from reg in tabla
                //           where reg.activo == 1
                //           select reg).ToList<MutualIsTAs>();

                foreach (MutualIsTAs l in listRes)
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
        public void bajaMutualista(int idMutualista)
        { }
        #endregion

        #region ABM_EmergenciasMedica
        public int altaEmergenciaMedica(string nombreEmergenciaMedica, bool activo)
        {
            try
            {
                Table<EmergeNcIasMedicA> tabla = database.GetTable<EmergeNcIasMedicA>();
                EmergeNcIasMedicA dep = new EmergeNcIasMedicA();

                dep.Nombre = nombreEmergenciaMedica;

                tabla.InsertOnSubmit(dep);
                database.SubmitChanges();
                return dep.IDEmergenciaMedica;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarEmergenciaMedica(int idEmergenciaMedica, string nombreEmergenciaMedica, bool activo)
        {
            try
            {
                Table<EmergeNcIasMedicA> tabla = database.GetTable<EmergeNcIasMedicA>();
                EmergeNcIasMedicA dep = (from reg in tabla
                                     where reg.IDEmergenciaMedica == idEmergenciaMedica
                                     select reg).Single();

                dep.Nombre = nombreEmergenciaMedica;
                //dep.Activo = activo;

                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<int, string> obtenerEmergenciaMedicas(bool soloActivos)
        {
            Dictionary<int, string> result;
            Table<EmergeNcIasMedicA> tabla;
            try
            {
                tabla = database.GetTable<EmergeNcIasMedicA>();
                result = new Dictionary<int, string>();
                List<EmergeNcIasMedicA> listRes;
                if (!soloActivos)
                    listRes = tabla.ToList<EmergeNcIasMedicA>();
                else
                    listRes = tabla.ToList<EmergeNcIasMedicA>();
                //listRes = (from reg in tabla
                //           where reg.activo == 1
                //           select reg).ToList<EmergeNcIasMedicA>();

                foreach (EmergeNcIasMedicA l in listRes)
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
        public void bajaEmergenciaMedica(int idEmergenciaMedica)
        { }
        #endregion

        #region ABM_TiposDocumentos
        public int altaTipoDocumento(string nombreTipoDocumento, bool activo)
        {
            try
            {
                Table<TipOsDocumentO> tabla = database.GetTable<TipOsDocumentO>();
                TipOsDocumentO dep = new TipOsDocumentO();

                dep.Nombre = nombreTipoDocumento;

                tabla.InsertOnSubmit(dep);
                database.SubmitChanges();
                return dep.IDTipoDocumento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarTipoDocumento(int idTipoDocumento, string nombreTipoDocumento, bool activo)
        {
            try
            {
                Table<TipOsDocumentO> tabla = database.GetTable<TipOsDocumentO>();
                TipOsDocumentO dep = (from reg in tabla
                                     where reg.IDTipoDocumento == idTipoDocumento
                                     select reg).Single();

                dep.Nombre = nombreTipoDocumento;
                //dep.Activo = activo;

                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<int, string> obtenerTipoDocumentos(bool soloActivos)
        {
            Dictionary<int, string> result;
            Table<TipOsDocumentO> tabla;
            try
            {
                tabla = database.GetTable<TipOsDocumentO>();
                result = new Dictionary<int, string>();
                List<TipOsDocumentO> listRes;
                if (!soloActivos)
                    listRes = tabla.ToList<TipOsDocumentO>();
                else
                    listRes = tabla.ToList<TipOsDocumentO>();
                    //listRes = (from reg in tabla
                    //           where reg.activo == 1
                    //           select reg).ToList<TipOsDocumentO>();
                foreach (TipOsDocumentO l in listRes)
                {
                    result.Add(l.IDTipoDocumento, l.Nombre);
                }
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void bajaTipoDocumento(int idTipoDocumento)
        { }
        #endregion

    }

}