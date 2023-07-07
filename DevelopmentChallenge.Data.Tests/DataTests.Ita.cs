namespace DevelopmentChallenge.Data.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;


    [TestFixture]
    public class DataTestsIta : TestBase, IDataTests
    {
        private Idioma _idioma;
        private FormasGeometricasService _service;
       
        public DataTestsIta()
        {
            _idioma = new Italiano();
            _service = new FormasGeometricasService(_idioma, _messageService);
        }


        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Elenco vuoto di moduli!</h1>",
                _service.Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = _service.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Rapporto sui moduli</h1> 1 Piazza | La zona 25 | Perimetro 20 <br/>TOTAL:<br/>1 Forme Perimetro 20 La zona 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = _service.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Rapporto sui moduli</h1> 3 Piazze | La zona 35 | Perimetro 36 <br/>TOTAL:<br/>3 Forme Perimetro 36 La zona 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
           {
               new Cuadrado(5),
               new Circulo(3),
               new TrianguloEquilatero(4),
               new Cuadrado(2),
               new TrianguloEquilatero(9),
               new Rectangulo(30,15),
               new Rectangulo(20,5)
           };

            var resumen = _service.Imprimir(formas);

            Assert.AreEqual(
                "<h1>Rapporto sui moduli</h1> 2 Piazze | La zona 29 | Perimetro 28 <br/>1 Cerchio | La zona 7,07 | Perimetro 9,42 <br/>2 Triangoli | La zona 42 | Perimetro 39 <br/>2 Rettangoli | La zona 550 | Perimetro 140 <br/>TOTAL:<br/>7 Forme Perimetro 216,42 La zona 628,07",
                resumen);
        }
    }
}

