using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CIsoscelesTrapezoid
    {
        // Atributos
        private double majorBase;
        private double minorBase;
        private double sideSide;
        private double height;

        // Constructor
        public CIsoscelesTrapezoid(double majorBase, double minorBase, double sideSide, double height)
        {
            this.majorBase = majorBase;
            this.minorBase = minorBase;
            this.sideSide = sideSide;
            this.height = height;
        }

        // Propiedades
        public double MajorBase
        {
            get { return majorBase; }
            set { majorBase = value; }
        }

        public double MinorBase
        {
            get { return minorBase; }
            set { minorBase = value; }
        }

        public double SideSide
        {
            get { return sideSide; }
            set { sideSide = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Métodos
        public double CalculateArea()
        {
            // Área = (Base mayor + Base menor) * altura / 2
            return ((majorBase + minorBase) * height) / 2;
        }

        public double CalculatePerimeter()
        {
            // Perímetro = Base mayor + Base menor + 2 * Lado lateral
            return majorBase + minorBase + 2 * sideSide;
        }

        // Método para validar que los datos sean coherentes para un trapecio isósceles
        public bool ValidateData()
        {
            // Validar que todos los valores sean positivos
            if (majorBase <= 0 || minorBase <= 0 || sideSide <= 0 || height <= 0)
                return false;

            // Validar que la base mayor sea mayor que la base menor
            if (majorBase <= minorBase)
                return false;

            // Validar que el lado lateral sea suficiente para unir los extremos de las bases
            // La diferencia entre las bases dividido por 2 es el incremento horizontal
            double horizontalDiff = (majorBase - minorBase) / 2;
            // Distancia mínima para el lado lateral usando el teorema de Pitágoras
            double minSideLength = Math.Sqrt(Math.Pow(horizontalDiff, 2) + Math.Pow(height, 2));

            // El lado lateral debe ser al menos tan largo como la distancia mínima
            return sideSide >= minSideLength * 0.98; // 2% de tolerancia para redondeos
        }
    }
}