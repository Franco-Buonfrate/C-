using System;

namespace I01_Numeros_locos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cadenaNum = new int[20];
            Random rdm = new Random();
            for (int i = 0; i < 20; i++)
            {
                cadenaNum[i] = rdm.Next(-100,100);
            }

            Console.WriteLine($"1. Aleatoreos tal cual: ");
            foreach (int num in cadenaNum)
            {
                Console.Write(num + " ");
            }

            Array.Sort(cadenaNum, Program.OrdenDescendente);
            Console.WriteLine($"\n2. Aleatoreos ordenados decreciente: ");
            foreach (int num in cadenaNum)
            {
                Console.Write(num + " ");
            }

            Array.Sort(cadenaNum);
            Console.WriteLine($"\n3. Aleatoreos ordenados creciente: ");
            foreach (int num in cadenaNum)
            {
                Console.Write(num + " ");
            }



        }

        public static int OrdenDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}
