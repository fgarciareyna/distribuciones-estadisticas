using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using NumerosAleatorios;
using NumerosAleatorios.NumerosAleatorios;
using NumerosAleatorios.VariablesAleatorias;

namespace Generadores
{
    public partial class Tp1 : Form
    {
        private IGeneradorNumerosAleatorios _generadorAleatorio;
        private GestorEstadistico _gestor;
        private const int TamañoMuestra = 20;
        private const int Cifras = 4;
        private const int Decimales = 3;
        private int _ord;

        public Tp1()
        {
            var culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            InitializeComponent();
            btn_compro.Enabled = false;
            txt_semillaA.Focus();
        }

        ////////////////     Punto A     ////////////////

        private void btn_PuntoA_Click(object sender, EventArgs e)
        {
            if (FormularioValidoA())
            {
                GenerarNumerosA();
            }
        }

        private bool FormularioValidoA()
        {
            if (radioButton3.Checked)
                return true;

            int semilla;
            int a;
            int c;
            int m;

            if (!int.TryParse(txt_mA.Text, out m) ||
                m <= 0)
            {
                MessageBox.Show(@"El valor de M debe ser un entero positivo");
                txt_mA.Focus();
                return false;
            }

            if (!int.TryParse(txt_semillaA.Text, out semilla) ||
                semilla <= 0 || semilla >= m)
            {
                MessageBox.Show(@"El valor de semilla debe ser un entero positivo menor a M");
                txt_semillaA.Focus();
                return false;
            }

            if (!int.TryParse(txt_aA.Text, out a) ||
                a <= 0 || a >= m)
            {
                MessageBox.Show(@"El valor de A debe ser un entero positivo menor a M");
                txt_aA.Focus();
                return false;
            }

            if (radioButton1.Checked && (!int.TryParse(txt_cA.Text, out c) ||
                c <= 0 || c >= m))
            {
                MessageBox.Show(@"El valor de C debe ser un entero positivo menor a M");
                txt_cA.Focus();
                return false;
            }

            return true;
        }

        public void GenerarNumerosA()
        {
            LimpiarTablas();

            if (radioButton3.Checked)
            {
                _generadorAleatorio = new GeneradorDelSistema();
            }

            else
            {
                var a = int.Parse(txt_aA.Text);
                var m = int.Parse(txt_mA.Text);
                var semilla = double.Parse(txt_semillaA.Text);

                //Congruencial Multiplicativo : Xn = (A * Xn-1 ) Mod M
                if (radioButton2.Checked)
                {
                    _generadorAleatorio = new CongruencialMultiplicativo(semilla, a, m);
                }

                //Congruencial Mixto : Xn = (A * Xn-1 + C ) Mod M
                else if (radioButton1.Checked)
                {
                    var c = int.Parse(txt_cA.Text);
                    _generadorAleatorio = new CongruencialMixto(semilla, a, c, m);
                }
            }

            for (var i = 0; i < TamañoMuestra; i++)
            {
                var aleatorio = _generadorAleatorio.Generar(Cifras);
                _ord++;
                dataGridView1.Rows.Add(_ord, aleatorio);
            }
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            var aleatorio = _generadorAleatorio.Generar(Cifras);
            _ord++;
            dataGridView1.Rows.Add(_ord, aleatorio);
        }

        private void LimpiarDatosA()
        {
            txt_semillaA.Text = "";
            txt_aA.Text = "";
            txt_cA.Text = "";
            txt_mA.Text = "";
            btn_siguiente.Enabled = false;
            btn_PuntoA.Enabled = true;
        }

        private void LimpiarTablas()
        {
            _ord = 0;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            histogramaGenerado.Series.Clear();

            lbl_chi_cu.Text = "";
            lblFrecuenciaEsperada.Text = "";

            btn_compro.Enabled = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_semillaA.Enabled = true;
            txt_aA.Enabled = true;
            txt_cA.Enabled = true;
            txt_mA.Enabled = true;
            btn_siguiente.Enabled = false;
            LimpiarDatosA();
            txt_semillaA.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_semillaA.Enabled = true;
            txt_aA.Enabled = true;
            txt_cA.Enabled = false;
            txt_mA.Enabled = true;
            btn_siguiente.Enabled = false;
            LimpiarDatosA();
            txt_semillaA.Focus();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txt_semillaA.Enabled = false;
            txt_aA.Enabled = false;
            txt_cA.Enabled = false;
            txt_mA.Enabled = false;
        }

