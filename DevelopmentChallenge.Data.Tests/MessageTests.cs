namespace DevelopmentChallenge.Data.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class MessageTests : TestBase
    {
        private Idioma _idiomaEspañol;
        private Idioma _idiomaIngles;
        private Idioma _idiomaItaliano;
        public MessageTests()
        {
            _idiomaEspañol = new Español();
            _idiomaIngles = new Ingles();
            _idiomaItaliano = new Italiano();
        }

        private string ObtenerMensaje(Idioma idioma)
        {
            return _messageService.ObtenerLinea(3, 108, 72, idioma, Keys.Cuadrado, Keys.Cuadrados);
        }

        private string TraducirFormaSingular(Idioma idioma, Keys key, Keys plural)
        {
            return _messageService.TraducirForma(1, idioma, key, plural);
        }

        private string TraducirFormaPlural(Idioma idioma, Keys key, Keys plural)
        {
            return _messageService.TraducirForma(2, idioma, key, plural);
        }

        #region  Español
        [TestCase]
        public void TestObtenerLineaRetornaMensajeEnEspañol()
        {
            string mensajeRespuesta = 
                $"3 Cuadrados | Area 108 | Perimetro 72 <br/>";

            var mensaje = ObtenerMensaje(_idiomaEspañol);

            Assert.AreEqual(mensajeRespuesta, mensaje);
        }

        [TestCase]
        public void TestTraducirFormaRetornaMensajeFormaEnEspañolSingular()
        {
            string mensajeRespuesta = "Cuadrado";

            var mensaje = TraducirFormaSingular(_idiomaEspañol, Keys.Cuadrado, Keys.Cuadrados);

            Assert.AreEqual(mensajeRespuesta, mensaje);
        }

        [TestCase]
        public void TestTraducirFormaRetornaMensajeFormaEnEspañolPlural()
        {
            string mensajeRespuesta = "Cuadrados";

            var mensaje = TraducirFormaPlural(_idiomaEspañol, Keys.Cuadrado, Keys.Cuadrados);

            Assert.AreEqual(mensajeRespuesta, mensaje);
        }

        #endregion

        #region Ingles
        [TestCase]
        public void TestObtenerLineaRetornaMensajeEnIngles()
        {
            string mensajeRespuesta = 
                $"3 Squares | Area 108 | Perimeter 72 <br/>";

            var mensaje = ObtenerMensaje(_idiomaIngles);

            Assert.AreEqual(mensajeRespuesta, mensaje);
        }

        [TestCase]
        public void TestTraducirFormaRetornaMensajeFormaEnIngleslSingular()
        {
            string mensajeRespuesta = "Square";

            var mensaje = TraducirFormaSingular(_idiomaIngles, Keys.Cuadrado, Keys.Cuadrados);

            Assert.AreEqual(mensajeRespuesta, mensaje);
        }

        [TestCase]
        public void TestTraducirFormaRetornaMensajeFormaEnInglesPlural()
        {
            string mensajeRespuesta = "Squares";

            var mensaje = TraducirFormaPlural(_idiomaIngles, Keys.Cuadrado, Keys.Cuadrados);

            Assert.AreEqual(mensajeRespuesta, mensaje);
        }
        #endregion

        #region Italiano
        [TestCase]
        public void TestObtenerLineaRetornaMensajeEnItaliano()
        {
            string mensajeRespuesta = 
                $"3 Piazze | La zona 108 | Perimetro 72 <br/>";


            var mensaje = ObtenerMensaje(_idiomaItaliano);

            Assert.AreEqual(mensajeRespuesta, mensaje);
        }

        [TestCase]
        public void TestTraducirFormaRetornaMensajeFormaEnItalianolSingular()
        {
            string mensajeRespuesta = "Piazza";

            var mensaje = TraducirFormaSingular(_idiomaItaliano, Keys.Cuadrado, Keys.Cuadrados);

            Assert.AreEqual(mensajeRespuesta, mensaje);
        }

        [TestCase]
        public void TestTraducirFormaRetornaMensajeFormaEnItalianoPlural()
        {
            string mensajeRespuesta = "Piazze";

            var mensaje = TraducirFormaPlural(_idiomaItaliano, Keys.Cuadrado, Keys.Cuadrados);

            Assert.AreEqual(mensajeRespuesta, mensaje);
        }
        #endregion 
    }
}
