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

        private decimal _baseMenor, _ladoIzq, _ladoDerech, _altura;

        public Trapecio(decimal ancho, decimal baseMenor, decimal ladoIzq, decimal ladoDerech, decimal altura)
            : base(ancho)
        {
            _baseMenor = baseMenor;
            _ladoIzq = ladoIzq;
            _ladoDerech = ladoDerech;
            _altura = altura;

        }

        public override decimal CalcularArea()
        {
            return ((_lado * _baseMenor) / 2) * _altura;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado + _baseMenor + _ladoDerech + _ladoIzq;
        }
    }

}
