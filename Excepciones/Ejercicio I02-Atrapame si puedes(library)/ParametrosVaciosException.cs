using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02_Atrapame_si_puedes_library_
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException():base("Se deben completar todos los parametros")
        {
            
        }

        public ParametrosVaciosException(string message) : base(message)
        {
        }

        public ParametrosVaciosException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
