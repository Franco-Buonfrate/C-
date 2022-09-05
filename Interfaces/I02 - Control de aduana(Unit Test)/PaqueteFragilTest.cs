using I02_Control_de_aduana_Library_;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace I02___Control_de_aduana_Unit_Test_
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void ImpuestosFragil_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //Arrange
            PaqueteFragil paquete = new PaqueteFragil("1", 10, "", "", 1);
            decimal expected = 10 * (decimal)0.35;

            //Act
            decimal actual = paquete.Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TienePRioridad_DeberiaRetornarTrue()
        {
            //Arrange 
            PaqueteFragil paquete = new PaqueteFragil("1", 1, "", "", 1);
            bool expected = true;

            //Act
            bool actual = paquete.TienePrioridad; 

            //Assert
            Assert.AreEqual(expected, actual);

        }

        
    }
}
