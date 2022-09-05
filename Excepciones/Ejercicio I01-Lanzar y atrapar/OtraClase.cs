using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01_Lanzar_y_atrapar
{
    public class OtraClase
    {
        public OtraClase()
        {

        }
        public void Metodo()
        {
            try
            {
                MiClase clase = new MiClase(1);
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Mi Excepcion", ex);
            }
        }
    }
}
