namespace DevelopmentChallenge.Data
{
    using System;

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
}
