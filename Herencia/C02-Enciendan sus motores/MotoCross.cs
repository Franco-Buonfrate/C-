using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Enciendan_sus_motores
{
    public class MotoCross : VehiculoDeCarreras
    {
        short cilindrada;

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        { }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        public string MostrarDatos()
        {
            return $"{base.MostrarDatos()}\nCilindrada: {Cilindrada}";
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return ((VehiculoDeCarreras)m1 == (VehiculoDeCarreras)m2) && m1.Cilindrada == m2.Cilindrada;
        }
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }



    }
}
