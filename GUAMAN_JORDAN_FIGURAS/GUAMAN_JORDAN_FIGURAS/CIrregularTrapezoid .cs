using System;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CIrregularTrapezoid
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double LadoIzquierdo { get; set; }
        public double LadoDerecho { get; set; }
        public double Altura { get; set; }

        public CIrregularTrapezoid(double baseMayor, double baseMenor, double ladoIzquierdo, double ladoDerecho, double altura)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            LadoIzquierdo = ladoIzquierdo;
            LadoDerecho = ladoDerecho;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return ((BaseMayor + BaseMenor) * Altura) / 2;
        }

        public double CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + LadoIzquierdo + LadoDerecho;
        }
    }
}
