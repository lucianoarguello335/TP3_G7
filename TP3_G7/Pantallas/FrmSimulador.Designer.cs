namespace TP3_G7.Pantallas
{
    partial class FrmSimulador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.CmbMetodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCantNums = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCotaSup = new System.Windows.Forms.TextBox();
            this.TxtCotaInf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtMedia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDesv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtLambda = new System.Windows.Forms.TextBox();
            this.ChrtFrecuencias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblGrillaValores = new System.Windows.Forms.Label();
            this.lblDistribucionFrecuencias = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiCuad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.TxtNivelConfianza = new System.Windows.Forms.TextBox();
            this.txtResultadoChi = new System.Windows.Forms.TextBox();
            this.TxtValorTabla = new System.Windows.Forms.TextBox();
            this.TxtSumatoriaChi = new System.Windows.Forms.TextBox();
            this.BtnVerificacion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtFrecuencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbMetodo
            // 
            this.CmbMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMetodo.FormattingEnabled = true;
            this.CmbMetodo.Items.AddRange(new object[] {
            "Uniforme",
            "Exponencial Negativa",
            "Normal",
            "Poisson"});
            this.CmbMetodo.Location = new System.Drawing.Point(160, 354);
            this.CmbMetodo.Name = "CmbMetodo";
            this.CmbMetodo.Size = new System.Drawing.Size(126, 21);
            this.CmbMetodo.TabIndex = 1;
            this.CmbMetodo.SelectedValueChanged += new System.EventHandler(this.CmbMetodo_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(301, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indicar cantidad de números e intervalos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccionar un método";
            // 
            // TxtCantNums
            // 
            this.TxtCantNums.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtCantNums.Location = new System.Drawing.Point(553, 354);
            this.TxtCantNums.Mask = "000000000000000";
            this.TxtCantNums.Name = "TxtCantNums";
            this.TxtCantNums.Size = new System.Drawing.Size(102, 25);
            this.TxtCantNums.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(661, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 35);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(111, 15);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 19);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "20";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(74, 15);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 19);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "15";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(37, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "10";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(5, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "5";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parámetros (según corresponda)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cota superior (b)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cota inferior (a)";
            // 
            // TxtCotaSup
            // 
            this.TxtCotaSup.Enabled = false;
            this.TxtCotaSup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtCotaSup.Location = new System.Drawing.Point(126, 439);
            this.TxtCotaSup.Name = "TxtCotaSup";
            this.TxtCotaSup.Size = new System.Drawing.Size(86, 25);
            this.TxtCotaSup.TabIndex = 5;
            // 
            // TxtCotaInf
            // 
            this.TxtCotaInf.Enabled = false;
            this.TxtCotaInf.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TxtCotaInf.Location = new System.Drawing.Point(126, 412);
            this.TxtCotaInf.Name = "TxtCotaInf";
            this.TxtCotaInf.Size = new System.Drawing.Size(86, 25);
            this.TxtCotaInf.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(218, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Media";
            // 
            // TxtMedia
            // 
            this.TxtMedia.Enabled = false;
            this.TxtMedia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtMedia.Location = new System.Drawing.Point(294, 412);
            this.TxtMedia.Name = "TxtMedia";
            this.TxtMedia.Size = new System.Drawing.Size(86, 25);
            this.TxtMedia.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label7.Location = new System.Drawing.Point(218, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Desviación";
            // 
            // TxtDesv
            // 
            this.TxtDesv.Enabled = false;
            this.TxtDesv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtDesv.Location = new System.Drawing.Point(294, 439);
            this.TxtDesv.Name = "TxtDesv";
            this.TxtDesv.Size = new System.Drawing.Size(86, 25);
            this.TxtDesv.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label8.Location = new System.Drawing.Point(386, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lambda";
            // 
            // TxtLambda
            // 
            this.TxtLambda.Enabled = false;
            this.TxtLambda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TxtLambda.Location = new System.Drawing.Point(447, 412);
            this.TxtLambda.Name = "TxtLambda";
            this.TxtLambda.Size = new System.Drawing.Size(86, 25);
            this.TxtLambda.TabIndex = 5;
            // 
            // ChrtFrecuencias
            // 
            this.ChrtFrecuencias.BackColor = System.Drawing.Color.Bisque;
            this.ChrtFrecuencias.BorderlineColor = System.Drawing.Color.Black;
            this.ChrtFrecuencias.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.ChrtFrecuencias.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.ChrtFrecuencias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChrtFrecuencias.Legends.Add(legend1);
            this.ChrtFrecuencias.Location = new System.Drawing.Point(12, 29);
            this.ChrtFrecuencias.Name = "ChrtFrecuencias";
            this.ChrtFrecuencias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChrtFrecuencias.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Tomato,
        System.Drawing.Color.Gold};
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "FE";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "FO";
            this.ChrtFrecuencias.Series.Add(series1);
            this.ChrtFrecuencias.Series.Add(series2);
            this.ChrtFrecuencias.Size = new System.Drawing.Size(535, 300);
            this.ChrtFrecuencias.TabIndex = 6;
            this.ChrtFrecuencias.Text = "ChrtFrecuencias";
            title1.BackColor = System.Drawing.Color.Bisque;
            title1.BorderColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Titulo";
            title1.Text = "Gráfico de frecuencias";
            title2.BackColor = System.Drawing.Color.Bisque;
            title2.BorderColor = System.Drawing.Color.Transparent;
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "Valores";
            title2.Text = "Valores";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title3.Name = "Intervalos";
            title3.Text = "Intervalos";
            this.ChrtFrecuencias.Titles.Add(title1);
            this.ChrtFrecuencias.Titles.Add(title2);
            this.ChrtFrecuencias.Titles.Add(title3);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(554, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(181, 299);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intervalo,
            this.FrecEsperada,
            this.FrecObs,
            this.ChiCuad});
            this.dataGridView2.Location = new System.Drawing.Point(741, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(418, 299);
            this.dataGridView2.TabIndex = 8;
            // 
            // lblGrillaValores
            // 
            this.lblGrillaValores.AutoSize = true;
            this.lblGrillaValores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrillaValores.Location = new System.Drawing.Point(578, 7);
            this.lblGrillaValores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrillaValores.Name = "lblGrillaValores";
            this.lblGrillaValores.Size = new System.Drawing.Size(137, 20);
            this.lblGrillaValores.TabIndex = 18;
            this.lblGrillaValores.Text = "Valores generados";
            // 
            // lblDistribucionFrecuencias
            // 
            this.lblDistribucionFrecuencias.AutoSize = true;
            this.lblDistribucionFrecuencias.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistribucionFrecuencias.Location = new System.Drawing.Point(803, 7);
            this.lblDistribucionFrecuencias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistribucionFrecuencias.Name = "lblDistribucionFrecuencias";
            this.lblDistribucionFrecuencias.Size = new System.Drawing.Size(177, 20);
            this.lblDistribucionFrecuencias.TabIndex = 25;
            this.lblDistribucionFrecuencias.Text = "Distribución frecuencias";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "#";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Numero.Width = 40;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Intervalo
            // 
            this.Intervalo.HeaderText = "Intervalo";
            this.Intervalo.Name = "Intervalo";
            this.Intervalo.ReadOnly = true;
            this.Intervalo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrecEsperada
            // 
            this.FrecEsperada.HeaderText = "Frec. Esp.";
            this.FrecEsperada.Name = "FrecEsperada";
            this.FrecEsperada.ReadOnly = true;
            this.FrecEsperada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrecObs
            // 
            this.FrecObs.HeaderText = "Frec. Obs.";
            this.FrecObs.Name = "FrecObs";
            this.FrecObs.ReadOnly = true;
            this.FrecObs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ChiCuad
            // 
            this.ChiCuad.HeaderText = "Chi. Cuad.";
            this.ChiCuad.Name = "ChiCuad";
            this.ChiCuad.ReadOnly = true;
            this.ChiCuad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(582, 447);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(162, 26);
            this.BtnLimpiar.TabIndex = 27;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.Location = new System.Drawing.Point(582, 399);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(162, 44);
            this.BtnGenerar.TabIndex = 26;
            this.BtnGenerar.Text = "GENERAR DISTRIBUCIÓN";
            this.BtnGenerar.UseVisualStyleBackColor = true;
            // 
            // TxtNivelConfianza
            // 
            this.TxtNivelConfianza.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNivelConfianza.Location = new System.Drawing.Point(1026, 344);
            this.TxtNivelConfianza.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNivelConfianza.MaxLength = 8;
            this.TxtNivelConfianza.Name = "TxtNivelConfianza";
            this.TxtNivelConfianza.Size = new System.Drawing.Size(121, 25);
            this.TxtNivelConfianza.TabIndex = 35;
            this.TxtNivelConfianza.Text = "0.05";
            // 
            // txtResultadoChi
            // 
            this.txtResultadoChi.Enabled = false;
            this.txtResultadoChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultadoChi.Location = new System.Drawing.Point(1026, 460);
            this.txtResultadoChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultadoChi.Name = "txtResultadoChi";
            this.txtResultadoChi.Size = new System.Drawing.Size(121, 25);
            this.txtResultadoChi.TabIndex = 40;
            // 
            // TxtValorTabla
            // 
            this.TxtValorTabla.Enabled = false;
            this.TxtValorTabla.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTabla.Location = new System.Drawing.Point(1026, 402);
            this.TxtValorTabla.Margin = new System.Windows.Forms.Padding(2);
            this.TxtValorTabla.Name = "TxtValorTabla";
            this.TxtValorTabla.Size = new System.Drawing.Size(121, 25);
            this.TxtValorTabla.TabIndex = 41;
            // 
            // TxtSumatoriaChi
            // 
            this.TxtSumatoriaChi.Enabled = false;
            this.TxtSumatoriaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSumatoriaChi.Location = new System.Drawing.Point(1026, 373);
            this.TxtSumatoriaChi.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSumatoriaChi.Name = "TxtSumatoriaChi";
            this.TxtSumatoriaChi.Size = new System.Drawing.Size(121, 25);
            this.TxtSumatoriaChi.TabIndex = 38;
            // 
            // BtnVerificacion
            // 
            this.BtnVerificacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificacion.Location = new System.Drawing.Point(1026, 429);
            this.BtnVerificacion.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVerificacion.Name = "BtnVerificacion";
            this.BtnVerificacion.Size = new System.Drawing.Size(121, 27);
            this.BtnVerificacion.TabIndex = 36;
            this.BtnVerificacion.Text = "VERIFICAR";
            this.BtnVerificacion.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label9.Location = new System.Drawing.Point(906, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "Nivel de confianza";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label10.Location = new System.Drawing.Point(870, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Sumatoria Chi Cuadrado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label11.Location = new System.Drawing.Point(866, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Valor tabla Chi Cuadrado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label12.Location = new System.Drawing.Point(955, 463);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Resultado";
            // 
            // FrmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1171, 496);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtNivelConfianza);
            this.Controls.Add(this.txtResultadoChi);
            this.Controls.Add(this.TxtValorTabla);
            this.Controls.Add(this.TxtSumatoriaChi);
            this.Controls.Add(this.BtnVerificacion);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.lblDistribucionFrecuencias);
            this.Controls.Add(this.lblGrillaValores);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChrtFrecuencias);
            this.Controls.Add(this.TxtLambda);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDesv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtMedia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCotaInf);
            this.Controls.Add(this.TxtCotaSup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtCantNums);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbMetodo);
            this.Name = "FrmSimulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.FrmSimulador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtFrecuencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbMetodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtCantNums;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCotaSup;
        private System.Windows.Forms.TextBox TxtCotaInf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtMedia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDesv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtLambda;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtFrecuencias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblGrillaValores;
        private System.Windows.Forms.Label lblDistribucionFrecuencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiCuad;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.TextBox TxtNivelConfianza;
        private System.Windows.Forms.TextBox txtResultadoChi;
        private System.Windows.Forms.TextBox TxtValorTabla;
        private System.Windows.Forms.TextBox TxtSumatoriaChi;
        private System.Windows.Forms.Button BtnVerificacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}