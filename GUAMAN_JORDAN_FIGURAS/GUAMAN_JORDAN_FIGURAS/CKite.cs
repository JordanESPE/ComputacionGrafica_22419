using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CKite
    {
        // Atributos
        private double majorDiagonal;
        private double minorDiagonal;
        private double side;

        // Constructor
        public CKite(double majorDiagonal, double minorDiagonal, double side)
        {
            this.majorDiagonal = majorDiagonal;
            this.minorDiagonal = minorDiagonal;
            this.side = side;
        }

        // Propiedades
        public double MajorDiagonal
        {
            get { return majorDiagonal; }
            set { majorDiagonal = value; }
        }

        public double MinorDiagonal
        {
            get { return minorDiagonal; }
            set { minorDiagonal = value; }
        }

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        // Métodos
        public double CalculateArea()
        {
            // Área = (diagonal mayor * diagonal menor) / 2
            return (majorDiagonal * minorDiagonal) / 2;
        }

        public double CalculatePerimeter()
        {
            // Perímetro = 4 * lado (todos los lados son iguales en un deltoide regular)
            return 4 * side;
        }

        // Método para validar que los datos sean coherentes para un deltoide
        public bool ValidateData()
        {
            // Validar que todos los valores sean positivos
            if (majorDiagonal <= 0 || minorDiagonal <= 0 || side <= 0)
                return false;

            // Validar que la diagonal mayor sea realmente mayor que la diagonal menor
            if (majorDiagonal <= minorDiagonal)
                return false;

            // En un deltoide, la mitad de cada diagonal es un segmento desde el centro hasta un vértice
            double halfMajorDiagonal = majorDiagonal / 2;
            double halfMinorDiagonal = minorDiagonal / 2;

            // Verificar que el lado sea suficiente para formar el deltoide utilizando el teorema de Pitágoras
            // La distancia desde el centro hasta cualquier vértice debe ser menor o igual que el lado
            return Math.Sqrt(Math.Pow(halfMajorDiagonal, 2) + Math.Pow(halfMinorDiagonal, 2)) <= side * 1.01; // 1% de tolerancia
        }
    }
}