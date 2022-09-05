using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01_Lanzar_y_atrapar
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion()
        {
        }

        public UnaExcepcion(Exception innerException) : base("",innerException)
        {
        }

        public UnaExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
