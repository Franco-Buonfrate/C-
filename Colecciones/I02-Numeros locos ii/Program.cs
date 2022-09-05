using System;
using System.Collections.Generic;

namespace I02_Numeros_locos_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int>();
            Queue<int> cola = new Queue<int>();

            Random numeros = new Random();
            
            for (int i = 0; i < 20; i++)
            {
                lista.Add(numeros.Next(-100, 100));
            }

            Console.WriteLine("Lista primera carga: ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(lista[i] + " "); 
            }

            Console.WriteLine("\nPila primera carga: ");
            for (int i = 0; i < 20; i++)
            {
                int num = numeros.Next(-100, 100);
                pila.Push(num);
                Console.Write(num + " ");
            }

            Console.WriteLine("\nCola primer carga: ");
            for (int i = 0; i < 20; i++)
            {
                int num = numeros.Next(-100, 100);
                cola.Enqueue(num);
                Console.Write(num + " ");
            }

        }
    }
}
