using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02_Control_de_aduana_Library_
{
    interface IAfip
    {
        decimal Impuestos { get; }
        decimal AplicarImpuestos();
    }
}
