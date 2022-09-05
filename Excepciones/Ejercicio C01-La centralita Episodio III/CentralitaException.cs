using System;

namespace Ejercicio_C01_La_centralita_Episodio_III
{
    public class CentralitaException:Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        public CentralitaException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

    }
}
