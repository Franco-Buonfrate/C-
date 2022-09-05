using System;

namespace C02_Enciendan_sus_motores
{
    public class VehiculoDeCarreras
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarreras(short numero, string escuderia)
        {
            Numero = numero;
            Escuderia = escuderia;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public string Escuderia { get => escuderia; set => escuderia = value; }
        public short Numero { get => numero; set => numero = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public string MostrarDatos()
        {
            return $"Numero: {Numero}\nEscuderia: {Escuderia}";
        }

        public static bool operator ==(VehiculoDeCarreras v1, VehiculoDeCarreras v2)
        {
            return (v1.numero == v2.numero) && (v1.escuderia == v2.escuderia);
        }
        public static bool operator !=(VehiculoDeCarreras v1, VehiculoDeCarreras v2)
        {
            return !(v1 == v2);
        }
    }
}
