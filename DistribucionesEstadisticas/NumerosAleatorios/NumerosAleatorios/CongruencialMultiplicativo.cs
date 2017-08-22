using System;

namespace NumerosAleatorios.NumerosAleatorios
{
    public class CongruencialMultiplicativo : IGeneradorNumerosAleatorios
    {
        public double Semilla { get; protected set; }
        public double A { get; protected set; }
        public double M { get; protected set; }

        public CongruencialMultiplicativo(double semilla, double a, double m)
        {
            Semilla = semilla;
            A = a;
            M = m;
        }

        public double Generar()
        {
            var aleatorio = (A * Semilla) % M;

            Semilla = aleatorio;

            return aleatorio / M;
        }

        public int Generar(int cifras)
        {
            var aleatorio = Generar();

            return (int)(aleatorio * Math.Pow(10, cifras));
        }
    }
}
