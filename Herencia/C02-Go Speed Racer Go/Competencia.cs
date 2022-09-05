using System;
using System.Collections.Generic;
using System.Text;

namespace C02_Go_Speed_Racer_Go
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        private short cantidadDeCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<T>();
        }
        public Competencia(short cantVueltas, short cantCompetidores, TipoCompetencia tipo):this()
        {
            this.cantidadDeCompetidores = cantCompetidores;
            this.cantidadVueltas = cantVueltas;
            this.tipo = tipo;
        }

        public List<T> Competidores
        {
            get
            {
                return this.competidores;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo de Competencia: {this.tipo}");
            sb.AppendLine($"Cantidad de Competidores: {this.cantidadDeCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            sb.AppendLine("----------------------------------------------------------");
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                sb.AppendLine(vehiculo.MostrarDatos());
                sb.AppendLine("----------------------------------------------------------");
            }
            return sb.ToString();
        }

        public static Competencia<T> operator +(Competencia<T> competencia, T vehiculo)
        {
            try
            {
                if (competencia == vehiculo && competencia.cantidadDeCompetidores > competencia.competidores.Count)
                {
                    foreach (VehiculoDeCarrera v in competencia.competidores)
                    {
                        if (v == vehiculo)
                        {
                            return competencia;
                        }
                    }

                    vehiculo.EnCompetencia = true;
                    vehiculo.VueltasRestantes = competencia.cantidadVueltas;
                    Random random = new Random();
                    vehiculo.CantidadCombustibe = (short)random.Next(15, 101);
                    competencia.competidores.Add(vehiculo);
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Sobrecarga del operador +", ex);
            }
            return competencia;
        }

        public static bool operator ==(Competencia<T> competencia, VehiculoDeCarrera vehiculo)
        {
            if ((competencia.tipo == TipoCompetencia.F1 && vehiculo is AutoF1) || (competencia.tipo == TipoCompetencia.MotoCross && vehiculo is MotoCross))
            {
                return true;
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Sobrecarga del operador ==");
            }
        }
        public static bool operator !=(Competencia<T> competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }

    }
}
