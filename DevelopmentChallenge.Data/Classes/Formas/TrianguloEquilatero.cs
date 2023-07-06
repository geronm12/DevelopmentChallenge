namespace DevelopmentChallenge.Data
{
    using System;

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
}
