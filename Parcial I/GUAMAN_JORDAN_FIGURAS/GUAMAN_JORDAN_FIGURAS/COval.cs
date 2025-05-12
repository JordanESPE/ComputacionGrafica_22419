using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class COval
    {
        // Propiedades
        private double semiMajorAxis; // semieje mayor
        private double semiMinorAxis; // semieje menor

        // Propiedades con validación
        public double SemiMajorAxis
        {
            get { return semiMajorAxis; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El semieje mayor debe ser un valor positivo mayor que cero.");
                semiMajorAxis = value;
            }
        }

        public double SemiMinorAxis
        {
            get { return semiMinorAxis; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El semieje menor debe ser un valor positivo mayor que cero.");
                if (value > semiMajorAxis)
                    throw new ArgumentException("El semieje menor no puede ser mayor que el semieje mayor.");
                semiMinorAxis = value;
            }
        }

        // Constructores
        public COval()
        {
            semiMajorAxis = 0;
            semiMinorAxis = 0;
        }

        public COval(double semiMajorAxis, double semiMinorAxis)
        {
            SemiMajorAxis = semiMajorAxis;
            SemiMinorAxis = semiMinorAxis;
        }

        // Métodos
        public double CalculateArea()
        {
            return Math.PI * semiMajorAxis * semiMinorAxis;
        }

        public double CalculatePerimeter()
        {
            // Aproximación de Ramanujan para el perímetro de una elipse
            double h = Math.Pow(semiMajorAxis - semiMinorAxis, 2) / Math.Pow(semiMajorAxis + semiMinorAxis, 2);
            return Math.PI * (semiMajorAxis + semiMinorAxis) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }

        // Método para validar si un texto es un número válido
        public static bool IsValidNumber(string text)
        {
            return double.TryParse(text, out double result) && result > 0;
        }

        // Método para validar que el semieje menor no sea mayor que el semieje mayor
        public static bool ValidateAxes(double semiMajorAxis, double semiMinorAxis)
        {
            return semiMinorAxis <= semiMajorAxis;
        }
    }
}