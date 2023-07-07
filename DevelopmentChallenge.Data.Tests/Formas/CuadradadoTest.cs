namespace DevelopmentChallenge.Data.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CuadradadoTest : IFormaTest
    {
        private Cuadrado _cuadrado;
        public CuadradadoTest()
        {
            _cuadrado = new Cuadrado(6);
        }

        [TestCase]
        public void TestRetornaValorSiSeCalculaElArea()
        {
            decimal valorEsperado = 36;
            decimal area = _cuadrado.CalcularArea();

            Assert.AreEqual(valorEsperado, area);
        }

        [TestCase]
        public void TestRetornaValorSiSeCalculaElPerimetro()
        {
            decimal valorEsperado = 24;
            decimal perimetro = _cuadrado.CalcularPerimetro();
            Assert.AreEqual(valorEsperado, perimetro);
        }

        [TestCase]
        public void TestAlInvocarSuKeyDevuelveNombreSingular()
        {
            string valorEsperado = "Cuadrado";
            Assert.AreEqual(valorEsperado, _cuadrado.Key.ToString());
        }

        [TestCase]
        public void TestAlInvocarSuPluralDevuelveNombrePlural()
        {
            string valorEsperado = "Cuadrados";
            Assert.AreEqual(valorEsperado, _cuadrado.Plural.ToString());
        }
    }
}
