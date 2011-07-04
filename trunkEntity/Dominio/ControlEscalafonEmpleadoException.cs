using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class ControlEscalafonEmpleadoException : Exception
    {
        public ControlEscalafonEmpleadoException() : base() { }
        public ControlEscalafonEmpleadoException(string message) : base(message) { }
        public ControlEscalafonEmpleadoException(string message, System.Exception inner) : base(message, inner) { }
    }
}
