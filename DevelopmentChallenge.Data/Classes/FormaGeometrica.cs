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
    }
    public enum Keys
    {
        ListaVacia,
        Encabezado,
        Cuadrado,
        Triangulo,
        Circulo,
        Area,
        Perimetro,
        Trapecio,
        Rectangulo,
        Formas
    }

    //Nota se podía utilizar una interfaz para declarar ambos o también se podría utilizar recursos externos
    //Eso nos ahorraría un par de clases
    //Otra opción sería tener un esquema en la base de datos que permita almacenar los idiomas y
    //sus traducciones específicas
    public abstract class Idioma
    {
        public virtual Dictionary<Keys, String> Traducciones { get; set; }

        public Idioma()
        {
        }
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
                { Keys.Perimetro, "Perimetro" },
                { Keys.Trapecio,  "Trapecio" },
                { Keys.Rectangulo,"Rectangulo"},
                { Keys.Formas, "Formas"}
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
                { Keys.Perimetro, "Perimeter" },
                { Keys.Trapecio,  "Trapezoid" },
                { Keys.Rectangulo,"Rectangle" },
                { Keys.Formas, "Shapes" }
            };
        }
    }
    public abstract class FormaGeometrica
    {
        protected readonly decimal _lado;
        public virtual Keys Key { get;  }
        public FormaGeometrica(decimal ancho)
        {
            _lado = ancho;
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
        public override Keys Key
        {
            get
            {
                return Keys.Cuadrado;
            }
        }
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
    
    }

    public class TrianguloEquilatero : FormaGeometrica
    {
        public override Keys Key
        {
            get
            {
                return Keys.Triangulo;
            }
        }

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
    }

    public class Circulo : FormaGeometrica
    {
        public override Keys Key
        {
            get
            {
                return Keys.Circulo;
            }
        }

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
    }

    public class Trapecio : FormaGeometrica
    {
        public override Keys Key
        {
            get
            {
                return Keys.Trapecio;
            }
        }
        public Trapecio(decimal ancho) 
            : base(ancho)
        {
        }

        public override decimal CalcularArea()
        {
            return base.CalcularArea();
        }

        public override decimal CalcularPerimetro()
        {
            return base.CalcularPerimetro();
        }
    }

    public class Rectangulo : FormaGeometrica
    {
        public override Keys Key
        {
            get
            {
                return Keys.Rectangulo;
            }
        }

        private decimal _alto;
 

        public Rectangulo(decimal ancho, decimal alto) 
            : base(ancho)
        {
            _alto = alto;
        }

        public override decimal CalcularArea()
        {
            return _lado * _alto;
        }

        public override decimal CalcularPerimetro()
        {
            return (this._lado * 2) + (_alto * 2);
        }
    }

    public interface IFormasGeometricasService
    {
        string Imprimir(List<FormaGeometrica> formas);
    }

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
           sb.Append(_idioma.Traducir(Keys.Perimetro)+ perimetroTotal.ToString("#.##") + " ");
           sb.Append(_idioma.Traducir(Keys.Area) + areaTotal.ToString("#.##"));

           return sb.ToString();
       }

    }

    public interface IMessage
    {
        string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Idioma idioma, Keys key);
        string TraducirForma(int cantidad, Idioma idioma, Keys key);
    }

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