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
using System.Data;
using System.Configuration;
using System.Globalization;

namespace Datos
{
    public class ControladorDatos : IDatos
    {
        private static TrustDb database = null;
        private static IDatos instance = null;
        private static MySqlConnection conexion = null;
        
        private static bool InDesignMode = true;

        private ControladorDatos()
        {
            database = getContext();
        }

        //internal static TrustDb getContext()
        //{
        //  //  if (database == null)
                
        //    return database;
        //}


        public static IDatos getInstance()//(string StringConnection)
        {
            if (instance == null)
                instance = new ControladorDatos(); //(string StringConnection)
            InDesignMode = false;
            return instance;
        }
        internal static MySqlConnection createConexion()//(string StringConnection)
        {
            //System.Configuration.Configuration config =
            // ConfigurationManager.OpenExeConfiguration(
            // ConfigurationUserLevel.None);
            //int appStgCnt =
            //    ConfigurationManager.AppSettings.Count;
            //string newKey = "Servidor";

            //string newValue = "localhost";

            //config.AppSettings.Settings.Add(newKey, newValue);

            //// Save the configuration file.
            //config.Save(ConfigurationSaveMode.Modified);

            //// Force a reload of the changed section.
            //ConfigurationManager.RefreshSection("appSettings");
                           
            
            try
            {
               
                //string pru = ConfigurationManager.AppSettings["Servidor"].ToString();
                var builder = new MySqlConnectionStringBuilder() //(StringConnection)
                {
                    //Server = "localhost",
                    Server = ConfigurationManager.AppSettings["Servidor"].ToString(),
                    //Port = 3306,
                    Port = uint.Parse(ConfigurationManager.AppSettings["Puerto"].ToString()),
                    //UserID = "root",
                    UserID = ConfigurationManager.AppSettings["Usuario"].ToString(),
                    //Password = "desdere",
                    Password = ConfigurationManager.AppSettings["Password"].ToString(),
                    //Database = "trustdb",
                    Database = ConfigurationManager.AppSettings["Base"].ToString(),
                    Pooling = false,
                    ConnectionLifeTime = 0,
                    AllowUserVariables = true
                };


                var conn = new MySqlConnection(builder.ToString());
                return conn;
            
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo crear el connectionString.",ex);
            }                        
        }

        internal static MySqlConnection getConexion()
        {
            if (conexion == null)
                conexion = createConexion();
            return conexion;
        }

        internal static TrustDb createContext()
        {

            TrustDb context = new TrustDb(getConexion(), new DbLinq.MySql.MySqlVendor());
            return context;
        }

        internal static TrustDb getContext()
        {
            if (database == null)
                database = createContext();
            return database;    
        }
        

