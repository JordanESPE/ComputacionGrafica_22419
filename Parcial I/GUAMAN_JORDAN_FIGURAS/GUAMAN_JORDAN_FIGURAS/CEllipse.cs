using System;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CEllipse
    {
        // Propiedades para los semiejes mayor y menor
        public double SemiMajorAxis { get; private set; }
        public double SemiMinorAxis { get; private set; }

        // Constructor de la clase para inicializar los semiejes
        public CEllipse(double semiMajorAxis, double semiMinorAxis)
        {
            SemiMajorAxis = semiMajorAxis;
            SemiMinorAxis = semiMinorAxis;
        }

        // Método para actualizar los semiejes
        public void UpdateAxes(double semiMajorAxis, double semiMinorAxis)
        {
            SemiMajorAxis = semiMajorAxis;
            SemiMinorAxis = semiMinorAxis;
        }

        // Método para calcular el área de la elipse
        public double CalculateArea()
        {
            return Math.PI * SemiMajorAxis * SemiMinorAxis;
        }

        // Método para calcular el perímetro de la elipse (aproximación de Ramanujan)
        public double CalculatePerimeter()
        {
            double a = SemiMajorAxis;
            double b = SemiMinorAxis;
            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }
    }
}
 