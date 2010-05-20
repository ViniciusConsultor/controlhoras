using System;
using System.Collections.Generic;
using System.Linq;
using DbLinq.Data.Linq;
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
        

    }
}
