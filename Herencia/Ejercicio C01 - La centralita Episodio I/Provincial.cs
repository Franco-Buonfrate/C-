using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___La_centralita_Episodio_I
{
    public class Provincial:Llamada
    {
        public enum Franja
        { 
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franjaHoraria;
        public Provincial(Franja miFranja, Llamada llamada):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion, destino, origen))
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
            sb.Append($"Costo: {this.CostoLlamada}");
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return (float)(this.duracion * 0.99);
                case Franja.Franja_2:
                    return (float)(this.duracion * 1.25);
                case Franja.Franja_3:
                    return (float)(this.duracion * 0.66);
            }
            return 0;
        }

    }
}
/*
 Hereda de Llamada.
Método Mostrar retornará como texto todos los datos de la clase base y agregará el costo de la llamada y la franja horaria. Utilizar StringBuilder.
CalcularCosto será privado y retornará el valor de la llamada a partir de la duración y el costo de la misma. Los valores serán:
Franja_1: 0.99
Franja_2: 1.25
Franja_3: 0.66
 */
