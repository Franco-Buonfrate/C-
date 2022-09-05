using System;

namespace Ejercicio_I02_Atrapame_si_puedes_library_
{
    public static class Calculador
    {
        public static float Calcular(float kilometros, float litros)
        {
            if (litros > 0)
            {
                return kilometros / litros;
            }
            else
            {
                throw new DivideByZeroException("No es posible dividir por cero");
            }
        }
    }
}
