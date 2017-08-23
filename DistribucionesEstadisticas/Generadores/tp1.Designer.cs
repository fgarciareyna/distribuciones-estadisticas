namespace Generadores
{
    partial class Tp1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cA = new System.Windows.Forms.TextBox();
            this.txt_IntC = new System.Windows.Forms.TextBox();
            this.txt_cant_nroC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_mA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_aA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_semillaA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_PuntoC = new System.Windows.Forms.Button();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_varianza = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rad_exponencial = new System.Windows.Forms.RadioButton();
            this.rad_normal = new System.Windows.Forms.RadioButton();
            this.rad_uniforme = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frecuenciaEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORelativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FERelativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiCuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histogramaGenerado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_compro = new System.Windows.Forms.Button();
            this.txt_chicierto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbl_chi_cu = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblFrecuenciaEsperada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaGenerado)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.posicion,
            this.numero});
            this.dataGridView1.Location = new System.Drawing.Point(579, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(161, 320);
            this.dataGridView1.TabIndex = 4;
            // 
            // posicion
            // 
            this.posicion.HeaderText = "Posición";
            this.posicion.Name = "posicion";
            // 
            // numero
            // 
            this.numero.HeaderText = "Números";
            this.numero.Name = "numero";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(11, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(361, 320);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Números aleatorios: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cA);
            this.groupBox2.Controls.Add(this.txt_IntC);
            this.groupBox2.Controls.Add(this.txt_cant_nroC);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_mA);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_aA);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_semillaA);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 134);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(337, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros";
            // 
            // txt_cA
            // 
            this.txt_cA.Enabled = false;
            this.txt_cA.Location = new System.Drawing.Point(116, 86);
            this.txt_cA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cA.Name = "txt_cA";
            this.txt_cA.Size = new System.Drawing.Size(60, 19);
            this.txt_cA.TabIndex = 3;
            // 
            // txt_IntC
            // 
            this.txt_IntC.Location = new System.Drawing.Point(247, 54);
            this.txt_IntC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IntC.Name = "txt_IntC";
            this.txt_IntC.Size = new System.Drawing.Size(76, 19);
            this.txt_IntC.TabIndex = 12;
            // 
            // txt_cant_nroC
            // 
            this.txt_cant_nroC.Location = new System.Drawing.Point(247, 21);
            this.txt_cant_nroC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cant_nroC.Name = "txt_cant_nroC";
            this.txt_cant_nroC.Size = new System.Drawing.Size(76, 19);
            this.txt_cant_nroC.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(182, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Intervalos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sumatorio C:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(180, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Cant. Nro:";
            // 
            // txt_mA
            // 
            this.txt_mA.Enabled = false;
            this.txt_mA.Location = new System.Drawing.Point(116, 120);
            this.txt_mA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mA.Name = "txt_mA";
            this.txt_mA.Size = new System.Drawing.Size(60, 19);
            this.txt_mA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Divisor M:";
            // 
            // txt_aA
            // 
            this.txt_aA.Enabled = false;
            this.txt_aA.Location = new System.Drawing.Point(116, 54);
            this.txt_aA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_aA.Name = "txt_aA";
            this.txt_aA.Size = new System.Drawing.Size(60, 19);
            this.txt_aA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Multiplicativo A:";
            // 
            // txt_semillaA
            // 
            this.txt_semillaA.Enabled = false;
            this.txt_semillaA.Location = new System.Drawing.Point(116, 21);
            this.txt_semillaA.Margin = new System.Windows.Forms.Padding(2);
            this.txt_semillaA.Name = "txt_semillaA";
            this.txt_semillaA.Size = new System.Drawing.Size(60, 19);
            this.txt_semillaA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semilla:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(337, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generadores";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(11, 72);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(151, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Generador del sistema";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(11, 50);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(321, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Congruencial Multiplicativo - Xn = (A * Xn-1 ) Mod M";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 28);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(299, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Congruencial Mixto - Xn = (A * Xn-1 + C ) Mod M";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_PuntoC);
            this.groupBox5.Controls.Add(this.txt_lambda);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txt_varianza);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txt_media);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txt_b);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txt_a);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.rad_exponencial);
            this.groupBox5.Controls.Add(this.rad_normal);
            this.groupBox5.Controls.Add(this.rad_uniforme);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(389, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(175, 320);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Distribución: ";
            // 
            // btn_PuntoC
            // 
            this.btn_PuntoC.Enabled = false;
            this.btn_PuntoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PuntoC.Location = new System.Drawing.Point(84, 260);
            this.btn_PuntoC.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PuntoC.Name = "btn_PuntoC";
            this.btn_PuntoC.Size = new System.Drawing.Size(68, 36);
            this.btn_PuntoC.TabIndex = 7;
            this.btn_PuntoC.Text = "Generar ";
            this.btn_PuntoC.UseVisualStyleBackColor = true;
            this.btn_PuntoC.Click += new System.EventHandler(this.btn_PuntoC_Click);
            // 
            // txt_lambda
            // 
            this.txt_lambda.Enabled = false;
            this.txt_lambda.Location = new System.Drawing.Point(84, 211);
            this.txt_lambda.Margin = new System.Windows.Forms.Padding(2);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(76, 19);
            this.txt_lambda.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Lambda:";
            // 
            // txt_varianza
            // 
            this.txt_varianza.Enabled = false;
            this.txt_varianza.Location = new System.Drawing.Point(84, 188);
            this.txt_varianza.Margin = new System.Windows.Forms.Padding(2);
            this.txt_varianza.Name = "txt_varianza";
            this.txt_varianza.Size = new System.Drawing.Size(76, 19);
            this.txt_varianza.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Varianza:";
            // 
            // txt_media
            // 
            this.txt_media.Enabled = false;
            this.txt_media.Location = new System.Drawing.Point(84, 165);
            this.txt_media.Margin = new System.Windows.Forms.Padding(2);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(76, 19);
            this.txt_media.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Media:";
            // 
            // txt_b
            // 
            this.txt_b.Enabled = false;
            this.txt_b.Location = new System.Drawing.Point(84, 142);
            this.txt_b.Margin = new System.Windows.Forms.Padding(2);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(76, 19);
            this.txt_b.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "B:";
            // 
            // txt_a
            // 
            this.txt_a.Enabled = false;
            this.txt_a.Location = new System.Drawing.Point(84, 119);
            this.txt_a.Margin = new System.Windows.Forms.Padding(2);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(76, 19);
            this.txt_a.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "A:";
            // 
            // rad_exponencial
            // 
            this.rad_exponencial.AutoSize = true;
            this.rad_exponencial.Location = new System.Drawing.Point(20, 81);
            this.rad_exponencial.Margin = new System.Windows.Forms.Padding(2);
            this.rad_exponencial.Name = "rad_exponencial";
            this.rad_exponencial.Size = new System.Drawing.Size(140, 17);
            this.rad_exponencial.TabIndex = 5;
            this.rad_exponencial.Text = "Exponencial Inversa";
            this.rad_exponencial.UseVisualStyleBackColor = true;
            this.rad_exponencial.CheckedChanged += new System.EventHandler(this.rad_exponencial_CheckedChanged);
            // 
            // rad_normal
            // 
            this.rad_normal.AutoSize = true;
            this.rad_normal.Location = new System.Drawing.Point(20, 59);
            this.rad_normal.Margin = new System.Windows.Forms.Padding(2);
            this.rad_normal.Name = "rad_normal";
            this.rad_normal.Size = new System.Drawing.Size(64, 17);
            this.rad_normal.TabIndex = 4;
            this.rad_normal.Text = "Normal";
            this.rad_normal.UseVisualStyleBackColor = true;
            this.rad_normal.CheckedChanged += new System.EventHandler(this.rad_normal_CheckedChanged);
            // 
            // rad_uniforme
            // 
            this.rad_uniforme.AutoSize = true;
            this.rad_uniforme.Location = new System.Drawing.Point(20, 37);
            this.rad_uniforme.Margin = new System.Windows.Forms.Padding(2);
            this.rad_uniforme.Name = "rad_uniforme";
            this.rad_uniforme.Size = new System.Drawing.Size(75, 17);
            this.rad_uniforme.TabIndex = 3;
            this.rad_uniforme.Text = "Uniforme";
            this.rad_uniforme.UseVisualStyleBackColor = true;
            this.rad_uniforme.CheckedChanged += new System.EventHandler(this.rad_uniforme_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.frecuencia,
            this.frecuenciaEsp,
            this.FORelativa,
            this.FERelativa,
            this.ChiCuadrado});
            this.dataGridView2.Location = new System.Drawing.Point(744, 18);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(597, 207);
            this.dataGridView2.TabIndex = 37;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.Name = "intervalo";
            // 
            // frecuencia
            // 
            this.frecuencia.HeaderText = "Frecuencia Observada";
            this.frecuencia.Name = "frecuencia";
            // 
            // frecuenciaEsp
            // 
            this.frecuenciaEsp.HeaderText = "Frecuencia Esperada";
            this.frecuenciaEsp.Name = "frecuenciaEsp";
            // 
            // FORelativa
            // 
            this.FORelativa.HeaderText = "Frec Obs Relativa";
            this.FORelativa.Name = "FORelativa";
            // 
            // FERelativa
            // 
            this.FERelativa.HeaderText = "Frec Esp Relativa";
            this.FERelativa.Name = "FERelativa";
            // 
            // ChiCuadrado
            // 
            this.ChiCuadrado.HeaderText = "Prueba Chi Cuadrado";
            this.ChiCuadrado.Name = "ChiCuadrado";
            // 
            // histogramaGenerado
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.Title = "Intervalos";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.Title = "Frecuencia";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.histogramaGenerado.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.histogramaGenerado.Legends.Add(legend1);
            this.histogramaGenerado.Location = new System.Drawing.Point(14, 29);
            this.histogramaGenerado.Name = "histogramaGenerado";
            this.histogramaGenerado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histogramaGenerado.Series.Add(series1);
            this.histogramaGenerado.Size = new System.Drawing.Size(1279, 311);
            this.histogramaGenerado.TabIndex = 36;
            this.histogramaGenerado.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.histogramaGenerado);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 354);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(1330, 365);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfico";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btn_compro);
            this.groupBox7.Controls.Add(this.txt_chicierto);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(1068, 254);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(273, 56);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hipótesis";
            // 
            // btn_compro
            // 
            this.btn_compro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compro.Location = new System.Drawing.Point(168, 16);
            this.btn_compro.Margin = new System.Windows.Forms.Padding(2);
            this.btn_compro.Name = "btn_compro";
            this.btn_compro.Size = new System.Drawing.Size(80, 30);
            this.btn_compro.TabIndex = 35;
            this.btn_compro.Text = "Comprobar";
            this.btn_compro.UseVisualStyleBackColor = true;
            this.btn_compro.Click += new System.EventHandler(this.btn_compro_Click);
            // 
            // txt_chicierto
            // 
            this.txt_chicierto.Location = new System.Drawing.Point(83, 21);
            this.txt_chicierto.Margin = new System.Windows.Forms.Padding(2);
            this.txt_chicierto.Name = "txt_chicierto";
            this.txt_chicierto.Size = new System.Drawing.Size(60, 19);
            this.txt_chicierto.TabIndex = 35;
            this.txt_chicierto.Text = "0.05";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ingrese Alfa";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbl_chi_cu);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(906, 254);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(158, 54);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Chi Cuadrado Observado";
            // 
            // lbl_chi_cu
            // 
            this.lbl_chi_cu.AutoSize = true;
            this.lbl_chi_cu.Location = new System.Drawing.Point(11, 33);
            this.lbl_chi_cu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_chi_cu.Name = "lbl_chi_cu";
            this.lbl_chi_cu.Size = new System.Drawing.Size(0, 13);
            this.lbl_chi_cu.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblFrecuenciaEsperada);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(744, 254);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(158, 54);
            this.groupBox9.TabIndex = 38;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Chi Cuadrado Esperado";
            // 
            // lblFrecuenciaEsperada
            // 
            this.lblFrecuenciaEsperada.AutoSize = true;
            this.lblFrecuenciaEsperada.Location = new System.Drawing.Point(23, 32);
            this.lblFrecuenciaEsperada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrecuenciaEsperada.Name = "lblFrecuenciaEsperada";
            this.lblFrecuenciaEsperada.Size = new System.Drawing.Size(0, 13);
            this.lblFrecuenciaEsperada.TabIndex = 0;
            // 
            // Tp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 730);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tp1";
            this.Text = "Practico N°3 - De Franceschi Andrea 62127 - García Majorel Álvaro 61856 - García " +
    "Reyna Facundo 63583 - Oliveda Claudio 49594 - Varela Sofía 65126";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramaGenerado)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_aA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_semillaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_PuntoC;
        private System.Windows.Forms.TextBox txt_cant_nroC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_IntC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart histogramaGenerado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btn_compro;
        private System.Windows.Forms.TextBox txt_chicierto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lbl_chi_cu;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lblFrecuenciaEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn frecuenciaEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORelativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn FERelativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiCuadrado;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.RadioButton rad_exponencial;
        private System.Windows.Forms.RadioButton rad_normal;
        private System.Windows.Forms.RadioButton rad_uniforme;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_varianza;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label7;
    }
}

