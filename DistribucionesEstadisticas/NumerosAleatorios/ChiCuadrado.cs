using System;
using Meta.Numerics.Statistics.Distributions;

namespace NumerosAleatorios
{
    public static class ChiCuadrado
    {
        public static double Calcular(double observada, double esperada)
        {
            var valor = Math.Pow(esperada - observada, 2) / esperada;

            return valor;
        }

        public static double ValorDeTabla(int grados, double alfa)
        {
            Distribution d = new ChiSquaredDistribution(grados);

            var valor = d.InverseRightProbability(alfa);

            return valor;
        }
    }
}
