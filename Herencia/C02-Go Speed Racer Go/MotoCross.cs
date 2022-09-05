using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Go_Speed_Racer_Go
{
    public class MotoCross:VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }
        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            return sb.ToString();
        }

        public static bool operator ==(MotoCross a, MotoCross b)
        {
            return (VehiculoDeCarrera)a == b && a.cilindrada == b.cilindrada;
        }
        public static bool operator !=(MotoCross a, MotoCross b)
        {
            return !(a == b);
        }

    }
}
