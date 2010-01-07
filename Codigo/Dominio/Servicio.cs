using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Servicio
    {
        private int Numero;
        private int NumeroCliente; //este campo me parece que no va y si iría creo ke debería ser una referencia al objeto cliente
        private string Nombre;
        private string Direccion = null;
        private string Telefonos = null;
        private string Contacto = null;
        private string email = null;
        private string Celular = null;
        private string CelularTrust = null;
        private string TareasAsign = null;
        private bool activo;
        private Contrato Contrato;

        public Servicio(int num, int numCliente, string nombre)
        {
            Numero = num;
            NumeroCliente = numCliente;
            Nombre = nombre;
            activo = true;
        }

        public Servicio(int num, string nombre, string dir, string tel, string con, string mail, string cel ,string celt, string tareas)
        {
            Numero = num;            
            Nombre = nombre;
            Direccion = dir;
            Telefonos = tel;
            Contacto = con;
            email = mail;
            Celular = cel;
            CelularTrust = celt;
            TareasAsign = tareas;
            activo = true;
        }

        public int getNumero()
        {
            return Numero;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public string getDireccion()
        {
            return Direccion;
        }

        public string getTelefonos()
        {
            return Telefonos;
        }

        public string getContacto()
        {
            return Contacto;
        }

        public string getemail()
        {
            return email;
        }

        public string getCelular()
        {
            return Celular;
        }

        public string getCelularTrust()
        {
            return CelularTrust;
        }

        public string getTareasAsignadas()
        {
            return TareasAsign;
        }

        public bool getActivo()
        {
            return activo;
        }

        public Contrato getContrato()
        {
            return Contrato;
        }

        public void setContrato(Contrato con)
        {
            Contrato = con;
        }

    }
}
