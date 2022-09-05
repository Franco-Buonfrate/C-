using System;
using System.Text;

namespace Ejercicio_C01___La_centralita_Episodio_I
{
    public class Llamada
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

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

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

        public int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            return (int)(l1.duracion - l2.duracion);
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Duracion : {this.duracion}");
            sb.AppendLine($"Numero de Origen : {this.nroOrigen}");
            sb.AppendLine($"Numero de destino: {this.nroDestino}");

            return sb.ToString();
        }
    }
}
/*
 *Tendrá todos sus atributos con el modificador protected. Crear las propiedades de sólo lectura para exponer estos atributos.
OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para ordenar una lista de llamadas de forma ascendente.
Mostrar es un método de instancia que deberá retornar todos los datos de la llamada como texto. Utilizar StringBuilder.
 */
