using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_Estadistica_Deportiva
{
    public class Jugador:Persona
    {
        private int partidosjugados;
        private int totalGoles;

        public int Partidosjugados 
        { 
            get
            { 
                return this.partidosjugados; 
            }
            set
            {
                this.partidosjugados = value;
            }
        }
        public float PromedioGoles 
        {
            get
            {
                float promedio = 0;

                if (this.partidosjugados > 0)
                {
                    promedio = (float)this.totalGoles / this.partidosjugados;
                }

                return promedio;
            }
        }
        public int TotalGoles 
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.TotalGoles = value;
            }
        }

        private Jugador(int dni, string nombre):this(dni,nombre,0,0)
        {
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):base(dni, nombre)
        {
            TotalGoles = totalGoles;
            Partidosjugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();

            constructor.AppendLine($"{base.MostrarDatos()}");
            constructor.AppendLine($"Partido jugador: {Partidosjugados}");
            constructor.AppendLine($"Total de goles: {TotalGoles}");
            constructor.AppendLine($"Promedio de goles: {PromedioGoles}");

            return constructor.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.Dni != j2.Dni;
        }

    }
}
