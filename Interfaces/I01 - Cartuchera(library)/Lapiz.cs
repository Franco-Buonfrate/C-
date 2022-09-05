using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01___Cartuchera_library_
{
    public class Lapiz : IAcciones
    {
        public float tamanioMina;

        public Lapiz(int tamanioMina)
        {
            this.tamanioMina = tamanioMina;
        }

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }

            set
            {
                this.tamanioMina = value;
            }

        }

        public EscrituraWrapper Escribir(string texto)
        {
            ((IAcciones)this).UnidadesDeEscritura-= (float)(texto.Length * 0.1);
            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Lapiz");
            sb.AppendLine($"Color: {((IAcciones)this).Color}");
            sb.AppendLine($"Tamanio Mina: {((IAcciones)this).UnidadesDeEscritura}");
            return sb.ToString();
        }
    }
}
