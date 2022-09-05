using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAtraparYLanzar
{
    public class OtraClase
    {


        public void MetodoDeInstancia()
        {
            try
            {
                MiClase miClase = new MiClase(5);
            }
            catch (UnaExcepcion e)
            {
                throw new MiExcepcion(e);
            }
        }
    }
}
