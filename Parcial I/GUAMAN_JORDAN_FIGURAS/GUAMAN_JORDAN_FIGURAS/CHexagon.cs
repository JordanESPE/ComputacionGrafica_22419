using System;
namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CHexagon
    {
        private double lado;
        private double apotema;

        // Constructor con lado
        public CHexagon(double lado)
        {
            this.lado = lado;
            this.apotema = CalcularApotema();
        }

        // Constructor con lado y apotema
        public CHexagon(double lado, double apotema)
        {
            this.lado = lado;
            this.apotema = apotema;
        }

        // Método para calcular el apotema
        public double CalcularApotema()
        {
            // Apotema = L/(2*tan(π/6)) o L*√3/2
            return (lado * Math.Sqrt(3)) / 2;
        }

        // Método para calcular el perímetro
        public double CalcularPerimetro()
        {
            return 6 * lado; // P = 6 * L
        }

        // Método para calcular el área usando el apotema
        public double CalcularArea()
        {
            // Área = (Perímetro * apotema) / 2
            return (CalcularPerimetro() * apotema) / 2;

            // Fórmula alternativa: A = (3√3 / 2) * L^2
            // return ((3 * Math.Sqrt(3)) / 2) * Math.Pow(lado, 2);
        }
    }
}