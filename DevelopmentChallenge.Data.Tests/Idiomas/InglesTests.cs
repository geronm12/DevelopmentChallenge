namespace DevelopmentChallenge.Data.Tests.Idiomas
{
    using NUnit.Framework;

    [TestFixture]
    public class InglesTests
    {
        private Ingles _ingles;
        public InglesTests()
        {
            _ingles = new Ingles();
        }

        [TestCase]
        public void ObtenerUnaLlaveDevuelveSuValorTraducidoAlIdiomaDeLaClase()
        {
            string valorEsperado = "Circle";
            string valor = _ingles.Traducir(Keys.Circulo);

            Assert.AreEqual(valorEsperado, valor);
        }
    }
}
