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
namespace DevelopmentChallenge.Data
{
    using System;

    public abstract class FormaGeometrica
    {
        protected readonly decimal _lado;
        public virtual Keys Key { get;  }
        public virtual Keys Plural { get; }
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
}