        ////////////////     Punto B     ////////////////

        private void btn_PuntoB_Click(object sender, EventArgs e)
        {
            if (FormularioValidoB())
            {
                GenerarNumerosB();
            }
        }

        private bool FormularioValidoB()
        {
            int muestra;
            int intervalos;
            double alfa;

            if (!int.TryParse(txt_Cant_nroB.Text, out muestra)
                || muestra <= 0)
            {
                MessageBox.Show(@"El tamaño de la muestra debe ser un entero positivo");
                txt_Cant_nroB.Focus();
                return false;
            }

            if (!int.TryParse(txt_IntB.Text, out intervalos)
                || intervalos <= 0)
            {
                MessageBox.Show(@"La cantidad de intervalos debe ser un entero positivo");
                txt_IntB.Focus();
                return false;
            }

            if (!double.TryParse(txt_chicierto.Text, out alfa)
                || alfa <= 0 || alfa >= 1)
            {
                MessageBox.Show(@"El valor de alfa debe estar entre 0 y 1");
                txt_chicierto.Focus();
                return false;
            }

            return true;
        }

        public void GenerarNumerosB()
        {
            LimpiarTablas();

            var tamañoMuestra = int.Parse(txt_Cant_nroB.Text);
            var cantidadIntervalos = int.Parse(txt_IntB.Text);
            var alfa = double.Parse(txt_chicierto.Text);

            var distribucion = new DistribucionUniforme(0, 1);
            _gestor = new GestorEstadistico(distribucion, tamañoMuestra, cantidadIntervalos, alfa);

            foreach (var valor in _gestor.Valores)
            {
                _ord++;
                dataGridView1.Rows.Add(_ord, valor);
            }

            AgregarValoresTabla();
            CargarHistograma();
        }

        ////////////////     Punto C     ////////////////

        private void btn_PuntoC_Click(object sender, EventArgs e)
        {
            if (FormularioValidoC())
            {
                GenerarNumerosC();
            }
        }

        private bool FormularioValidoC()
        {
            int muestra;
            int intervalos;
            double alfa;

            if (!int.TryParse(txt_cant_nroC.Text, out muestra)
                || muestra <= 0)
            {
                MessageBox.Show(@"El tamaño de la muestra debe ser un entero positivo");
                txt_Cant_nroB.Focus();
                return false;
            }

            if (!int.TryParse(txt_IntC.Text, out intervalos)
                || intervalos <= 0)
            {
                MessageBox.Show(@"La cantidad de intervalos debe ser un entero positivo");
                txt_IntB.Focus();
                return false;
            }

            if (!double.TryParse(txt_chicierto.Text, out alfa)
                || alfa <= 0 || alfa >= 1)
            {
                MessageBox.Show(@"El valor de alfa debe estar entre 0 y 1");
                txt_chicierto.Focus();
                return false;
            }

            int semilla;
            int a;
            int c;
            int m;

            if (!int.TryParse(txt_mC.Text, out m) ||
                m <= 0)
            {
                MessageBox.Show(@"El valor de M debe ser un entero positivo");
                txt_mA.Focus();
                return false;
            }

            if (!int.TryParse(txt_semillaC.Text, out semilla) ||
                semilla <= 0 || semilla >= m)
            {
                MessageBox.Show(@"El valor de semilla debe ser un entero positivo menor a M");
                txt_semillaA.Focus();
                return false;
            }

            if (!int.TryParse(txt_aC.Text, out a) ||
                a <= 0 || a >= m)
            {
                MessageBox.Show(@"El valor de A debe ser un entero positivo menor a M");
                txt_aA.Focus();
                return false;
            }

            if (radioButton1.Checked && (!int.TryParse(txt_cC.Text, out c) ||
                c <= 0 || c >= m))
            {
                MessageBox.Show(@"El valor de C debe ser un entero positivo menor a M");
                txt_cA.Focus();
                return false;
            }

            return true;
        }

