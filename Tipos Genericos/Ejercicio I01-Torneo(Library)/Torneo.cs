using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_I01_Torneo_Library_
{
    public class Torneo<T> where T:Equipo
    {
        public List<T> equipos;
        public string nombre;

        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random equipo = new Random();
                int indiceMax = this.equipos.Count - 1;                                                                                                                                       
                return CalcularPartido(this.equipos[equipo.Next(0,indiceMax)], this.equipos[equipo.Next(0, indiceMax)]);
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Torneo: {this.nombre}");
            sb.AppendLine("Participantes: ");
            foreach (Equipo e in this.equipos)
            {
                sb.AppendLine(e.Ficha());
            }
            return sb.ToString();
        }
        private string CalcularPartido(Equipo e1, Equipo e2)
        {
            Random resultados = new Random();
            return $"{e1.nombre} {resultados.Next(1, 10)} - {resultados.Next(1, 10)} {e2.nombre}";
        }

        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            foreach (Equipo e in torneo.equipos)
            {
                if (e.nombre == equipo.nombre)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }
        public static Torneo<T> operator +(Torneo<T> torneo, Equipo equipo)
        {
            if (torneo != equipo)
            {
                torneo.equipos.Add((T)equipo);
            }
            return torneo;
        }

    }
}
