namespace DevelopmentChallenge.Data.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class TrapecioTests : IFormaTest
    {
        private Trapecio _trapecio;

        public TrapecioTests()
        {
            _trapecio = new Trapecio(30, 15, 10, 20, 30);
        }
 
        [TestCase]
        public void TestRetornaValorSiSeCalculaElArea()
        {
            decimal valorEsperado = 6750;
            decimal valor = _trapecio.CalcularArea();

            Assert.AreEqual(valorEsperado, valor);
        }

        [TestCase]
        public void TestRetornaValorSiSeCalculaElPerimetro()
        {
            decimal valorEsperado = 75;
            decimal valor = _trapecio.CalcularPerimetro();

            Assert.AreEqual(valorEsperado, valor);
        }

        [TestCase]
        public void TestAlInvocarSuKeyDevuelveNombreSingular()
        {
            string valorEsperado = "Trapecio";
            Assert.AreEqual(valorEsperado, _trapecio.Key.ToString());
        }

        [TestCase]
        public void TestAlInvocarSuPluralDevuelveNombrePlural()
        {
            string valorEsperado = "Trapecios";
            Assert.AreEqual(valorEsperado, _trapecio.Plural.ToString());
        }
    }
}
