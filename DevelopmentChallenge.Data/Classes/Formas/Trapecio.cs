namespace DevelopmentChallenge.Data
{
    public class Trapecio : FormaGeometrica
    {
        public override Keys Key
        {
            get
            {
                return Keys.Trapecio;
            }
        }

        public override Keys Plural
        {
            get
            {
                return Keys.Trapecios;
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

}
