using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Go_Speed_Racer_Go
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : this(mensaje,clase,metodo,null)
        {

        }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }
        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Exception actual = this;
            sb.AppendFormat($"Exepcion en el metodo {0} de la clase {1}",this.nombreMetodo, this.nombreClase);
            sb.AppendLine(this.Message);
            while (actual.InnerException is not null)
            {
                sb.Append(actual.InnerException + "\t");
                actual = actual.InnerException;
            }
            return sb.ToString();
        }


    }
}
