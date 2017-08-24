using System;
using System.Collections.Generic;
using Meta.Numerics.Statistics.Distributions;
using NumerosAleatorios.NumerosAleatorios;

namespace NumerosAleatorios.VariablesAleatorias
{
    public class DistribucionExponencialNegativa : IDistribucion
    {
        public double Lambda { get; protected set; }
        public IGeneradorNumerosAleatorios Generador { get; protected set; }

        public DistribucionExponencialNegativa(double lambda)
        {
            if (lambda <= 0)
                throw new NotSupportedException("Lambda debe ser un número positivo");

            Lambda = lambda;
            Generador = new GeneradorDelSistema();
        }

        public DistribucionExponencialNegativa(double lambda, IGeneradorNumerosAleatorios generador)
        {
            if (lambda <= 0)
                throw new NotSupportedException("Lambda debe ser un número positivo");

            Lambda = lambda;
            Generador = generador;
        }

        public void AsignarGenerador(IGeneradorNumerosAleatorios generador)
        {
            Generador = generador;
        }

        public double Generar()
        {
            //x=-1/lambda*ln(1-r1)
            var aleatorio = Generador.Generar();

            var variable = (-1 / Lambda) * Math.Log(1 - aleatorio);

            return variable;
        }

        public List<double> Generar(int cantidad)
        {
            var variables = new List<double>(cantidad);

            for (int i = 0; i < cantidad; i++)
            {
                variables.Add(Generar());
            }

            return variables;
        }

        public List<double> FrecuenciasEsperadas(List<Intervalo> intervalos)
        {
            var frecuencias = new List<double>(intervalos.Count);

            Distribution d = new ExponentialDistribution(1/Lambda);

            foreach (var intervalo in intervalos)
            {
                var frecuencia = d.LeftProbability(intervalo.Fin) - d.LeftProbability(intervalo.Inicio);

                frecuencias.Add(frecuencia);
            }

            return frecuencias;
        }

        public int CantidadParametros()
        {
            return 1;
        }
    }
}
