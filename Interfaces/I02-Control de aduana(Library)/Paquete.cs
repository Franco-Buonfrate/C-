using System;
using System.Text;

namespace I02_Control_de_aduana_Library_
{
    public abstract class Paquete:IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

        public abstract bool TienePrioridad { get; }

        public decimal Impuestos
        {
            get
            {
                return (decimal)((double)this.costoEnvio * 0.35);
            }
        }

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: {this.costoEnvio}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Peso: {this.pesoKg}");
            sb.AppendLine($"{(this.TienePrioridad ? "Tiene prioridad." : "No tiene prioridad")}");

            return sb.ToString();
        }

        public virtual decimal AplicarImpuestos()
        {
            throw new NotImplementedException();
        }
    }
}
