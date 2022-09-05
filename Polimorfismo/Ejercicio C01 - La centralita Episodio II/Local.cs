using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___La_centralita_Episodio_II
{
    public class Local:Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion,llamada.NroDestino,costo)
        {
            
        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return (float) (this.duracion * this.costo);
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.CostoLlamada}");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
/*
 * Sobrescribir el método Mostrar. Será protegido. Reutilizará el código escrito en la clase base y además agregará la propiedad CostoLlamada, utilizando un StringBuilder.
El método Equals retornará true sólo si el objeto que recibe es de tipo Local.
El método ToString reutilizará el código del método Mostrar.
 */
