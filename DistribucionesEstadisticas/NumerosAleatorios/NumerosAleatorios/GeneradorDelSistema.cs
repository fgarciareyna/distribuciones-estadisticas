using System;
using System.Threading;

namespace NumerosAleatorios.NumerosAleatorios
{
     public class GeneradorDelSistema : IGeneradorNumerosAleatorios
    {
        public double Generar()
        {
            Thread.Sleep(20); // Para que la semilla sea distinta

            var aleatorio = new Random().NextDouble();

            return aleatorio;
        }

        public int Generar(int cifras)
        {
            var aleatorio = Generar();

            return (int)(aleatorio * Math.Pow(10, cifras));
        }
    }
}
