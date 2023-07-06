namespace DevelopmentChallenge.Data.Tests.Formas
{
    using NUnit.Framework;

    [TestFixture]
    public class CuadradadoTest
    {
        private Cuadrado _cuadrado;
        public CuadradadoTest()
        {
            _cuadrado = new Cuadrado(6);
        }

        [TestCase]
        public void TestRetornaCuatroSiSeCalculaElArea()
        {
            decimal valorEsperado = 36;
            decimal area = _cuadrado.CalcularArea();

            Assert.AreEqual(valorEsperado, area);
        }

        [TestCase]
        public void TestRetornaVeintiCuatroSiSeCalculaElPerimetro()
        {
            decimal valorEsperado = 24;
            decimal perimetro = _cuadrado.CalcularPerimetro();
            Assert.AreEqual(valorEsperado, perimetro);
        }

        [TestCase]
        public void TestAlInvocarSuKeyDevuelveCuadrado()
        {
            string valorEsperado = "Cuadrado";
            Assert.AreEqual(valorEsperado, _cuadrado.Key.ToString());
        }
    }
}
