using I02_Control_de_aduana_Library_;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace I02___Control_de_aduana_Unit_Test_
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void ImpuestosPesado_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //Arrange
            PaquetePesado paquete = new PaquetePesado("1", 10, "", "", 1);
            decimal expected = 10 * (decimal)0.35;

            //Act
            decimal actual = paquete.Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //Arrange 
            PaquetePesado paqueteFragil;
            bool expected = false;

            //Act
            paqueteFragil = new PaquetePesado("1", 1, "", "", 1);

            //Assert
            Assert.AreEqual(expected, paqueteFragil.TienePrioridad);

        }
    }
}
