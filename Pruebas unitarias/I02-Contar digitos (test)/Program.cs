using System;
using I02_Contar_digitos;

namespace I02_Contar_digitos__test_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero");
                string input = Console.ReadLine();

                try
                {
                    int contar = long.Parse(input).ContarCantidadDeDigitos();
                    Console.WriteLine($"Cantidad de digitos: {contar}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingreso Invalido");
                    i -= 1;
                }
            }



        }
    }
}
