using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02_Contabilidad
{
    class Recibo:Documento
    {
        public Recibo() : base(0)
        {

        }
        public Recibo(int numero) : base(numero)
        {

        }
    }
}
