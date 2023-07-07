namespace DevelopmentChallenge.Data.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class TrianguloEquilateroTests : IFormaTest
    {
        private TrianguloEquilatero _triangulo;

        public TrianguloEquilateroTests()
        {
            _triangulo = new TrianguloEquilatero(20);
        }

        [TestCase]
        public void TestRetornaValorSiSeCalculaElArea()
        {
            decimal valorEsperado = ((decimal)Math.Sqrt(3) / 4) * 20 * 20;
            decimal valor = _triangulo.CalcularArea();
            Assert.AreEqual(valorEsperado, valor);
        }

        public void TestRetornaValorSiSeCalculaElPerimetro()
        {
            decimal valorEsperado = 60;
            decimal valor = _triangulo.CalcularPerimetro();
            Assert.AreEqual(valorEsperado, valor);
        }

        public void TestAlInvocarSuKeyDevuelveNombreSingular()
        {
            string valorEsperado = "Triangulo";
            Assert.AreEqual(valorEsperado, _triangulo.Key.ToString());
        }

        public void TestAlInvocarSuPluralDevuelveNombrePlural()
        {
            string valorEsperado = "Triangulos";
            Assert.AreEqual(valorEsperado, _triangulo.Key.ToString());
        }
    }
}
