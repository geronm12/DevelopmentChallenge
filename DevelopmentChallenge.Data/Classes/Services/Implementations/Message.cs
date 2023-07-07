namespace DevelopmentChallenge.Data
{
    using System;
    public class Message : IMessage
    {
        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Idioma idioma, Keys key, Keys plural)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(cantidad, idioma, key, plural)} | {idioma.Traducir(Keys.Area)} {area:#.##} | {idioma.Traducir(Keys.Perimetro)} {perimetro:#.##} <br/>";
            }

            return String.Empty;
        }

        public string TraducirForma(int cantidad, Idioma idioma, Keys key, Keys plural)
        {
            return cantidad == 1 ? idioma.Traducir(key) : idioma.Traducir(plural);
        }
    }
}
