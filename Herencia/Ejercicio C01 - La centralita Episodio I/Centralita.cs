using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___La_centralita_Episodio_I
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        private Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
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
        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public float GananciaLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciaProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float recaudado=0;
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            recaudado += ((Local)llamada).CostoLlamada;
                        }
                         break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            recaudado += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    default:
                        if (llamada is Local)
                        {
                            recaudado += ((Local)llamada).CostoLlamada;
                        }
                        if (llamada is Provincial)
                        {
                            recaudado += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                }
            }
            return recaudado;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {this.GananciaTotal}");
            sb.AppendLine($"Ganancia Local: {this.GananciaLocal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciaProvincial}");
            sb.AppendLine("-----------------------");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.AppendLine(llamada.Mostrar());
                sb.AppendLine("-----------------------");
            }
            return sb.ToString();

        }
        public void OrdenarLlamadas()
        {
            
        }
    }
}
/*
 CalcularGanancia será privado. Este método recibe un enumerado TipoLlamada y retornará el valor de lo recaudado, según el criterio elegido (ganancias por las llamadas del tipo Local, Provincial o de Todas según corresponda).
El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales y provinciales y el detalle de las llamadas realizadas.
La lista sólo se inicializará en el constructor por defecto Centralita.
Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el precio de lo facturado según el criterio (llamada local, provincial o todas). Dichos valores se calcularán en el método CalcularGanancia.
 */
