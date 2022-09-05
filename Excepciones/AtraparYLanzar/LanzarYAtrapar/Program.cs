using System;
using ClassLibraryAtraparYLanzar;

namespace LanzarYAtrapar
{
    class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase = new OtraClase();
            string mensaje = string.Empty;

            try
            {
                otraClase.MetodoDeInstancia();
            }
            catch (Exception e)
            {
                Exception aux = e;
                do
                {
                    mensaje = aux.Message +"\n" + mensaje;
                    aux = aux.InnerException;

                } while (aux is not null);
                Console.WriteLine(mensaje);
            }
            Console.ReadKey();
        }
    }
}
