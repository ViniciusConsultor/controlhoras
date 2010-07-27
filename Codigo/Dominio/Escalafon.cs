using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    class Escalafon
    {
        public Contrato ContratoServicio { set; get; }
        public Servicio ServicioCliente { set; get; }

        public List<EscalafonEmpleado> ListaEscalafonEmpleados { set; get; }


    }
}
