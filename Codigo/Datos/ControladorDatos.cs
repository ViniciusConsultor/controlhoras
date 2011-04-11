using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbLinq;
using DbLinq.MySql;
using DbLinq.Data.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Globalization;
using System.IO;
using Utilidades;
using System.Threading;



namespace Datos
{
    public class ControladorDatos : IDatos
    {
        private static TrustDb database = null;
        private static IDatos instance = null;
        private static MySqlConnection conexion = null;
        private int? IdUsuarioLogueado = null;
        
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
            return instance;
        }

        public void recargarContexto()
        {
            try
            {
                database = createContext();
            }
            catch (Exception e)
            {
                
                throw e;
            }
      
        }

        internal static MySqlConnection createConexion()//(string StringConnection)
        {
            try
            {
                // Cambio las properties a mano por un connection string ya que le da mas modificabilidad.
                ConnectionStringSettingsCollection conections = ConfigurationManager.ConnectionStrings;

                var builder = new MySqlConnectionStringBuilder(conections["TrustDbConnectionString"].ToString());
                //{
                //    //Server = "192.168.1.103",
                //    Server = ConfigurationManager.AppSettings["Servidor"].ToString(),
                //    //Port = 3306,
                //    Port = uint.Parse(ConfigurationManager.AppSettings["Puerto"].ToString()),
                //    //UserID = "usrtrust",
                //    UserID = ConfigurationManager.AppSettings["Usuario"].ToString(),
                //    //Password = "usrtrust",
                //    Password = ConfigurationManager.AppSettings["Password"].ToString(),
                //    //Database = "trustdb",
                //    Database = ConfigurationManager.AppSettings["Base"].ToString(),
                //    Pooling = false,
                //    ConnectionLifeTime = 0,
                //    AllowUserVariables = true
                //};


                MySqlConnection conn = new MySqlConnection(builder.ToString());
                
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

        private MySqlConnection createNewConnection()
        {
            return createConexion();
        }

        internal static TrustDb createContext()
        {
            
            TrustDb context = new TrustDb(getConexion(), new DbLinq.MySql.MySqlVendor());
            //context.Log = new StreamWriter("C:\\dblinq.log"); 
            return context;
        }

        internal static TrustDb getContext()
        {
            if (database == null)
                database = createContext();
            return database;    
        }
        
        
        #region ABM_Cliente
        public void altaCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime? fecAlta, DateTime? fecBaja, string motivo, string referencia, string diaHoraCobro, string contactoCobro, string telefonosCobro, int diaInicioFacturacion, int diaFinFacturacion)
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
                cliente.DiaHoraCobro = diaHoraCobro;
                cliente.ContactoCobro = contactoCobro;
                cliente.TelefonosCobro = telefonosCobro;
                cliente.Referencia = referencia;
                cliente.Fax = fax;
                cliente.Referencia = referencia;
                cliente.FechaAlta = fecAlta;
                cliente.FechaBaja = fecBaja;
                cliente.MotivoBaja = motivo;
                cliente.DiaInicioFacturacion = (short)diaInicioFacturacion;
                cliente.DiaFinFacturacion = (short)diaFinFacturacion;
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

        public List<ClientEs> obtenerClientes(bool soloActivos)
        {
            List<ClientEs> result;
            Table<ClientEs> tabla;
            try
            {
                tabla = database.GetTable<ClientEs>();
                result = new List<ClientEs>();
                
                if (!soloActivos)
                    result = tabla.ToList<ClientEs>();
                else
                    result = (from reg in tabla
                           where reg.Activo == 1
                           select reg).ToList<ClientEs>();
                return result;

            }
            catch (Exception ex)
            {
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
                                        where varcli.Nombre.Contains(Nombre) || varcli.NombreFantasia.Contains(Nombre)
                                        select varcli).ToList<ClientEs>();
                return clies;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
        public void modificarCliente(int numeroCliente, string nombre, string nombreFantantasia, string rut, string email, string direccion, string direccionCobro, string telefono, string fax, bool activo, DateTime? fechaAlta, DateTime? fechaBaja, string motivoBaja, string referencia, string diaHoraCobro, string contactoCobro, string telefonosCobro, int diaInicioFacturacion, int diaFinFacturacion)
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
                cli.DiaHoraCobro = diaHoraCobro;
                cli.ContactoCobro = contactoCobro;
                cli.TelefonosCobro = telefonosCobro;
                cli.Referencia = referencia;
                cli.Fax = fax;
                cli.FechaAlta = fechaAlta;
                cli.FechaBaja = fechaBaja;
                cli.MotivoBaja = motivoBaja;
                cli.DiaInicioFacturacion = (short)diaInicioFacturacion;
                cli.DiaFinFacturacion = (short)diaFinFacturacion;
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
        public void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string Observaciones, bool Activo, DateTime? FechaBaja, string MotivoBaja)
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
                //ser.DiaCobro = DiaDeCobro;
                //ser.NombreCobrar = NombreCobrar;
                ser.Celular = Celular;
                ser.CelularTrust = CelularTrust;
                ser.TareasAsignadas = Tareas;
                ser.Observaciones = Observaciones;
                ser.FechaAlta = DateTime.Now;
                                
                if (Activo)
                    ser.Activo = 1;
                else
                    ser.Activo = 0;
                ser.FechaBaja = FechaBaja;
                ser.MotivoBaja = MotivoBaja;                

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
        public void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string Observaciones, bool activo, DateTime? FechaBaja, string MotivoBaja)
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
                ser.Observaciones = Observaciones;
                ser.Celular = Celular;
                ser.CelularTrust = CelularTrust;
                ser.TareasAsignadas = Tareas;

                if (activo)
                    ser.Activo = 1;
                else
                    ser.Activo = 0;
                ser.FechaBaja = FechaBaja;
                ser.MotivoBaja = MotivoBaja;  

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

