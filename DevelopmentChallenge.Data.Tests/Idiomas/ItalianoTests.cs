namespace DevelopmentChallenge.Data.Tests.Idiomas
{
    using NUnit.Framework;

    [TestFixture]
    public class ItalianoTests
    {
        private Italiano _italiano;
        public ItalianoTests()
        {
            _italiano = new Italiano();
        }

        [TestCase]
        public void ObtenerUnaLlaveDevuelveSuValorTraducidoAlIdiomaDeLaClase()
        {
            string valorEsperado = "Cerchio";
            string valor = _italiano.Traducir(Keys.Circulo);

            Assert.AreEqual(valorEsperado, valor);
        }
    }
}
