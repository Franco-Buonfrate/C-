using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Puesto_de_atencion
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return clientes.Peek();
            }
            set
            {
                if (!clientes.Contains(value))
                {
                    clientes.Enqueue(value);
                }
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno;
            if (!(n.clientes.Contains(c)))
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            return n.clientes.Contains(c);
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !n.clientes.Contains(c);
        }
        public static bool operator ~(Negocio n)
        {
            if (n.caja.Atender(n.Cliente))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
