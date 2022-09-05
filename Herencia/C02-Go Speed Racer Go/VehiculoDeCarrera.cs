using System;
using System.Text;

namespace C02_Go_Speed_Racer_Go
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustibe;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        private VehiculoDeCarrera(short cantidadDeCombustible, bool enCompetencia, short vueltasRestantes)
        {
            this.cantidadCombustibe = cantidadDeCombustible;
            this.enCompetencia = enCompetencia;
            this.vueltasRestantes = vueltasRestantes;
        }
        public VehiculoDeCarrera(short numero, string escuderia):this(0,false,0)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public short CantidadCombustibe { get => cantidadCombustibe; set => cantidadCombustibe = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public string Escuderia { get => escuderia; set => escuderia = value; }
        public short Numero { get => numero; set => numero = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"En competencia: {(this.enCompetencia ? "Si":"No")}");
            if (enCompetencia)
            {
                sb.AppendLine($"Vueltas Restantes: {this.vueltasRestantes}");
                sb.AppendLine($"Cantidad de combustible: {this.cantidadCombustibe}");
            }
            return sb.ToString();
        }
        public static bool operator ==(VehiculoDeCarrera a, VehiculoDeCarrera b)
        {
            return a.escuderia == b.escuderia && a.numero == b.numero;
        }
        public static bool operator !=(VehiculoDeCarrera a, VehiculoDeCarrera b)
        {
            return !(a == b);
        }

    }
}
