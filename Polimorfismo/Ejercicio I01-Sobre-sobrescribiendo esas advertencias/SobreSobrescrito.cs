using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01_Sobre_sobrescribiendo_esas_advertencias
{
    internal class SobreSobrescrito : Sobrescrito
    {
        public SobreSobrescrito() : base()
        {

        }

        public override string MiPropiedad
        { 
            get 
            { 
                return miAtributo; 
            } 
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
