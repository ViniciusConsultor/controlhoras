using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class TransaccionGeneracionHorasYaIniciadaException : Exception
    {
        public TransaccionGeneracionHorasYaIniciadaException() : base() { }
        public TransaccionGeneracionHorasYaIniciadaException(string message) : base(message) { }
        public TransaccionGeneracionHorasYaIniciadaException(string message, System.Exception inner) : base(message, inner) { }
    }
}
