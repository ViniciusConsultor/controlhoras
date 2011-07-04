using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DbLinq;
using DbLinq.MySql;
using DbLinq.Data.Linq;
using Utilidades;

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
                    cargo.CobraHsExtras = 1;
                else
                    cargo.CobraHsExtras = 0;
                if (fulltime)
                    cargo.Fulltime = 1;
                else
                    cargo.Fulltime = 0;
                if (inactivo)
                    cargo.Activo = 0;
                else
                    cargo.Activo = 1;

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
                    cargo.CobraHsExtras = 1;
                else
                    cargo.CobraHsExtras = 0;
                if (fulltime)
                    cargo.Fulltime = 1;
                else
                    cargo.Fulltime = 0;
                if (inactivo)
                    cargo.Activo = 0;
                else
                    cargo.Activo = 1;

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
                    //listaCargos = tabla.ToList<TipOscarGoS>();

                    listaCargos = (from reg in tabla
                                   where reg.Activo == 1
                                   select reg).ToList<TipOscarGoS>();
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
                                   where reg.Activo == 1
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
                    tipoEvento.Activo = 1;
                else
                    tipoEvento.Activo = 0;

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
                    tipoEvento.Activo = 1;
                else
                    tipoEvento.Activo = 0;

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
                                  where reg.Activo == 1
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

        #region ABMUsuarios_Grupos
        public int altaUsuario(string NombreUsuario, string Password, string Nombre, string Apellido, DateTime FechaNacimiento, bool Estado)
        {
            UsUarIoS user = new UsUarIoS();
            user.Nombre = Nombre;
            user.Apellido = Apellido;
            user.UserName = NombreUsuario;
            user.FechaCreacion = DateTime.Today;
            user.Password = ControladorUtilidades.encriptarStringToMD5(Password);
            if (!Estado)
                    user.Activo = 1;
                else
                    user.Activo = 0;
            try
            {
                database.UsUarIoS.InsertOnSubmit(user);
                database.SubmitChanges();
                return user.IDUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
        public void modificarUsuario(int idUsuario, string NombreUsuario, string Nombre, string Apellido, bool Estado)
        {
            try
            {
                UsUarIoS user = (from reg in database.UsUarIoS
                                 where reg.IDUsuario == idUsuario
                                 select reg).Single();
                user.Nombre = Nombre;
                user.Apellido = Apellido;
                user.UserName = NombreUsuario;
                if (Estado)
                    user.Activo = 1;
                else
                    user.Activo = 0;
                
                database.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public List<UsUarIoS> obtenerListaUsuarios(bool soloactivos)
        {
            List<UsUarIoS> retornar;
            try
            {
                if (soloactivos)
                    retornar = (from reg in database.UsUarIoS
                                where reg.Activo == 1
                                select reg).ToList();
                else
                    retornar = database.UsUarIoS.ToList();
                return retornar;
            }catch (Exception e)
            {
                throw e;
            }
        }
        
        public List<string> obtenerListaUserNames(bool soloactivos)
        {
            List<string> retornar;
            try
            {
                if (soloactivos)
                    retornar = (from reg in database.UsUarIoS
                                where reg.Activo == 1
                                select reg.UserName).ToList();
                else
                    retornar = (from reg in database.UsUarIoS
                                select reg.UserName).ToList();
                return retornar;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Dictionary<int, List<int>> obtenerPermisosUsuario(string UserName)
        {
            Dictionary<int, List<int>> listaRetornar;
            try
            {
                int idUsuario = (from user in database.UsUarIoS
                                 where user.UserName == UserName
                                 select user.IDUsuario).Single();
                listaRetornar = new Dictionary<int, List<int>>();
                List<int> listaWinForm = (from r in database.PerMisOs
                                          where r.IDPermiso == idUsuario && r.UsuarioOrgRupo == "U" && r.WinFormOrcOntrol== "W"
                                          select r.IDControl).ToList();
                foreach (int idPant in listaWinForm)
                {
                    List<int> listaControles = (from pant in database.PerMisOs
                                                where pant.WinFormOrcOntrol == "C" && pant.UsuarioOrgRupo == "U" && pant.IDPermiso==idUsuario
                                                orderby pant.IDControl
                                                select pant.IDControl).ToList();
                    listaRetornar.Add(idPant, listaControles);
                }
                return listaRetornar;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<PerMisOControl> obtenerListaPermisosUsuarioPantalla(string UserName, string NombrePantalla)
        {
            try
            {
                ControladorDatos.getInstance().recargarContexto();
                int idUsuario = (from user in database.UsUarIoS
                                 where user.UserName == UserName
                                 select user.IDUsuario).Single();
                var idPantalla = from pant in database.PantAllAwInForm
                                  where pant.Nombre == NombrePantalla
                                  select pant.IDPantallaWinForm;
                if (idPantalla.Count() > 0)
                {
                    int i = idPantalla.Single();
                    List<PerMisOControl> listaWinForm = (from perm in database.PerMisOs
                                                         where perm.IDPermiso == idUsuario
                                        && perm.UsuarioOrgRupo == "U" && perm.WinFormOrcOntrol == "C"
                                                         join pc in database.PerMisOControl on perm.IDControl equals pc.IDPermisoControl
                                                         where pc.IDPantallaWinForm == i
                                                         select pc).ToList();


                    if (listaWinForm.Count() > 0)
                    {
                        return listaWinForm;
                    }
                    else
                        return new List<PerMisOControl>();
                }
                else
                    return new List<PerMisOControl>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void modificarPermisosUsuario(string UserName, Dictionary<int, List<int>> ListaIdPantallas_Controles)
        {
            try
            {
                int idUsuario = (from user in database.UsUarIoS
                                 where user.UserName == UserName
                                 select user.IDUsuario).Single();
                List<PerMisOs> permsViejos = (
                                              
                                              from user in database.UsUarIoS
                                              where user.IDUsuario == idUsuario
                                              join r in database.PerMisOs on user.IDUsuario equals r.IDPermiso
                                              where r.IDPermiso == idUsuario && r.UsuarioOrgRupo == "U"
                                              select r).ToList();


                database.PerMisOs.DeleteAllOnSubmit(permsViejos);
                List<PerMisOs> listaPermisos = new List<PerMisOs>();
                PerMisOs permiso;
                PerMisOs control;
                foreach (int idpantalla in ListaIdPantallas_Controles.Keys)
                {
                    permiso = new PerMisOs();
                    permiso.Activo = 1;
                    permiso.IDPermiso = idUsuario;
                    permiso.IDControl = idpantalla;
                    permiso.UsuarioOrgRupo = "U";
                    permiso.WinFormOrcOntrol = "W";
                    listaPermisos.Add(permiso);
                    foreach (int idcontrol in ListaIdPantallas_Controles[idpantalla])
                    {
                        control = new PerMisOs();
                        control.Activo = 1;
                        control.IDPermiso = idUsuario;
                        control.IDControl = idcontrol;
                        control.UsuarioOrgRupo = "U";
                        control.WinFormOrcOntrol = "C";
                        listaPermisos.Add(control);
                    }
                }
                database.PerMisOs.InsertAllOnSubmit(listaPermisos);
                database.SubmitChanges();
               
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int altaGrupo(string Nombre, string Descripcion,bool activo,List<string> usuarios, Dictionary<int,List<int>> ListaIdPantallas_Controles)
        {
            GRuPOs grupo;
            try
            {
                grupo = new GRuPOs();
                grupo.Nombre = Nombre;
                grupo.Descripcion = Descripcion;
                if (activo)
                    grupo.Activo = 1;
                else
                    grupo.Activo = 0;
                UsUarIoSGRuPOs ug;
                EntitySet<UsUarIoSGRuPOs> listaUsuariosGrupos = new EntitySet<UsUarIoSGRuPOs>();
                foreach(string username in usuarios)
                {
                    ug = new UsUarIoSGRuPOs();
                    UsUarIoS user = database.UsUarIoS.Where(u => u.UserName ==username).Single();
                    ug.UsUarIoS = user;
                    ug.GRuPOs = grupo;
                    listaUsuariosGrupos.Add(ug);
                }
                grupo.UsUarIoSGRuPOs = listaUsuariosGrupos;

                database.GRuPOs.InsertOnSubmit(grupo);
                database.SubmitChanges();
                return grupo.IDGrupo;
            }
            catch
            {
                throw;
            }
        }
        public void modificarGrupo(int IdGrupo, string Nombre, string Descripcion, bool activo, List<string> usuarios, Dictionary<int, List<int>> ListaIdPantallas_Controles)
        {
            try
            {
                GRuPOs grupo = database.GRuPOs.Where(g => g.IDGrupo == IdGrupo).Single();
                grupo.Nombre = Nombre;
                grupo.Descripcion = Descripcion;
                if (activo)
                    grupo.Activo = 1;
                else
                    grupo.Activo = 0;
                UsUarIoSGRuPOs ug;
                EntitySet<UsUarIoSGRuPOs> lista = new EntitySet<UsUarIoSGRuPOs>();
                foreach (string username in usuarios)
                {
                    ug = new UsUarIoSGRuPOs();
                    int iduser = database.UsUarIoS.Where(u => u.UserName == username).Select(u=>u.IDUsuario).Single();
                    ug.IDUsuario = iduser;
                    ug.GRuPOs = grupo;
                    lista.Add(ug);
                }
                
                grupo.UsUarIoSGRuPOs = lista;

                List<PerMisOs> listaPermisos = new List<PerMisOs>();
                PerMisOs permiso;
                PerMisOs control;
                foreach (int idpantalla in ListaIdPantallas_Controles.Keys)
                {
                    permiso = new PerMisOs();
                    permiso.Activo = 1;
                    permiso.IDPermiso = IdGrupo;
                    permiso.IDControl = idpantalla;
                    permiso.UsuarioOrgRupo = "G";
                    permiso.WinFormOrcOntrol = "W";
                    listaPermisos.Add(permiso);
                    foreach (int idcontrol in ListaIdPantallas_Controles[idpantalla])
                    {
                        control = new PerMisOs();
                        control.Activo = 1;
                        control.IDPermiso = IdGrupo;
                        control.IDControl = idcontrol;
                        control.UsuarioOrgRupo = "G";
                        control.WinFormOrcOntrol = "C";
                        listaPermisos.Add(control);
                    }
                }
                List<PerMisOs> permsViejos = (from reg in database.PerMisOs
                                              where reg.IDPermiso == IdGrupo && reg.UsuarioOrgRupo=="G"
                                              select reg).ToList();
                //List<UsUarIoSGRuPOs> usugroupsViejos = (from reg in database.UsUarIoSGRuPOs
                //                                        where reg.IDGrupo == IdGrupo
                //                                        select reg).ToList();
                //database.UsUarIoSGRuPOs.DeleteAllOnSubmit(usugroupsViejos);
                database.SubmitChanges();
                database.PerMisOs.DeleteAllOnSubmit(permsViejos);
                database.SubmitChanges();
                database.PerMisOs.InsertAllOnSubmit(listaPermisos);
                database.SubmitChanges();
            }
            catch
            {
                ControladorDatos.createContext();
                throw;
            }
        }
        public List<GRuPOs> obtenerListaGrupos(bool soloactivos)
        {
            try
            {
                if (soloactivos)
                    return database.GRuPOs.Where(g => g.Activo == 1).ToList();
                else
                    return database.GRuPOs.ToList();
            }
            catch
            {
                throw;
            }
        }
        

        #endregion

        #region ABM_TipoExtraLiquidacion
        public int altaTipoExtraLiquidacion(string nombreTipoExtra, bool activo, bool llevaHs)
        {
            try
            {
                TipOExtraLiquidAcIon tipoExtra = new TipOExtraLiquidAcIon();

                tipoExtra.Nombre = nombreTipoExtra;
                if (activo)
                    tipoExtra.Activo = 1;
                else
                    tipoExtra.Activo = 0;
                if (llevaHs)
                    tipoExtra.LlevaHs = 1;
                else
                    tipoExtra.LlevaHs = 0;
                database.TipOExtraLiquidAcIon.InsertOnSubmit(tipoExtra);
                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

                return tipoExtra.IDTipoExtraLiquidacion;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void modificarTipoExtraLiquidacion(TipOExtraLiquidAcIon tipoExtra)
        {
            try
            {
                TipOExtraLiquidAcIon tipoEvento = (from reg in database.TipOExtraLiquidAcIon
                                                   where reg.IDTipoExtraLiquidacion == tipoExtra.IDTipoExtraLiquidacion
                                                   select reg).Single<TipOExtraLiquidAcIon>();
                tipoEvento.Nombre = tipoExtra.Nombre;
                tipoEvento.Activo = tipoExtra.Activo;
                tipoEvento.LlevaHs = tipoExtra.LlevaHs;
                

                database.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TipOExtraLiquidAcIon> obtenerTipoExtraLiquidacion(bool soloactivos)
        {
            try
            {
                List<TipOExtraLiquidAcIon> tipoEvento;
                if (soloactivos)
                    tipoEvento = (from reg in database.TipOExtraLiquidAcIon
                                  where reg.Activo == 1
                                  orderby reg.Nombre ascending
                                  select reg).ToList<TipOExtraLiquidAcIon>();
                else
                    tipoEvento = (from reg in database.TipOExtraLiquidAcIon
                                  orderby reg.Nombre ascending
                                  select reg).ToList<TipOExtraLiquidAcIon>();
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
