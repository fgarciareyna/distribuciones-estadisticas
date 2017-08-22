using System;

namespace NumerosAleatorios
{
    public class Intervalo
    {
        public double Inicio { get; set; }
        public double Fin { get; set; }

        public Intervalo(double inicio, double fin)
        {
            if (fin <= inicio)
                throw new NotSupportedException("El fin del intervalo debe ser superior al inicio");

            Inicio = inicio;
            Fin = fin;
        }
    }
}
