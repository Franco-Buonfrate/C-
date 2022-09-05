using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryAtraparYLanzar
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }

        public MiClase(int a)
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("Exepcion con parametros UnaExcepcion", e);
            }
        }

        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("No se puede dividir por 0");
        }
    }
}
