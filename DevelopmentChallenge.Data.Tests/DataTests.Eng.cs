namespace DevelopmentChallenge.Data.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;


    [TestFixture]
    public class DataTestsEng : TestBase, IDataTests
    {
        private Idioma _idioma;
        private FormasGeometricasService _service;
       
        public DataTestsEng()
        {
            _idioma = new Ingles();
            _service = new FormasGeometricasService(_idioma, _messageService);
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                _service.Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };

            var resumen = _service.Imprimir(cuadrados);

            Assert.AreEqual("<h1>Shapes report</h1> 1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 Shapes Perimeter 20 Area 25", resumen);
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

            Assert.AreEqual("<h1>Shapes report</h1> 3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
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
                "<h1>Shapes report</h1> 2 Squares | Area 29 | Perimeter 28 <br/>1 Circle | Area 7,07 | Perimeter 9,42 <br/>2 Triangles | Area 42 | Perimeter 39 <br/>2 Rectangles | Area 550 | Perimeter 140 <br/>TOTAL:<br/>7 Shapes Perimeter 216,42 Area 628,07",
                resumen);
        }
    }
}

