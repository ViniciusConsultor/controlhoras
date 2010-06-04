using System;
using System.Collections.Generic;
using System.Text;
using Datos;

namespace Logica
{
    public class ControladorABMTipos : IABMTipos
    {
        private static ControladorABMTipos instancia = null;
        private static IDatos datos = null;

        private ControladorABMTipos()
        {
            datos = ControladorDatos.getInstance();
        }

        public static ControladorABMTipos getInstance()
        {
            if (instancia == null)
                instancia = new ControladorABMTipos();
            return instancia;
        }

        #region Miembros de IABMTipos

        public int altaTipoEmpleado()
        {
            throw new NotImplementedException();
        }

        public void modificacionTipoEmpleado()
        {
            throw new NotImplementedException();
        }

        public void bajaTipoEmpleado()
        {
            throw new NotImplementedException();
        }

        public List<TipoEmpleado> obtenerTiposEmpleado()
        {
            throw new NotImplementedException();
        }

        #endregion

        

        #region ABM_Departamentos
        public int altaDepartamento(string nombreDepartamento, bool activo)
        {
            try
            {
                return datos.altaDepartamento(nombreDepartamento, activo);
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
                datos.modificarDepartamento(idDepartamento, nombreDepartamento, activo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerDepartamentos(bool soloActivos)
        {
            try
            {
                return datos.obtenerDepartamentos(soloActivos);
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
                return datos.altaCiudad(nombreCiudad, activo);
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
                datos.modificarCiudad(idCiudad, nombreCiudad, activo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerCiudades(bool soloActivos)
        {
            try
            {
                return datos.obtenerCiudades(soloActivos);
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
                return datos.altaBarrio(nombreBarrio, activo);
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
                datos.modificarBarrio(idBarrio, nombreBarrio, activo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerBarrios(bool soloActivos)
        {
            try
            {
                return datos.obtenerBarrios(soloActivos);
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
                return datos.altaBanco(nombreBanco, activo);

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
                datos.modificarBanco(idBanco, nombreBanco, activo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerBancos(bool soloActivos)
        {
            try
            {
                return datos.obtenerBancos(soloActivos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void bajaBanco(int idBanco)
        {}
        #endregion

        #region ABM_Mutualistas
        public int altaMutualista(string nombreMutualista, bool activo)
        {
            try
            {
                return datos.altaMutualista(nombreMutualista, activo);
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
                datos.modificarMutualista(idMutualista, nombreMutualista, activo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerMutualistas(bool soloActivos)
        {
            try
            {
                return datos.obtenerMutualistas(soloActivos);
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
                return datos.altaEmergenciaMedica(nombreEmergenciaMedica, activo);
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
                datos.modificarEmergenciaMedica(idEmergenciaMedica, nombreEmergenciaMedica, activo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerEmergenciaMedicas(bool soloActivos)
        {
            try
            {
                return datos.obtenerEmergenciaMedicas(soloActivos);
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
                return datos.altaTipoDocumento(nombreTipoDocumento, activo);
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
                datos.modificarTipoDocumento(idTipoDocumento, nombreTipoDocumento, activo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<int, string> obtenerTipoDocumentos(bool soloActivos)
        {
            try
            {
                return datos.obtenerTipoDocumentos(soloActivos);
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
