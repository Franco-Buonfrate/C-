using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___La_centralita_Episodio_II
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        private Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local)
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTodas
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia total: {this.GananciasPorTodas}");
            sb.AppendLine($"Ganancia Local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciasPorProvincial}");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.AppendLine(llamada.ToString());
            }
            return sb.ToString();

        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia=0;
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            ganancia += llamada.CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            ganancia += llamada.CostoLlamada;
                        }
                        break;
                    default:
                        ganancia += llamada.CostoLlamada;
                        break;
                }
            }
            return ganancia;

        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {

           this.listaDeLlamadas.Add(nuevaLlamada);
            
        }
        public static bool operator ==(Centralita c, Llamada l)
        {
            foreach (Llamada llamada in c.listaDeLlamadas)
            {
                if (llamada == l)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }
        public static Centralita operator +(Centralita cen, Llamada llamada)
        {
            if (cen != llamada)
            {
                cen.AgregarLlamada(llamada);
            }
            return cen;
        }
    }
}
/*
 * El método Mostrar pasará a ser privado y será llamado por la sobrescritura del método ToString.
El método AgregarLlamada es privado. Recibe una instancia de Llamada y la agrega a la lista de llamadas.
El operador == retornará true si la centralita contiene la llamada en su lista genérica. Utilizar la sobrecarga del operador == de la clase Llamada.
El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la Centralita. Utilizar la sobrecarga del operador == de Centralita.
 */
