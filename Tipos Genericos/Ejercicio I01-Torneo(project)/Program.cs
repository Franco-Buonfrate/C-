using System;
using Ejercicio_I01_Torneo_Library_;

namespace Ejercicio_I01_Torneo_project_
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("afa");
            Torneo<EquipoBasquet> toneoBasquet = new Torneo<EquipoBasquet>("nba");

            torneoFutbol += new EquipoFutbol("San Lorenzo", new DateTime(1908, 04, 1));
            torneoFutbol += new EquipoFutbol("Boca Jr", new DateTime(1905, 04, 3));
            torneoFutbol += new EquipoFutbol("River Plate", new DateTime(1901, 05, 25));


            toneoBasquet += new EquipoBasquet("Golde State Warriors", new DateTime(1946, 00, 00));
            toneoBasquet += new EquipoBasquet("Boston Celtics", new DateTime(1946, 06, 6));
            toneoBasquet += new EquipoBasquet("Chicago Bulls", new DateTime(1966, 01, 16));



            Console.WriteLine("Hello World!");
        }
    }
}
