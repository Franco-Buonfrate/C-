using System;
using Ejercicio_I01_Lanzar_y_atrapar;

namespace Ejercicio_I01_Lanzar_y_atrapar_main_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiClase nueva = new MiClase(1);
            }
            catch (MiExcepcion ex)
            {

            }
        }
    }
}