        public SERVicIoS obtenerServicioCliente(int numeroCliente, int numeroServicio)
        {
            try
            {

                SERVicIoS servsCli = (from servreg in database.GetTable<SERVicIoS>()
                                            where servreg.NumeroCliente == numeroCliente && servreg.NumeroServicio == numeroServicio
                                            select servreg).Single<SERVicIoS>();
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
        // Deuelve el maximo sin tener en cuenta los empleadosPivot
        {
            int NroFuncionarioPivot=-1;
            int NroFuncionarioVacanteTemporal = -1;
            try
            {
                if (ConfigurationManager.AppSettings.AllKeys.Contains("NroFuncionarioPivot"))
                    if (!int.TryParse(ConfigurationManager.AppSettings["NroFuncionarioPivot"].ToString(), out NroFuncionarioPivot))
                        throw new Exception("El formato de la propiedad NroFuncionarioPivot no es correcto.");
                if (ConfigurationManager.AppSettings.AllKeys.Contains("NroFuncionarioVacanteTemporal"))
                    if (!int.TryParse(ConfigurationManager.AppSettings["NroFuncionarioVacanteTemporal"].ToString(), out NroFuncionarioVacanteTemporal))
                        throw new Exception("El formato de la propiedad NroFuncionarioVacanteTemporal no es correcto.");
           
                var maxId = (from reg in database.GetTable<EmPleadOs>()
                             where reg.NroEmpleado != NroFuncionarioPivot && reg.NroEmpleado != NroFuncionarioVacanteTemporal
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
        public List<EmPleadOs> buscarEmpleaos(string CampoBusqueda, string patronBusqueda, bool incluirInactivos)
        {
            try
            {
                
                List<EmPleadOs> emps;
                
                uint estado = 1;
                if (incluirInactivos)
                    estado = 0;
                switch (CampoBusqueda)
                {
                    case "Nombre":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.Nombre.Contains(patronBusqueda) && varemp.Activo == estado
                                select varemp).ToList<EmPleadOs>();
                        break;
                    case "Apellido":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.Apellido.Contains(patronBusqueda) && varemp.Activo == estado
                                select varemp).ToList<EmPleadOs>();
                        break;
                    case "Direccion":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.Direccion.Contains(patronBusqueda) && varemp.Activo == estado
                                select varemp).ToList<EmPleadOs>();
                        break;
                    case "Telefono":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.Telefonos.Contains(patronBusqueda) && varemp.Activo == estado
                                select varemp).ToList<EmPleadOs>();
                        break;
                    case "Documento":
                        emps = (from varemp in database.GetTable<EmPleadOs>()
                                where varemp.NumeroDocumento.Contains(patronBusqueda) && varemp.Activo == estado
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
                    string sql = makeSQLSentencies(consEmp.Query,parametrosConsulta);
                    
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

        private string makeSQLSentencies(string sql,Dictionary<string,string> parametrosConsulta)
        {
            if (sql.Contains("FECHASOLA"))
            {
                if (parametrosConsulta.ContainsKey("FECHASOLA"))
                {
                    string[] fecha = parametrosConsulta["FECHASOLA"].Split('/');
                    DateTime dt = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
                    string fecha2 = String.Format("{0:yyyy-MM-dd}", dt);
                    sql = sql.Replace("FECHASOLA", fecha2);
                }
                else
                    throw new Exception("No se obtuvieron los parametros necesarios FECHA para ejecutar la consulta");

            }
            if (sql.Contains("NROCLIENTE"))
            {
                if (parametrosConsulta.ContainsKey("NROCLIENTE"))
                {
                    sql = sql.Replace("NROCLIENTE", parametrosConsulta["NROCLIENTE"]);
                    if (sql.Contains("NROSERVICIO"))
                    {
                        if (parametrosConsulta.ContainsKey("NROSERVICIO"))
                        {
                            sql = sql.Replace("NROSERVICIO", parametrosConsulta["NROSERVICIO"]);
                        }
                        else
                            throw new Exception("No se obtuvieron los parametros necesarios NROSERVICIO para ejecutar la consulta");
                    }
                }
                else
                    throw new Exception("No se obtuvieron los parametros necesarios NROCLIENTE para ejecutar la consulta");
            }
            if (sql.Contains("NROEMPLEADO"))
            {
                if (sql.Contains("IFNROEMPLEADO"))
                {
                    if (parametrosConsulta.ContainsKey("NROEMPLEADO"))
                    {
                        // Reemplazamos el IFNROEMPLEADO por el and NroEmpleado-
                        string paraReemp = " and NroEmpleado=" + parametrosConsulta["NROEMPLEADO"];
                        sql = sql.Replace("IFNROEMPLEADO", paraReemp);
                    }
                    else
                    {
                        // Reemplazamos el IFNROEMPLEADO por vacio.
                        sql = sql.Replace("IFNROEMPLEADO", "");
                    }
                }
                else
                {
                    if (parametrosConsulta.ContainsKey("NROEMPLEADO"))
                    {
                        sql = sql.Replace("NROEMPLEADO", parametrosConsulta["NROEMPLEADO"]);
                    }
                    else
                        throw new Exception("No se obtuvieron los parametros necesarios NROEMPLEADO para ejecutar la consulta");
                }
            }
            if (sql.Contains("FECHADESDE") && sql.Contains("FECHAHASTA"))
            {
                if (parametrosConsulta.ContainsKey("FECHADESDE") && parametrosConsulta.ContainsKey("FECHAHASTA"))
                {
                    string[] fecha = parametrosConsulta["FECHADESDE"].Split('/');
                    DateTime dt = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
                    string fecha2 = String.Format("{0:yyyy-MM-dd}", dt);
                    sql = sql.Replace("FECHADESDE", fecha2);

                    fecha = parametrosConsulta["FECHAHASTA"].Split('/');
                    dt = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
                    fecha2 = String.Format("{0:yyyy-MM-dd}", dt);
                    sql = sql.Replace("FECHAHASTA", fecha2);

                }
                else
                    throw new Exception("No se obtuvieron los parametros necesarios NROEMPLEADO para ejecutar la consulta");
            }
            return sql;
        }

        public DataSet ejecutarConsultaCliente(int numeroConsultaCliente, Dictionary<string, string> parametrosConsulta)
        {
            MySqlConnection conexion2;
            try
            {
               
                ConsultAsClientEs consCli = (from reg in database.GetTable<ConsultAsClientEs>()
                                             where reg.IDConsultaCliente == numeroConsultaCliente
                                              select reg).Single();
                if (consCli != null)
                {
                    string sql = makeSQLSentencies(consCli.Query,parametrosConsulta);
                    
                    conexion2 = (MySqlConnection)database.Connection;
                    
                    MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter(sql, conexion2);
                    
                    DataSet sd = new DataSet();
                    mysqlAdapter.Fill(sd);
                    
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
                    throw new NoExisteException("No existe el Evento en el Historial del Empleado " + idEmpleado.ToString());

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
                    throw new NoExisteException("No existe el Evento en el Historial del Empleado " + idEmpleado.ToString());
                //El Borrado Logico en el historial del empleado no tiene mucho sentido. 
                //eventHist.BoRrAdo = 1;
                database.EventOsHistOrIalEmPleadO.DeleteOnSubmit(eventHist);
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
                                 where reg.IDEmpleado == idEmpleado && reg.BoRrAdo == 0
                                 select reg).ToList<EventOsHistOrIalEmPleadO>();

                return eventList;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool empleadoTieneEventosHistorialEnFecha(int NroEmpleado, DateTime Fecha)
        {
            try
            {
               int res = database.EventOsHistOrIalEmPleadO.Where(reg => reg.IDEmpleado == NroEmpleado && reg.BoRrAdo == 0 &&reg.FechaInicio <= Fecha && reg.FechaFin >= Fecha).Count();
               return (res > 0);
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
        
        public void eliminarExtraLiquidacionEmpleado(int idEmpleado, int idExtraLiquidacion, DateTime mesSeleccionado)
        {
            //throw new NotImplementedException();
            // REstricciones: - NO se puede eliminar los extras que sean de mas de 1 cuota y tenga alguna cuota liquidada.
            try
            {
                // Verificamos si tiene alguna cuota paga.
                int cantLiquidadas = (from reg in database.CuOtAsExtrasLiquidAcIon
                                      where reg.IDExtraLiquidacion == idExtraLiquidacion && reg.Liquidado == 1
                                      select reg).Count();
                if (cantLiquidadas > 0) // Si tiene alguna cuota liquidad no se puede eliminar
                    throw new Exception("No se puede eliminar un ExtraLiquidacion con Cuotas ya liquidadas.");
                
                // Si no tiene una cuota paga procedemos con la eliminacion.
                ExtrasLiquidAcIon extras = (from reg in database.ExtrasLiquidAcIon
                                            where reg.IDExtraLiquidacion == idExtraLiquidacion
                                            select reg).Single();
                database.CuOtAsExtrasLiquidAcIon.DeleteAllOnSubmit(extras.CuOtAsExtrasLiquidAcIon);
                database.ExtrasLiquidAcIon.DeleteOnSubmit(extras);
                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                recargarContexto();
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

        #region Contratos
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
            {  
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
                recargarContexto();
                //database.SubmitChanges();
            }
            catch (MySqlException ex)
            {
                //database.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues);
                // database.Connection.Close();
                database.Transaction.Rollback();
                recargarContexto();
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
        #endregion
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

        #region ListaNegra
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
        #endregion
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
              
        public List<HoRaSGeneraDaSEScalaFOn> obtenerHorasGeneradasServicio(int NumeroCliente, int NumeroServicio, DateTime fecha)
        {
            List<HoRaSGeneraDaSEScalaFOn> result;
            Table<HoRaSGeneraDaSEScalaFOn> tabla;
            try
            {
                tabla = database.GetTable<HoRaSGeneraDaSEScalaFOn>();                
                
                result = (from reg in tabla
                          where reg.NumeroCliente == NumeroCliente && reg.NumeroServicio==NumeroServicio && reg.FechaCorrespondiente==fecha
                          select reg).ToList<HoRaSGeneraDaSEScalaFOn>();

                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region TiposMotivoCambioDiario
        public List<TipOsMotIVOCamBIoDiARio> obtenerTiposMotivoCambioDiario(bool soloactivos)
        {
            try
            {
                if (soloactivos)
                    return database.TipOsMotIVOCamBIoDiARio.Where(t => t.Activo == 1).ToList();
                else
                    return database.TipOsMotIVOCamBIoDiARio.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void altaTipoMotivoCambioDiario(TipOsMotIVOCamBIoDiARio t)
        {
            try
            {
                database.TipOsMotIVOCamBIoDiARio.InsertOnSubmit(t);
                database.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public void modificacionTipoMotivoCambioDiario(TipOsMotIVOCamBIoDiARio t)
        {
            try
            {
                TipOsMotIVOCamBIoDiARio treg = (from reg in database.TipOsMotIVOCamBIoDiARio
                                               where reg.IDTipoMotivo == t.IDTipoMotivo
                                               select reg).Single<TipOsMotIVOCamBIoDiARio>();
                if (treg != null)
                {
                    treg.Activo = t.Activo;
                    treg.Descripcion = t.Descripcion;
                    database.SubmitChanges();
                }
                else
                {
                    throw new NoExisteException("No existe un Tipo Motivo Cambio Diario con id " + t.IDTipoMotivo);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void bajaTipoMotivoCambioDiario(TipOsMotIVOCamBIoDiARio t)
        {
            try
            {
                TipOsMotIVOCamBIoDiARio treg = (from reg in database.TipOsMotIVOCamBIoDiARio
                                                where reg.IDTipoMotivo == t.IDTipoMotivo
                                                select reg).Single<TipOsMotIVOCamBIoDiARio>();
                if (treg != null)
                {
                    treg.Activo = t.Activo;
                    database.SubmitChanges();
                }
                else
                {
                    throw new NoExisteException("No existe un Tipo Motivo Cambio Diario con id " + t.IDTipoMotivo);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region MotivosCambioDiario
        public List<MotIVOsCamBiosDiARioS> obtenerMotivosCambiosDiarios(int numeroCliente, int numeroServicio, int nroEmpleado, DateTime fecha)
        {
            try
            {
                List<MotIVOsCamBiosDiARioS> motivosServicio = null;
                if (fecha == null)
                {
                    motivosServicio = (from reg in database.MotIVOsCamBiosDiARioS
                                                                   where reg.NumeroCliente == numeroCliente & reg.NumeroServicio == numeroServicio & reg.NroEmpleado == nroEmpleado
                                                                   select reg).ToList<MotIVOsCamBiosDiARioS>();
                }
                else
                {
                    motivosServicio = (from reg in database.MotIVOsCamBiosDiARioS
                                                                   where reg.NumeroCliente == numeroCliente & reg.NumeroServicio == numeroServicio & reg.FechaCambio == fecha & reg.NroEmpleado == nroEmpleado
                                                                   select reg).ToList<MotIVOsCamBiosDiARioS>();
                }
                return motivosServicio;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void altaMotivosCambiosDiarios(MotIVOsCamBiosDiARioS t)
        {
            try
            {
                database.MotIVOsCamBiosDiARioS.InsertOnSubmit(t);
                database.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void modificacionMotivosCambiosDiarios(MotIVOsCamBiosDiARioS t)
        {
            try
            {
                MotIVOsCamBiosDiARioS treg = (from reg in database.MotIVOsCamBiosDiARioS
                                                where reg.IDMotivoCambioDiario == t.IDMotivoCambioDiario
                                                select reg).Single<MotIVOsCamBiosDiARioS>();
                if (treg != null)
                {
                    treg.IDTipoMotivo = t.IDTipoMotivo;
                    treg.NroEmpleado = t.NroEmpleado;
                    treg.NumeroCliente = t.NumeroCliente;
                    treg.NumeroServicio = t.NumeroServicio;
                    treg.Observaciones = t.Observaciones;                    
                    database.SubmitChanges();
                }
                else
                {
                    throw new NoExisteException("No existe un Motivo Cambio Diario con id " + t.IDTipoMotivo);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region ControlDiario

        public void cambiarFuncionarioControlDiario(long IdHorasGeneragasEscalafon, int NroEmpleadoNuevo, MotIVOsCamBiosDiARioS mtcd)
        {            
            try
            {
                HoRaSGeneraDaSEScalaFOn hs = database.HoRaSGeneraDaSEScalaFOn.Single(p => p.IDHorasGeneradasEscalafon == IdHorasGeneragasEscalafon);
                //EmPleadOs emp = database.EmPleadOs.Single(e => e.NroEmpleado == NroEmpleadoNuevo);

                database.MotIVOsCamBiosDiARioS.InsertOnSubmit(mtcd);
                hs.NroEmpleado = (uint) NroEmpleadoNuevo;
                
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                recargarContexto();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }

        public void cambiarHoraFuncionarioControlDiario(long IdHorasGeneragasEscalafon, int NroEmpleado, DateTime Horanueva, bool Entrada, MotIVOsCamBiosDiARioS mtcd)
        {
           // Table<HoRaSGeneraDaSEScalaFOn> horasGen = database.HoRaSGeneraDaSEScalaFOn;
            try
            {
                recargarContexto();
                HoRaSGeneraDaSEScalaFOn hs = database.HoRaSGeneraDaSEScalaFOn.Single(p => p.IDHorasGeneradasEscalafon == IdHorasGeneragasEscalafon);

                if (Entrada)
                    hs.HoraEntrada = Horanueva;
                else
                    hs.HoraSalida = Horanueva; 
                
                //mtcd.IDHorasGeneradasEscalafon = IdHorasGeneragasEscalafon;                
                mtcd.FechaCorresponde = hs.FechaCorrespondiente;
                mtcd.FechaCambio = DateTime.Now;
                database.MotIVOsCamBiosDiARioS.InsertOnSubmit(mtcd);
                
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public void quitarFuncionarioControlDiario(long IdHorasGeneragasEscalafon, MotIVOsCamBiosDiARioS mtcd)
        {
            try
            {
                recargarContexto();
                HoRaSGeneraDaSEScalaFOn hs = database.HoRaSGeneraDaSEScalaFOn.Single(p => p.IDHorasGeneradasEscalafon == IdHorasGeneragasEscalafon);

                database.MotIVOsCamBiosDiARioS.InsertOnSubmit(mtcd);
                database.HoRaSGeneraDaSEScalaFOn.DeleteOnSubmit(hs);
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Usuarios
        
        public UsUarIoS login(string UserName, string Password)
        {
            string PassEncriptada;
            try
            {
                PassEncriptada = ControladorUtilidades.encriptarStringToMD5(Password);
                var user = (from reg in database.UsUarIoS
                                 where reg.UserName == UserName && reg.Password == PassEncriptada
                                 select reg);
                if (user.Count() == 0)
                {
                    throw new Exception("Usuario o Password incorrecto");
                }
                
                IdUsuarioLogueado = user.Single().IDUsuario;
                return user.Single();
            }
            catch
            {
                throw;
            }
        }

        public int obtenerIdUsuarioLogueado()
        {
            if (IdUsuarioLogueado == null)
                throw new Exception("No hay ningun usuario logueado");

            return (int)IdUsuarioLogueado;

        }

        public void cambiarPasswordUsuario(int IdUsuario, string NewPassword, string OldPassword, bool force)
        {
            // Si force esta en true, no tiene en cuenta que OldPassword sea igual a la password actual. 
            // Directamente se setea la NewPassword.
            try
            {
                UsUarIoS user = (from reg in database.UsUarIoS
                                 where reg.IDUsuario == IdUsuario
                                 select reg).Single();
                if (user == null)
                    throw new Exception("No existe el Usuario con Id: "+IdUsuario);

                if (!force && !ControladorUtilidades.encriptarStringToMD5(OldPassword).Equals(user.Password))
                    throw new Exception("La password actual no coincide.");

                user.Password = ControladorUtilidades.encriptarStringToMD5(NewPassword);
                database.SubmitChanges();
            }catch
            {
                throw;
            }
        }
        #endregion

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
                st += escalafon.Cubierto + ", ";
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
                        tempsql += dh.NroEmpleado + ", ";
                        tempsql += dh.Solapa + ", ";
                        tempsql += dh.TipoDia.ToString() + ")";
                        database.ExecuteCommand(tempsql, null);
                    }

                }
                database.Transaction.Commit();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                recargarContexto();
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

        public string getNombreCliente(int NroCliente)
        {           
            try
            {                
                var cli = (from clireg in database.GetTable<ClientEs>()
                           where clireg.NumeroCliente == NroCliente
                           select clireg);
                if (cli.Count<ClientEs>() == 0)
                    return "";
                else
                    return cli.Single<ClientEs>().Nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public string getNombreServicio(int NroCliente,int nroServicio)
        {
            Table<SERVicIoS> tabla;
            try
            {
                tabla = database.GetTable<SERVicIoS>();
                var cli = (from clireg in tabla
                           where clireg.NumeroServicio == nroServicio && clireg.NumeroCliente == NroCliente
                           select clireg);
                if (cli.Count<SERVicIoS>() == 0)
                    return "";
                else
                    return cli.Single<SERVicIoS>().Nombre;
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

                //tran = conexion.BeginTransaction();
                //database.Transaction = tran;
                //sqllineas = @"DELETE FROM trustdb.horariosempleados WHERE idEscalafon=" + NroEscalafon.ToString();
                //database.ExecuteCommand(sqllineas, null);

                //database.Transaction.Commit();
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
                        tempsql += dh.NroEmpleado + ", ";
                        tempsql += dh.Solapa + ", ";
                        tempsql += dh.TipoDia.ToString() + ")";
                        database.ExecuteCommand(tempsql, null);
                    }

                }
                database.Transaction.Commit();
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
                //database.SubmitChanges();
                recargarContexto();
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

        public List<EScalaFOneMpLeadO> getHorariosEmpleado(int NroEmpleado)
        {
            try
            {
                List<EScalaFOneMpLeadO> hors = (from varcli in database.GetTable<EScalaFOneMpLeadO>()
                                        where varcli.NroEmpleado == (uint)NroEmpleado
                                        select varcli).ToList<EScalaFOneMpLeadO>();
                return hors;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public bool ClienteActivo(int NroCliente)
        {
            try
            {

                Table<ClientEs> tablaCliente = database.GetTable<ClientEs>();
                var cli = (from clireg in tablaCliente
                           where clireg.NumeroCliente == NroCliente
                           select clireg);
                if (cli.Count<ClientEs>() == 0)
                    throw new NoExisteException("No existe el cliente con idCliente " + NroCliente);

                return (cli.Single<ClientEs>().Activo == 1);
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
        
        public void SetearCubierto(int NroEscalafon, bool ContCubierto)
        {
            try
            {
                Table<EScalaFOn> tablaEscalafon = database.GetTable<EScalaFOn>();
                var con = (from conreg in tablaEscalafon
                           where conreg.IDEscalafon == NroEscalafon
                           select conreg);
                if (con.Count<EScalaFOn>() == 0)
                    throw new NoExisteException("No existe el escalafón con número " + NroEscalafon);
                con.Single<EScalaFOn>().Cubierto = (ContCubierto) ? (sbyte)1 : (sbyte)0;

                database.SubmitChanges();
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

        public void SustituirEmpleado(int NroNuevoEmp, int NroViejoEmp)
        {
            try
            {
                List<EScalaFOneMpLeadO> hors = (from reg in database.GetTable<EScalaFOneMpLeadO>()
                                                where reg.NroEmpleado == (uint)NroViejoEmp
                                                select reg).ToList<EScalaFOneMpLeadO>();

                foreach (EScalaFOneMpLeadO linea in hors)
                {
                    linea.NroEmpleado = (uint)NroNuevoEmp;
                }

                database.SubmitChanges();

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void MarcarSolapados(List<HoRaRioEScalaFOn> HorsSolapados)
        {
            try
            {
                recargarContexto();

                foreach (HoRaRioEScalaFOn h in HorsSolapados)
                {
                    HoRaRioEScalaFOn hor = (from reg in database.GetTable<HoRaRioEScalaFOn>()
                                            where reg.IDEscalafon == h.IDEscalafon && reg.IDEscalafonEmpleado == h.IDEscalafonEmpleado && reg.DiA == h.DiA
                                            select reg).Single<HoRaRioEScalaFOn>();
                    hor.Solapa = 1;                  
                }                   
                
                database.SubmitChanges();

                recargarContexto();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public long agregarEmpleadoHoraGeneradaEscalafon(HoRaSGeneraDaSEScalaFOn horaGeneradaEscalafon, MotIVOsCamBiosDiARioS motivoCambio)
        {
            try
            {
                Table<HoRaSGeneraDaSEScalaFOn> tabla = database.HoRaSGeneraDaSEScalaFOn;
                //motivoCambio.HoRaSGeneraDaSEScalaFOn = horaGeneradaEscalafon;
                motivoCambio.FechaCorresponde = horaGeneradaEscalafon.FechaCorrespondiente;
                motivoCambio.FechaCambio = DateTime.Now;
                tabla.InsertOnSubmit(horaGeneradaEscalafon);
               // database.MotIVOsCamBiosDiARioS.InsertOnSubmit(motivoCambio);

                database.SubmitChanges();

                return horaGeneradaEscalafon.IDHorasGeneradasEscalafon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<HoRaSGeneraDaSEScalaFOn> obtenerHorasGeneradasEscalafonEmpleado(uint nroEmpleado, DateTime fechaCorresponde)
        {
            try
            {
                List<HoRaSGeneraDaSEScalaFOn> listaRetornar;

                listaRetornar = (from reg in database.HoRaSGeneraDaSEScalaFOn
                                 where reg.NroEmpleado == nroEmpleado && reg.FechaCorrespondiente.Date == fechaCorresponde.Date
                                 select reg).ToList<HoRaSGeneraDaSEScalaFOn>();

                return listaRetornar;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void guardarGeneracionHorasEscalafon(List<HoRaSGeneraDaSEScalaFOn> listaHorasGeneradas, bool sobreescribir)
        {
            try
            {
                if (sobreescribir)
                {
                    List<HoRaSGeneraDaSEScalaFOn> hgeAux;
                    List<string> listaYaEliminados = new List<string>();
                    string cliserdate;
                    foreach (HoRaSGeneraDaSEScalaFOn hge in listaHorasGeneradas)
                    {
                        cliserdate = hge.NumeroCliente.ToString() + "-" + hge.NumeroServicio.ToString() + "-" + hge.FechaCorrespondiente.Ticks.ToString();
                        if (!listaYaEliminados.Contains(cliserdate))
                        {
                            hgeAux = (from hg in database.HoRaSGeneraDaSEScalaFOn
                                      where hg.NumeroCliente == hge.NumeroCliente && hg.NumeroServicio == hge.NumeroServicio && hg.FechaCorrespondiente == hge.FechaCorrespondiente
                                      select hg).ToList();
                            
                            database.HoRaSGeneraDaSEScalaFOn.DeleteAllOnSubmit(hgeAux);
                            listaYaEliminados.Add(cliserdate);
                        }
                    }

                }
                database.HoRaSGeneraDaSEScalaFOn.InsertAllOnSubmit(listaHorasGeneradas);
                database.SubmitChanges();
                recargarContexto();

            }
            catch (MySql.Data.MySqlClient.MySqlException myex)
            {
                throw myex;
            }
        }       
  

        public List<HoRaRioEScalaFOn> getHorEmpleado(int NroEmpleado, string dia, int IdEscalafon)
        {
            try
            {
                List<HoRaRioEScalaFOn> hors = (from varcli in database.GetTable<HoRaRioEScalaFOn>()
                                                where varcli.NroEmpleado == (uint)NroEmpleado && varcli.DiA == dia && varcli.IDEscalafon != (uint)IdEscalafon
                                               select varcli).ToList<HoRaRioEScalaFOn>();
                return hors;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
 

        public void MarcarNoSolapados(List<HoRaRioEScalaFOn> HorsNOSolap)
        {
            try
            {
                recargarContexto();

                foreach (HoRaRioEScalaFOn h in HorsNOSolap)
                {
                    HoRaRioEScalaFOn hor = (from reg in database.GetTable<HoRaRioEScalaFOn>()
                                            where reg.IDEscalafon == h.IDEscalafon && reg.IDEscalafonEmpleado == h.IDEscalafonEmpleado && reg.DiA == h.DiA
                                            select reg).Single<HoRaRioEScalaFOn>();
                    hor.Solapa = 0;                   
                }

                database.SubmitChanges();

                recargarContexto();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<HoRaRioEScalaFOn> getHorariosEmpleadoDia(int NroEmpleado, string dia, int IdEscalafon)
        {
            try
            {
                List<HoRaRioEScalaFOn> hors = (from varcli in database.GetTable<HoRaRioEScalaFOn>()
                                                where varcli.NroEmpleado == (uint)NroEmpleado && varcli.DiA == dia && varcli.IDEscalafon != IdEscalafon
                                               select varcli).ToList<HoRaRioEScalaFOn>();
                return hors;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public bool esServicioActivo(int nroCliente, int nroServicio)
        {
            Table<SERVicIoS> tabla;
            try
            {
                tabla = database.GetTable<SERVicIoS>();
                var ser = (from serreg in tabla
                           where serreg.NumeroServicio == nroServicio && serreg.NumeroCliente == nroCliente
                           select serreg);

                return (ser.Single<SERVicIoS>().Activo == 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void LiquidarEmpleados(DateTime inicio, DateTime fin)
        {
            System.Data.Common.DbConnection conexion = database.Connection;
            try
            {                
                string nombreTabla = database.Connection.Database + ".liquidacionempleados";                
                string st = "TRUNCATE " + nombreTabla;
                //st += "'" + string.Format("{0:yyyy-MM-dd}", Contrato.FechaFin) + "', ";

                if (conexion.State != System.Data.ConnectionState.Open)
                    conexion.Open();
                System.Data.Common.DbTransaction tran = conexion.BeginTransaction();
                database.Transaction = tran;
                database.ExecuteCommand(st, null);

                string sql = "INSERT INTO liquidacionempleados (Fecha, NroEmpleado, NroServicio, NroCliente, Horas)" +
                             "SELECT hg.FechaCorrespondiente, hg.NroEmpleado, hg.NumeroServicio, hg.NumeroCliente, addtime('2011-01-01 0:0:0', sec_to_time(sum(time_to_sec(time(hg.HoraSalida)) - time_to_sec(time(hg.HoraEntrada)))))" +
                             "FROM horasgeneradasescalafon hg WHERE hg.FechaCorrespondiente BETWEEN '" + string.Format("{0:yyyy-MM-dd}", inicio) + "' AND '" + string.Format("{0:yyyy-MM-dd}", fin) + "'" +
                             "GROUP BY hg.FechaCorrespondiente, hg.NroEmpleado, hg.NumeroServicio, hg.NumeroCliente";

                database.ExecuteCommand(sql, null);

                sql = "UPDATE cuotasextrasliquidacion SET Liquidado=1 WHERE Fecha BETWEEN '" + string.Format("{0:yyyy-MM-dd}", inicio) + "' AND '" + string.Format("{0:yyyy-MM-dd}", fin) + "'";
                database.ExecuteCommand(sql, null);

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

        public void empleadosLiquidados(out DataTable empleados)
        {
            MySqlConnection conexion2;
            try
            {
                string sql = "Select distinct NroEmpleado "+
                             "FROM liquidacionempleados "+
                             @"Where NroEmpleado != 9999 and NroEmpleado != 9998 "+
                             "order by NroEmpleado";

                conexion2 = (MySqlConnection)database.Connection;

                MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter(sql, conexion2);

                DataTable dt = new DataTable();
                mysqlAdapter.Fill(dt);
                empleados = dt;
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


        #region PermisosUsuarios_PantallasWinForms_PermisoControl

        public List<PantAllAwInForm> obtenerPantallasWinForms(bool soloactivos)
        {
            List<PantAllAwInForm> retornar;
            try
            {
                if (soloactivos)
                    retornar = database.PantAllAwInForm.Where(p => p.Activo == 1).ToList();
                else
                    retornar = database.PantAllAwInForm.ToList();
                return retornar;
            }
            catch
            {
                throw;
            }


        }
        #endregion

        public TipOscarGoS obtenerCargo(int idCargo)
        {
            try
            {

                Table<TipOscarGoS> tabla = database.GetTable<TipOscarGoS>();
                var cli = (from clireg in tabla
                           where clireg.IDCargo == idCargo
                           select clireg);
                if (cli.Count<TipOscarGoS>() == 0)
                    throw new NoExisteException("No existe el cargo con IdCargo" + idCargo);

                return cli.Single<TipOscarGoS>();
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

        public List<DateTime> ObtenerFeriados()
        {            
            Table<FeRiAdoS> tabla;

            try
            {
                tabla = database.GetTable<FeRiAdoS>();
                List<FeRiAdoS> listFeriados;
                List<DateTime> ListFechas = new List<DateTime>();
                
                listFeriados = tabla.ToList<FeRiAdoS>();

                foreach (FeRiAdoS f in listFeriados)
                {
                    ListFechas.Add(f.FeCHa);
                }
                return ListFechas;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public DataTable LiquidarunEmpleado2(int nroEmp)
        {
            MySqlConnection conexion2;
            Dictionary<DateTime, TimeSpan> tabla = new Dictionary<DateTime, TimeSpan>();
            try
            {
                string sql = "SELECT DAY(Fecha) as dia, sec_to_time(SUM(time_to_sec(Horas)))" +
                             "FROM liquidacionempleados" +
                             "WHERE NroEmpleado = " + nroEmp.ToString() +
                             "GROUP BY dia";

                conexion2 = (MySqlConnection)database.Connection;

                MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter(sql, conexion2);

                DataTable dt = new DataTable();
                mysqlAdapter.Fill(dt);

                return dt;
                

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

        public Dictionary<DateTime, TimeSpan> LiquidarunEmpleado(int nroEmp)
        {
            Table<LiquidAcIonEmPleadOs> tabla;
            try
            {
                tabla = database.GetTable<LiquidAcIonEmPleadOs>();

                var hors = from varcli in tabla
                           where varcli.NroEmpleado == (uint)nroEmp
                           group varcli by varcli.Fecha;

                
                            //select varcli).GroupBy(LiquidAcIonEmPleadOs => LiquidAcIonEmPleadOs.Fecha);

                Dictionary<DateTime, TimeSpan> liqui = new Dictionary<DateTime, TimeSpan>();
                DateTime fecha;
                TimeSpan horas;
                //foreach (var dia in hors)
                //{
                //    fecha = dia.Key;                    
                //    horas = new TimeSpan(0);
                //    foreach (LiquidAcIonEmPleadOs l in dia)
                //        horas = horas + l.Horas.TimeOfDay;                  
                //    liqui.Add(fecha, horas);
                //}

                foreach (var dia in hors)
                {
                    fecha = dia.Key;
                    horas = new TimeSpan(0);
                    List<LiquidAcIonEmPleadOs> horsdia = (from reg in tabla
                                                          where reg.NroEmpleado == (uint)nroEmp && reg.Fecha == fecha
                                                          select reg).ToList<LiquidAcIonEmPleadOs>();
                    foreach (LiquidAcIonEmPleadOs l in horsdia)
                        horas = horas + l.Horas.TimeOfDay;
                    liqui.Add(fecha, horas);
                }

                return liqui;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public bool existeEmpleadoLiquidado(int nroEmpleado)
        {
            Table<LiquidAcIonEmPleadOs> tabla;
            try
            {

                tabla = database.GetTable<LiquidAcIonEmPleadOs>();
                var cli = (from clireg in tabla
                           where clireg.NroEmpleado == nroEmpleado
                           select clireg);
                if (cli.Count<LiquidAcIonEmPleadOs>() == 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
                // MySQLException = Access Denied  Codigo = 1045
            }
        }


        public DataFacturacion facturarClienteServicio(int NumeroCliente, int NroServicio, DateTime DiaInicioFacturacion, DateTime DiaFinFacturacion)
        {
            MySqlConnection conexion2 = null;
            MySqlDataReader mydata = null;
            try
            {
                // Si el cliente paga hs extras, hay que ir a ver el contrato y obtener la cantidad de hs que se deberian cubrir el dia, si se cubren mas, 
                // la diferencia son hs extras.

                // Si DiaInicioFacturacion del Cliente es mayor a DiaFinFacturacion se le resta un mes al diaInicio
                if (DiaInicioFacturacion.Day > DiaFinFacturacion.Day)
                    DiaInicioFacturacion = DiaInicioFacturacion.AddMonths(-1);

                ContraToS con = obtenerContrato(NumeroCliente, NroServicio);
                bool pagaExtras = (con.HorasExtras == 1);
                List<DataDiaFacturacion> listaDias = new List<DataDiaFacturacion>();

                TimeSpan totalHsComunes = new TimeSpan(0);
                TimeSpan totalHsExtras = new TimeSpan(0);
                TimeSpan tempComunes;
                TimeSpan tempExtras;
                TimeSpan tempHsTotales;

                DataDiaFacturacion diafact;
                //var listahoras = (from reg in database.HoRaSGeneraDaSEScalaFOn
                //                  where reg.NumeroCliente == NumeroCliente && reg.NumeroServicio == NroServicio && reg.FechaCorrespondiente >= DiaInicioFacturacion && reg.FechaCorrespondiente <= DiaFinFacturacion
                //                  group reg by reg.FechaCorrespondiente into g
                //                  select  g.Key);


                string sql = "SELECT FechaCorrespondiente, SEC_TO_TIME(SUM(TIME_TO_SEC(TIMEDIFF(HoraSalida,HoraEntrada)))) " +
                                 "FROM horasgeneradasescalafon " +
                                 "WHERE (NumeroCliente = " + NumeroCliente + ") AND (NumeroServicio = "+NroServicio+") AND (FechaCorrespondiente BETWEEN '"+string.Format("{0:yyyy-MM-dd}", DiaInicioFacturacion)+"' AND '"+string.Format("{0:yyyy-MM-dd}", DiaFinFacturacion)+"') " +
                                 "GROUP BY FechaCorrespondiente";

                conexion2 = createNewConnection();
                conexion2.Open();               
                MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter(sql, conexion2);
                mydata = mysqlAdapter.SelectCommand.ExecuteReader(CommandBehavior.Default);

                
                //foreach(var v in listahoras)
                DateTime FechaCorresponde;
                TimeSpan HoraEnt;
                TimeSpan HoraSal;
                while(mydata.Read())
                {
                    FechaCorresponde = mydata.GetDateTime(0);
                    HoraEnt = mydata.GetTimeSpan(1);
                   // HoraSal = mydata.GetTimeSpan(2);
                    if (pagaExtras)
                    {
                        // OBTENER EL DIA DE LA LINEAHORA DEL CONTRATO Y COMPARAR CON EL DIA DE V.
                        tempComunes = getCantHsContrato(con, FechaCorresponde);
                        tempHsTotales = HoraEnt;
                        tempComunes = (tempHsTotales > tempComunes ? tempComunes : tempHsTotales);
                        tempExtras = tempHsTotales - tempComunes;

                        diafact = new DataDiaFacturacion(FechaCorresponde, tempComunes, tempExtras);
                    }
                    else
                    {
                        tempExtras = new TimeSpan(0);
                        tempComunes = HoraEnt;
                        diafact = new DataDiaFacturacion(FechaCorresponde, tempComunes, tempExtras);
                    }
                    listaDias.Add(diafact);
                    totalHsComunes += tempComunes;
                    totalHsExtras += tempExtras;
                }
                DataFacturacion df = new DataFacturacion(NumeroCliente,NroServicio,listaDias,totalHsComunes,totalHsExtras);
                return df;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mydata != null)
                    mydata.Close();
                if (conexion2 != null && conexion2.State != ConnectionState.Closed)
                    conexion2.Close();
            }
        }

        private TimeSpan getCantHsContrato(ContraToS con, DateTime dia)//, bool Comunes)
        {
            TimeSpan ret = new TimeSpan(0);
            TimeSpan hini;
            TimeSpan hfin;
            
            foreach (LineAshOrAs lh in con.LineAshOrAs)
            {
                foreach (HoRaRioDiA hd in lh.HoRaRioDiA)
                {
                    
                    if (hd.Dia.ToLower()==Thread.CurrentThread.CurrentCulture.DateTimeFormat.GetDayName(dia.DayOfWeek))
                    {
                        hini = TimeSpan.Parse(hd.HoraIni);
                        hfin = TimeSpan.Parse(hd.HoraFin);
                        if (hfin <= hini)
                            ret += hfin + new TimeSpan(TimeSpan.TicksPerDay) - hini;
                        else
                            ret += hfin - hini;
                    }
                }
            }
           
            return ret;
        }


        public DataEmpleadoExLiquidacion obtenerExLiquidacionEmpleado(int NroEmpleado, DateTime Mes)
        {
            DateTime inicio, fin, aux;

            inicio = new DateTime(Mes.Year, Mes.Month, 1);
            aux = new DateTime(Mes.Year, Mes.AddMonths(1).Month, 1);
            fin = aux.AddDays(-1);
            
            MySqlConnection conexion2 = null;
            MySqlDataReader mydata = null;


            try
            {
                List<DataExtraLiquidacion> listaEx = new List<DataExtraLiquidacion>();

                DataExtraLiquidacion exLiqui;
                

                string sql = "SELECT e.Descripcion, c.NumeroCuota, e.CantidadCuotas, e.Signo, c.ValorCuota "+
                             "FROM extrasliquidacion e, cuotasextrasliquidacion c "+
                             "WHERE "+
                             "e.IdEmpleado="+ NroEmpleado.ToString() + " AND "+
                             "e.IdExtraLiquidacion=c.IdExtraLiquidacion AND "+
                             "c.Fecha BETWEEN '" + string.Format("{0:yyyy-MM-dd}", inicio) + "' AND '" + string.Format("{0:yyyy-MM-dd}", fin) + "'";

                conexion2 = createNewConnection();
                conexion2.Open();
                MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter(sql, conexion2);
                mydata = mysqlAdapter.SelectCommand.ExecuteReader(CommandBehavior.Default);

                string desc;
                int nc, tc, s, valor, tot=0;
                
                while (mydata.Read())
                {
                    desc = mydata.GetString(0);
                    nc = mydata.GetInt32(1);
                    tc = mydata.GetInt32(2);
                    s = mydata.GetInt32(3);
                    valor = mydata.GetInt32(4);
                    
                    valor = (s == 0 ? valor * -1 : valor);

                    exLiqui = new DataExtraLiquidacion(desc, nc.ToString() + @"/" + tc.ToString(), valor);

                    listaEx.Add(exLiqui);
                    tot += valor;
                }

                DataEmpleadoExLiquidacion deel = new DataEmpleadoExLiquidacion(NroEmpleado, Mes, listaEx, tot);
                return deel;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mydata != null)
                    mydata.Close();
                if (conexion2 != null && conexion2.State != ConnectionState.Closed)
                    conexion2.Close();
            }

            
        }


        public List<MotIVOsCamBiosDiARioS> obtenerMotivosCambiosDiarios2(int NroEmpleado, DateTime Fecha)
        {
            try
            {
                List<MotIVOsCamBiosDiARioS> motivosServicio = null;
                
                motivosServicio = (from reg in database.MotIVOsCamBiosDiARioS
                                   where reg.FechaCorresponde == Fecha & reg.NroEmpleado == NroEmpleado
                                   select reg).ToList<MotIVOsCamBiosDiARioS>();
                            
                return motivosServicio;

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<int> obtenerObsCambios(int nroEmp, DateTime Mes)
        {
            DateTime inicio, fin, aux;

            inicio = new DateTime(Mes.Year, Mes.Month, 1);
            aux = new DateTime(Mes.Year, Mes.AddMonths(1).Month, 1);
            fin = aux.AddDays(-1);

            List<DateTime> fechas = null;
            List<int> dias = new List<int>();
            try
            {                
                fechas = (from reg in database.MotIVOsCamBiosDiARioS
                           where reg.NroEmpleado == (uint)nroEmp && reg.FechaCorresponde >= inicio && reg.FechaCorresponde <= fin
                           select reg.FechaCorresponde).ToList<DateTime>();

                foreach (DateTime d in fechas)
                    dias.Add(d.Day);

                return dias;                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataEventosHE obtenerEventosHistEmpleado(int NroEmpleado, DateTime Mes)
        {
            DateTime inicio, fin, aux;

            inicio = new DateTime(Mes.Year, Mes.Month, 1);
            aux = new DateTime(Mes.Year, Mes.AddMonths(1).Month, 1);
            fin = aux.AddDays(-1);

            MySqlConnection conexion2 = null;
            MySqlDataReader mydata = null;


            try
            {
                List<DataEventoHistEmpleado> listaEvs = new List<DataEventoHistEmpleado>();

                DataEventoHistEmpleado evento;

                string sql = "SELECT e.FechaInicio, e.FechaFin, t.Nombre, e.Descripcion " +
                             "FROM eventoshistorialempleado e, tiposeventohistorial t " +
                             "WHERE " +
                             "e.IdEmpleado=" + NroEmpleado.ToString() + " AND " +
                             "e.IdTipoEvento=t.IdTipoEventoHistorial AND " +
                             "e.FechaInicio < '" + string.Format("{0:yyyy-MM-dd}", fin) + "' AND " + 
                             "e.FechaFin > '" + string.Format("{0:yyyy-MM-dd}", inicio) + "'";

                conexion2 = createNewConnection();
                conexion2.Open();
                MySqlDataAdapter mysqlAdapter = new MySqlDataAdapter(sql, conexion2);
                mydata = mysqlAdapter.SelectCommand.ExecuteReader(CommandBehavior.Default);

                DateTime FIni, FFin;
                string tipo, desc;
                
                while (mydata.Read())
                {
                    FIni = mydata.GetDateTime(0);
                    FFin = mydata.GetDateTime(1);
                    tipo = mydata.GetString(2);
                    desc = mydata.GetString(3);

                    evento = new DataEventoHistEmpleado(FIni, FFin, tipo, desc);

                    listaEvs.Add(evento);                   
                }

                DataEventosHE dehe = new DataEventosHE(NroEmpleado, listaEvs);
                return dehe;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mydata != null)
                    mydata.Close();
                if (conexion2 != null && conexion2.State != ConnectionState.Closed)
                    conexion2.Close();
            }
        }


    }

}

        
 
