using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class COctagon
    {
        // Propiedades
        private double side;
        private double apothem;
        private const int NUM_SIDES = 8; // Un octágono tiene 8 lados

        // Propiedades con validación
        public double Side
        {
            get { return side; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado debe ser un valor positivo mayor que cero.");
                side = value;
            }
        }

        public double Apothem
        {
            get { return apothem; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La apotema debe ser un valor positivo mayor que cero.");
                apothem = value;
            }
        }

        // Constructores
        public COctagon()
        {
            side = 0;
            apothem = 0;
        }

        public COctagon(double side, double apothem)
        {
            Side = side;
            Apothem = apothem;
        }

        // Métodos
        public double CalculatePerimeter()
        {
            return NUM_SIDES * side;
        }

        public double CalculateArea()
        {
            return (CalculatePerimeter() * apothem) / 2;
        }

        // Método para validar si un texto es un número válido
        public static bool IsValidNumber(string text)
        {
            return double.TryParse(text, out double result) && result > 0;
        }
    }
}