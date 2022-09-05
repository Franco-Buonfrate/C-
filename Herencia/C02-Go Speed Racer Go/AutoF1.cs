using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Go_Speed_Racer_Go
{
    public class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {

        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }
         
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}");
            return sb.ToString();
        }
        public static bool operator ==(AutoF1 a, AutoF1 b)
        {
            return (VehiculoDeCarrera)a == b && a.caballosDeFuerza == b.caballosDeFuerza;
        }
        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a == b);
        }

    }
}
