using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbLinq;
using DbLinq.MySql;
using DbLinq.Data.Linq;

namespace Datos
{
    public class DatosABMTipos : IDatosABMTipos
    {
        private TrustDb database = null;
        private static IDatosABMTipos instance = null;


        private DatosABMTipos()
        {
            database = ControladorDatos.getContext();
        }

        public static IDatosABMTipos getInstance()//(string StringConnection)
        {
            if (instance == null)
                instance = new DatosABMTipos(); //(string StringConnection)
            return instance;
        }
       


        #region Miembros de IDatosABMTipos

        #region Cargos
        public int altaCargo(string nombre, string descripcion, int cantidadHsComunes, string tipoFacturacion, bool cobraExtras, bool fulltime, bool inactivo)
        {
            try
            {
                Table<TipOscarGoS> tabla = database.GetTable<TipOscarGoS>();

                TipOscarGoS cargo = new TipOscarGoS();
                cargo.Nombre = nombre;
                cargo.Descripcion = descripcion;
                cargo.CantidadHsComunes = (sbyte) cantidadHsComunes;
                cargo.TipoFacturacion = tipoFacturacion;
                if (cobraExtras)
                    cargo.CobraHsExtras = 0;
                else
                    cargo.CobraHsExtras = 1;
                if (fulltime)
                    cargo.Fulltime = 0;
                else
                    cargo.Fulltime = 1;
                if (inactivo)
                    cargo.Activo = 1;
                else
                    cargo.Activo = 0;

                tabla.InsertOnSubmit(cargo);
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                return (int)cargo.IDCargo;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void modificarTipoCargo(int idCargo, string nombre, string descripcion, int cantidadHsComunes, string tipoFacturacion, bool cobraExtras, bool fulltime, bool inactivo)
        {
            try
            {
                Table<TipOscarGoS> tabla = database.GetTable<TipOscarGoS>();

                TipOscarGoS cargo = (from reg in tabla
                                     where reg.IDCargo == idCargo
                                     select reg).Single<TipOscarGoS>();

                cargo.Nombre = nombre;
                cargo.Descripcion = descripcion;
                cargo.CantidadHsComunes = (sbyte) cantidadHsComunes;
                cargo.TipoFacturacion = tipoFacturacion;
                if (cobraExtras)
                    cargo.CobraHsExtras = 0;
                else
                    cargo.CobraHsExtras = 1;
                if (fulltime)
                    cargo.Fulltime = 0;
                else
                    cargo.Fulltime = 1;
                if (inactivo)
                    cargo.Activo = 1;
                else
                    cargo.Activo = 0;

                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Dictionary<int, string> obtenerTiposCargos(bool soloactivos)
        {
            Dictionary<int, string> result;

            try
            {
                Table<TipOscarGoS> tabla = database.GetTable<TipOscarGoS>();
                List<TipOscarGoS> listaCargos;

                result = new Dictionary<int, string>();

                if (soloactivos)
                    listaCargos = tabla.ToList<TipOscarGoS>();

                    //listaCargos = (from reg in tabla
                    //               where reg.Activo == 0
                    //               select reg).ToList<TipOscarGoS>();
                else
                    listaCargos = tabla.ToList<TipOscarGoS>();

                foreach (TipOscarGoS l in listaCargos)
                {
                    result.Add((byte)l.IDCargo, l.Nombre);
                }

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<TipOscarGoS> obtenerTiposCargosList(bool soloactivos)
        {            
            try
            {
                Table<TipOscarGoS> tabla = database.GetTable<TipOscarGoS>();
                List<TipOscarGoS> listaCargos;
                
                if (soloactivos)
                    listaCargos = (from reg in tabla
                                   where reg.Activo == 0
                                   select reg).ToList<TipOscarGoS>();
                else
                    listaCargos = tabla.ToList<TipOscarGoS>();

                return listaCargos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion


        public int altaDepartamento(string nombreDepartamento, bool activo)
        {
            throw new NotImplementedException();
        }

        public void modificarDepartamento(int idDepartamento, string nombreDepartamento, bool activo)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> obtenerDepartamentos(bool activos)
        {
            throw new NotImplementedException();
        }

        public void bajaDepartamento(int idDepartamento)
        {
            throw new NotImplementedException();
        }

        public int altaBanco(string nombreBanco, bool activo)
        {
            throw new NotImplementedException();
        }

        public void modificarBanco(int idBanco, string nombreBanco, bool activo)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> obtenerBancos(bool activos)
        {
            throw new NotImplementedException();
        }

        public void bajaBanco(int idBanco)
        {
            throw new NotImplementedException();
        }

        public int altaMutualista(string nombreMutualista, bool activo)
        {
            throw new NotImplementedException();
        }

        public void modificarMutualista(int idMutualista, string nombreMutualista, bool activo)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> obtenerMutualistas(bool activos)
        {
            throw new NotImplementedException();
        }

        public void bajaMutualista(int idMutualista)
        {
            throw new NotImplementedException();
        }

        public int altaEmergenciaMedica(string nombreEmergenciaMedica, bool activo)
        {
            throw new NotImplementedException();
        }

        public void modificarEmergenciaMedica(int idEmergenciaMedica, string nombreEmergenciaMedica, bool activo)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> obtenerEmergenciaMedicas(bool activos)
        {
            throw new NotImplementedException();
        }

        public void bajaEmergenciaMedica(int idEmergenciaMedica)
        {
            throw new NotImplementedException();
        }

        public int altaTipoDocumento(string nombreTipoDocumento, bool activo)
        {
            throw new NotImplementedException();
        }

        public void modificarTipoDocumento(int idTipoDocumento, string nombreTipoDocumento, bool activo)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> obtenerTipoDocumentos(bool activos)
        {
            throw new NotImplementedException();
        }

        public void bajaTipoDocumento(int idTipoDocumento)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region TipoEventoHistorial

        public int altaTipoEventoHistorial(string descripcion, bool activo)
        {
            try
            {
                Table<TipOsEventOHistOrIal> tabla = database.GetTable<TipOsEventOHistOrIal>();

                TipOsEventOHistOrIal tipoEvento = new TipOsEventOHistOrIal();

                tipoEvento.Nombre = descripcion;
                if (activo)
                    tipoEvento.Activo = 0;
                else
                    tipoEvento.Activo = 1;

                tabla.InsertOnSubmit(tipoEvento);
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                return tipoEvento.IDTipoEventoHistorial;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void modificarTipoEventoHistorial(int idTipoEventoHistorial, string descripcion, bool activo)
        {
            try
            {
                Table<TipOsEventOHistOrIal> tabla = database.GetTable<TipOsEventOHistOrIal>();

                TipOsEventOHistOrIal tipoEvento = (from reg in tabla
                                                   where reg.IDTipoEventoHistorial == idTipoEventoHistorial
                                                   select reg).Single<TipOsEventOHistOrIal>();
                tipoEvento.Nombre = descripcion;
                if (activo)
                    tipoEvento.Activo = 0;
                else
                    tipoEvento.Activo = 1;

                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TipOsEventOHistOrIal> obtenerTiposEventoHistorial(bool soloactivos)
        {
            try
            {

                Table<TipOsEventOHistOrIal> tabla = database.GetTable<TipOsEventOHistOrIal>();

                List<TipOsEventOHistOrIal> tipoEvento;
                if (soloactivos)
                    tipoEvento = (from reg in tabla
                                  where reg.Activo == 0
                                  select reg).ToList<TipOsEventOHistOrIal>();
                else
                    tipoEvento = (from reg in tabla
                                  select reg).ToList<TipOsEventOHistOrIal>();
                return tipoEvento;

                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
