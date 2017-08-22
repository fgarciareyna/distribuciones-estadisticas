using System;

namespace NumerosAleatorios.NumerosAleatorios
{
    public class CongruencialMixto : IGeneradorNumerosAleatorios
    {
        public double Semilla { get; protected set; }
        public double A { get; protected set; }
        public double C { get; protected set; }
        public double M { get; protected set; }

        public CongruencialMixto(double semilla, double a, double c, double m)
        {
            Semilla = semilla;
            A = a;
            C = c;
            M = m;
        }

        public double Generar()
        {
            var aleatorio = (A * Semilla + C) % M;

            Semilla = aleatorio;

            return aleatorio / M;
        }

        public int Generar(int cifras)
        {
            var aleatorio = Generar();

            return (int) (aleatorio * Math.Pow(10, cifras));
        }
    }
}