        #region ABM_Cliente
        public void altaCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime? fecAlta, DateTime? fecBaja, string motivo)
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
        public void modificarCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja)
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
        public void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string DiaDeCobro, string NombreCobrar)
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
                ser.DiaCobro = DiaDeCobro;
                ser.NombreCobrar = NombreCobrar;
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
        public void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string DiaDeCobro, string NombreCobrar)
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
                ser.DiaCobro = DiaDeCobro;
                ser.NombreCobrar = NombreCobrar;
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

        #region Contratos
        public void altaContratoServicioCliente(int NumeroCliente, int NumeroServicio, int NumeroContrato, DateTime FechaInicio, DateTime FechaFin, bool CostoFijo, bool HorasExtras, string Ajuste, string Observaciones, float Monto)
        {

            ContraToS con = null;

            try
            {
                con = new ContraToS();

                con.TipodeContrato = 0;
                con.IDContratos = (uint)NumeroContrato;
                con.FechaIni = FechaInicio;
                con.FechaFin = FechaFin;
                if (CostoFijo)
                    con.CostoFijo = 1;
                else
                    con.CostoFijo = 0;
                if (HorasExtras)
                    con.HorasExtras = 1;
                else
                    con.HorasExtras = 0;
                con.Ajuste = Ajuste;
                con.Observaciones = Observaciones;
                con.Costo = Monto;

                Table<ContraToS> tablaContratos = database.GetTable<ContraToS>();
                tablaContratos.InsertOnSubmit(con);

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

        public bool existeContrato(int NumeroContrato)
        {
            try
            {
                var cli = (from clireg in database.GetTable<ContraToS>()
                           where clireg.IDContratos == NumeroContrato
                           select clireg);
                if (cli.Count<ContraToS>() == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;
                // MySQLException = Access Denied  Codigo = 1045
            }
        }    



        #endregion

        #region ABM_Empleados
        public void altaEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, char sexo, DateTime? fechaPsicologo, DateTime? fechaNacimiento, int edad, DateTime? fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadMenoresACargo, byte[] foto, float valorHora, bool activo, DateTime? fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, int ciudad, int barrio, string codigoPostal, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime? fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime? fechaAltaBPS, bool bajaBPS, DateTime? fechaBajaBPS, string numeroCAJ, DateTime? fechaEmisionCAJ, DateTime? fechaEntregaCAJ, bool antecedentesEmpleado, string observacionesAntecedentesEmpleado, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime? fechaIngresoAntecedete, DateTime? fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime? vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica, bool capacitadoPorteArma, bool enservicioArmado, string observacionesEmpleado, string nivelEducativo, int idCargo, DateTime? fechaPagoEfectuado, DateTime? fechaPrevistaPago, String servicioActual, string turno, bool ConstanciaDomicilio, DateTime? FechaEntregaCelular)
        {
            Table<EmPleadOs> tablaEmpleados;
            try
            {
                tablaEmpleados = database.GetTable<EmPleadOs>();

                EmPleadOs emp = new EmPleadOs();

                emp.NroEmpleado = (uint)idEmpleado;
                emp.Nombre = nombre;
                emp.Apellido = apellido;
                emp.IDTipoDocumento = (sbyte)idTipoDocumento;
                emp.NumeroDocumento = documento;
                emp.SexO = sexo.ToString();
                emp.IDDepartamento = (sbyte)idDepartamento;
                emp.IDCiudad = (sbyte)ciudad;
                emp.IDBarrio = (sbyte)barrio;
                //emp.Ciudad = ciudad;
                //emp.Barrio = barrio;
                emp.CodigoPostal = codigoPostal;
                emp.Direccion = direccion;
                emp.DireccionDeEncuentro = puntoEncuentro;
                emp.EntreCalles = entreCalles;
                emp.Telefonos = telefono;
                emp.Celular = celular;
                emp.CelularenConvenio = celularConvenio;
                emp.EstadoCivil = estadoCivil;
                emp.Email = email;
                emp.Foto = foto;
                emp.Edad = (sbyte)edad;
                emp.FechaNacimiento = fechaNacimiento;
                emp.LugarDeNacimiento = lugarNacimiento;                
                emp.FechaIngreso = fechaIngreso;
                if (antecedentesEmpleado)
                {
                    emp.Antecedentes = 1;
                    emp.ObservacionesAntecedentes = observacionesAntecedentesEmpleado;
                }
                else
                {
                    emp.Antecedentes = 0;
                    emp.ObservacionesAntecedentes = null;
                }
                emp.FechaVencimientoCarneDeSalud = vencimientoCarneSalud;
                emp.IDMutualista = (byte)idMutualista;
                emp.IDEmergenciaMedica = (byte)idEmergenciaMedica;
                emp.CantidadMenoresAcArgo = (sbyte)cantidadMenoresACargo;
                emp.TalleCamisa = talleCamisa;
                if (talleZapatos != "")
                    emp.TalleZapatos = (sbyte)int.Parse(talleZapatos);
                else
                    emp.TalleZapatos = null;
                emp.TallePantalon = tallePantalon;
                emp.TalleCampera = talleCampera;
                emp.FechaBaja = fechaBaja;
                emp.MotivoBaja = motivoBaja;
                if (capacitadoPorteArma)
                    emp.CapacitadoPortarArma = 1;
                else
                    emp.CapacitadoPortarArma = 0;
                if (enservicioArmado)
                    emp.EnServicioArmado = 1;
                else
                    emp.EnServicioArmado = 0;

                if (antecedentesPolicialesOMilitares)
                {
                    emp.AntecedentesPolicialesOmIlitares = 1;
                    if (PolicialOMilitar == "Policia")
                        emp.PolicialesoMilitar = 0;
                    else
                        emp.PolicialesoMilitar = 1;
                    emp.FechaIngresoPolicialoMilitar = fechaIngresoAntecedete;
                    emp.FechaEgresoPolicialoMilitar = fechaEgresoAntecedente;
                }
                else
                    emp.AntecedentesPolicialesOmIlitares = 0;

                emp.ServicioActual = servicioActual;
                emp.Turno = turno;
                emp.ValorHora = valorHora;
                emp.FechaPrevistaPago = fechaPrevistaPago;
                emp.FechaPagoEfectuado = fechaPagoEfectuado;
                //emp.SueldoActual = sueldo;
                //emp.IDBanco = (byte)idBanco;
                //emp.NumeroCuenta = numeroCuenta;
                emp.Observaciones = observacionesEmpleado;
                emp.CajnUmero = numeroCAJ;
                emp.CajfEchaEmision = fechaEmisionCAJ;
                emp.CajfEchaEntrega = fechaEntregaCAJ;
                emp.BpsaCumulacionLaboral = (byte)acumulacionLaboralBPS;
                emp.BpsfEchaAlta = fechaAltaBPS;
                if (bajaBPS)
                    emp.BpseSBaja = 1;
                else
                    emp.BpseSBaja = 0;
                emp.BpsfEchaBaja = fechaBajaBPS;
                emp.FechaTestPsicologico = fechaPsicologo;

                //emp.MtssfEchaAlta = fechaAltaMTSS;
                //if (bajaMTSS)
                //    emp.MtsseSBaja = 1;
                //else
                //    emp.MtsseSBaja = 0;
                //emp.MtssfEchaBaja = fechaBajaMTSS;

                emp.SubEscalafonPolicial = subEscalafon;
                if (combatiente)
                    emp.CombatienteMilitar = 1;
                else
                    emp.CombatienteMilitar = 0;
                emp.RenaemsefEchaIngreso = fechaIngresoRENAEMSE;
                emp.RenaemsenUmeroAsunto = numeroAsuntoRENAEMSE;
                emp.NivelEducativo = nivelEducativo;
                emp.IDCargo = (short)idCargo;
                //emp.FechaPagoFinal = fechaEgreso;
                if (activo)
                    emp.Activo = 1;
                else
                    emp.Activo = 0;
                if (ConstanciaDomicilio)
                    emp.ConstanciaDomicilio = 1;
                else
                    emp.ConstanciaDomicilio = 0;
                emp.FechaEntregaCelular = FechaEntregaCelular;
                

                tablaEmpleados.InsertOnSubmit(emp);
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        //public void modificarEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, string nacionalidad, char sexo, DateTime fechaPsicologo, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadHijos, byte[] foto, int idBanco, string numeroCuenta, float sueldo, bool activo, DateTime fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, string ciudad, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime fechaAltaBPS, DateTime fechaBajaBPS, string numeroCAJ, DateTime fechaEmisionCAJ, DateTime fechaEntregaCAJ, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime fechaIngresoAntecedete, DateTime fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica)
        public void modificarEmpleado(int idEmpleado, string nombre, string apellido, int idTipoDocumento, string documento, string lugarNacimiento, char sexo, DateTime? fechaPsicologo, DateTime? fechaNacimiento, int edad, DateTime? fechaIngreso, string telefono, string celular, string celularConvenio, string email, string estadoCivil, int cantidadMenoresACargo, byte[] foto, float valorHora, bool activo, DateTime? fechaBaja, string motivoBaja, /* Segundo Tab */ int idDepartamento, int ciudad, int barrio, string codigoPostal, string direccion, string entreCalles, string puntoEncuentro, string numeroAsuntoRENAEMSE, DateTime? fechaIngresoRENAEMSE, int acumulacionLaboralBPS, DateTime? fechaAltaBPS, bool bajaBPS, DateTime? fechaBajaBPS, string numeroCAJ, DateTime? fechaEmisionCAJ, DateTime? fechaEntregaCAJ, bool antecedentesEmpleado, string observacionesAntecedentesEmpleado, bool antecedentesPolicialesOMilitares, string PolicialOMilitar, DateTime? fechaIngresoAntecedete, DateTime? fechaEgresoAntecedente, string subEscalafon, bool combatiente, string talleCamisa, string tallePantalon, string talleZapatos, string talleCampera, DateTime? vencimientoCarneSalud, int idMutualista, int idEmergenciaMedica, bool capacitadoPorteArma, bool enservicioArmado, string observacionesEmpleado, string nivelEducativo, int idCargo, DateTime? fechaPagoEfectuado, DateTime? fechaPrevistaPago, String servicioActual, string turno, bool ConstanciaDomicilio, DateTime? FechaEntregaCelular)
        {
            Table<EmPleadOs> tablaEmpleados;
            try
            {
                tablaEmpleados = database.GetTable<EmPleadOs>();

                EmPleadOs emp = (from reg in tablaEmpleados
                                 where reg.NroEmpleado == idEmpleado
                                 select reg).Single();


                emp.Nombre = nombre;
                emp.Apellido = apellido;
                emp.IDTipoDocumento = (sbyte)idTipoDocumento;
                emp.NumeroDocumento = documento;
                emp.SexO = sexo.ToString();
                emp.IDDepartamento = (sbyte)idDepartamento;
                emp.IDCiudad = (sbyte)ciudad;
                emp.IDBarrio = (sbyte)barrio;
                //emp.Ciudad = ciudad;
                //emp.Barrio = barrio;
                emp.CodigoPostal = codigoPostal;
                emp.Direccion = direccion;
                emp.DireccionDeEncuentro = puntoEncuentro;
                emp.EntreCalles = entreCalles;
                emp.Telefonos = telefono;
                emp.Celular = celular;
                emp.CelularenConvenio = celularConvenio;
                emp.EstadoCivil = estadoCivil;
                emp.Email = email;
                emp.Foto = foto;
                emp.Edad = (sbyte)edad;
                emp.FechaNacimiento = fechaNacimiento;
                emp.LugarDeNacimiento = lugarNacimiento;                
                emp.FechaIngreso = fechaIngreso;
                if (antecedentesEmpleado)
                {
                    emp.Antecedentes = 1;
                    emp.ObservacionesAntecedentes = observacionesAntecedentesEmpleado;
                }
                else
                {
                    emp.Antecedentes = 0;
                    emp.ObservacionesAntecedentes = null;
                }
                emp.FechaVencimientoCarneDeSalud = vencimientoCarneSalud;
                emp.IDMutualista = (byte)idMutualista;
                emp.IDEmergenciaMedica = (byte)idEmergenciaMedica;
                emp.CantidadMenoresAcArgo = (sbyte)cantidadMenoresACargo;
                emp.TalleCamisa = talleCamisa;
                if (talleZapatos != "")
                    emp.TalleZapatos = (sbyte)int.Parse(talleZapatos);
                else
                    emp.TalleZapatos = null;
                emp.TallePantalon = tallePantalon;
                emp.TalleCampera = talleCampera;
                emp.FechaBaja = fechaBaja;
                emp.MotivoBaja = motivoBaja;
                if (capacitadoPorteArma)
                    emp.CapacitadoPortarArma = 1;
                else
                    emp.CapacitadoPortarArma = 0;
                if (enservicioArmado)
                    emp.EnServicioArmado = 1;
                else
                    emp.EnServicioArmado = 0;

                if (antecedentesPolicialesOMilitares)
                {
                    emp.AntecedentesPolicialesOmIlitares = 1;
                    if (PolicialOMilitar == "Policia")
                        emp.PolicialesoMilitar = 0;
                    else
                        emp.PolicialesoMilitar = 1;
                    emp.FechaIngresoPolicialoMilitar = fechaIngresoAntecedete;
                    emp.FechaEgresoPolicialoMilitar = fechaEgresoAntecedente;
                }
                else
                    emp.AntecedentesPolicialesOmIlitares = 0;

                emp.ServicioActual = servicioActual;
                emp.Turno = turno;
                emp.ValorHora = valorHora;
                emp.FechaPrevistaPago = fechaPrevistaPago;
                emp.FechaPagoEfectuado = fechaPagoEfectuado;
                //emp.SueldoActual = sueldo;
                //emp.IDBanco = (byte)idBanco;
                //emp.NumeroCuenta = numeroCuenta;
                emp.Observaciones = observacionesEmpleado;
                emp.CajnUmero = numeroCAJ;
                emp.CajfEchaEmision = fechaEmisionCAJ;
                emp.CajfEchaEntrega = fechaEntregaCAJ;
                emp.BpsaCumulacionLaboral = (byte)acumulacionLaboralBPS;
                emp.BpsfEchaAlta = fechaAltaBPS;
                if (bajaBPS)
                    emp.BpseSBaja = 1;
                else
                    emp.BpseSBaja = 0;
                emp.BpsfEchaBaja = fechaBajaBPS;
                emp.FechaTestPsicologico = fechaPsicologo;

                //emp.MtssfEchaAlta = fechaAltaMTSS;
                //if (bajaMTSS)
                //    emp.MtsseSBaja = 1;
                //else
                //    emp.MtsseSBaja = 0;
                //emp.MtssfEchaBaja = fechaBajaMTSS;
                
                emp.SubEscalafonPolicial = subEscalafon;
                if (combatiente)
                    emp.CombatienteMilitar = 1;
                else
                    emp.CombatienteMilitar = 0;
                emp.RenaemsefEchaIngreso = fechaIngresoRENAEMSE;
                emp.NivelEducativo = nivelEducativo;
                emp.RenaemsenUmeroAsunto = numeroAsuntoRENAEMSE;
                if (activo)
                    emp.Activo = 1;
                else
                    emp.Activo = 0;

                emp.IDCargo = (short)idCargo;
                if (ConstanciaDomicilio)
                    emp.ConstanciaDomicilio = 1;
                else
                    emp.ConstanciaDomicilio = 0;
                emp.FechaEntregaCelular = FechaEntregaCelular;
                
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
                           where clireg.NroEmpleado == idEmpleado
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
        public int obtenerMaxIdEmpleado()
        {
            try
            {
                var maxId = (from reg in database.GetTable<EmPleadOs>()
                             select (int)reg.NroEmpleado).Max<int>();

                return maxId;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public EmPleadOs obtenerEmpleado(int idEmpleado)
        {
            try
            {

                Table<EmPleadOs> tabla = database.GetTable<EmPleadOs>();
                var cli = (from clireg in tabla
                           where clireg.NroEmpleado == idEmpleado
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
        public int? obtenerProximoIdEmpleadoActivo(int idEmpleado)
        {

            try
            {
                int? idemp = (from reg in database.GetTable<EmPleadOs>()
                             where reg.NroEmpleado > idEmpleado && reg.Activo == 1
                             select (int?)reg.NroEmpleado).Min<int?>();
                return idemp;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int? obtenerPrevioIdEmpleadoActivo(int idEmpleado)
        {

            try
            {
                int? idemp = null;
                idemp = (from reg in database.GetTable<EmPleadOs>()
                             where reg.NroEmpleado < idEmpleado  && reg.Activo == 1
                             select (int?)reg.NroEmpleado).Max<int?>();
                return idemp;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void cambiarNumeroEmpleado(int NumeroActual, int NumeroEmpleadoNuevo)
        {
            if (existeEmpleado(NumeroEmpleadoNuevo))
                throw new Exception("Error al reemplazar el Numero de Empleado.\nYa existe un empleado con el Numero " + NumeroEmpleadoNuevo.ToString());
            else if (!existeEmpleado(NumeroActual))
            {
                throw new Exception("Error al reemplazar el Numero de Empleado.\nNo existe un empleado con el Numero " + NumeroActual.ToString());
            }
            MySqlCommand com = null;
            try
            {
                
                //System.Data.Common.DbTransaction trans = database.Connection.BeginTransaction();
                System.Data.Common.DbConnection conn = database.Connection;


                string SQL = "UPDATE empleados SET NroEmpleado=?idempleadonuevo where NroEmpleado=?idempleadoactual";
                com = new MySqlCommand(SQL, (MySqlConnection) conn);
                MySqlParameter myIdEmpActual = new MySqlParameter("?idempleadoactual", MySqlDbType.UInt16);
                myIdEmpActual.Value = NumeroActual;
                MySqlParameter myNuevoIdEmp = new MySqlParameter("?idempleadonuevo", MySqlDbType.UInt16);
                myNuevoIdEmp.Value = NumeroEmpleadoNuevo;

                com.Parameters.Add(myIdEmpActual);
                com.Parameters.Add(myNuevoIdEmp);
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                com.ExecuteNonQuery();
                com.Connection.Close();
                
                //Table<EmPleadOs> empleados = database.GetTable<EmPleadOs>();
                //EmPleadOs emp = (from varemp in empleados
                //                 where varemp.IDEmpleado == NumeroActual
                //                 select varemp).Single();

                //emp.IDEmpleado = (uint)NumeroEmpleadoNuevo;
                //database.SubmitChanges();
            }
            catch (Exception ex)
            {
                if (com != null && com.Connection.State != ConnectionState.Closed)
                    com.Connection.Close();
                throw ex;
            }
        }
        public List<EmPleadOs> buscarEmpleaos(string CampoBusqueda, string patronBusqueda)
        {
            try
            {
                List<EmPleadOs> emps;

                switch (CampoBusqueda)
                {
                    case "Nombre":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.Nombre.Contains(patronBusqueda)
                                select varemp).ToList<EmPleadOs>();
                        break;
                    case "Apellido":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.Apellido.Contains(patronBusqueda)
                                select varemp).ToList<EmPleadOs>();
                        break;
                    case "Direccion":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.Direccion.Contains(patronBusqueda)
                                select varemp).ToList<EmPleadOs>();
                        break;
                    case "Telefono":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.Telefonos.Contains(patronBusqueda)
                                select varemp).ToList<EmPleadOs>();
                        break;
                    case "Documento":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.NumeroDocumento.Contains(patronBusqueda)
                                select varemp).ToList<EmPleadOs>();
                        break;
                    default:
                        throw new NoExisteException("No existe el Campo de Busqueda " + CampoBusqueda);
                }
                return emps;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Consultas
        public List<ConsultAsEmPleadOs> obtenerConsultasEmpleados(bool soloactivos)
        {
            List<ConsultAsEmPleadOs> lista = new List<ConsultAsEmPleadOs>();

            try
            {
                sbyte activos = 0;
                if (soloactivos)
                    activos = 1;

                lista = (from reg in database.GetTable<ConsultAsEmPleadOs>()
                         where reg.Activo == activos   //&&reg.Activo == 0
                         select reg).ToList();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public List<ConsultAsClientEs> obtenerConsultasClientes(bool soloactivos)
        {
            List<ConsultAsClientEs> lista = new List<ConsultAsClientEs>();

            try
            {
                sbyte activos = 0;
                if (soloactivos)
                    activos = 1;

                lista = (from reg in database.GetTable<ConsultAsClientEs>()
                         where reg.Activo == activos   //&&reg.Activo == 0
                         select reg).ToList();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public DataSet ejecutarConsultaEmpleado(int numeroConsultaEmpleado, Dictionary<string, string> parametrosConsulta)
        {
            MySqlConnection conexion2;
            try
            {
                ConsultAsEmPleadOs consEmp = (from reg in database.GetTable<ConsultAsEmPleadOs>()
                                              where reg.IDConsultaEmpleado == numeroConsultaEmpleado
                                              select reg).Single();
                if (consEmp != null)
                {
                    string sql = consEmp.Query;
                    if (consEmp.Query.Contains("FECHA"))
                        if (parametrosConsulta.ContainsKey("FECHA"))
                        {
                            string[] fecha = parametrosConsulta["FECHA"].Split('/');
                            DateTime dt = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
                            string fecha2 = String.Format("{0:yyyy-MM-dd}", dt);
                            sql = sql.Replace("FECHA", fecha2);
                        }


                    conexion2 = (MySqlConnection)database.Connection;

                    MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter(sql, conexion2);

                    DataSet sd = new DataSet();
                    mysqlAdapter.Fill(sd);
                    //conexion.Close();
                    return sd;
                }
                throw new Exception("Error al ejecutar la consulta para obtener el query");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public DataSet ejecutarConsultaCliente(int numeroConsultaCliente, Dictionary<string, string> parametrosConsulta)
        {
            MySqlConnection conexion2;
            try
            {
                ConsultAsClientEs consEmp = (from reg in database.GetTable<ConsultAsClientEs>()
                                             where reg.IDConsultaCliente == numeroConsultaCliente
                                              select reg).Single();
                if (consEmp != null)
                {
                    string sql = consEmp.Query;
                    if (consEmp.Query.Contains("FECHA"))
                        if (parametrosConsulta.ContainsKey("FECHA"))
                        {
                            string[] fecha = parametrosConsulta["FECHA"].Split('/');
                            DateTime dt = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
                            string fecha2 = String.Format("{0:yyyy-MM-dd}", dt);
                            sql = sql.Replace("FECHA", fecha2);
                        }


                    conexion2 = (MySqlConnection)database.Connection;

                    MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter(sql, conexion2);

                    DataSet sd = new DataSet();
                    mysqlAdapter.Fill(sd);
                    //conexion.Close();
                    return sd;
                }
                throw new Exception("Error al ejecutar la consulta para obtener el query");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        #endregion

        #region HistorialEmpleado
        public int agregarEventoHistorialEmpleado(int idEmpleado, DateTime fechaInicioEvento, DateTime fechaFinEvento, int idTipoEventoHistorial, string descripcionEvento)
        {
            try
            {
                EventOsHistOrIalEmPleadO eventHist = new EventOsHistOrIalEmPleadO();
                Table<EventOsHistOrIalEmPleadO> tabla = database.GetTable<EventOsHistOrIalEmPleadO>();

                eventHist.FechaInicio = fechaInicioEvento;
                eventHist.FechaFin = fechaFinEvento;
                eventHist.IDEmpleado = (uint) idEmpleado;
                eventHist.IDTipoEvento = idTipoEventoHistorial;
                eventHist.Descripcion = descripcionEvento;

                tabla.InsertOnSubmit(eventHist);

                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                return (int) eventHist.IDEventoHistorialEmpleado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void modificarEventoHistorialEmpleado(int idEventoHistorialEmpleado, int idEmpleado, DateTime fechaInicioEvento,DateTime fechaFinEvento,int idTipoEventoHistorial,string descripcionHistorial)
        {
            try
            {
                Table<EventOsHistOrIalEmPleadO> tabla = database.GetTable<EventOsHistOrIalEmPleadO>();
                var eventHist = (from reg in tabla
                                 where reg.IDEventoHistorialEmpleado == idEventoHistorialEmpleado
                                 && reg.IDEmpleado == idEmpleado
                                 select reg).Single<EventOsHistOrIalEmPleadO>();

                if (eventHist == null)
                    throw new Excepciones.NoExisteException("No existe el Evento en el Historial del Empleado " + idEmpleado.ToString());

                eventHist.FechaInicio = fechaInicioEvento;
                eventHist.FechaFin = fechaFinEvento;
                eventHist.IDTipoEvento = idTipoEventoHistorial;
                eventHist.Descripcion = descripcionHistorial;
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarEventoHistorialEmpleado(int idEventoHistorialEmpleado, int idEmpleado)
        {
            try
            {
                Table<EventOsHistOrIalEmPleadO> tabla = database.GetTable<EventOsHistOrIalEmPleadO>();
                var eventHist = (from reg in tabla
                                 where reg.IDEventoHistorialEmpleado == idEventoHistorialEmpleado
                                 && reg.IDEmpleado == idEmpleado
                                 select reg).Single<EventOsHistOrIalEmPleadO>();

                if (eventHist == null)
                    throw new Excepciones.NoExisteException("No existe el Evento en el Historial del Empleado " + idEmpleado.ToString());
                //eventHist.BoRrAdo = 1;
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EventOsHistOrIalEmPleadO> obtenerEventosHistorialEmpleado(int idEmpleado)
        {
            try
            {
                Table<EventOsHistOrIalEmPleadO> tabla = database.GetTable<EventOsHistOrIalEmPleadO>();
                List<EventOsHistOrIalEmPleadO> eventList = (from reg in tabla
                                 where reg.IDEmpleado == idEmpleado //&& reg.BoRrAdo == 0
                                 select reg).ToList<EventOsHistOrIalEmPleadO>();

                return eventList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region ExtrasLiquidacionEmpleado
        // 2010-05-12 - JG: Esta es la primer version de los extrasliquidacion, cuando se usaba una sola tabla.
        //public int agregarExtraLiquidacionEmpleado(int idEmpleado, DateTime fecha, string descripcion, bool signoPositivo, float valor, int cantidadCuotas)
        //{
        //    ExtrasLiquidAcIonEmPleadO exliq;
        //    Table<ExtrasLiquidAcIonEmPleadO> tabla;
        //    try
        //    {
        //        tabla = database.GetTable<ExtrasLiquidAcIonEmPleadO>();

        //        int cuotaActual = 1;
        //        int idExtraARetornar = -1;
        //        DateTime mesCorrespondiente = fecha;

        //        uint proximoIdExtraEmpleado;
              
        //        List<uint> ListExtras = (from reg in tabla
        //                   where reg.IDEmpleado == idEmpleado
        //                   select reg.IDExtrasLiquidacionEmpleado).ToList<uint>();

        //        uint extras=0;
        //        if (ListExtras.Count > 0)
        //            extras = ListExtras.Max();
        //        proximoIdExtraEmpleado = (uint)extras + 1;
                
        //        // Se crea un registro nuevo por cada cuota, aumentando la cuota y el mes
        //        while (cuotaActual <= cantidadCuotas)
        //        {
        //            exliq = new ExtrasLiquidAcIonEmPleadO();

        //            exliq.IDEmpleado = (uint) idEmpleado;
        //            exliq.IDExtrasLiquidacionEmpleado = proximoIdExtraEmpleado;
        //            exliq.Fecha = mesCorrespondiente;
        //            //if (signoPositivo)
        //            //    exliq.Signo = 1;
        //            //else
        //            //    exliq.Signo = -1;
        //            exliq.Valor = valor/cantidadCuotas;
        //            //exliq.CantidadCuotas = (sbyte)cantidadCuotas;
        //            exliq.Descripcion = descripcion;
        //            //exliq.CuotaActual = (sbyte) cuotaActual;
                
        //            tabla.InsertOnSubmit(exliq);
                    
        //            if (cuotaActual == 1)  // Si es la primer cuota, todo el idextra nuevo para retornarlo
        //                idExtraARetornar = (int) exliq.IDExtrasLiquidacionEmpleado;
        //            cuotaActual++; // Aumento en uno la cuota actual
        //            mesCorrespondiente = mesCorrespondiente.AddMonths(1); // Aumento en 1 el mes correspondiente de la cuota.
        //        }

        //        database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
        //        if (idExtraARetornar != -1)
        //        {
                   
        //            return idExtraARetornar;
                    
        //        }
        //        else
        //            throw new Exception("Error al crear los Extras para el empleado.");


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public int agregarExtraLiquidacionEmpleado(int idEmpleado, DateTime fecha, string descripcion, bool signoPositivo, float valor, int cantidadCuotas)
        {
            Table<ExtrasLiquidAcIon> tablaExtrasLiquidacion =  null;
            Table<CuOtAsExtrasLiquidAcIon> tablaCuotas;
            int idExtraARetornar = -1;
            CuOtAsExtrasLiquidAcIon cuota;
            ExtrasLiquidAcIon el = null;
            int estado = 0;
            try
            {
                tablaExtrasLiquidacion = database.GetTable<ExtrasLiquidAcIon>();
                tablaCuotas = database.GetTable<CuOtAsExtrasLiquidAcIon>();
                DateTime mesCorrespondiente = fecha;

                el = new ExtrasLiquidAcIon();
                el.IDEmpleado = (uint) idEmpleado;
                el.Descripcion = descripcion;
                if (signoPositivo)
                    el.Signo = 1;
                else
                    el.Signo = 0;
                el.CuotaActual = 1;
                el.CantidadCuotas = (byte)cantidadCuotas;

                tablaExtrasLiquidacion.InsertOnSubmit(el);
                 
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                idExtraARetornar = (int)el.IDExtraLiquidacion;
                if (idExtraARetornar == -1)
                {
                    throw new Exception("Error al crear los Extras para el empleado.");
                }

                // Primer estado, al confirmar el insert del extra
                estado = 1;
                
                EntitySet<CuOtAsExtrasLiquidAcIon> set = new EntitySet<CuOtAsExtrasLiquidAcIon>();
                int numCuota = 1;
                while (numCuota <= cantidadCuotas)
                {
                    cuota = new CuOtAsExtrasLiquidAcIon();
                    cuota.Fecha = mesCorrespondiente;
                    cuota.Liquidado = 0;
                    cuota.NumeroCuota = (sbyte) numCuota;
                    numCuota++;
                    cuota.ValorCuota = valor / cantidadCuotas;
                    cuota.IDExtraLiquidacion = el.IDExtraLiquidacion;
                    cuota.ExtrasLiquidAcIon = el;
                  
                    set.Add(cuota);
                    mesCorrespondiente = mesCorrespondiente.AddMonths(1);
                }

                el.CuOtAsExtrasLiquidAcIon = set;
                
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                

                return idExtraARetornar;

            }
            catch (Exception ex)
            {
                if (estado == 1)
                {
                    tablaExtrasLiquidacion.DeleteOnSubmit(el);
                    database.SubmitChanges();

                }
                throw new Exception("Error al ingresar los extras. " + ex.Message); 
            }
            
        }



        public void modificarExtraLiquidacionEmpleado(int idEmpleado, int idExtraLiquidacionEmpleado, DateTime fecha, string descripcion, bool  signoPositivo, float valor, int cantidadCuotas)
        {
            throw new NotImplementedException("El metodo modificarExtraLiquidacionEmpleado");
            // Restricciones. Ver como trabajar con los extras que tienen cuotas. En ppio no se puede editar extras con cuotas.
            // Tratar de hacer alguna logica que permite modificar las cuotas restantes, que no esten liquidadas.
            //try
            //{
            //    Table<ExtrasLiquidAcIon> tabla = database.GetTable<ExtrasLiquidAcIon>();

            //    // Chequeo que no esten editando un extra que ya se ha liquidado alguna cuota anterior.
            //    var Cuotas =from reg in tabla
            //                           where reg.IDEmpleado == idEmpleado && reg.IDExtraLiquidacion == (uint) idExtraLiquidacionEmpleado
            //                           select (int) reg.CantidadCuotas;
            //    if (Cuotas.Count<int>() > 1)
            //        throw new Exception("No se puede editar un extra con cuotas.");

            //    var extra = (from reg in tabla
            //                where reg.IDEmpleado == idEmpleado && reg.IDExtraLiquidacion == idExtraLiquidacionEmpleado
            //                select reg).Single();

            //    //if (signoPositivo)
            //    //    extra.Signo = 1;
            //    //else
            //    //    extra.Signo = -1;
            //    extra.Descripcion = descripcion;
            //    //extra.CantidadCuotas = (sbyte) cantidadCuotas;
            //    extra.ValorTotal = valor / cantidadCuotas;
            //    extra.Fecha = fecha;

            //    database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
        
        public void eliminarExtraLiquidacionEmpleado(int idEmpleado, int idExtraLiquidacionEmpleado, DateTime mesSeleccionado)
        {
            throw new NotImplementedException();
            // REstricciones: - NO se puede eliminar los extras que sean de mas de 1 cuota y tenga alguna cuota liquidada.
            //try
            //{
            //    Table<ExtrasLiquidAcIonEmPleadO> tabla = database.GetTable<ExtrasLiquidAcIonEmPleadO>();
                
            //    // Chequeo que no esten editando un extra que ya se ha liquidado alguna cuota anterior.
            //    var CantCuotasLiquidadas = (from reg in tabla
            //                           where reg.IDEmpleado == idEmpleado && reg.IDExtraLiquidacionEmpleado == idExtraLiquidacionEmpleado
            //                           //&& reg.Liquidado == 1
            //                           select 1).Count();
            //    if (CantCuotasLiquidadas >= 1)
            //        throw new Exception("No se puede eliminar un extra con alguna cuota liquidada.");

            //    var ListExtras = from reg in tabla 
            //                     where reg.IDEmpleado == idEmpleado && reg.IDExtraLiquidacionEmpleado==idExtraLiquidacionEmpleado
            //                     select reg;

            //    // Chequeo que solo se pueda eliminar un extra desde el mes correspondiente a la primer cuota.
            //    int cuota = 1; //(int)((from reg in tabla
            //    //                      where reg.IDEmpleado == idEmpleado && reg.IDExtraLiquidacionEmpleado == idExtraLiquidacionEmpleado && reg.Fecha.Month == mesSeleccionado.Month && reg.Fecha.Year == mesSeleccionado.Year
            //    //                      select reg.CuotaActual).Single());
            //    if (cuota != 1)
            //        throw new Exception("Para eliminar todas las cuotas del extra debe eliminarlo desde el Mes de la Primer Cuota.");


            //    tabla.DeleteAllOnSubmit(ListExtras);
            //    database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }        

        //public List<ExtrasLiquidAcIonEmPleadO> obtenerExtrasLiquidacionEmpleado(int idEmpleado, DateTime mesCorrespondiente)
        //{
        //    try
        //    {
        //        Table<ExtrasLiquidAcIonEmPleadO> tabla = database.GetTable<ExtrasLiquidAcIonEmPleadO>();

        //        List<ExtrasLiquidAcIonEmPleadO> listaExtras = (from reg in tabla
        //                           where reg.IDEmpleado == idEmpleado && mesCorrespondiente.Month == reg.Fecha.Month && reg.Fecha.Year == mesCorrespondiente.Year
        //                           select reg).ToList<ExtrasLiquidAcIonEmPleadO>();

        //        return listaExtras;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public List<ExtrasLiquidAcIon> obtenerExtrasLiquidacionEmpleado(int idEmpleado, DateTime mesCorrespondiente)
        {
            try
            {
                Table<ExtrasLiquidAcIon> tabla = database.GetTable<ExtrasLiquidAcIon>();
                Table<CuOtAsExtrasLiquidAcIon> tablaCuotas = database.GetTable<CuOtAsExtrasLiquidAcIon>();
                var opts = new DbLinq.Data.Linq.DataLoadOptions();
                opts.LoadWith((ExtrasLiquidAcIon elq) => elq.CuOtAsExtrasLiquidAcIon);
                //opts.LoadWith<ExtrasLiquidAcIon>(eliq => eliq.CuOtAsExtrasLiquidAcIon);
                database.LoadOptions = opts;
                List<ExtrasLiquidAcIon> listaExtras = (from reg in tabla
                                                       from cuotas in reg.CuOtAsExtrasLiquidAcIon
                                                               where reg.IDEmpleado == idEmpleado && mesCorrespondiente.Month == cuotas.Fecha.Month && cuotas.Fecha.Year == mesCorrespondiente.Year
                                                               select reg).ToList<ExtrasLiquidAcIon>();

                return listaExtras;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<CuOtAsExtrasLiquidAcIon> obtenerCuotasExtrasLiquidacionEmpleado(int idEmpleado, DateTime mes)
        {
            try
            {
                Table<ExtrasLiquidAcIon> tabla = database.GetTable<ExtrasLiquidAcIon>();
                Table<CuOtAsExtrasLiquidAcIon> tablaCuotas = database.GetTable<CuOtAsExtrasLiquidAcIon>();
                var opts = new DbLinq.Data.Linq.DataLoadOptions();
                opts.LoadWith((CuOtAsExtrasLiquidAcIon elq) => elq.ExtrasLiquidAcIon);
                //opts.LoadWith<ExtrasLiquidAcIon>(eliq => eliq.CuOtAsExtrasLiquidAcIon);
                //database.LoadOptions = opts;
                List<CuOtAsExtrasLiquidAcIon> listaCuotasDelMes = (from extra in tabla
                                                             from cuota in extra.CuOtAsExtrasLiquidAcIon
                                                               where extra.IDEmpleado == idEmpleado && mes.Month == cuota.Fecha.Month && cuota.Fecha.Year == mes.Year
                                                               select cuota).ToList<CuOtAsExtrasLiquidAcIon>();

                return listaCuotasDelMes;

            }
            catch (Exception ex)
            {
                throw ex;
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

        #region ABM_Ciudades
        public int altaCiudad(string nombreCiudad, bool activo)
        {
            try
            {
                Table<CIudAdEs> tabla = database.GetTable<CIudAdEs>();
                CIudAdEs dep = new CIudAdEs();

                dep.Nombre = nombreCiudad;

                tabla.InsertOnSubmit(dep);
                database.SubmitChanges();
                return dep.IDCiudades;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void modificarCiudad(int idCiudad, string nombreCiudad, bool activo)
        {
            try
            {
                Table<CIudAdEs> tabla = database.GetTable<CIudAdEs>();
                CIudAdEs dep = (from reg in tabla
                                where reg.IDCiudades == idCiudad
                                     select reg).Single();

                dep.Nombre = nombreCiudad;
                //dep.Activo = activo;

                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<int, string> obtenerCiudades(bool soloActivos)
        {
            Dictionary<int, string> result;
            Table<CIudAdEs> tabla;
            try
            {
                tabla = database.GetTable<CIudAdEs>();
                result = new Dictionary<int, string>();
                List<CIudAdEs> listRes;
                if (!soloActivos)
                    listRes = tabla.ToList<CIudAdEs>();
                else
                    listRes = tabla.ToList<CIudAdEs>();
                //listRes = (from reg in tabla
                //           where reg.activo == 1
                //           select reg).ToList<DepartAmenToS>();

                foreach (CIudAdEs l in listRes)
                {
                    result.Add(l.IDCiudades, l.Nombre);
                }
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void bajaCiudad(int idCiudad)
        { }

        #endregion

        #region ABM_Barrios
        public int altaBarrio(string nombreBarrio, bool activo)
        {
            try
            {
                Table<BarrioS> tabla = database.GetTable<BarrioS>();
                BarrioS dep = new BarrioS();

                dep.Nombre = nombreBarrio;

                tabla.InsertOnSubmit(dep);
                database.SubmitChanges();
                return dep.IDBarrio;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void modificarBarrio(int idBarrio, string nombreBarrio, bool activo)
        {
            try
            {
                Table<BarrioS> tabla = database.GetTable<BarrioS>();
                BarrioS dep = (from reg in tabla
                               where reg.IDBarrio == idBarrio
                                     select reg).Single();

                dep.Nombre = nombreBarrio;
                //dep.Activo = activo;

                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<int, string> obtenerBarrios(bool soloActivos)
        {
            Dictionary<int, string> result;
            Table<BarrioS> tabla;
            try
            {
                tabla = database.GetTable<BarrioS>();
                result = new Dictionary<int, string>();
                List<BarrioS> listRes;
                if (!soloActivos)
                    listRes = tabla.ToList<BarrioS>();
                else
                    listRes = tabla.ToList<BarrioS>();
                //listRes = (from reg in tabla
                //           where reg.activo == 1
                //           select reg).ToList<DepartAmenToS>();

                foreach (BarrioS l in listRes)
                {
                    result.Add(l.IDBarrio, l.Nombre);
                }
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void bajaBarrio(int idBarrio)
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

        #region BD_Schema
        public List<string> obtenerNombreTablas()
        {
            try
            {
                List<string> res = new List<string>();
                database.Connection.Open();
                var dataTables = database.Mapping;
                database.Connection.Close();
                foreach (var tabla in dataTables.GetTables())
                {
                    res.Add(tabla.TableName);
                }
                
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet obtenerDataFromTable(string nombreTabla, List<string> listaColumnas, bool incluirInactivos)
        {
            try
            {
                MySqlConnection conexion = (MySqlConnection) database.Connection;
                string campos = "";
                if (listaColumnas.Count == 0)
                    campos = "*";
                else
                    foreach (string str in listaColumnas)
                    {
                        if (listaColumnas.Last<string>() == str)
                            campos += str;
                        else
                            campos += str + ", ";
                    }

                string sql = "SELECT " + campos + " FROM " + nombreTabla;
                if (obtenerTableColumnsName(obtenerNombreBaseDatos()+"."+nombreTabla).Contains("Activo"))
                    if (!incluirInactivos)
                        sql += " where Activo = 1";
                    
                MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter(sql, conexion);
                DataSet sd = new DataSet();
                mysqlAdapter.Fill(sd);
                conexion.Close();

                return sd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> obtenerTableColumnsName(string nombreTabla)
        {
            try
            {
                List<string> res = new List<string>();
                database.Connection.Open();
                var dataTables = database.Mapping;
                database.Connection.Close();
                foreach (var tabla in dataTables.GetTables())
                {
                    if (tabla.TableName ==nombreTabla)
                    {
                        foreach (var column in tabla.RowType.DataMembers)
                        {
                            res.Add(column.MappedName);
                        }
                        break;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string obtenerNombreBaseDatos()
        {
            return database.Connection.Database;
        }

        public List<string> obtenerColumnasDeTabla(string nombreTabla)
        {
            try
            {
                List<string> res = new List<string>();
                //database.Connection.Open();
                var dataTables = database.Mapping;
                //database.Connection.Close();
                string nomtabla = nombreTabla.Split(".".ToCharArray()[0])[1];
                foreach (var tabla in dataTables.GetTables())
                {
                    string nomtablatemp = tabla.TableName.Split(".".ToCharArray()[0])[1];
                    if (nomtabla == nomtablatemp)
                    {
                        foreach (var column in tabla.RowType.DataMembers)
                        {
                            res.Add(column.MappedName);
                        }
                        break;
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        #endregion

        public void altaContratoServicioCliente(int NumeroCliente, int NumeroServicio, int NumeroContrato, DateTime FechaInicio, DateTime? FechaFin, bool CostoFijo, bool HorasExtras, string Ajuste, string Observaciones, float Monto)
        {

            ContraToS con = null;

            try
            {
                con = new ContraToS();

                con.TipodeContrato = 0;
                con.IDContratos = (uint)NumeroContrato;
                con.FechaIni = FechaInicio;
                con.FechaFin = FechaFin;
                if (CostoFijo)
                    con.CostoFijo = 1;
                else
                    con.CostoFijo = 0;
                if (HorasExtras)
                    con.HorasExtras = 1;
                else
                    con.HorasExtras = 0;
                con.Ajuste = Ajuste;
                con.Observaciones = Observaciones;
                con.Costo = Monto;

                Table<ContraToS> tablaContratos = database.GetTable<ContraToS>();
                tablaContratos.InsertOnSubmit(con);

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
        public ContraToS obtenerContrato(int NumeroCliente, int NumeroServicio)
           {
            try
            {
                int ID = NumeroCliente * 1000 + NumeroServicio;
                Table<ContraToS> tablaContrato = database.GetTable<ContraToS>();
                var con = (from conreg in tablaContrato
                           where conreg.IDContratos==ID
                           select conreg);
                if (con.Count<ContraToS>() == 0)
                    throw new NoExisteException("No existe el contrato para el Cliente " + NumeroCliente + " - Servicio: " + NumeroServicio);

                return con.Single<ContraToS>();
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

        public ContraToS obtenerContrato(int NumeroContrato)
        {
            try
            {

                Table<ContraToS> tablaContrato = database.GetTable<ContraToS>();
                var con = (from conreg in tablaContrato
                           where conreg.IDContratos == NumeroContrato
                           select conreg);
                if (con.Count<ContraToS>() == 0)
                    throw new NoExisteException("No existe el contrato con número " + NumeroContrato);

                return con.Single<ContraToS>();
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
        
        public void modificarContrato(int numeroContrato, DateTime FechaInicial, DateTime? FechaFinal, bool Costo, bool HorasExtras, string Ajuste, string Observaciones, float Monto)
        {
            try
            {   ;
                ContraToS con = (from conreg in database.GetTable<ContraToS>()
                                 where conreg.IDContratos == numeroContrato
                                 select conreg).Single<ContraToS>();
                con.FechaIni = FechaInicial;
                con.FechaFin = FechaFinal;
                if (Costo)
                    con.CostoFijo = 1;
                else
                    con.CostoFijo = 0;
                if (HorasExtras)
                    con.HorasExtras = 1;
                else
                    con.HorasExtras = 0;
                con.Ajuste = Ajuste;
                con.Observaciones = Observaciones;
                con.Costo = Monto;
                
                database.SubmitChanges();

                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        

        public void altaContrato(ContraToS Contrato, List<LineAshOrAs> Lineas)
        {
            System.Data.Common.DbConnection conexion = database.Connection;
            try
            {
                //database.ContraToS.InsertOnSubmit(Contrato);
                //database.GetTable<ContraToS>().InsertOnSubmit(Contrato);
                //database.SubmitChanges();

                //ContraToS con = database.ContraToS.Single(c => c.IDContratos == Contrato.IDContratos);
                
                
                // Inserción del contrato
                string nombreTabla = database.Connection.Database + ".contratos";
                List<string> campos = obtenerColumnasDeTabla(nombreTabla);
                string st = "INSERT INTO ";
                st += nombreTabla + " (";
                foreach (string columna in campos)
                {
                    if (campos.Last<string>().Equals(columna))
                        st += columna + ") ";
                    else
                        st += columna + ", ";
                }
                st += " VALUES(";
                st += "'" + Contrato.Ajuste.ToString() + "', ";
                st += Contrato.Costo.ToString() + ", ";
                st += Contrato.CostoFijo.ToString() + ", ";
                st += "NULL, ";
                if (Contrato.FechaFin==null)
                    st += "NULL, ";
                else
                    st += "'" + string.Format("{0:yyyy-MM-dd}", Contrato.FechaFin) + "', ";

                
                st += "'" + string.Format("{0:yyyy-MM-dd}", Contrato.FechaIni) + "', ";
                st += Contrato.HorasExtras.ToString() + ", ";
                st += Contrato.IDContratos.ToString() + ", ";
                st += "'" + Contrato.Observaciones.ToString() + "', ";
                st += "NULL, ";
                st += "NULL, ";
                st += Contrato.TipodeContrato.ToString() + ", ";
                st += "NULL, ";
                st += "NULL, ";
                st += "NULL)";

                
                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();
                System.Data.Common.DbTransaction tran = conexion.BeginTransaction();
                database.Transaction = tran;
                database.ExecuteCommand(st, null);
                
                nombreTabla = database.Connection.Database + ".lineashoras";
                string sqlLineasHoras = "INSERT INTO " + nombreTabla +" (";
                campos = obtenerColumnasDeTabla(nombreTabla);
                
                foreach (string columna in campos)
                {
                    if (campos.Last<string>().Equals(columna))
                         sqlLineasHoras += columna + ") ";
                    else
                        sqlLineasHoras += columna + ", ";
                }
                sqlLineasHoras += " VALUES(";
                string tempsql;
                string sqlhorariodia;
                foreach (LineAshOrAs lh in Lineas)
                {
                    tempsql = sqlLineasHoras;
                    tempsql += lh.Armado.ToString() + ", ";
                    tempsql += "NULL, ";
                    tempsql += "NULL, ";                    
                    tempsql += lh.Cantidad.ToString() + ", ";
                    tempsql += lh.IDContrato.ToString() + ", ";
                    tempsql += lh.NroLinea.ToString() + ", ";
                    tempsql += lh.PrecioXhOra.ToString() + ", ";
                    tempsql += "'" + lh.Puesto.ToString() + "')";
                    database.ExecuteCommand(tempsql, null);
                    nombreTabla = database.Connection.Database + ".horariodia";
                    campos = obtenerColumnasDeTabla(nombreTabla);
                    sqlhorariodia = "INSERT INTO " + nombreTabla + "(";
                    foreach (string columna in campos)
                    {
                        if (campos.Last<string>().Equals(columna))
                            sqlhorariodia += columna + ") ";
                        else
                        sqlhorariodia += columna + ", ";
                    }
                    sqlhorariodia += " VALUES (";
                    foreach (HoRaRioDiA dh in lh.HoRaRioDiA)
                    {
                        tempsql = sqlhorariodia;
                        tempsql += "'"+dh.Dia.ToString() + "', ";
                        tempsql += "'"+dh.HoraFin.ToString() + "', ";
                        tempsql += "'" + dh.HoraIni.ToString() + "', ";
                        tempsql += dh.IDContrato.ToString() + ", ";
                        tempsql += dh.NroLinea.ToString() + ")";
                        database.ExecuteCommand(tempsql, null);
                    }
                    
                }
                database.Transaction.Commit();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                //database.SubmitChanges();
            }
            catch (MySqlException ex)
            {
                //database.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues);
                // database.Connection.Close();
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                if (ex.Number == 1062)
                {
                    // int index = database.GetChangeSet().Inserts.IndexOf(cliente);
                    // database.GetChangeSet().Inserts.RemoveAt(index);
                    database.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                }
                throw ex;
            }
            catch (Exception ex)
            {
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                throw ex;
            } 
        }

        public void eliminarLineasContrato(int NumeroContrato)
        {
            System.Data.Common.DbConnection conexion = database.Connection;
            try
            {
                string sqlHoras = @"DELETE FROM trustdb.horariodia WHERE IdContrato=" + NumeroContrato.ToString();

                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();
                System.Data.Common.DbTransaction tran = conexion.BeginTransaction();
                database.Transaction = tran;
                database.ExecuteCommand(sqlHoras, null);                
                database.Transaction.Commit();

                tran = conexion.BeginTransaction();
                database.Transaction = tran;
                string sqllineas = @"DELETE FROM trustdb.lineashoras WHERE IdContrato=" + NumeroContrato.ToString();
                database.ExecuteCommand(sqllineas, null);
                
                database.Transaction.Commit();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();                
            }
            catch (MySqlException ex)
            {
                //database.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues);
                // database.Connection.Close();
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                if (ex.Number == 1062)
                {
                    // int index = database.GetChangeSet().Inserts.IndexOf(cliente);
                    // database.GetChangeSet().Inserts.RemoveAt(index);
                    database.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                }
                throw ex;
            }
            catch (Exception ex)
            {
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                throw ex;
            }
            
            
            /*
            try
            {
               var lineas = (from lin in database.GetTable<LineAshOrAs>()
                                            where lin.IDContrato == (uint)NumeroContrato
                                            select lin).ToList<LineAshOrAs>();                

                List<HoRaRioDiA> hors = new List<HoRaRioDiA>();
                if (lineas.Count != 0)
                {
                    foreach (LineAshOrAs lh in lineas)
                    {
                        foreach (HoRaRioDiA h in lh.HoRaRioDiA)
                        {
                            if (h.IDContrato == lh.IDContrato && h.NroLinea == lh.NroLinea)
                                hors.Add(h);
                        }
                    }

                    Table<HoRaRioDiA> TablaHD = database.GetTable<HoRaRioDiA>();
                    TablaHD.DeleteAllOnSubmit(hors);
                    database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                }
                Table<LineAshOrAs> TablaLH = database.GetTable<LineAshOrAs>();
                TablaLH.DeleteAllOnSubmit(lineas);
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            */
        }
           
        
        public void guardarLineasContrato(List<LineAshOrAs> Lineas)
        {
            System.Data.Common.DbConnection conexion = database.Connection;
            try
            {
                string nombreTabla = database.Connection.Database + ".lineashoras";
                string sqlLineasHoras = "INSERT INTO " + nombreTabla + " (";
                List<string> campos = obtenerColumnasDeTabla(nombreTabla);

                foreach (string columna in campos)
                {
                    if (campos.Last<string>().Equals(columna))
                        sqlLineasHoras += columna + ") ";
                    else
                        sqlLineasHoras += columna + ", ";
                }
                sqlLineasHoras += " VALUES(";
                string tempsql;
                string sqlhorariodia;

                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();
                System.Data.Common.DbTransaction tran = conexion.BeginTransaction();
                database.Transaction = tran;
                                
                foreach (LineAshOrAs lh in Lineas)
                {
                    tempsql = sqlLineasHoras;
                    tempsql += lh.Armado.ToString() + ", ";
                    tempsql += "NULL, ";
                    tempsql += "NULL, ";
                    tempsql += lh.Cantidad.ToString() + ", ";
                    tempsql += lh.IDContrato.ToString() + ", ";
                    tempsql += lh.NroLinea.ToString() + ", ";
                    tempsql += lh.PrecioXhOra.ToString() + ", ";
                    tempsql += "'" + lh.Puesto.ToString() + "')";
                    database.ExecuteCommand(tempsql, null);
                    nombreTabla = database.Connection.Database + ".horariodia";
                    campos = obtenerColumnasDeTabla(nombreTabla);
                    sqlhorariodia = "INSERT INTO " + nombreTabla + "(";
                    foreach (string columna in campos)
                    {
                        if (campos.Last<string>().Equals(columna))
                            sqlhorariodia += columna + ") ";
                        else
                            sqlhorariodia += columna + ", ";
                    }
                    sqlhorariodia += " VALUES (";
                    foreach (HoRaRioDiA dh in lh.HoRaRioDiA)
                    {
                        tempsql = sqlhorariodia;
                        tempsql += "'" + dh.Dia.ToString() + "', ";
                        tempsql += "'" + dh.HoraFin.ToString() + "', ";
                        tempsql += "'" + dh.HoraIni.ToString() + "', ";
                        tempsql += dh.IDContrato.ToString() + ", ";
                        tempsql += dh.NroLinea.ToString() + ")";
                        database.ExecuteCommand(tempsql, null);
                    }

                }
                database.Transaction.Commit();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                //database.SubmitChanges();
            }
            catch (MySqlException ex)
            {
                //database.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues);
                // database.Connection.Close();
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                if (ex.Number == 1062)
                {
                    // int index = database.GetChangeSet().Inserts.IndexOf(cliente);
                    // database.GetChangeSet().Inserts.RemoveAt(index);
                    database.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                }
                throw ex;
            }
            catch (Exception ex)
            {
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                throw ex;
            }
        }



        

        public bool existeEmpleadoCI(string CI, out EmPleadOs empleado)
        {   
            empleado = null;
            try
            {
                Table<EmPleadOs> tabla = database.GetTable<EmPleadOs>();
                var cli = (from clireg in tabla
                           where clireg.NumeroDocumento == CI
                           select clireg);
                if (cli.Count<EmPleadOs>() == 0)
                    return false;

                empleado = cli.Single<EmPleadOs>();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                // MySQLException = Access Denied  Codigo = 1045
            }
        }

        public void altaListaNegra(string CI, string apellidos, string nombres, string motivo)
        {
            Table<ListAnEGRa> tablaListaNegra;
            try
            {
                tablaListaNegra = database.GetTable<ListAnEGRa>();

                ListAnEGRa emp = new ListAnEGRa();
                DateTime? hoy = DateTime.Now;

                emp.CI = CI;
                emp.Apellidos = apellidos;
                emp.Nombres = nombres;
                emp.MotivoRechazo = motivo;
                emp.Activo = 1;
                emp.FechaAlta = hoy;

                tablaListaNegra.InsertOnSubmit(emp);
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        public void modificarListaNegra(string CI, string apellidos, string nombres, string motivo)
        {
            Table<ListAnEGRa> tablaListaNegra;
            try
            {
                tablaListaNegra = database.GetTable<ListAnEGRa>();

                ListAnEGRa emp = (from reg in tablaListaNegra
                                 where reg.CI == CI
                                 select reg).Single();

                emp.Apellidos = apellidos;
                emp.Nombres = nombres;
                emp.MotivoRechazo = motivo;

                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool existeEmpleadoListaNegra(string CI, out ListAnEGRa empleado)
        {
            empleado = null;
            try
            {
                Table<ListAnEGRa> tabla = database.GetTable<ListAnEGRa>();
                var cli = (from clireg in tabla
                           where clireg.CI == CI && clireg.Activo == 1
                           select clireg);
                if (cli.Count<ListAnEGRa>() == 0)
                    return false;

                empleado = cli.Single<ListAnEGRa>();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                // MySQLException = Access Denied  Codigo = 1045
            }
        }

        public void BajaListaNegra(string CI)
        {
            Table<ListAnEGRa> tablaListaNegra;
            try
            {
                tablaListaNegra = database.GetTable<ListAnEGRa>();

                ListAnEGRa emp = (from reg in tablaListaNegra
                                  where reg.CI == CI
                                  select reg).Single();

                emp.FechaBaja = DateTime.Now;
                emp.Activo = 0;

                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void altaEmpleadoDesdeListaNegra(string CI, string nroEmpleado, string apellidos, string nombres, string observaciones)
        {
            Table<EmPleadOs> tablaEmpleados;
            try
            {
                tablaEmpleados = database.GetTable<EmPleadOs>();

                EmPleadOs emp = new EmPleadOs();

                emp.NroEmpleado = (uint)int.Parse(nroEmpleado);
                emp.Nombre = nombres;
                emp.Apellido = apellidos;                
                emp.NumeroDocumento = CI;
                emp.Observaciones = observaciones;
                emp.FechaIngreso = DateTime.Now;
                emp.BpsfEchaAlta = DateTime.Now;
                emp.NivelEducativo = "Primario";
                emp.Activo = 1;                

                tablaEmpleados.InsertOnSubmit(emp);
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
        
        public int obtenerMaxIdCliente()
        {
            try
            {
                var maxId = (from reg in database.GetTable<ClientEs>()
                             select (int)reg.NumeroCliente).Max<int>();

                return maxId;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
              

        public bool existeEscalafon(int nroEsc)
        {
            try
            {
                var cli = (from clireg in database.GetTable<EScalaFOn>()
                           where clireg.IDEscalafon == nroEsc
                           select clireg);
                if (cli.Count<EScalaFOn>() == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw ex;                
            }
        }

        public void altaEscalafon(EScalaFOn escalafon, List<EScalaFOneMpLeadO> lineas)
        {
            System.Data.Common.DbConnection conexion = database.Connection;
            try
            {
                // Inserción de Escalafon 
                string nombreTabla = database.Connection.Database + ".escalafon";
                List<string> campos = obtenerColumnasDeTabla(nombreTabla);
                string st = "INSERT INTO ";
                st += nombreTabla + " (";
                
                foreach (string columna in campos)
                {
                    if (campos.Last<string>().Equals(columna))
                        st += columna + ") ";
                    else
                        st += columna + ", ";
                }
                st += " VALUES(";
                st += "0, ";
                st += escalafon.IDContrato.ToString() + ", ";
                st += escalafon.IDEscalafon.ToString() + ", ";
                st += escalafon.NumeroCliente.ToString() + ", ";                
                st += escalafon.NumeroServicio.ToString() + ")";


                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();
                System.Data.Common.DbTransaction tran = conexion.BeginTransaction();
                database.Transaction = tran;
                database.ExecuteCommand(st, null);

                nombreTabla = database.Connection.Database + ".escalafonempleado";
                string sqlLineasHoras = "INSERT INTO " + nombreTabla + " (";
                campos = obtenerColumnasDeTabla(nombreTabla);

                foreach (string columna in campos)
                {
                    if (campos.Last<string>().Equals(columna))
                        sqlLineasHoras += columna + ") ";
                    else
                        sqlLineasHoras += columna + ", ";
                }
                sqlLineasHoras += " VALUES(";
                string tempsql;
                string sqlhorariodia;
                foreach (EScalaFOneMpLeadO lh in lineas)
                {
                    tempsql = sqlLineasHoras;
                    tempsql += "'" + lh.AcArgoDe + "', '";
                    tempsql += lh.CodigoPuesto + "', ";
                    tempsql += lh.HsLlamadaAntesHoraInicio.ToString() + ", ";
                    tempsql += lh.IDEscalafon.ToString() + ", ";
                    tempsql += lh.IDEscalafonEmpleado.ToString() + ", ";                    
                    tempsql += lh.NroEmpleado.ToString() + ")";
                    database.ExecuteCommand(tempsql, null);
                    nombreTabla = database.Connection.Database + ".horarioescalafon";
                    campos = obtenerColumnasDeTabla(nombreTabla);
                    sqlhorariodia = "INSERT INTO " + nombreTabla + "(";
                    foreach (string columna in campos)
                    {
                        if (campos.Last<string>().Equals(columna))
                            sqlhorariodia += columna + ") ";
                        else
                            sqlhorariodia += columna + ", ";
                    }
                    sqlhorariodia += " VALUES (";
                    foreach (HoRaRioEScalaFOn dh in lh.HoRaRioEScalaFOn)
                    {
                        tempsql = sqlhorariodia;
                        tempsql += "'" + dh.DiA + "', ";
                        tempsql += "'" + dh.HoRaFIn + "', ";
                        tempsql += "'" + dh.HoRaInI + "', ";
                        tempsql += dh.IDEscalafon.ToString() + ", ";
                        tempsql += dh.IDEscalafonEmpleado.ToString() + ", ";
                        tempsql += dh.TipoDia.ToString() + ")";
                        database.ExecuteCommand(tempsql, null);
                    }

                }
                database.Transaction.Commit();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                //database.SubmitChanges();
            }
            catch (MySqlException ex)
            {
                //database.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues);
                // database.Connection.Close();
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                if (ex.Number == 1062)
                {
                    // int index = database.GetChangeSet().Inserts.IndexOf(cliente);
                    // database.GetChangeSet().Inserts.RemoveAt(index);
                    database.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                }
                throw ex;
            }
            catch (Exception ex)
            {
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                throw ex;
            } 
        }

        public string getNombreEmpleado(int nroEmpleado)
        {
            Table<EmPleadOs> tabla;
            try
            {
                tabla = database.GetTable<EmPleadOs>();
                var cli = (from clireg in tabla
                           where clireg.NroEmpleado == nroEmpleado
                           select clireg);
                if (cli.Count<EmPleadOs>() == 0)
                    return "";
                else
                    return cli.Single<EmPleadOs>().Nombre + " " + cli.Single<EmPleadOs>().Apellido;
            }
            catch (Exception ex)
            {
                throw ex;               
            }
        }      

        public EScalaFOn obtenerEscalafon(int NroEscalafon)
        {
            try
            {
                Table<EScalaFOn> tablaEscalafon = database.GetTable<EScalaFOn>();
                var con = (from conreg in tablaEscalafon
                           where conreg.IDEscalafon == NroEscalafon
                           select conreg);
                if (con.Count<EScalaFOn>() == 0)
                    throw new NoExisteException("No existe el escalafón con número " + NroEscalafon);

                return con.Single<EScalaFOn>();
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

        public void eliminarLineasEscalafon(int NroEscalafon)
        {
            System.Data.Common.DbConnection conexion = database.Connection;
            try
            {
                string sqlHoras = @"DELETE FROM trustdb.horarioescalafon WHERE idEscalafon=" + NroEscalafon.ToString();

                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();
                System.Data.Common.DbTransaction tran = conexion.BeginTransaction();
                database.Transaction = tran;
                database.ExecuteCommand(sqlHoras, null);
                database.Transaction.Commit();

                tran = conexion.BeginTransaction();
                database.Transaction = tran;
                string sqllineas = @"DELETE FROM trustdb.escalafonempleado WHERE idEscalafon=" + NroEscalafon.ToString();
                database.ExecuteCommand(sqllineas, null);

                database.Transaction.Commit();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (MySqlException ex)
            {
                //database.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues);
                // database.Connection.Close();
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                if (ex.Number == 1062)
                {
                    // int index = database.GetChangeSet().Inserts.IndexOf(cliente);
                    // database.GetChangeSet().Inserts.RemoveAt(index);
                    database.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                }
                throw ex;
            }
            catch (Exception ex)
            {
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                throw ex;
            }
        }
        
        public void guardarLineasEscalafon(List<EScalaFOneMpLeadO> lineas)
        {
            System.Data.Common.DbConnection conexion = database.Connection;
            try
            {
                string nombreTabla = database.Connection.Database + ".escalafonempleado";
                string sqlLineasHoras = "INSERT INTO " + nombreTabla + " (";
                List<string> campos = obtenerColumnasDeTabla(nombreTabla);

                foreach (string columna in campos)
                {
                    if (campos.Last<string>().Equals(columna))
                        sqlLineasHoras += columna + ") ";
                    else
                        sqlLineasHoras += columna + ", ";
                }
                sqlLineasHoras += " VALUES(";
                string tempsql;
                string sqlhorariodia;

                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();
                System.Data.Common.DbTransaction tran = conexion.BeginTransaction();
                database.Transaction = tran;

                foreach (EScalaFOneMpLeadO lh in lineas)
                {
                    tempsql = sqlLineasHoras;
                    tempsql += "'" + lh.AcArgoDe + "', '";
                    tempsql += lh.CodigoPuesto + "', ";
                    tempsql += lh.HsLlamadaAntesHoraInicio.ToString() + ", ";
                    tempsql += lh.IDEscalafon.ToString() + ", ";
                    tempsql += lh.IDEscalafonEmpleado.ToString() + ", ";
                    tempsql += lh.NroEmpleado.ToString() + ")";
                    database.ExecuteCommand(tempsql, null);
                    nombreTabla = database.Connection.Database + ".horarioescalafon";
                    campos = obtenerColumnasDeTabla(nombreTabla);
                    sqlhorariodia = "INSERT INTO " + nombreTabla + "(";
                    foreach (string columna in campos)
                    {
                        if (campos.Last<string>().Equals(columna))
                            sqlhorariodia += columna + ") ";
                        else
                            sqlhorariodia += columna + ", ";
                    }
                    sqlhorariodia += " VALUES (";
                    foreach (HoRaRioEScalaFOn dh in lh.HoRaRioEScalaFOn)
                    {
                        tempsql = sqlhorariodia;
                        tempsql += "'" + dh.DiA + "', ";
                        tempsql += "'" + dh.HoRaFIn + "', ";
                        tempsql += "'" + dh.HoRaInI + "', ";
                        tempsql += dh.IDEscalafon.ToString() + ", ";
                        tempsql += dh.IDEscalafonEmpleado.ToString() + ", ";
                        tempsql += dh.TipoDia.ToString() + ")";
                        database.ExecuteCommand(tempsql, null);
                    }

                }
                database.Transaction.Commit();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                //database.SubmitChanges();
            }
            catch (MySqlException ex)
            {
                //database.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues);
                // database.Connection.Close();
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                if (ex.Number == 1062)
                {
                    // int index = database.GetChangeSet().Inserts.IndexOf(cliente);
                    // database.GetChangeSet().Inserts.RemoveAt(index);
                    database.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues);
                }
                throw ex;
            }
            catch (Exception ex)
            {
                database.Transaction.Rollback();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                throw ex;
            }
        }
        public void modificarEscalafon(EScalaFOn escal)
        {
            Table<EScalaFOn> tabla = database.EScalaFOn;
            try
            {
                EScalaFOn es = (from reg in tabla
                                where reg.IDEscalafon == escal.IDEscalafon
                                select reg).Single();
                es.EScalaFOneMpLeadO = escal.EScalaFOneMpLeadO;
                es.Cubierto = escal.Cubierto;

                database.SubmitChanges();
                   
            }
            
            catch (Exception ex)
            {                
                throw ex;
            }

        }
        
    }

}
