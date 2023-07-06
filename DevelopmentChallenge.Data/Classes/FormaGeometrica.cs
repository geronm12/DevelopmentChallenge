/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * OPCIONAL: Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public static class Labels
    {
        public static string Pluralizar = "s";
    }

    public static class HtmlTagsHelper
    {
        public static string H1 = "<h1>{0}</h1>";
        public enum Keys
        {
            ListaVacia,
            Encabezado,
            Cuadrado,
            Triangulo,
            Circulo,
            Area,
            Perimetro
        }

        public abstract class Idioma
        {
            public virtual Dictionary<Keys, String> Traducciones { get; set; }
            public virtual String Traducir(Keys key)
            {
                String traduccion = "";
                Traducciones.TryGetValue(key, out traduccion);

                return traduccion;
            }
        }

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
                { Keys.Perimetro, "Perimetro" }
            };
            }
        }

        public class Ingles : Idioma
        {
            public Ingles()
            {
                this.Traducciones = new Dictionary<Keys, string>()
            {
                { Keys.ListaVacia, "Empty list of shapes!" },
                { Keys.Encabezado, "Shapes report" },
                { Keys.Cuadrado, "Squre" },
                { Keys.Triangulo, "Triangle" },
                { Keys.Circulo,   "Circle" },
                { Keys.Area,      "Area" },
                { Keys.Perimetro, "Perimeter" }
            };
            }
        }
        public abstract class FormaGeometrica
        {
            protected readonly decimal _lado;


            public FormaGeometrica(decimal ancho)
            {
                _lado = ancho;
            }

            public virtual string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Idioma idioma)
            {
                return string.Empty;
            }


            public virtual string TraducirForma(int cantidad, Idioma idioma)
            {
                return string.Empty;
            }

            public virtual decimal CalcularArea()
            {
                throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }

            public virtual decimal CalcularPerimetro()
            {
                throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }
        }

        public class Cuadrado : FormaGeometrica
        {
            public Cuadrado(decimal ancho)
                : base(ancho)
            {

            }

            public override decimal CalcularArea()
            {
                return this._lado * this._lado;
            }

            public override decimal CalcularPerimetro()
            {
                return _lado * 4;
            }

            public override string TraducirForma(int cantidad, Idioma idioma)
            {
                return cantidad > 1
                        ? String.Format(HtmlTagsHelper.H1, String.Concat(idioma.Traducir(Keys.Cuadrado), Labels.Pluralizar))
                        : idioma.Traducir(Keys.Cuadrado);
            }

            public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Idioma idioma)
            {
                if (cantidad > 0)
                {
                    return $"{cantidad} {idioma.Traducir(Keys.Cuadrado)} |{idioma.Traducir(Keys.Area)} {area:#.##} | {idioma.Traducir(Keys.Perimetro)} {perimetro:#.##} <br/>";
                }

                return base.ObtenerLinea(cantidad, area, perimetro, idioma);
            }
        }

        public class TrianguloEquilatero : FormaGeometrica
        {
            public TrianguloEquilatero(decimal ancho)
                : base(ancho)
            {

            }

            public override decimal CalcularArea()
            {
                return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
            }

            public override decimal CalcularPerimetro()
            {
                return _lado * 3;
            }

            public override string TraducirForma(int cantidad, Idioma idioma)
            {
                return cantidad > 1
                  ? String.Concat(idioma.Traducir(Keys.Triangulo), Labels.Pluralizar)
                  : idioma.Traducir(Keys.Triangulo);
            }

            public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Idioma idioma)
            {
                if (cantidad > 0)
                {
                    return $"{cantidad} {idioma.Traducir(Keys.Triangulo)} |{idioma.Traducir(Keys.Area)} {area:#.##} | {idioma.Traducir(Keys.Perimetro)} {perimetro:#.##} <br/>";
                }

                return base.ObtenerLinea(cantidad, area, perimetro, idioma);
            }
        }

        public class Circulo : FormaGeometrica
        {
            public Circulo(decimal ancho)
                : base(ancho)
            {

            }

            public override decimal CalcularArea()
            {
                return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
            }
            public override decimal CalcularPerimetro()
            {
                return (decimal)Math.PI * _lado;
            }

            public override string TraducirForma(int cantidad, Idioma idioma)
            {
                return cantidad > 1
                  ? String.Concat(idioma.Traducir(Keys.Circulo), Labels.Pluralizar)
                  : idioma.Traducir(Keys.Circulo);
            }

            public override string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Idioma idioma)
            {
                if (cantidad > 0)
                {
                    return $"{cantidad} {idioma.Traducir(Keys.Circulo)} |{idioma.Traducir(Keys.Area)} {area:#.##} | {idioma.Traducir(Keys.Perimetro)} {perimetro:#.##} <br/>";
                }

                return base.ObtenerLinea(cantidad, area, perimetro, idioma);
            }
        }

        public interface IFormasGeometricasService
        {
            string Imprimir(List<FormaGeometrica> formas);
        }

        public class FormasGeometricasService : IFormasGeometricasService
        {
            private readonly Idioma _idioma;
            public FormasGeometricasService(Idioma idioma)
            {
                this._idioma = idioma;
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

  
                foreach (var item in formas.GroupBy(forma => forma.GetType()))
                {
                    var primerItem = item.First();
                    String linea = primerItem.ObtenerLinea(item.Count(), item.Sum(forma => forma.CalcularArea()), item.Sum(forma => forma.CalcularPerimetro()), _idioma);
                    sb.Append(linea);
                }

            

          
                // FOOTER
                //sb.Append("TOTAL:<br/>");
                //sb.Append(numeroCuadrados + numeroCirculos + numeroTriangulos + " " + (idioma == Castellano ? "formas" : "shapes") + " ");
                //sb.Append((idioma == Castellano ? "Perimetro " : "Perimeter ") + (perimetroCuadrados + perimetroTriangulos + perimetroCirculos).ToString("#.##") + " ");
                //sb.Append("Area " + (areaCuadrados + areaCirculos + areaTriangulos).ToString("#.##"));

                return sb.ToString();
            }

        }
    }

}