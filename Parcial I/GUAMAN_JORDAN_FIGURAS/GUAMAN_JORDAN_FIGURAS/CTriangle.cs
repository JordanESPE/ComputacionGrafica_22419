using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CTriangle
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        // Propiedades con validación
        public double SideA
        {
            get { return _sideA; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado A debe ser un número positivo.");
                _sideA = value;
            }
        }

        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado B debe ser un número positivo.");
                _sideB = value;
            }
        }

        public double SideC
        {
            get { return _sideC; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado C debe ser un número positivo.");
                _sideC = value;
            }
        }

        // Constructores
        public CTriangle()
        {
            _sideA = 0;
            _sideB = 0;
            _sideC = 0;
        }

        public CTriangle(double sideA, double sideB, double sideC)
        {
            // Validamos que los lados formen un triángulo
            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Los lados proporcionados no pueden formar un triángulo.");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Métodos
        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double CalculateArea()
        {
            // Utilizamos la fórmula de Herón
            double s = CalculatePerimeter() / 2; // Semiperímetro
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        // Métodos de validación
        public static bool IsValidNumber(string text)
        {
            return double.TryParse(text, out double result) && result > 0;
        }

        public static bool IsValidTriangle(double a, double b, double c)
        {
            // Un triángulo es válido si la suma de las longitudes de dos lados
            // es mayor que la longitud del tercer lado (desigualdad triangular)
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}