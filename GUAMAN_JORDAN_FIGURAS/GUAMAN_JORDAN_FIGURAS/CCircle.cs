using System;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CCircle
    {
        private double radio;

        // Constructor que recibe el radio
        public CCircle(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
