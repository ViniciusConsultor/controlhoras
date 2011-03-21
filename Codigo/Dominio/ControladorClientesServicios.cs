using System;
using System.Collections.Generic;
using System.Linq;
using DbLinq.Data.Linq;
using System.Text;
using System.Globalization;
using Datos;
using System.Configuration;

namespace Logica
{
    public class ControladorClientesServicios : IClientesServicios
    {

        private static ControladorClientesServicios instancia = null;
        private IDatos datos;
        int nroFuncPivot = -1;
        int nroFuncVacanteTemporal = -1;
            

        // Variable para la generacion de horas. Se inicializa, se genera cada cliente y se confirma. 
        // Es una forma de generar un estilo de transaccion a nivel logico
        List<HoRaSGeneraDaSEScalaFOn> listaHorasGeneradas = null;


        private ControladorClientesServicios()
        {
            try
            {
                datos = ControladorDatos.getInstance();

                // Leemos los numeros de FuncionarioPivot y de Vacante Temporal del archivo de configuracion
                if (ConfigurationManager.AppSettings.AllKeys.Contains("NroFuncionarioPivot"))
                    int.TryParse(ConfigurationManager.AppSettings["NroFuncionarioPivot"], out nroFuncPivot);
                if (ConfigurationManager.AppSettings.AllKeys.Contains("NroFuncionarioVacanteTemporal"))
                    int.TryParse(ConfigurationManager.AppSettings["NroFuncionarioVacanteTemporal"], out nroFuncVacanteTemporal);
                
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

        public void altaCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime? fecAlta, DateTime? fecBaja, string motivo, string referencia, string diaHoraCobro, string contactoCobro, string telefonosCobro, int diaInicioFacturacion, int diaFinFacturacion)
        {
            try
            {
                datos.altaCliente(num, nom, nomFant, rut, email, dir, dirCobro, telefono, fax, activo, fecAlta, fecBaja, motivo, referencia, diaHoraCobro, contactoCobro,telefonosCobro, diaInicioFacturacion,diaFinFacturacion);
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

        public void modificarCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime? fecAlta, DateTime? fecBaja, string motivo, string referencia, string diaHoraCobro, string contactoCobro, string telefonosCobro, int diaInicioFacturacion, int diaFinFacturacion)
        {
            try
            {
                datos.modificarCliente(num, nom, nomFant, rut, email, dir, dirCobro, telefono, fax, activo, fecAlta, fecBaja, motivo, referencia, diaHoraCobro,contactoCobro,telefonosCobro,diaInicioFacturacion,diaFinFacturacion);
            }
            catch (Exception e)
            {
                throw e;
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

            Cliente tdcli = new Cliente((int)cliDatos.NumeroCliente, cliDatos.Nombre, cliDatos.NombreFantasia, cliDatos.Rut, cliDatos.Email, cliDatos.Direccion, cliDatos.DireccionDeCobro, cliDatos.Telefonos, cliDatos.Fax, act, cliDatos.FechaAlta, cliDatos.FechaBaja, cliDatos.MotivoBaja, cliDatos.Referencia, cliDatos.DiaHoraCobro, cliDatos.ContactoCobro, cliDatos.TelefonosCobro, listServs,cliDatos.DiaInicioFacturacion,cliDatos.DiaFinFacturacion);
            
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
                servicio = new Servicio((int)ser.NumeroServicio, ser.Nombre, ser.Direccion, ser.Telefonos, ser.PersonaContacto, ser.Email, ser.Celular, ser.CelularTrust, ser.TareasAsignadas, act, ser.FechaAlta.Value, ser.FechaBaja, ser.MotivoBaja, ser.Observaciones);
                    return servicio;
             }catch(Exception ex)
             {
                 throw ex;
             }
        }

        public void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string Observaciones, bool activo, DateTime? FechaBaja, string MotivoBaja)
        {
            try
            {
                datos.altaServicioCliente(numeroCliente, numeroServicio, Nombre, Direccion, Telefonos, Contacto, email, Celular, CelularTrust, Tareas, Observaciones, activo, FechaBaja, MotivoBaja);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string Observaciones, bool activo, DateTime? FechaBaja, string MotivoBaja)
        {
            try
            {
                datos.modificarServicioCliente(numeroCliente, numeroServicio, Nombre, Direccion, Telefonos, Contacto, email, Celular, CelularTrust, Tareas, Observaciones, activo, FechaBaja, MotivoBaja);
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
        
        public void altaContratoServicioCliente(int NumeroCliente, int NumeroServicio, int NumeroContrato, DateTime FechaInicio, DateTime? FechaFin, bool CostoFijo, bool HorasExtras, string Ajuste, string Observaciones, float Monto)
        {
            try
            {
               // datos.altaContratoServicioCliente(NumeroCliente, NumeroServicio, NumeroContrato, FechaInicio, FechaFin, CostoFijo, HorasExtras, Ajuste, Observaciones, Monto);
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int CalcNroContrato(int nroCli, int nroSer)
        {
            return nroCli * 1000 + nroSer;
        }

        public bool existeContrato(int NumeroContrato)
        {
            try
            {
                return datos.existeContrato(NumeroContrato);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void altaContrato(int NumeroContrato, ConSeguridadFisica cont)
        {
            ContraToS con = null;
      
            con = new ContraToS();
            
            con.TipodeContrato=0;
            con.IDContratos = (uint)NumeroContrato;
            con.FechaIni = cont.getFechaIni();
            con.FechaFin = cont.getFechaFin();
            if (cont.GetCostoFijo())
                con.CostoFijo = 1;
            else
                con.CostoFijo = 0;
            if (cont.getHorasExtras())
                con.HorasExtras = 1;
            else
                con.HorasExtras = 0;
            con.Ajuste = cont.getAjuste();
            con.Observaciones = cont.getObservaciones();
            con.Costo = cont.getMonto();

            List<LineAshOrAs> lhs = new List<LineAshOrAs>();
            LineAshOrAs lh = null;            
            int i=0;
            foreach (LineaDeHoras ldh in cont.getLineas())
            {
                lh = new LineAshOrAs();
                lh.IDContrato = (uint)NumeroContrato;                
                lh.NroLinea = (sbyte)i;
                lh.Puesto = ldh.getPuesto();
                lh.Armado = (ldh.getArmado()) ? (sbyte)1 : (sbyte)0;
                lh.Cantidad = (sbyte)ldh.getCantEmp();
                lh.PrecioXhOra = ldh.getCostoH();
                
                //pasar los horarios por dia
                HoRaRioDiA hd = null;
                foreach (HorarioXDia hpd in ldh.getHorario())
                {
                    hd = new HoRaRioDiA();
                    hd.IDContrato = (uint)NumeroContrato;
                    hd.NroLinea = (sbyte)i;
                    hd.Dia = hpd.getDia();
                    hd.HoraIni = hpd.getHoraIni();
                    hd.HoraFin = hpd.getHoraFin();

                    lh.HoRaRioDiA.Add(hd);
                }
                
                lhs.Add(lh);
                //con.LineAshOrAs.Add(lh);
                i++;
            }

            datos.altaContrato(con, lhs);
        }

        public ConSeguridadFisica getContrato(int NumeroContrato)
        {
            ContraToS con = datos.obtenerContrato(NumeroContrato);

            ConSeguridadFisica aux = new ConSeguridadFisica((con.HorasExtras == (sbyte)1) ? true : false, 0, 0, 0, con.FechaIni.Value, con.FechaFin, con.Ajuste, con.Observaciones, (con.CostoFijo == (sbyte)1) ? true : false, con.Costo.Value);

            LineaDeHoras lhs = null;
            HorarioXDia hor = null;

            foreach (LineAshOrAs lh in con.LineAshOrAs)
            {
                lhs = new LineaDeHoras(lh.Puesto, (lh.Armado == (sbyte)1) ? true : false, lh.PrecioXhOra.Value, (int)(lh.Cantidad), 0, 0);

                foreach (HoRaRioDiA h in lh.HoRaRioDiA)
                {
                    if (h.IDContrato == lh.IDContrato && h.NroLinea == lh.NroLinea)
                    {
                        hor = new HorarioXDia(h.Dia, h.HoraIni, h.HoraFin);
                        lhs.addDia(hor);
                    }
                }
                aux.addLinea(lhs);
            }

            return aux;
        }

        public void modificarContrato(int NumeroContrato, ConSeguridadFisica Contrato)
        {
            datos.modificarContrato(NumeroContrato, Contrato.getFechaIni(), Contrato.getFechaFin(), Contrato.GetCostoFijo(), Contrato.getHorasExtras(), Contrato.getAjuste(), Contrato.getObservaciones(), Contrato.getMonto());

            datos.eliminarLineasContrato(NumeroContrato);

            List<LineAshOrAs> lhs = new List<LineAshOrAs>();
            LineAshOrAs lh = null;
            int i = 0;
            foreach (LineaDeHoras ldh in Contrato.getLineas())
            {
                lh = new LineAshOrAs();
                lh.IDContrato = (uint)NumeroContrato;
                lh.NroLinea = (sbyte)i;
                lh.Puesto = ldh.getPuesto();
                lh.Armado = (ldh.getArmado()) ? (sbyte)1 : (sbyte)0;
                lh.Cantidad = (sbyte)ldh.getCantEmp();
                lh.PrecioXhOra = ldh.getCostoH();

                //pasar los horarios por dia
                HoRaRioDiA hd = null;
                foreach (HorarioXDia hpd in ldh.getHorario())
                {
                    hd = new HoRaRioDiA();
                    hd.IDContrato = (uint)NumeroContrato;
                    hd.NroLinea = (sbyte)i;
                    hd.Dia = hpd.getDia();
                    hd.HoraIni = hpd.getHoraIni();
                    hd.HoraFin = hpd.getHoraFin();

                    lh.HoRaRioDiA.Add(hd);
                }

                lhs.Add(lh);
                //con.LineAshOrAs.Add(lh);
                i++;
            }

            datos.guardarLineasContrato(lhs);
        }       

        public void altaEscalafon(int numCli, int numSer, int nroCon, Escalafon es)
        {
            try
            {
                EScalaFOn esc = null;

                esc = new EScalaFOn();
                esc.NumeroCliente = (uint)numCli;
                esc.NumeroServicio = (uint)numSer;
                esc.IDContrato = (uint)nroCon;
                esc.IDEscalafon = (uint)nroCon;

                if (es.Cubierto)
                    esc.Cubierto = 1;
                else
                    esc.Cubierto = 0;

                List<EScalaFOneMpLeadO> lhs = new List<EScalaFOneMpLeadO>();
                EScalaFOneMpLeadO lh = null;
                int i = 0;
                foreach (EscalafonEmpleado ldh in es.ListaEscalafonEmpleados)
                {
                    lh = new EScalaFOneMpLeadO();
                    lh.IDEscalafon = (uint)nroCon;
                    lh.IDEscalafonEmpleado = (uint)i;
                    lh.NroEmpleado = (uint)ldh.NroEmpleado;
                    lh.CodigoPuesto = ldh.CodigoPuesto;
                    lh.HsLlamadaAntesHoraInicio = (sbyte)ldh.CantidadHsLlamadaAntesHoraInicio;
                    lh.AcArgoDe = ldh.AcargoDe;

                    //pasar los horarios por dia
                    HoRaRioEScalaFOn hd = null;
                    //HoRaRioSEmPleadOs he = null;
                    foreach (HorarioEscalafon hpd in ldh.Horario)
                    {
                        hd = new HoRaRioEScalaFOn();
                        hd.IDEscalafon = (uint)nroCon;
                        hd.IDEscalafonEmpleado = (uint)i;
                        hd.NroEmpleado = (uint)ldh.NroEmpleado;
                        if (hpd.EsLaborable())
                        {
                            hd.DiA = hpd.getDia();
                            hd.HoRaInI = hpd.getHoraIni();
                            hd.HoRaFIn = hpd.getHoraFin();
                            hd.TipoDia = 0;
                            hd.Solapa = (hpd.Solapea()) ? (sbyte)1 : (sbyte)0;
                        }
                        else
                        {
                            hd.DiA = hpd.getDia();
                            hd.TipoDia = (byte)hpd.getTipoDia();
                            hd.Solapa = 0;
                        }

                        lh.HoRaRioEScalaFOn.Add(hd);

                        //HORARIOS EMPLEADOS
                        //he = new HoRaRioSEmPleadOs();
                        //he.NroEmpleado = (uint)ldh.NroEmpleado;
                        //he.IDEscalafon = (uint)nroCon;
                        //he.IDEscalafonEmpleado = (uint)i;
                        //he.Dia = hpd.getDia();
                        //he.TipoDia = (byte)hpd.getTipoDia();
                        //he.Solapa = (hpd.Solapea()) ? (sbyte)1 : (sbyte)0;

                        //datos.altaHorEmpleado(he);
                    }

                    lhs.Add(lh);
                    //con.LineAshOrAs.Add(lh);
                    i++;
                }

                datos.altaEscalafon(esc, lhs);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void modificarEscalafon(int nroEsc, Escalafon es)
        {
            try
            {
                datos.SetearCubierto(nroEsc, es.Cubierto);

                datos.eliminarLineasEscalafon(nroEsc);

                List<EScalaFOneMpLeadO> lhs = new List<EScalaFOneMpLeadO>();
                EScalaFOneMpLeadO lh = null;
                int i = 0;
                foreach (EscalafonEmpleado ldh in es.ListaEscalafonEmpleados)
                {
                    lh = new EScalaFOneMpLeadO();
                    lh.IDEscalafon = (uint)nroEsc;
                    lh.IDEscalafonEmpleado = (uint)i;
                    lh.NroEmpleado = (uint)ldh.NroEmpleado;
                    lh.CodigoPuesto = ldh.CodigoPuesto;
                    lh.HsLlamadaAntesHoraInicio = (sbyte)ldh.CantidadHsLlamadaAntesHoraInicio;
                    lh.AcArgoDe = ldh.AcargoDe;                   

                    //pasar los horarios por dia
                    HoRaRioEScalaFOn hd = null;
                  
                    foreach (HorarioEscalafon hpd in ldh.Horario)
                    {
                        hd = new HoRaRioEScalaFOn();
                        hd.IDEscalafon = (uint)nroEsc;
                        hd.IDEscalafonEmpleado = (uint)i;
                        hd.NroEmpleado = (uint)ldh.NroEmpleado;
                        if (hpd.EsLaborable())
                        {
                            hd.DiA = hpd.getDia();
                            hd.HoRaInI = hpd.getHoraIni();
                            hd.HoRaFIn = hpd.getHoraFin();
                            hd.TipoDia = 0;
                            hd.Solapa = (hpd.Solapea()) ? (sbyte)1 : (sbyte)0;
                        }
                        else
                        {
                            hd.DiA = hpd.getDia();
                            hd.TipoDia = (byte)hpd.getTipoDia();
                            hd.Solapa = 0;
                        }

                        lh.HoRaRioEScalaFOn.Add(hd);


                        //HORARIOS EMPLEADOS
                        //he = new HoRaRioSEmPleadOs();
                        //he.NroEmpleado = (uint)ldh.NroEmpleado;
                        //he.IDEscalafon = (uint)nroEsc;
                        //he.IDEscalafonEmpleado = (uint)i;
                        //he.Dia = hpd.getDia();
                        //he.TipoDia = (byte)hpd.getTipoDia();
                        //he.Solapa = (hpd.Solapea()) ? (sbyte)1 : (sbyte)0;

                        //datos.altaHorEmpleado(he);
                    }

                    lhs.Add(lh);
                    //con.LineAshOrAs.Add(lh);
                    i++;
                }

                datos.guardarLineasEscalafon(lhs);
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Escalafon getEscalafon(int nroEsc)
        {
            EScalaFOn esc = datos.obtenerEscalafon(nroEsc);
            
            Escalafon aux = new Escalafon();
            aux.Cubierto = esc.Cubierto == 1;
            aux.ListaEscalafonEmpleados = new List<EscalafonEmpleado>();
            
            EscalafonEmpleado lhs = null;
            HorarioEscalafon hor = null;

            foreach (EScalaFOneMpLeadO lh in esc.EScalaFOneMpLeadO)
            {
                lhs = new EscalafonEmpleado();
                lhs.NroEmpleado = (int)lh.NroEmpleado;
                lhs.CodigoPuesto = lh.CodigoPuesto;
                lhs.CantidadHsLlamadaAntesHoraInicio = lh.HsLlamadaAntesHoraInicio;
                lhs.AcargoDe = lh.AcArgoDe;
                lhs.Horario = new List<HorarioEscalafon>();
                
                foreach (HoRaRioEScalaFOn h in lh.HoRaRioEScalaFOn)
                {
                    if (h.IDEscalafon == lh.IDEscalafon && h.IDEscalafonEmpleado == lh.IDEscalafonEmpleado)
                    {
                        if (h.TipoDia == 0)
                            hor = new HorarioEscalafon(h.DiA, h.HoRaInI, h.HoRaFIn, (h.Solapa == 1)? true:false);
                        else
                            hor = new HorarioEscalafon(h.DiA, (int)h.TipoDia);
                        
                        lhs.Horario.Add(hor);
                    }
                }
                aux.ListaEscalafonEmpleados.Add(lhs);
            }

            return aux;
        }

        public bool EsHorarioSolapado(int IdEscalafon, int NroEmpleado, string dia, string HoraIni, string HoraFin)
        {
            int  nrocliente, nroservicio;
            try
            {
                List<HoRaRioEScalaFOn> horarios = datos.getHorariosEmpleadoDia(NroEmpleado, dia, IdEscalafon);
                
                foreach (HoRaRioEScalaFOn h in horarios)
                {
                    nrocliente = ObtenerNroCliente(h.IDEscalafon);
                    nroservicio = ObtenerNroServicio(h.IDEscalafon);

                    if (datos.esServicioActivo(nrocliente, nroservicio))
                    {
                        if (h.TipoDia == 0)
                        {
                            if (HorariosSolapados(HoraIni, HoraFin, h.HoRaInI, h.HoRaFIn))
                                return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        private int ObtenerNroCliente(uint p)
        {
            return (int)p / 1000;
        }

        private int ObtenerNroServicio(uint p)
        {
            return (int)p % 1000;           
        }

        private bool HorariosSolapados(string hi1, string hf1, string hi2, string hf2)
        {
            DateTime dti1, dtf1, dti2, dtf2;

            dti1 = DateTime.ParseExact(hi1, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dtf1 = DateTime.ParseExact(hf1, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dti2 = DateTime.ParseExact(hi2, @"HH:mm", DateTimeFormatInfo.InvariantInfo);
            dtf2 = DateTime.ParseExact(hf2, @"HH:mm", DateTimeFormatInfo.InvariantInfo);

            if (dti2 < dtf1 && dtf2 > dti1) //- Con este IF se controla solo un caso
            //if ((dti1 < dtf1 && dti2 < dtf2) && (dti2 > dtf1 || dtf2 < dti1)) // Asi se controlan los dos casos.
                return true;
            else
                return false;
        }

        public bool HorariosCruzados(int NroEmp1, int NroEmp2)
        {
            try
            {
                List<EScalaFOneMpLeadO> horariosEmp2 = datos.getHorariosEmpleado(NroEmp2);               

                foreach (EScalaFOneMpLeadO linea in horariosEmp2)
                {
                    foreach (HoRaRioEScalaFOn h in linea.HoRaRioEScalaFOn)
                    {
                        if (h.IDEscalafonEmpleado == linea.IDEscalafonEmpleado && h.TipoDia == 0)
                        {
                            if (EsHorarioSolapado(-1, NroEmp1, h.DiA, h.HoRaInI, h.HoRaFIn))
                                return true;
                        }
                    }                    
                }

                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public bool SustituirEmpleadoEnEscalafon(int NroNuevoEmp, int NroViejoEmp)
        {            
            try
            {
                if (NroNuevoEmp != nroFuncPivot && NroNuevoEmp != nroFuncVacanteTemporal)
                {
                    if (HorariosCruzados(NroNuevoEmp, NroViejoEmp))
                        return false;
                }
                datos.SustituirEmpleado(NroNuevoEmp, NroViejoEmp);
                return true;
                   
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void marcarSolapados(int IdEscalafon, Escalafon EscSolapados)
        {
            int NroEmp;
            List<HoRaRioEScalaFOn> HorsSolap = new List<HoRaRioEScalaFOn>();
            List<HoRaRioEScalaFOn> HorsNOSolap = new List<HoRaRioEScalaFOn>();
            List<HoRaRioEScalaFOn> aux;
            try
            {
                foreach (EscalafonEmpleado ee in EscSolapados.ListaEscalafonEmpleados)
                {
                    NroEmp = ee.NroEmpleado;
                    foreach (HorarioEscalafon he in ee.Horario)
                    {
                        aux = datos.getHorariosEmpleadoDia(NroEmp, he.getDia(), IdEscalafon);
                        if (he.Solapea())
                        {
                            foreach (HoRaRioEScalaFOn h in aux)
                            {
                                if (h.TipoDia == 0)
                                {
                                    if (HorariosSolapados(he.getHoraIni(), he.getHoraFin(), h.HoRaInI, h.HoRaFIn))
                                    {
                                        HorsSolap.Add(h);
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (HoRaRioEScalaFOn h in aux)
                            {
                                if (h.Solapa == 1)
                                {
                                    if (!EsHorarioSolapado((int)h.IDEscalafon, (int)h.NroEmpleado, h.DiA, h.HoRaInI, h.HoRaFIn))
                                        HorsNOSolap.Add(h);
                                }
                            }
                        }
                    }
                }

                datos.MarcarNoSolapados(HorsNOSolap);
                datos.MarcarSolapados(HorsSolap);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }      
        }    
    
        /// <summary>
        /// Agrega un nuevo funcionario con un horario determinado a un HorasGeneradasEscalafon de un cliente servicio de un dia determinado aplicando los controles necesarios para su alta.
        /// </summary>
        /// <param name="fechaCorresponde">La fechaCorrespondiente a la que se va a dar el alta</param>
        /// <param name="horaGeneradaEscalafon">La horaGeneradaEscalafon a dar de alta sin el Identificador y el Motivo.</param>
        /// <param name="motivoCambio">El MotivoCambioDiario correspondiente al motivo del cambio.</param>
        /// <returns>El Identificador del alta de HorarioEscalafonEmpleado</returns>
        public long agregarEmpleadoControlDiario(DateTime fechaCorresponde, HoRaSGeneraDaSEScalaFOn horaGeneradaEscalafon, MotIVOsCamBiosDiARioS motivoCambio)
        {
            try
            {
                aplicarControlesAltaHoraGeneradaEscalafon(fechaCorresponde, horaGeneradaEscalafon);
                long ret = datos.agregarEmpleadoHoraGeneradaEscalafon(horaGeneradaEscalafon, motivoCambio);

                return ret;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private string obtenerStringHoraMinuto(DateTime fecha)
        {
            return fecha.ToShortTimeString().Substring(0, 5);
        }

        private void aplicarControlesAltaHoraGeneradaEscalafon(DateTime fechaCorresponde, HoRaSGeneraDaSEScalaFOn horaGeneradaEscalafon)
        {
            try
            {
                List<HoRaSGeneraDaSEScalaFOn> horarios = datos.obtenerHorasGeneradasEscalafonEmpleado(horaGeneradaEscalafon.NroEmpleado,fechaCorresponde);

                foreach (HoRaSGeneraDaSEScalaFOn linea in horarios)
                {
                    //DayOfWeek day = (DayOfWeek) DayOfWeek.Parse(typeof(DayOfWeek), h.DiA, true);
                    if (HorariosSolapados(obtenerStringHoraMinuto(horaGeneradaEscalafon.HoraEntrada), obtenerStringHoraMinuto(horaGeneradaEscalafon.HoraSalida), obtenerStringHoraMinuto(linea.HoraEntrada), obtenerStringHoraMinuto(linea.HoraSalida)))
                        throw new Exception("Error de solapamiento de horarios. (" + horaGeneradaEscalafon.HoraEntrada.ToLongTimeString() + "-" + horaGeneradaEscalafon.HoraSalida.ToLongTimeString() + ") con " + "(" + linea.HoraEntrada.ToLongTimeString() + " - " + linea.HoraSalida.ToLongTimeString() + "). Dia: " + fechaCorresponde.ToShortDateString());
                                       
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<string> controlarPlanificacionEscalafonEmpleado(int nroEmpleado)
        {
            try
            {
                List<string> listaErrores = new List<string>();
                List<EScalaFOneMpLeadO> listaEscEmp = datos.getHorariosEmpleado(nroEmpleado);

                bool tieneDescanso = false;
                int cantDiasPlanificados = 0;

                int nroCli, nroSer;

                foreach (EScalaFOneMpLeadO escEmp in listaEscEmp)
                {
                    nroCli = ObtenerNroCliente(escEmp.IDEscalafon);
                    nroSer = ObtenerNroServicio(escEmp.IDEscalafon);
                    if (datos.esServicioActivo(nroCli,nroSer))
                    {
                        // Hacemos chequeos sobre los tipos de dias y horarios.
                        foreach (HoRaRioEScalaFOn he in escEmp.HoRaRioEScalaFOn)
                        {
                            if (he.TipOsDiAs.NoMbRe.Equals("Descanso", StringComparison.OrdinalIgnoreCase))
                            {
                                tieneDescanso = true;
                            }
                            else
                            {
                                if (he.TipOsDiAs.NoMbRe.Equals("Laborable", StringComparison.OrdinalIgnoreCase))
                                {
                                    cantDiasPlanificados++;
                                    // Revisamos si tiene horarios solapados.
                                    if (EsHorarioSolapado((int)he.IDEscalafon, nroEmpleado, he.DiA, he.HoRaInI, he.HoRaFIn))
                                    {
                                        listaErrores.Add(nroEmpleado + " tiene horarios solapados en el Cliente: " + escEmp.EScalaFOn.NumeroCliente + " - Servicio: " + escEmp.EScalaFOn.NumeroServicio);
                                    }
                                }
                            }                            
                        }
                    }
                }

                if (!tieneDescanso)
                    listaErrores.Add(nroEmpleado + " no tiene un descanso planificado.");
                return listaErrores;
            }
            catch
            {
                throw;
            }
        }

        #region GeneracionHorasDiarias
        public void iniciarGeneracionHoras()
        {
            if (listaHorasGeneradas != null)
                throw new TransaccionGeneracionHorasYaIniciadaException("Existe una transaccion en ejecucion en este momento");
            listaHorasGeneradas = new List<HoRaSGeneraDaSEScalaFOn>();
        }


        public void finalizarGeneracionHoras(bool commit, bool sobreescribir)
        {
            if (listaHorasGeneradas != null)
            {
                if (commit)
                {
                    try
                    {
                         datos.guardarGeneracionHorasEscalafon(listaHorasGeneradas,sobreescribir);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        listaHorasGeneradas = null;
                    }
                }
                else
                {
                    listaHorasGeneradas = null;
                }
            }
            else
            {
                throw new TransaccionGeneracionHorasNoIniciadaException("No hay una transaccion de Generacion de Horas iniciada.");
            }

        }

        public void generarHorasDiaServicio(int NumeroCliente, int NumeroServicio, DateTime Fecha, bool ForzarGeneracion)
        {
            try
            {
                if (Fecha.Date.CompareTo(DateTime.Today) <= 0)
                {
                    throw new GenerarHorasDiaException("La fecha a generar debe ser mayor a hoy. " + DateTime.Today.ToShortDateString());
                }
                List<HoRaSGeneraDaSEScalaFOn> listaHoras = datos.obtenerHorasGeneradasServicio(NumeroCliente, NumeroServicio, Fecha);
                if (listaHoras.Count != 0 && !ForzarGeneracion)
                {
                    throw new YaExistenHorasGeneradasParaLaFechaException("Existen HorasGeneradas del Cliente: " + NumeroCliente + " - Servicio: " + NumeroServicio + " en la Fecha: " + Fecha.ToShortDateString());
                }else
                {
                    SERVicIoS serv = datos.obtenerServicioCliente(NumeroCliente, NumeroServicio);
                    EScalaFOn escalafon = datos.obtenerEscalafon(CalcNroContrato(NumeroCliente,NumeroServicio));
                    HoRaSGeneraDaSEScalaFOn hge;
                    foreach(EScalaFOneMpLeadO esc in escalafon.EScalaFOneMpLeadO)
                    {
                        // Chequeamos que el empleado no este durante ningun evente en el EventoHistorialEmpleado en esta fecha
                        if (datos.empleadoTieneEventosHistorialEnFecha((int)esc.NroEmpleado, Fecha))
                            throw new GenerarHorasDiaException("El empleado " + esc.NroEmpleado + " tiene eventos en el Historial en la Ficha del empleado para la Fecha: " + Fecha.ToShortDateString());

                        hge = new HoRaSGeneraDaSEScalaFOn();
                        hge.FechaCorrespondiente = Fecha;
                        int i=0;
                        while (! nombreDiasInglesAEspanol(Fecha.DayOfWeek.ToString()).Equals(esc.HoRaRioEScalaFOn[i].DiA))
                        {
                            i++;
                        }
                        if (esc.HoRaRioEScalaFOn[i].TipoDia == 0)  // Si el dia es Laborable
                        {
                            hge.HoraEntrada = DateTime.Parse(Fecha.ToShortDateString() + " " + esc.HoRaRioEScalaFOn[i].HoRaInI);
                            hge.HoraSalida = DateTime.Parse(Fecha.ToShortDateString() + " " + esc.HoRaRioEScalaFOn[i].HoRaFIn);
                            if (hge.HoraSalida < hge.HoraEntrada)
                                hge.HoraSalida = hge.HoraSalida.AddDays(1.0);
                            hge.NroEmpleado = esc.NroEmpleado;
                            hge.NumeroCliente = escalafon.NumeroCliente;
                            hge.NumeroServicio = escalafon.NumeroServicio;
                            listaHorasGeneradas.Add(hge);
                        }
                    }
                }
            }
            catch(YaExistenHorasGeneradasParaLaFechaException y)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new GenerarHorasDiaException("Error en la generacion de horas. Cliente: " + NumeroCliente + " - Servicio: "+NumeroServicio + " - Fecha: " + Fecha.ToShortDateString() + "\n"+e.Message);
            }
        }

        private string nombreDiasInglesAEspanol(string nomDiaIngles)
        {
            switch (nomDiaIngles)
            {
                case "Monday":
                    return "Lunes";
                   
                case "Tuesday":
                    return "Martes";
                    
                case "Wednesday":
                    return "Miercoles";
                case "Thursday":                    
                    return "Jueves";
                case "Friday":
                    return "Viernes";
                case "Saturday":
                    return "Sabado";
                case "Sunday":
                    return "Domingo";

            }
            return null;
        }
        #endregion

        #region Consolidacion - Controles
        public List<string> ejecutarControlesEscalafonServicio(int NumeroCliente, int NumeroServicio)
        {
            try
            {
                List<string> errores = new List<string>();
                EScalaFOn escalafon = datos.obtenerEscalafon(CalcNroContrato(NumeroCliente, NumeroServicio));
                if (escalafon.Cubierto == 0)
                    errores.Add("El Contrato no esta Cubierto. No se cubren todas las horas contratadas.");
                
                return errores;
            }catch
            {
                throw;
            }
        }

        public List<string> ejecutarControlesEscalafonEmpleado(int NumeroCliente, int NumeroServicio)
        {
            
            try
            {
                List<string> errores = new List<string>();
                EScalaFOn escalafon = datos.obtenerEscalafon(CalcNroContrato(NumeroCliente, NumeroServicio));
                List<string> erroresControlEmpleado;
                foreach (EScalaFOneMpLeadO escEmp in escalafon.EScalaFOneMpLeadO)
                {
                    if (escEmp.NroEmpleado != nroFuncVacanteTemporal)
                    {
                        if (escEmp.NroEmpleado == nroFuncPivot)
                            errores.Add("El servicio No puede tener asignado el Funcionario Pivot en el Escalafon. NroEmpleado: " + nroFuncPivot);

                        else
                        {
                            erroresControlEmpleado = controlarPlanificacionEscalafonEmpleado((int)escEmp.NroEmpleado);
                            //errores.Concat(erroresControlEmpleado);
                            erroresControlEmpleado.Concat(errores);
                            errores = erroresControlEmpleado;
                        }
                    }
                }
                
                return errores;
            }catch
            {
                throw;
            }
        }
        #endregion
    }
}
