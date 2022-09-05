using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01_Estadistica_Deportiva
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(long dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;
        }

        public Persona(string nombre) : this(0, nombre)
        {}

        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string MostrarDatos()
        {
            return $"Dni: {Dni} \nNombre: {Nombre}";
        }
    }
}
