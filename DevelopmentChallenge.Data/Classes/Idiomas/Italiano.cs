namespace DevelopmentChallenge.Data
{
    using System.Collections.Generic;

    public class Italiano : Idioma
    {
        public Italiano()
        {
            this.Traducciones = new Dictionary<Keys, string>()
            {
                { Keys.ListaVacia, "Elenco vuoto di moduli!" },
                { Keys.Encabezado, "Rapporto sui moduli" },
                { Keys.Cuadrado,   "Piazza" },
                { Keys.Triangulo,  "Triangolo" },
                { Keys.Circulo,    "Cerchio" },
                { Keys.Area,       "La zona" },
                { Keys.Perimetro,  "Perimetro" },
                { Keys.Trapecio,   "Trapezio" },
                { Keys.Rectangulo, "Rettangolo"},
                { Keys.Formas,     "Forme"},
                { Keys.Circulos, "Cerchi" },
                { Keys.Cuadrados, "Piazze" },
                { Keys.Rectangulos, "Rettangoli" },
                { Keys.Triangulos, "Triangoli" },
                { Keys.Trapecios, "Trapezi" }
            };
        }
    }
}
