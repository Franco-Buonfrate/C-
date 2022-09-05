using System;

namespace ClassLibraryAtraparYLanzar
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion() : base("Soy del tipo UnaExcepcion")
        {

        }

        public UnaExcepcion(string mensaje, Exception exception) 
            : base(mensaje, exception)
        {

        }
    }
}
