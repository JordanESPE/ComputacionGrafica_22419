using System;
namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CHeptagon
    {
        private double sideLength;
        private double apotema;

        // Constructor con solo el lado
        public CHeptagon(double sideLength)
        {
            this.sideLength = sideLength;
            this.apotema = CalculateApotema();
        }

        // Constructor con lado y apotema
        public CHeptagon(double sideLength, double apotema)
        {
            this.sideLength = sideLength;
            this.apotema = apotema;
        }

        // Método para calcular el apotema
        public double CalculateApotema()
        {
            // Apotema de un heptágono regular = R * cos(π/7)
            // Donde R (radio) = sideLength / (2 * sin(π/7))
            double radio = sideLength / (2 * Math.Sin(Math.PI / 7));
            return radio * Math.Cos(Math.PI / 7);
        }

        // Método para calcular el perímetro
        public double CalculatePerimeter()
        {
            return 7 * sideLength; // Fórmula: P = 7 * L
        }

        // Método para calcular el área usando el apotema
        public double CalculateArea()
        {
            // Área = (Perímetro * Apotema) / 2
            return (CalculatePerimeter() * apotema) / 2;

            // Fórmula alternativa: A = (7/4) * L^2 * cot(π/7)
            // return (7 / 4.0) * Math.Pow(sideLength, 2) * (1 / Math.Tan(Math.PI / 7));
        }
    }
}