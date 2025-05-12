using System;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CPentagon
    {
        private double lado;
        private double apotema;

        public CPentagon(double lado, double apotema)
        {
            if (lado <= 0 || apotema <= 0)
            {
                throw new ArgumentException("El lado y la apotema deben ser mayores que cero.");
            }

            this.lado = lado;
            this.apotema = apotema;
        }

        public double CalcularPerimetro()
        {
            return 5 * lado;
        }

        public double CalcularArea()
        {
            return (CalcularPerimetro() * apotema) / 2;
        }
    }
}
