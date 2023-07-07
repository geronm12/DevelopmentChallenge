namespace DevelopmentChallenge.Data
{
    public interface IMessage
    {
        string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Idioma idioma, Keys key, Keys plural);
        string TraducirForma(int cantidad, Idioma idioma, Keys key, Keys plural);
    }
}
