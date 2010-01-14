using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
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
        private List<Servicio> Servicios;

        public Cliente(int num, string nom)
        {
            Nombre = nom;
            Numero = num;
            Activo = true;
            Servicios = new List<Servicio>();
        }

        public Cliente(int num, string nom, string rut, string telefono)
        {
            Numero=num;
            Nombre=nom;
            RUT=rut;
            Telefonos=telefono;
            Activo = true;
            Servicios = new List<Servicio>();
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

        public void addServicio(Servicio s)
        {
            Servicios.Add(s);
        }

        public List<Servicio> getListaServicios()
        {
            return Servicios;
        }

        public void deleteServicio(Servicio s)
        {
            Servicios.Remove(s);
        }
    }
}
