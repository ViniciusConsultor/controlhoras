using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TransaccionGeneracionHorasNoIniciadaException : Exception
    {
        public TransaccionGeneracionHorasNoIniciadaException() : base() { }
        public TransaccionGeneracionHorasNoIniciadaException(string message) : base(message) { }
        public TransaccionGeneracionHorasNoIniciadaException(string message, System.Exception inner) : base(message, inner) { }
    }
}
