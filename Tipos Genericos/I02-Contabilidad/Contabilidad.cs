using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I02_Contabilidad
{
    public class Contabilidad<T, U> 
        where T:Documento 
        where U:Documento
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T,U> cont, T egreso)
        {
            cont.egresos.Add(egreso);
            return cont;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T,U> cont, U ingreso)
        {
            cont.ingresos.Add(ingreso);
            return cont;
        }

    }
}
