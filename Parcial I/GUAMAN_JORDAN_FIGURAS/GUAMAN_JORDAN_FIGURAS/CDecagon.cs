namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CDecagon
    {
        private double side;
        private double apothem;
        private double perimeter;
        private double area;

        public CDecagon(double side, double apothem)
        {
            this.side = side;
            this.apothem = apothem;
            CalculatePerimeter();
            CalculateArea();
        }

        private void CalculatePerimeter()
        {
            this.perimeter = 10 * this.side;
        }

        private void CalculateArea()
        {
            this.area = (this.perimeter * this.apothem) / 2;
        }

        public double GetPerimeter()
        {
            return this.perimeter;
        }

        public double GetArea()
        {
            return this.area;
        }
    }
}
