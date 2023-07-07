namespace DevelopmentChallenge.Data.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;


    [TestFixture]
    public class DataTestsIta : TestBase, IDataTests
    {
        private Idioma idioma;
        private FormasGeometricasService service;
       
        public DataTestsIta()
        {
            idioma = new Italiano();
            service = new FormasGeometricasService(idioma, _messageService);
        }


        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Elenco vuoto di moduli!</h1>",
                service.Imprimir(new List<FormaGeometrica>()));
        }

        public void TestResumenListaConMasCuadrados()
        {
            throw new System.NotImplementedException();
        }

        public void TestResumenListaConMasTipos()
        {
            throw new System.NotImplementedException();
        }

        public void TestResumenListaConUnCuadrado()
        {
            throw new System.NotImplementedException();
        }
    }
}
