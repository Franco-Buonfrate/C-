using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02_Enciendan_sus_motores
{
    public enum TipoCompetencia
    {
        F1,
        MotoCross
    }

    class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<VehiculoDeCarreras> competidores;
        TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarreras>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarreras v)
        {
            if (c.tipo == TipoCompetencia.F1 && v is AutoF1)
            {
                return true;
            }
            else if (c.tipo == TipoCompetencia.MotoCross && v is MotoCross)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarreras v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarreras v)
        {
            if (c==v)
            {
                c.competidores.Add(v);
                return true;
            }

            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarreras v)
        {
            if (c==v && c.competidores.Contains(v))
            {
                c.competidores.Remove(v);
                return true;
            }
            return false;
        }



    }
}
