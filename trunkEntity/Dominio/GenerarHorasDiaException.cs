using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class GenerarHorasDiaException : Exception
    {
        public GenerarHorasDiaException() : base() { }
        public GenerarHorasDiaException(string message) : base(message) { }
        public GenerarHorasDiaException(string message, System.Exception inner) : base(message, inner) { }
    }
   
}
