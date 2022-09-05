using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAtraparYLanzar
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion() : base("Soy del tipo MiExcepcion")
        {

        }
        public MiExcepcion(Exception exception) : base("Exepcion con parametros MiExcepcion", exception)
        {

        }
    }
}
