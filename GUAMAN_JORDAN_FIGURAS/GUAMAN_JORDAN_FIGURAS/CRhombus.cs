namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CRhombus
    {
        // atributos
        private double majorDiagonal;
        private double minorDiagonal;
        private double side;

        // metodos Set
        public void SetMajorDiagonal(double majorDiagonal)
        {
            this.majorDiagonal = majorDiagonal;
        }

        public void SetMinorDiagonal(double minorDiagonal)
        {
            this.minorDiagonal = minorDiagonal;
        }

        public void SetSide(double side)
        {
            this.side = side;
        }

        // metodos de calculo
        public double CalculateArea()
        {
            return (majorDiagonal * minorDiagonal) / 2.0;
        }

        public double CalculatePerimeter()
        {
            return 4 * side;
        }
    }
}
