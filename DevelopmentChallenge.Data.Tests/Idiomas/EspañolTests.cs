namespace DevelopmentChallenge.Data.Tests.Idiomas
{
    using NUnit.Framework;

    [TestFixture]
    public class EspañolTests : IIdomaTests
    {
        private Español _español;
        public EspañolTests()
        {
            _español = new Español();
        }

        [TestCase]
        public void ObtenerUnaLlaveDevuelveSuValorTraducidoAlIdiomaDeLaClase()
        {
            string valorEsperado = "Circulo";
            string valor = _español.Traducir(Keys.Circulo);

            Assert.AreEqual(valorEsperado, valor);
        }
    }
}
