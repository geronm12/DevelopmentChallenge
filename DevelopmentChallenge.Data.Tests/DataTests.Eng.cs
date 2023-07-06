﻿namespace DevelopmentChallenge.Data.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;


    [TestFixture]
    public class DataTestsIta : TestBase
    {
        private Idioma idioma;
        private FormasGeometricasService service;
       
        public DataTestsIta()
        {
            idioma = new Italiano();
            service = new FormasGeometricasService(idioma, _messageService);
        }
       
 
        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                service.Imprimir(new List<FormaGeometrica>()));
        }
    }
}