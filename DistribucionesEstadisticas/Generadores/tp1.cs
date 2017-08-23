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
        private IDistribucion _distribucion;
        private GestorEstadistico _gestor;
        private const int Decimales = 3;

        public Tp1()
        {
            var culture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            InitializeComponent();
            btn_compro.Enabled = false;
            txt_semillaA.Focus();
        }

        private bool FormularioValido()
        {
            var generador = FormularioValidoGenerador();
            var distribucion = FormularioValidoDistribucion();

            return generador && distribucion;
        }

        private bool FormularioValidoGenerador()
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

        private bool FormularioValidoDistribucion()
        {
            int muestra;
            int intervalos;
            double alfa;

            if (!int.TryParse(txt_cant_nroC.Text, out muestra)
                || muestra <= 0)
            {
                MessageBox.Show(@"El tamaño de la muestra debe ser un entero positivo");
                txt_cant_nroC.Focus();
                return false;
            }

            if (!int.TryParse(txt_IntC.Text, out intervalos)
                || intervalos <= 0)
            {
                MessageBox.Show(@"La cantidad de intervalos debe ser un entero positivo");
                txt_IntC.Focus();
                return false;
            }

            if (!double.TryParse(txt_chicierto.Text, out alfa)
                || alfa <= 0 || alfa >= 1)
            {
                MessageBox.Show(@"El valor de alfa debe estar entre 0 y 1");
                txt_chicierto.Focus();
                return false;
            }

            if (rad_uniforme.Checked)
            {
                double a;
                double b;

                if (!double.TryParse(txt_a.Text, out a))
                {
                    MessageBox.Show(@"El valor de A debe ser un número válido");
                    txt_a.Focus();
                    return false;
                }

                if (!double.TryParse(txt_b.Text, out b) || b <= a)
                {
                    MessageBox.Show(@"El valor de B debe ser mayor que A");
                    txt_b.Focus();
                    return false;
                }
            }

            if (rad_normal.Checked)
            {
                double media;
                double varianza;

                if (!double.TryParse(txt_media.Text, out media))
                {
                    MessageBox.Show(@"La Media debe ser un número válido");
                    txt_media.Focus();
                    return false;
                }

                if (!double.TryParse(txt_varianza.Text, out varianza) || varianza < 0)
                {
                    MessageBox.Show(@"La Varianza no puede ser negativa");
                    txt_varianza.Focus();
                    return false;
                }
            }

            if (rad_exponencial.Checked)
            {
                double lambda;

                if (!double.TryParse(txt_lambda.Text, out lambda) || lambda <= 0)
                {
                    MessageBox.Show(@"La Varianza debe ser positiva");
                    txt_lambda.Focus();
                    return false;
                }
            }

            return true;
        }

        private void LimpiarDatosGenerador()
        {
            txt_semillaA.Text = "";
            txt_aA.Text = "";
            txt_cA.Text = "";
            txt_mA.Text = "";
        }

        private void LimpiarDatosDistribucion()
        {
            txt_a.Text = "";
            txt_b.Text = "";
            txt_media.Text = "";
            txt_varianza.Text = "";
            txt_lambda.Text = "";
        }

        private void LimpiarTablas()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            histogramaGenerado.Series.Clear();

            lbl_chi_cu.Text = "";
            lblFrecuenciaEsperada.Text = "";
            txt_chicierto.Text = @"0.05";

            btn_compro.Enabled = false;
        }

        private void HabilitarGeneracion()
        {
            var generador = radioButton1.Checked || radioButton2.Checked || radioButton3.Checked;
            var distribucion = rad_uniforme.Checked || rad_normal.Checked || rad_exponencial.Checked;

            btn_PuntoC.Enabled = generador && distribucion;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_semillaA.Enabled = true;
            txt_aA.Enabled = true;
            txt_cA.Enabled = true;
            txt_mA.Enabled = true;
            LimpiarDatosGenerador();
            txt_semillaA.Focus();
            HabilitarGeneracion();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_semillaA.Enabled = true;
            txt_aA.Enabled = true;
            txt_cA.Enabled = false;
            txt_mA.Enabled = true;
            LimpiarDatosGenerador();
            txt_semillaA.Focus();
            HabilitarGeneracion();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txt_semillaA.Enabled = false;
            txt_aA.Enabled = false;
            txt_cA.Enabled = false;
            txt_mA.Enabled = false;
            LimpiarDatosGenerador();
            HabilitarGeneracion();
        }

        private void rad_uniforme_CheckedChanged(object sender, EventArgs e)
        {
            txt_a.Enabled = true;
            txt_b.Enabled = true;
            txt_media.Enabled = false;
            txt_varianza.Enabled = false;
            txt_lambda.Enabled = false;
            LimpiarDatosDistribucion();
            txt_a.Focus();
            HabilitarGeneracion();
        }

        private void rad_normal_CheckedChanged(object sender, EventArgs e)
        {
            txt_a.Enabled = false;
            txt_b.Enabled = false;
            txt_media.Enabled = true;
            txt_varianza.Enabled = true;
            txt_lambda.Enabled = false;
            LimpiarDatosDistribucion();
            txt_media.Focus();
            HabilitarGeneracion();
        }

        private void rad_exponencial_CheckedChanged(object sender, EventArgs e)
        {
            txt_a.Enabled = false;
            txt_b.Enabled = false;
            txt_media.Enabled = false;
            txt_varianza.Enabled = false;
            txt_lambda.Enabled = true;
            LimpiarDatosDistribucion();
            txt_lambda.Focus();
            HabilitarGeneracion();
        }

        private void btn_PuntoC_Click(object sender, EventArgs e)
        {
            if (FormularioValido())
                GenerarNumeros();
        }

        public void GenerarNumeros()
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

            if (rad_uniforme.Checked)
            {
                var a = double.Parse(txt_a.Text);
                var b = double.Parse(txt_b.Text);

                _distribucion = new DistribucionUniforme(a, b, _generadorAleatorio);
            }

            if (rad_normal.Checked)
            {
                var media = double.Parse(txt_media.Text);
                var varianza = double.Parse(txt_varianza.Text);

                _distribucion = new DistribucionNormal(media, varianza, _generadorAleatorio);
            }

            if (rad_exponencial.Checked)
            {
                var lambda = double.Parse(txt_lambda.Text);

                _distribucion = new DistribucionExponencialNegativa(lambda, _generadorAleatorio);
            }

            var tamañoMuestra = int.Parse(txt_cant_nroC.Text);
            var cantidadIntervalos = int.Parse(txt_IntC.Text);
            var alfa = double.Parse(txt_chicierto.Text);

            try
            {
                _gestor = new GestorEstadistico(_distribucion, tamañoMuestra, cantidadIntervalos, alfa);
            }
            catch (Exception)
            {
                var grados = int.Parse(txt_IntC.Text) - _distribucion.CantidadParametros() - 1;

                MessageBox.Show(grados <= 0
                    ? @"Grados de libertad insuficientes, utilice más intervalos"
                    : @"Falla la prueba de Chi Cuadrado porque las frecuencias esperadas tienden a cero, utilice menos intervalos");

                txt_mA.Focus();
                return;
            }

            for (var i = 0; i < tamañoMuestra; i++)
            {
                var valor = _gestor.Valores[i];

                dataGridView1.Rows.Add(i + 1, valor);
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

            dataGridView2.Rows.Add(
                "Totales",
                _gestor.FrecuenciasObservadasAbsolutas.Sum(),
                _gestor.FrecuenciasEsperadasAbsolutas.Sum(),
                _gestor.FrecuenciasObservadasRelativas.Sum(),
                _gestor.FrecuenciasEsperadasRelativas.Sum(),
                _gestor.ValoresChiCuadrado.Sum()
            );

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