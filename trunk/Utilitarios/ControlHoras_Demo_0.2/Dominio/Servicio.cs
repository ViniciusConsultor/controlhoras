using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Servicio
    {
        private int Numero;
        private int NumeroCliente;
        private string Nombre;
        private string Direccion=null;
        private bool activo;

        public Servicio(int num, int numCliente, string nombre)
        {
            Numero = num;
            NumeroCliente = numCliente;
            Nombre = nombre;
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

        public bool getActivo()
        {
            return activo;
        }
    }
}
