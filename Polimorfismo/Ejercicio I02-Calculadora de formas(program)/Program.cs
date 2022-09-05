using System;
using System.Collections.Generic;
using Ejercicio_I02_Calculadora_de_formas;
namespace Ejercicio_I02_Calculadora_de_formas_program_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Rectangulo(4, 8));
            figuras.Add(new Circulo(5));
            figuras.Add(new Cuadrado(3));

            //foreach (Figura fig in figuras)
            //{
            //    fig.Dibujar();
            //    Console.WriteLine($"Perimetro: {fig.CalcularPerimetro()}");
            //    Console.WriteLine($"Area: {fig.CalcularSuperficie()}");
            //}

            for (int i = 0; i < figuras.Count; i++)
            {
                Console.WriteLine($"=============FIGURA {i+1}===============");
                Console.WriteLine($"{figuras[i].Dibujar()}");
                Console.WriteLine($"Perimetro: {figuras[i].CalcularPerimetro()}");
                Console.WriteLine($"Area: {figuras[i].CalcularSuperficie()}");
                Console.WriteLine("====================================\n");

            }

        }
    }
}
