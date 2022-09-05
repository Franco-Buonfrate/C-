using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01_Lanzar_y_atrapar
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                MiClase.division();
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
                MiClase nueva = new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new UnaExcepcion("Una exepcion",ex);
            }
        }

        public static void division()
        {
            throw new DivideByZeroException("DivideByCero");
        }
    }
}
