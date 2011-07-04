using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class YaExistenHorasGeneradasParaLaFechaException : Exception
    {
        public YaExistenHorasGeneradasParaLaFechaException() : base() { }
        public YaExistenHorasGeneradasParaLaFechaException(string message) : base(message) { }
        public YaExistenHorasGeneradasParaLaFechaException(string message, System.Exception inner) : base(message, inner) { }
    }
}
