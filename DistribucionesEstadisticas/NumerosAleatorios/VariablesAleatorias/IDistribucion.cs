using System.Collections.Generic;
using NumerosAleatorios.NumerosAleatorios;

namespace NumerosAleatorios.VariablesAleatorias
{
    public interface IDistribucion
    {
        void AsignarGenerador(IGeneradorNumerosAleatorios generador);
        double Generar();
        List<double> Generar(int cantidad);
        List<double> FrecuenciasEsperadas(List<Intervalo> intervalos);
        int CantidadParametros();
    }
}
