using System;
using System.Text;

namespace I01___Cartuchera_library_
{
    public class Boligrafo:IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor colorTinta)
        {
            this.tinta = unidades;
            this.colorTinta = colorTinta;
        }

        public ConsoleColor Color 
        { 
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }
        public float UnidadesDeEscritura 
        { 
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }

        }

        public EscrituraWrapper Escribir(string texto)
        {
            int lenght_texto = texto.Length;
            this.tinta -= (float)(texto.Length * 0.3);
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Tipo: Boligrafo");
            sb.AppendLine($"Color: {this.colorTinta.ToString()}");
            sb.AppendLine($"Unidades de tinta: {this.UnidadesDeEscritura}");
            return sb.ToString();
        }
    }
}
