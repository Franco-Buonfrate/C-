using System;

namespace Conexion_bases_de_datos
{
    public class Persona
    {
        public int id;
        public string nombre;

        public Persona(string nombre, int id)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}
