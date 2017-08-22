using System.Collections.Generic;
using System.Linq;
using NumerosAleatorios.VariablesAleatorias;

namespace NumerosAleatorios
{
    public class GestorEstadistico
    {
        public IDistribucion Distribucion { get; protected set; }
        public int TamañoMuestra { get; protected set; }
        public int CantidadIntervalos { get; protected set; }
        public double Alfa { get; protected set; }
        public List<double> Valores { get; protected set; }
        public List<Intervalo> Intervalos { get; protected set; }
        public List<int> FrecuenciasObservadasAbsolutas { get; protected set; }
        public List<double> FrecuenciasObservadasRelativas { get; protected set; }
        public List<double> FrecuenciasEsperadasAbsolutas { get; protected set; }
        public List<double> FrecuenciasEsperadasRelativas { get; protected set; }
        public List<double> ValoresChiCuadrado { get; protected set; }
        public double TablaChiCuadrado { get; protected set; }

        public GestorEstadistico(IDistribucion distribucion, int tamañoMuestra, int cantidadIntervalos, double alfa)
        {
            Distribucion = distribucion;
            TamañoMuestra = tamañoMuestra;
            CantidadIntervalos = cantidadIntervalos;
            Alfa = alfa;

            CalcularValores();
            CalcularIntervalos();
            CalcularFrecuenciasObservadas();
            ObtenerFrecuenciasEsperadas();
            CalcularValoresChiCuadrado();
            ObtenerValorDeTablaChiCuadrado();
        }

        private void CalcularIntervalos()
        {
            var intervalos = new List<Intervalo>(CantidadIntervalos);

            var min = Valores.Min();
            var max = Valores.Max();
            var paso = (max - min) / CantidadIntervalos;

            var inicio = min;
            var fin = min + paso;

            for (var i = 0; i < CantidadIntervalos; i++)
            {
                intervalos.Add(new Intervalo(inicio, fin));

                inicio = fin;
                fin += paso;
            }

            intervalos.Last().Fin = max;

            Intervalos = intervalos;
        }

        private void CalcularValores()
        {
            var valores = Distribucion.Generar(TamañoMuestra);

            Valores = valores;
        }

        private void CalcularFrecuenciasObservadas()
        {
            var absolutas = new List<int>(CantidadIntervalos);
            var relativas = new List<double>(CantidadIntervalos);

            foreach (var intervalo in Intervalos)
            {
                var encontrados = Valores.Where(valor => valor >= intervalo.Inicio && valor < intervalo.Fin);

                var absoluta = encontrados.Count();
                var relativa = (double)absoluta / TamañoMuestra;

                absolutas.Add(absoluta);
                relativas.Add(relativa);
            }

            //Corrección para contar el máximo valor
            absolutas[CantidadIntervalos - 1] += 1;
            relativas[CantidadIntervalos - 1] = (double)absolutas.Last() / TamañoMuestra;

            FrecuenciasObservadasAbsolutas = absolutas;
            FrecuenciasObservadasRelativas = relativas;
        }

        private void ObtenerFrecuenciasEsperadas()
        {
            var relativas = Distribucion.FrecuenciasEsperadas(Intervalos);

            var absolutas = new List<double>(CantidadIntervalos);

            foreach (var frecuencia in relativas)
            {
                var absoluta = frecuencia * TamañoMuestra;

                absolutas.Add(absoluta);
            }

            FrecuenciasEsperadasAbsolutas = absolutas;
            FrecuenciasEsperadasRelativas = relativas;
        }

        private void CalcularValoresChiCuadrado()
        {
            var chiCuadrado = new List<double>();

            for (var i = 0; i < CantidadIntervalos; i++)
            {
                var observada = FrecuenciasObservadasAbsolutas[i];
                var esperada = FrecuenciasEsperadasAbsolutas[i];

                var valor = ChiCuadrado.Calcular(observada, esperada);

                chiCuadrado.Add(valor);
            }

            ValoresChiCuadrado = chiCuadrado;
        }

        public void ObtenerValorDeTablaChiCuadrado()
        {
            var grados = CantidadIntervalos - Distribucion.CantidadParametros() - 1;

            var valor = ChiCuadrado.ValorDeTabla(grados, Alfa);

            TablaChiCuadrado = valor;
        }
    }
}
