using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02_Calculadora_de_formas
{
    public sealed class Cuadrado:Rectangulo
    {

        public Cuadrado(double lado):base(lado,lado)
        {
        }

        public override string Dibujar()
        {
            return "Dibujando cuadrado";
        }

        public override double CalcularSuperficie()
        {
            return base.CalcularSuperficie();
        }

        public override double CalcularPerimetro()
        {
            return base.CalcularPerimetro();
        }
    }
}
