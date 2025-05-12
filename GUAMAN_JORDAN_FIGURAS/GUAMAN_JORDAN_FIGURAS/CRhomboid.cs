namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CRhomboid
    {
        // Atributos
        private double width;
        private double height;
        private double side;

        // Métodos Set
        public void SetWidth(double width)
        {
            this.width = width;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public void SetSide(double side)
        {
            this.side = side;
        }

        // Método para calcular el área del romboide
        public double CalculateArea()
        {
            return width * height;
        }

        // Método para calcular el perímetro del romboide
        public double CalculatePerimeter()
        {
            return 2 * (width + side);
        }
    }
}
