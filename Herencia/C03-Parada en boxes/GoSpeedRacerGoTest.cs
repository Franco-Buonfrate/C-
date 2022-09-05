using Microsoft.VisualStudio.TestTools.UnitTesting;
using C02_Go_Speed_Racer_Go;
using System.Collections.Generic;

namespace C03_Parada_en_boxes
{
    [TestClass]
    public class GoSpeedRacerGoTest
    {
        [TestMethod]
        public void PruebaLista_RecibeUnObjetoDeTipoCompetencia_RetornaLaListaInicializada()
        {
            //Arrange
            Competencia<VehiculoDeCarrera> actual;
            List<VehiculoDeCarrera> expected = new List<VehiculoDeCarrera>();

            //Act
            actual = new Competencia<VehiculoDeCarrera>(1, 3, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);

            //Assert
            Assert.AreNotEqual(null, actual.Competidores);
        }

        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void PruebaException_RecibeIntentaAgregarUnObjetoMotocrossAUnaListaAutoF1_RetornaCompetenciaNoDisponibleException()
        {
            //Arrange
            Competencia<VehiculoDeCarrera> actual = new Competencia<VehiculoDeCarrera>(1, 2, Competencia<VehiculoDeCarrera>.TipoCompetencia.F1);

            //Act
            actual += new MotoCross(15, "Red Bull");

        }

        [TestMethod]
        public void PruebaAgregaUnObjetoALaLista_RecibeIntentaAgregarUnObjetoMotocrossAUnaListaMotoCross_RetornaNoSeLanzaLaException()
        {
            //Arrange
            Competencia<MotoCross> actual = new Competencia<MotoCross>(1, 2, Competencia<MotoCross>.TipoCompetencia.MotoCross);

            //Act
            actual += new MotoCross(15, "Red Bull");
        }

        [TestMethod]
        public void PruebaAgregarunObjetoALaLista_RecibeAgregaUnObjetoALaLista_RetornaValidaQueSeHayaAgregado()
        {
            //Arrange
            Competencia<MotoCross> actual = new Competencia<MotoCross>(1, 2, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross expected = new MotoCross(15, "Red Bull");

            //Act
            actual += expected;

            //Assert
            Assert.AreEqual(expected, actual.Competidores[0]);
        }
        [TestMethod]
        public void PruebaRemuever_RecibeRemueveUnObjetoDeLaLista_RetornaValidaQueSeHayaRemovido()
        {
            //Arrange
            Competencia<MotoCross> actual = new Competencia<MotoCross>(1, 2, Competencia<MotoCross>.TipoCompetencia.MotoCross);
            MotoCross expected = new MotoCross(15, "Red Bull");

            //Act
            

            //Assert
            Assert.AreEqual(expected, actual.Competidores[0]);
        }
    }

}
