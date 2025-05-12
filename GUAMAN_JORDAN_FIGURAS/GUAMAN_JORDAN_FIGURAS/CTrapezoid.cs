using System;

namespace GUAMAN_JORDAN_FIGURAS
{
    internal class CTrapezoid
    {
        // Atributos
        private double baseMayor;
        private double baseMenor;
        private double ladoIzq;
        private double ladoDer;
        private double altura;

        // Propiedades
        public double BaseMayor
        {
            get => baseMayor;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La base mayor debe ser mayor que cero.");
                baseMayor = value;
            }
        }

        public double BaseMenor
        {
            get => baseMenor;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La base menor debe ser mayor que cero.");
                baseMenor = value;
            }
        }

        public double LadoIzq
        {
            get => ladoIzq;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado izquierdo debe ser mayor que cero.");
                ladoIzq = value;
            }
        }

        public double LadoDer
        {
            get => ladoDer;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado derecho debe ser mayor que cero.");
                ladoDer = value;
            }
        }

        public double Altura
        {
            get => altura;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La altura debe ser mayor que cero.");
                altura = value;
            }
        }

        // Métodos de cálculo
        public double CalcularArea()
        {
            return ((baseMayor + baseMenor) / 2.0) * altura;
        }

        public double CalcularPerimetro()
        {
            return baseMayor + baseMenor + ladoIzq + ladoDer;
        }
    }
}
