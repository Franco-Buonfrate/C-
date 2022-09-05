using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01_Sobre_sobrescribiendo_esas_advertencias
{
    abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstracto";
        }

        public abstract string  MiPropiedad { get; }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "Este es mi metodo To string sobrescrito";
        }


        public override bool Equals(object obj)
        {
            return obj.GetType()==typeof(Sobrescrito);
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }


    }
}
