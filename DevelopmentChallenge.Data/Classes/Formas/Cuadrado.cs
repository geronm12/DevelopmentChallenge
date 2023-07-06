namespace DevelopmentChallenge.Data
{
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
}
