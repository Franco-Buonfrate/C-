using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___La_centralita_Episodio_I
{
    public class Local:Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo):this(new Llamada(duracion,destino,origen),costo)
        {
        }
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {this.GetType().Name}");
            sb.AppendLine(base.Mostrar());
            sb.Append($"Costo: {this.costo}");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return (float)(this.costo * this.duracion);
        }
    }
}
/*
 * Hereda de Llamada.
Método Mostrar retornará como texto todos los datos de la clase base y agregará el costo de la llamada. Utilizar StringBuilder.
CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
La propiedad CostoLlamada retornará el precio, que se calculará en el método CalcularCosto.
 */
