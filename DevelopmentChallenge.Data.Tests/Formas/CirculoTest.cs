namespace DevelopmentChallenge.Data.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CirculoTest : IFormaTest
    {
        private Circulo _circulo;
        public CirculoTest()
        {
            _circulo = new Circulo(10);
        }

        [TestCase]
        public void TestRetornaValorSiSeCalculaElArea()
        {
            decimal valorEsperado = (decimal)Math.PI * 5 * 5;
            decimal area = _circulo.CalcularArea();

            Assert.AreEqual(valorEsperado, area);
        }

        [TestCase]
        public void TestRetornaValorSiSeCalculaElPerimetro()
        {
            decimal valorEsperado = (decimal)Math.PI * 10;
            decimal perimetro = _circulo.CalcularPerimetro();
            Assert.AreEqual(valorEsperado, perimetro);
        }

        [TestCase]
        public void TestAlInvocarSuKeyDevuelveNombreSingular()
        {
            string valorEsperado = "Circulo";
            Assert.AreEqual(valorEsperado, _circulo.Key.ToString());
        }

        [TestCase]
        public void TestAlInvocarSuPluralDevuelveNombrePlural()
        {
            string valorEsperado = "Circulos";
            Assert.AreEqual(valorEsperado, _circulo.Plural.ToString());
        }
    }
}
