using System;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CRectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El ancho debe ser mayor a cero.");
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El largo debe ser mayor a cero.");
                height = value;
            }
        }

        public CRectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