        public void GenerarNumerosC()
        {
            //Congruencial Mixto : Xn = (A * Xn-1 + C ) Mod M
            LimpiarTablas();

            var c = int.Parse(txt_cC.Text);
            var a = int.Parse(txt_aC.Text);
            var m = int.Parse(txt_mC.Text);
            var semilla = double.Parse(txt_semillaC.Text);

            _generadorAleatorio = new CongruencialMixto(semilla, a, c, m);

            var tamañoMuestra = int.Parse(txt_cant_nroC.Text);
            var cantidadIntervalos = int.Parse(txt_IntC.Text);
            var alfa = double.Parse(txt_chicierto.Text);

            var distribucion = new DistribucionUniforme(0, 1, _generadorAleatorio);
            _gestor = new GestorEstadistico(distribucion, tamañoMuestra, cantidadIntervalos, alfa);

            foreach (var valor in _gestor.Valores)
            {
                _ord++;
                dataGridView1.Rows.Add(_ord, valor);
            }

            AgregarValoresTabla();
            CargarHistograma();
        }

        private void AgregarValoresTabla()
        {
            for (var i = 0; i < _gestor.CantidadIntervalos; i++)
            {
                var subint = $"{decimal.Round((decimal)_gestor.Intervalos[i].Inicio, Decimales)} - " +
                             $"{decimal.Round((decimal)_gestor.Intervalos[i].Fin, Decimales)}";
                var freObs = _gestor.FrecuenciasObservadasAbsolutas[i];
                var freEsp = decimal.Round((decimal)_gestor.FrecuenciasEsperadasAbsolutas[i], Decimales);
                var freObsRel = decimal.Round((decimal)_gestor.FrecuenciasObservadasRelativas[i], Decimales);
                var freEspRel = decimal.Round((decimal)_gestor.FrecuenciasEsperadasRelativas[i], Decimales);
                var chiCuad = decimal.Round((decimal)_gestor.ValoresChiCuadrado[i], Decimales);

                dataGridView2.Rows.Add(subint, freObs, freEsp, freObsRel, freEspRel, chiCuad);
            }

            lbl_chi_cu.Text = decimal.Round((decimal)_gestor.ValoresChiCuadrado.Sum(), Decimales)
                .ToString(CultureInfo.InvariantCulture);

            lblFrecuenciaEsperada.Text = decimal.Round((decimal) _gestor.TablaChiCuadrado, Decimales)
                .ToString(CultureInfo.InvariantCulture);

            btn_compro.Enabled = true;
        }

        private void CargarHistograma()
        {
            histogramaGenerado.Series.Add("Frecuecias Observadas");
            histogramaGenerado.Series.Add("Frecuecias Esperadas");

            for (var i = 0; i < _gestor.CantidadIntervalos; i++)
            {
                histogramaGenerado.Series[0].Points.Add(_gestor.FrecuenciasObservadasAbsolutas[i]);
                histogramaGenerado.Series[1].Points.Add(
                    (double)decimal.Round((decimal)_gestor.FrecuenciasEsperadasAbsolutas[i], Decimales));
                histogramaGenerado.Series[0].Points[i].AxisLabel = 
                    $"[{decimal.Round((decimal)_gestor.Intervalos[i].Inicio, Decimales)} - " +
                    $"{decimal.Round((decimal)_gestor.Intervalos[i].Fin, Decimales)}]";
                histogramaGenerado.Series[0].IsValueShownAsLabel = true;
                histogramaGenerado.Series[1].IsValueShownAsLabel = true;
            }

            histogramaGenerado.ChartAreas[0].AxisY.Maximum = _gestor.FrecuenciasObservadasAbsolutas.Max();

            histogramaGenerado.Series[0].Color = Color.Blue;
            histogramaGenerado.Series[1].Color = Color.Red;
        }

        private void btn_compro_Click(object sender, EventArgs e)
        {
            var chiObtenido = _gestor.ValoresChiCuadrado.Sum();
            var chiEsperado = _gestor.TablaChiCuadrado;

            var mensaje = chiObtenido < chiEsperado 
                ? "Se acepta la hipótesis" 
                : "Se rechaza la hipótesis";

            MessageBox.Show(mensaje);
        }
    }
}