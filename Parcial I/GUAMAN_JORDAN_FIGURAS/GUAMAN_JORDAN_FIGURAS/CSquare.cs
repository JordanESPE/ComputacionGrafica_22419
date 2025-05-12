namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CSquare
    {
        private double side;

        public void SetSide(double s)
        {
            side = s;
        }

        public double CalculateArea()
        {
            return side * side;
        }

        public double CalculatePerimeter()
        {
            return 4 * side;
        }
    }
}
