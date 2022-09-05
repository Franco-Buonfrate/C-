using Microsoft.VisualStudio.TestTools.UnitTesting;
using I01_Test_Driven_Development;
using System;

namespace I01_Test_Driven_Development_pruebas_
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Add_RecibeUnNumero_RetornaElValorDelMismo()
        {
            //Arrange
            string numerosString = "15";
            int expected = 15;

            //Act
            int actual = Calculadora.Add(numerosString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_RecibeDosNumerosSeparadosPorUnaComa_RetornaLaSumaDeLosNumeros()
        {
            //Arrange
            string numerosString = "1,5";
            int expected = 6;

            //Act
            int actual = Calculadora.Add(numerosString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_RecibeStringVacio_RetornaCero()
        {
            //Arrange
            string numerosString = "";
            int expected = 0;

            //Act
            int actual = Calculadora.Add(numerosString);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_RecibeMasDeDosNumeros_RetornaLaSuma()
        {
            //Arrange
            string numerosString = "1,2,3,4";
            int expected = 10;

            //Act
            int actual = Calculadora.Add(numerosString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_RecibeNumerosSepardosPorSaltosDeLinea_RetornaLaSuma()
        {
            //Arrange
            string numerosString = "1\n2\n3,4";
            int expected = 10;

            //Act
            int actual = Calculadora.Add(numerosString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_RecibeNuevoDelimitador_RetornaLaSuma()
        {
            //Arrange
            string numerosString = "//;1\n2\n3;4";
            int expected = 10;

            //Act
            int actual = Calculadora.Add(numerosString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Add_RecibeNumeroNegativo_RetornaException()
        {
            //Arrange
            string numerosString = "//;1\n2\n-3;-4";
            Exception expected = new Exception("No se permiten numeros negativos");

            //Act
            int actual = Calculadora.Add(numerosString);

            
        }
    }
}
//Arrange
//long numero = 100;
//int expected = 3;

//Act
//int actual = numero.ContarCantidadDeDigitos();

//Assert
//Assert.AreEqual(expected, actual);
