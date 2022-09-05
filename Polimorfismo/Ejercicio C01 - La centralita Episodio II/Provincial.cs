using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___La_centralita_Episodio_II
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

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja horaria: {this.franjaHoraria.ToString()}");
            sb.AppendLine($"Costo: {this.CostoLlamada}");

            return sb.ToString();
        }
        
        public float CalcularCosto()
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
            return this.duracion;
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
/*
 * El método Mostrar será protegido. Reutilizará el código escrito en la clase base y agregará los datos de franjaHoraria y CostoLlamada al texto de retorno. Utilizar StringBuilder.
El método Equals retornará true sólo si el objeto que recibe es de tipo Provincial.
El método ToString reutilizará el código del método Mostrar.
 */
