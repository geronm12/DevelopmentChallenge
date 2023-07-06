namespace DevelopmentChallenge.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FormasGeometricasService : IFormasGeometricasService
    {
        private readonly Idioma _idioma;

        private readonly IMessage _messageService;

        public FormasGeometricasService(Idioma idioma, IMessage messageService)
        {
            this._idioma = idioma;
            this._messageService = messageService;
        }

        public string Imprimir(List<FormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(String.Format(HtmlTagsHelper.H1, this._idioma.Traducir(Keys.ListaVacia)));
                return sb.ToString();
            }

            // Hay por lo menos una forma
            // HEADER
            sb.Append(this._idioma.Traducir(Keys.Encabezado));

            int numeroItems = 0;
            decimal perimetroTotal = 0;
            decimal areaTotal = 0;

            foreach (var item in formas.GroupBy(forma => forma.GetType()))
            {
                var primerItem = item.First();
                int cantidad = item.Count();
                decimal perimetro = item.Sum(forma => forma.CalcularPerimetro());
                decimal area = item.Sum(forma => forma.CalcularArea());

                numeroItems += cantidad;
                perimetroTotal += perimetro;
                areaTotal += area;

                sb.Append(_messageService.ObtenerLinea(
                           item.Count(),
                           item.Sum(forma => forma.CalcularArea()),
                           item.Sum(forma => forma.CalcularPerimetro()),
                           _idioma,
                           primerItem.Key));
            }

            //FOOTER
            sb.Append("TOTAL:<br/>");
            sb.Append(numeroItems + " " + _idioma.Traducir(Keys.Formas) + " ");
            sb.Append(_idioma.Traducir(Keys.Perimetro) + perimetroTotal.ToString("#.##") + " ");
            sb.Append(_idioma.Traducir(Keys.Area) + areaTotal.ToString("#.##"));

            return sb.ToString();
        }
    }

}
