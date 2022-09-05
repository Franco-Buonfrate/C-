using System;

namespace Ejercicio_I01_Lanzar_y_atrapar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.Metodo();
            }
            catch (MiExcepcion ex)
            {
                Exception aux = ex;
                do
                {
                    Console.WriteLine(aux.Message);
                    aux = aux.InnerException;
                } while (aux is not null);
            }
        }
    }
}
