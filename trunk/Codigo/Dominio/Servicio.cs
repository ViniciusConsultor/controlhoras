using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Servicio
    {
        private int Numero;
        private int NumeroCliente; //este campo me parece que no va y si iría creo ke debería ser una referencia al objeto cliente
        private string Nombre;
        private string Direccion = null;
        private string Telefonos = null;
        private string Contacto = null;
        private string DiaDeCobro = null;
        private string NombreCobrar = null;
        private string Email = null;
        private string Celular = null;
        private string CelularTrust = null;
        private string TareasAsign = null;
        private bool Activo;
        //private Contrato Contrato;
        private DateTime FechaAlta;
        private DateTime FechaBaja;
        private string MotivoBaja;
        

        public Servicio(int num, int numCliente, string nombre)
        {
            Numero = num;
            NumeroCliente = numCliente;
            Nombre = nombre;
            Activo = true;
        }

        public Servicio(int num, string nombre, string dir, string tel, string con, string mail, string cel, string celt, string tareas, bool activo, DateTime fechaalta, DateTime fechabaja, string motivobaja, string diacobrar, string nombrecobrar)
        {
            Numero = num;            
            Nombre = nombre;
            Direccion = dir;
            Telefonos = tel;
            Contacto = con;
            Email = mail;
            Celular = cel;
            CelularTrust = celt;
            TareasAsign = tareas;
            Activo = activo;
            FechaAlta = fechaalta;
            FechaBaja = fechabaja;
            MotivoBaja = motivobaja;
            DiaDeCobro = diacobrar;
            NombreCobrar = nombrecobrar;            
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
            return Email;
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
            return Activo;
        }

        public string getDiaCobro()
        {
            return DiaDeCobro;
        }

        public string getNombreCobrar()
        {
            return NombreCobrar;
        }

        //public Contrato getContrato()
        //{
        //    return new Contrato(DateTime.Now,DateTime.Now,"","",true,0.0);
        //}

        //public void setContrato(Contrato con)
        //{
        //    Contrato = con;
        //}

    }
}
