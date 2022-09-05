using Microsoft.VisualStudio.TestTools.UnitTesting;
using I02_Contar_digitos;

namespace I02_Contar_digitos__pruebas_
{
    [TestClass]
    public class IntExtensionTest
    {

        [TestMethod]
        public void ContarCantidadDeDigitos_CuandorRecibeUno_DeberiaRetornarUno()
        {
            //Arrange
            long numero = 1;
            int expected = 1;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContarCantidadDeDigitos_CuandorRecibeCien_DeberiaRetornarTres()
        {
            //Arrange
            long numero = 100;
            int expected = 3;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ContarCantidadDeDigitos_CuandorRecibeDiezNegativo_DeberiaRetornarDos()
        {
            //Arrange
            long numero = -10;
            int expected = 2;

            //Act
            int actual = numero.ContarCantidadDeDigitos();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
