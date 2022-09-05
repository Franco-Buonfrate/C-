using System;

namespace I01_El_viajar_es_un_placer
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajero;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color,short cantidadMarchas, int cantidadPasajero):
            base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajero = cantidadPasajero;
        }
    }
}
