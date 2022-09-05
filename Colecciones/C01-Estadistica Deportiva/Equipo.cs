using System;
using System.Collections.Generic;

namespace C01_Estadistica_Deportiva
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;



        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidadDeJugadores, string nombre):this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno;
            bool validator = false;

            foreach (Jugador cadaJugador in e.jugadores)
            {
                if (j == cadaJugador)
                {
                    validator = true;
                }
            }

            if (validator && e.jugadores.Count<e.cantidadDeJugadores)
            {
                e.jugadores.Add(j);
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
