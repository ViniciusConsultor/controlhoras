using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    public class NoExisteException : Exception
    {

        public NoExisteException()
            : base()
        {
        }

        public NoExisteException(string message)
            : base(message)
        {
        }

        public NoExisteException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public NoExisteException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}
