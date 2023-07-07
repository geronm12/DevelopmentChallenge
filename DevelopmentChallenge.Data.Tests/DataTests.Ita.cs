namespace DevelopmentChallenge.Data.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;


    [TestFixture]
    public class DataTestsEng : TestBase, IDataTests
    {
        private Idioma idioma;
        private FormasGeometricasService service;
       
        public DataTestsEng()
        {
            idioma = new Ingles();
            service = new FormasGeometricasService(idioma, _messageService);
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
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
