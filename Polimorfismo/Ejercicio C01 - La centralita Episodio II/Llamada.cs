using System;
using System.Text;


namespace Ejercicio_C01___La_centralita_Episodio_II
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion,string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.duracion}");
            sb.AppendLine($"Origen: {this.nroOrigen}");
            sb.AppendLine($"Destino: {this.nroDestino}");
            return sb.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                return -1;
            }

            return 0;
        }

        public static bool operator ==(Llamada a, Llamada b)
        {
            return a.Equals(b) && a.nroDestino == b.nroDestino && a.nroOrigen == b.nroOrigen;
        }
        public static bool operator !=(Llamada a, Llamada b)
        {
            return !(a == b);
        }

    }
}
/*
 * La clase Llamada ahora será abstracta. Tendrá definida la propiedad de sólo lectura CostoLlamada que también será abstracta.
El método Mostrar deberá ser declarado como virtual, protegido y retornará un string que contendrá los atributos propios de la clase Llamada.
El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo (utilizar el método Equals, sobrescrito en las clases derivadas) y los números de destino y origen son iguales en ambas llamadas.
 */
