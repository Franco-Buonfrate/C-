using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02_Calculadora_de_formas
{
    public class Rectangulo: Figura
    {
        double altura;
        double pie;

        public Rectangulo(double altura, double pie)
        {
            this.altura = altura;
            this.pie = pie;
        }

        public override string Dibujar()
        {
            return "Dibujando rectangulo";
        }

        public override double CalcularSuperficie()
        {
            return pie * altura;
        }

        public override double CalcularPerimetro()
        {
            return (2 * pie) + (2 * altura);
        }
    }
}
