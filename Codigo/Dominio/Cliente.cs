using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Cliente
    {
        private int Numero;
        private string Nombre;
        private string NombreFantasia;
        private string RUT = null;
        private string Email = null;
        private string Direccion = null;
        private string DireccionCobro;
        private string Telefonos = null;
        private string Fax = null;
        private bool Activo;
        private DateTime? FechaAlta;
        private DateTime? FechaBaja;
        private string MotivoBaja;
        private List<Servicio> ListaServicios;

        public Cliente(int num, string nom, string tel)
        {
            Nombre = nom;
            Numero = num;
            Telefonos = tel;
            Activo = true;
            ListaServicios = new List<Servicio>();
        }

        public Cliente(int num, string nom, string nomFant, string rut, string email, string dir, string dirCobro, string telefono, string fax, bool activo, DateTime? fecAlta, DateTime? fecBaja, string motivo, List<Servicio> servicios)
        {
            Numero=num;
            Nombre=nom;
            NombreFantasia = nomFant;
            RUT=rut;
            Email = email;
            Direccion = dir;
            DireccionCobro = dirCobro;
            Telefonos=telefono;
            Fax = fax;
            Activo = activo;
            FechaAlta = fecAlta;
            FechaBaja = fecBaja;
            MotivoBaja = motivo;
            ListaServicios = servicios;
        }


        public int getNumero()
        {
            return Numero;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getNombreFantasia()
        {
            return NombreFantasia;
        }

        public string getRUT()
        {
            return RUT;
        }

        public string getEmail()
        {
            return Email;
        }

        public string getDireccion()
        {
            return Direccion;
        }

        public string getDireccionCobro()
        {
            return DireccionCobro;
        }

        public string getTelefonos()
        {
            return Telefonos;
        }

        public string getFax()
        {
            return Fax;
        }

        public bool getActivo()
        {
            return Activo;
        }

        public DateTime? getFechaAlta()
        {
            return FechaAlta;
        }

        public DateTime? getFechaBaja()
        {
            return FechaBaja;
        }

        public string getMotivoBaja()
        {
            return MotivoBaja;
        }

        public void addServicio(Servicio s)
        {
            ListaServicios.Add(s);
        }

        public List<Servicio> getListaServicios()
        {
            return ListaServicios;
        }

        public void deleteServicio(Servicio s)
        {
            ListaServicios.Remove(s);
        }

        public Servicio obtenerServicio(int numServicio)
        {
            return ListaServicios[0];
        }
    }
}
