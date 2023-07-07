namespace DevelopmentChallenge.Data.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class RectanguloTest : IFormaTest
    {
        private Rectangulo _rectangulo;
        public RectanguloTest()
        {
            _rectangulo = new Rectangulo(20,10);
        }

        [TestCase]
        public void TestRetornaValorSiSeCalculaElArea()
        {
            decimal valorEsperado = 200;
            decimal area = _rectangulo.CalcularArea();

            Assert.AreEqual(valorEsperado, area);
        }

        [TestCase]
        public void TestRetornaValorSiSeCalculaElPerimetro()
        {
            decimal valorEsperado = 60;
            decimal perimetro = _rectangulo.CalcularPerimetro();
            Assert.AreEqual(valorEsperado, perimetro);
        }

        [TestCase]
        public void TestAlInvocarSuKeyDevuelveNombreSingular()
        {
            string valorEsperado = "Rectangulo";
            Assert.AreEqual(valorEsperado, _rectangulo.Key.ToString());
        }

        [TestCase]
        public void TestAlInvocarSuPluralDevuelveNombrePlural()
        {
            string valorEsperado = "Rectangulos";
            Assert.AreEqual(valorEsperado, _rectangulo.Plural.ToString());
        }
    }
}
