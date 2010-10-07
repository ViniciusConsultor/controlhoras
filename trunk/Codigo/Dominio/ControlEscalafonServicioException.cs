using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ControlEscalafonServicioException: Exception
    {
        public ControlEscalafonServicioException() : base() { }
        public ControlEscalafonServicioException(string message) : base(message) { }
        public ControlEscalafonServicioException(string message, System.Exception inner) : base(message, inner) { }
    }
}
