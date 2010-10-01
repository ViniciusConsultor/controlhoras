﻿using System;
using System.Collections.Generic;
using System.Linq;
using DbLinq.Data.Linq;
using System.Text;
using System.Globalization;
using Datos;

namespace Logica
{
    public class ControladorClientesServicios : IClientesServicios
    {

        private static ControladorClientesServicios instancia = null;
        private IDatos datos;

        // Variable para la generacion de horas. Se inicializa, se genera cada cliente y se confirma. 
        // Es una forma de generar un estilo de transaccion a nivel logico
        List<HoRaSGeneraDaSEScalaFOn> listaHorasGeneradas = null;


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

        public void altaCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime? fecAlta, DateTime? fecBaja, string motivo)
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

        public void modificarCliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime? fecAlta, DateTime? fecBaja, string motivo)
        {
            try
            {
                datos.modificarCliente(num, nom, nomFant, rut, email, dir, dirCobro, telefono, fax, activo, fecAlta, fecBaja, motivo);
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

            Cliente tdcli = new Cliente((int)cliDatos.NumeroCliente, cliDatos.Nombre, cliDatos.NombreFantasia, cliDatos.Rut, cliDatos.Email, cliDatos.Direccion, cliDatos.DireccionDeCobro, cliDatos.Telefonos, cliDatos.Fax, act, cliDatos.FechaAlta, cliDatos.FechaBaja, cliDatos.MotivoBaja, listServs);
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
                    servicio = new Servicio((int)ser.NumeroServicio, ser.Nombre, ser.Direccion, ser.Telefonos, ser.PersonaContacto, ser.Email, ser.Celular, ser.CelularTrust, ser.TareasAsignadas, act, (DateTime) ser.FechaAlta, (DateTime)ser.FechaBaja, ser.MotivoBaja, ser.DiaCobro, ser.NombreCobrar);
                    return servicio;
             }catch(Exception ex)
             {
                 throw ex;
             }
        }

        public void altaServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string DiaDeCobro, string NombreCobrar)
        {
            try
            {
                datos.altaServicioCliente(numeroCliente, numeroServicio, Nombre, Direccion, Telefonos, Contacto, email, Celular, CelularTrust, Tareas, DiaDeCobro, NombreCobrar);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void modificarServicioCliente(int numeroCliente, int numeroServicio, string Nombre, string Direccion, string Telefonos, string Contacto, string email, string Celular, string CelularTrust, string Tareas, string DiaDeCobro, string NombreCobrar)
        {
            try
            {
                datos.modificarServicioCliente(numeroCliente, numeroServicio, Nombre, Direccion, Telefonos, Contacto, email, Celular, CelularTrust, Tareas, DiaDeCobro, NombreCobrar);
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
                    HoRaRioSEmPleadOs he = null;
                    foreach (HorarioEscalafon hpd in ldh.Horario)
                    {
                        hd = new HoRaRioEScalaFOn();
                        hd.IDEscalafon = (uint)nroCon;
                        hd.IDEscalafonEmpleado = (uint)i;
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
                        he = new HoRaRioSEmPleadOs();
                        he.NroEmpleado = (uint)ldh.NroEmpleado;
                        he.IDEscalafon = (uint)nroCon;
                        he.IDEscalafonEmpleado = (uint)i;
                        he.Dia = hpd.getDia();
                        he.TipoDia = (byte)hpd.getTipoDia();
                        he.Solapa = (hpd.Solapea()) ? (sbyte)1 : (sbyte)0;

                        datos.altaHorEmpleado(he);
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
                    HoRaRioSEmPleadOs he = null;
                    foreach (HorarioEscalafon hpd in ldh.Horario)
                    {
                        hd = new HoRaRioEScalaFOn();
                        hd.IDEscalafon = (uint)nroEsc;
                        hd.IDEscalafonEmpleado = (uint)i;
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
                        he = new HoRaRioSEmPleadOs();
                        he.NroEmpleado = (uint)ldh.NroEmpleado;
                        he.IDEscalafon = (uint)nroEsc;
                        he.IDEscalafonEmpleado = (uint)i;
                        he.Dia = hpd.getDia();
                        he.TipoDia = (byte)hpd.getTipoDia();
                        he.Solapa = (hpd.Solapea()) ? (sbyte)1 : (sbyte)0;

                        datos.altaHorEmpleado(he);
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
            try
            {
                List<EScalaFOneMpLeadO> horarios = datos.getHorariosEmpleado(NroEmpleado);

                foreach (EScalaFOneMpLeadO linea in horarios)
                {
                    if (linea.IDEscalafon != IdEscalafon)
                    {
                        foreach (HoRaRioEScalaFOn h in linea.HoRaRioEScalaFOn)
                        {
                            if (h.IDEscalafonEmpleado == linea.IDEscalafonEmpleado && h.DiA == dia && h.TipoDia == 0)
                            {
                                if (HorariosSolapados(HoraIni, HoraFin, h.HoRaInI, h.HoRaFIn))
                                    return true;
                            }
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


        public bool SustituirEmpleado(int NroNuevoEmp, int NroViejoEmp)
        {            
            try
            {
                if (HorariosCruzados(NroNuevoEmp, NroViejoEmp))
                    return false;
                else
                {
                    datos.SustituirEmpleado(NroNuevoEmp, NroViejoEmp);
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void marcarSolapados(int IdEscalafon, Escalafon EscSolapados)
        {
            int NroEmp;
            List<HoRaRioSEmPleadOs> HorsSolap = new List<HoRaRioSEmPleadOs>();
            List<HoRaRioSEmPleadOs> HorsNOSolap = new List<HoRaRioSEmPleadOs>();
            foreach (EscalafonEmpleado ee in EscSolapados.ListaEscalafonEmpleados)
            {
                NroEmp = ee.NroEmpleado;
                foreach (HorarioEscalafon he in ee.Horario)
                {
                    if (he.Solapea())
                    {
                        try
                        {
                            List<EScalaFOneMpLeadO> horarios = datos.getHorariosEmpleado(NroEmp);
                            HoRaRioSEmPleadOs hemp;
                            foreach (EScalaFOneMpLeadO linea in horarios)
                            {
                                if (linea.IDEscalafon != IdEscalafon)
                                {
                                    foreach (HoRaRioEScalaFOn h in linea.HoRaRioEScalaFOn)
                                    {
                                        if (h.IDEscalafonEmpleado == linea.IDEscalafonEmpleado && h.DiA == he.getDia() && h.TipoDia == 0)
                                        {
                                            if (HorariosSolapados(he.getHoraIni(), he.getHoraFin(), h.HoRaInI, h.HoRaFIn))
                                            {
                                                //HORARIOS EMPLEADOS
                                                hemp = new HoRaRioSEmPleadOs();
                                                hemp.NroEmpleado = (uint)NroEmp;
                                                hemp.IDEscalafon = h.IDEscalafon;
                                                hemp.IDEscalafonEmpleado = h.IDEscalafonEmpleado;
                                                hemp.Dia = h.DiA;
                                                hemp.TipoDia = h.TipoDia;
                                                hemp.Solapa = 1;

                                                HorsSolap.Add(hemp);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                            throw ex;
                        }
                    }
                    else
                    {
                        try
                        {
                            List<HoRaRioSEmPleadOs> horemp = datos.getHorEmpleado(NroEmp, he.getDia(), IdEscalafon);                            
                            HoRaRioEScalaFOn h2;
                            foreach (HoRaRioSEmPleadOs h in horemp)
                            {
                                if (h.Solapa == 1)
                                {
                                    h2 = datos.getHorario(h);
                                    if (!EsHorarioSolapado((int)h.IDEscalafon, (int)h.NroEmpleado, h2.DiA, h2.HoRaInI, h2.HoRaFIn))
                                        HorsNOSolap.Add(h);
                                }                                    
                            }                                
                        }
                        catch (Exception ex)
                        {

                            throw ex;
                        }
                    }
                }
            }
            try
            {
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

        private void aplicarControlesAltaHoraGeneradaEscalafon(DateTime fechaCorresponde, HoRaSGeneraDaSEScalaFOn horaGeneradaEscalafon)
        {
            try
            {
                List<HoRaSGeneraDaSEScalaFOn> horarios = datos.obtenerHorasGeneradasEscalafonEmpleado(horaGeneradaEscalafon.NroEmpleado,fechaCorresponde);

                foreach (HoRaSGeneraDaSEScalaFOn linea in horarios)
                {
                    //DayOfWeek day = (DayOfWeek) DayOfWeek.Parse(typeof(DayOfWeek), h.DiA, true);
                    if (HorariosSolapados(horaGeneradaEscalafon.HoraEntrada.ToLongTimeString(), horaGeneradaEscalafon.HoraSalida.ToLongTimeString(), linea.HoraEntrada.ToLongTimeString(), linea.HoraSalida.ToLongTimeString()))
                        throw new Exception("Error de solapamiento de horarios. (" + horaGeneradaEscalafon.HoraEntrada.ToLongTimeString() + "-" + horaGeneradaEscalafon.HoraSalida.ToLongTimeString() + ") con " + "(" + linea.HoraEntrada.ToLongTimeString() + " - " + linea.HoraSalida.ToLongTimeString() + "). Dia: " + fechaCorresponde.ToShortDateString());
                                       
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                throw new GenerarHorasDiaException("Error en la generacion de horas. Cliente: " + NumeroCliente + " - Servicio: "+NumeroServicio + " - Fecha: " + Fecha.ToShortDateString(),e);
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
    }
}
