using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02_Control_de_aduana_Library_
{
    public class PaquetePesado : Paquete
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg) : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }

        public override bool TienePrioridad
        {
            get
            {
                return false;
            }
        }

        public override decimal AplicarImpuestos()
        {
            return this.costoEnvio += this.Impuestos;
        }
    }
}
