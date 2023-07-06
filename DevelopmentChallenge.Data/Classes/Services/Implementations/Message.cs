namespace DevelopmentChallenge.Data
{
    using System;
    public class Message : IMessage
    {
        public string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Idioma idioma, Keys key)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {idioma.Traducir(key)} |{idioma.Traducir(Keys.Area)} {area:#.##} | {idioma.Traducir(Keys.Perimetro)} {perimetro:#.##} <br/>";
            }

            return String.Empty;
        }

        public string TraducirForma(int cantidad, Idioma idioma, Keys key)
        {
            return cantidad > 1
                ? String.Concat(idioma.Traducir(key), Labels.Pluralizar)
                : idioma.Traducir(key);
        }
    }
}
