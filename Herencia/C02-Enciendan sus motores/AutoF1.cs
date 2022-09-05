using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Enciendan_sus_motores
{
    public class AutoF1 : VehiculoDeCarreras
    {
        short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) :
            this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza { get => caballosDeFuerza; set => caballosDeFuerza = value; }

        public string MostrarDatos()
        {
            return $"{base.MostrarDatos()}\nCaballos de Fuerza: {CaballosDeFuerza}";
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((VehiculoDeCarreras)a1==(VehiculoDeCarreras)a2) && (a1.caballosDeFuerza == a2.caballosDeFuerza);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
