namespace DevelopmentChallenge.Data
{
    public class Rectangulo : FormaGeometrica
    {
        public override Keys Key
        {
            get
            {
                return Keys.Rectangulo;
            }
        }

        public override Keys Plural
        {
            get
            {
                return Keys.Rectangulos;
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
            return (_lado * 2) + (_alto * 2);
        }
    }

}
