namespace DevelopmentChallenge.Data
{
    using System.Collections.Generic;

    public class Ingles : Idioma
    {
        public Ingles()
        {
            this.Traducciones = new Dictionary<Keys, string>()
                {
                { Keys.ListaVacia, "Empty list of shapes!" },
                { Keys.Encabezado, "Shapes report" },
                { Keys.Cuadrado, "Square" },
                { Keys.Triangulo, "Triangle" },
                { Keys.Circulo,   "Circle" },
                { Keys.Area,      "Area" },
                { Keys.Perimetro, "Perimeter" },
                { Keys.Trapecio,  "Trapezoid" },
                { Keys.Rectangulo,"Rectangle" },
                { Keys.Formas,    "Shapes" },
                { Keys.Circulos, "Circles" },
                { Keys.Cuadrados, "Squares" },
                { Keys.Rectangulos, "Rectangles" },
                { Keys.Triangulos, "Triangles" },
                { Keys.Trapecios, "Trapezoids" }
            };
        }
    }
}
