using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02_Calculadora_de_formas
{
    public sealed class Circulo:Figura
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando circulo";
        }

        public override double CalcularSuperficie()
        {
            return Math.Pow(radio, 2)*Math.PI;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }


    }
}
