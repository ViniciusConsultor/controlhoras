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
        private string RUT = null;
        private string Direccion = null;
        private string Telefono = null;
        private bool activo;
        private List<Servicio> Servicios;

        public Cliente(int num, string nom)
        {
            Nombre = nom;
            Numero = num;
            activo = true;
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

        public string getRUT()
        {
            return RUT;
        }

        public string getDireccion()
        {
            return Direccion;
        }

        public string getTelefono()
        {
            return Telefono;
        }

        public bool getActivo()
        {
            return activo;
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
