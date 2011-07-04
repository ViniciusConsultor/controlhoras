using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class Escalafon
    {
        public Contrato ContratoServicio { set; get; }
        public Servicio ServicioCliente { set; get; }
        public bool Cubierto { set; get; }

        public List<EscalafonEmpleado> ListaEscalafonEmpleados;


    }
}
