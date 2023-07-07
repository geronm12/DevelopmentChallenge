namespace DevelopmentChallenge.Data
{
    using System.Collections.Generic;

    public class Español : Idioma
    {
        public Español()
        {
            this.Traducciones = new Dictionary<Keys, string>()
            {
                { Keys.ListaVacia,"Lista vacía de formas!" },
                { Keys.Encabezado,"Reporte de Formas" },
                { Keys.Cuadrado,  "Cuadrado" },
                { Keys.Triangulo, "Triangulo" },
                { Keys.Circulo,   "Circulo" },
                { Keys.Area,      "Area" },
                { Keys.Perimetro, "Perimetro" },
                { Keys.Trapecio,  "Trapecio" },
                { Keys.Rectangulo,"Rectangulo"},
                { Keys.Formas,    "Formas"},
                { Keys.Circulos, "Circulos" },
                { Keys.Cuadrados, "Cuadrados" },
                { Keys.Rectangulos, "Rectangulos" },
                { Keys.Triangulos, "Triangulos" },
                { Keys.Trapecios, "Trapecios" }
            };
        }
    }
}
