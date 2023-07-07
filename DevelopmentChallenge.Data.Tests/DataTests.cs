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
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5), new Circulo(5)};

            var resumen = _service.Imprimir(cuadrados);
            
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            //var cuadrados = new List<FormaGeometrica>
            //{
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 1),
            //    new FormaGeometrica(FormaGeometrica.Cuadrado, 3)
            //};
            //
            //var resumen = FormaGeometrica.Imprimir(cuadrados, FormaGeometrica.Ingles);
            //
            //Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
           // var formas = new List<FormaGeometrica>
           // {
           //     new FormaGeometrica(FormaGeometrica.Cuadrado, 5),
           //     new FormaGeometrica(FormaGeometrica.Circulo, 3),
           //     new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4),
           //     new FormaGeometrica(FormaGeometrica.Cuadrado, 2),
           //     new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 9),
           //     new FormaGeometrica(FormaGeometrica.Circulo, 2.75m),
           //     new FormaGeometrica(FormaGeometrica.TrianguloEquilatero, 4.2m)
           // };
           //
           // var resumen = FormaGeometrica.Imprimir(formas, FormaGeometrica.Ingles);
           //
           // Assert.AreEqual(
           //     "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
           //     resumen);
        }
    }
}
