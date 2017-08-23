using System;
using Meta.Numerics.Statistics.Distributions;

namespace NumerosAleatorios
{
    public static class ChiCuadrado
    {
        public static double Calcular(double observada, double esperada)
        {
            if (!(esperada > 0))
                throw new NotSupportedException("La frecuencia esperada debe ser mayor a cero");

            var valor = Math.Pow(esperada - observada, 2) / esperada;

            return valor;
        }

        public static double ValorDeTabla(int grados, double alfa)
        {
            if (!(grados > 0))
                throw new NotSupportedException("Los grados de libertad deben ser mayores a cero");

            Distribution d = new ChiSquaredDistribution(grados);

            var valor = d.InverseRightProbability(alfa);

            return valor;
        }
    }
}
