namespace DevelopmentChallenge.Data.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;


    [TestFixture]
    public class DataTests : TestBase, IDataTests
    {
        private Idioma _idioma;
        private IFormasGeometricasService _service;
        public DataTests()
        {
            _idioma = new Español();
            _service = new FormasGeometricasService(_idioma, _messageService);
        }
        
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                _service.Imprimir(new List<FormaGeometrica>()));
        }


        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5)};

            var resumen = _service.Imprimir(cuadrados);
            
            Assert.AreEqual("<h1>Reporte de Formas</h1> 1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 Formas Perimetro 20 Area 25", resumen);
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
            
            Assert.AreEqual("<h1>Reporte de Formas</h1> 3 Cuadrados | Area 35 | Perimetro 36 <br/>TOTAL:<br/>3 Formas Perimetro 36 Area 35", resumen);
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
               "<h1>Reporte de Formas</h1> 2 Cuadrados | Area 29 | Perimetro 28 <br/>1 Circulo | Area 7,07 | Perimetro 9,42 <br/>2 Triangulos | Area 42 | Perimetro 39 <br/>2 Rectangulos | Area 550 | Perimetro 140 <br/>TOTAL:<br/>7 Formas Perimetro 216,42 Area 628,07",
               resumen);
        }
    }
}
