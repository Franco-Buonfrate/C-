using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace I01_Puesto_de_atencion
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        }

        static int numeroActual;
        Puesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            if (cli is not null && cli.Numero >= 0)
            {
                Thread.Sleep(3000);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
