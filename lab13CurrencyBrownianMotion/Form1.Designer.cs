namespace lab13CurrencyBrownianMotion
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btStop = new System.Windows.Forms.Button();
            this.edPriceDollar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.edPriceEuro = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.edSigmaEuro = new System.Windows.Forms.NumericUpDown();
            this.edSigmaDollar = new System.Windows.Forms.NumericUpDown();
            this.edMuEuro = new System.Windows.Forms.NumericUpDown();
            this.edMuDollar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPriceDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPriceEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSigmaEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSigmaDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMuEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMuDollar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.edMuDollar);
            this.panel1.Controls.Add(this.edMuEuro);
            this.panel1.Controls.Add(this.edSigmaDollar);
            this.panel1.Controls.Add(this.edSigmaEuro);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.edPriceDollar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edPriceEuro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 177);
            this.panel1.TabIndex = 0;
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(684, 40);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(96, 23);
            this.btStop.TabIndex = 8;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // edPriceDollar
            // 
            this.edPriceDollar.DecimalPlaces = 2;
            this.edPriceDollar.Location = new System.Drawing.Point(302, 41);
            this.edPriceDollar.Name = "edPriceDollar";
            this.edPriceDollar.Size = new System.Drawing.Size(98, 22);
            this.edPriceDollar.TabIndex = 7;
            this.edPriceDollar.Value = new decimal(new int[] {
            9201,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Доллар";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(534, 40);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(114, 23);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edPriceEuro
            // 
            this.edPriceEuro.DecimalPlaces = 2;
            this.edPriceEuro.Location = new System.Drawing.Point(188, 41);
            this.edPriceEuro.Name = "edPriceEuro";
            this.edPriceEuro.Size = new System.Drawing.Size(98, 22);
            this.edPriceEuro.TabIndex = 4;
            this.edPriceEuro.Value = new decimal(new int[] {
            9964,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Евро";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная стоимость:";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Minimum = 50D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 177);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "c";
            series1.Legend = "Legend1";
            series1.Name = "Курс Евро";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "c";
            series2.Legend = "Legend1";
            series2.Name = "Курс Доллара";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(903, 383);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // edSigmaEuro
            // 
            this.edSigmaEuro.DecimalPlaces = 3;
            this.edSigmaEuro.Location = new System.Drawing.Point(188, 85);
            this.edSigmaEuro.Name = "edSigmaEuro";
            this.edSigmaEuro.Size = new System.Drawing.Size(98, 22);
            this.edSigmaEuro.TabIndex = 9;
            this.edSigmaEuro.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            // 
            // edSigmaDollar
            // 
            this.edSigmaDollar.DecimalPlaces = 3;
            this.edSigmaDollar.Location = new System.Drawing.Point(302, 85);
            this.edSigmaDollar.Name = "edSigmaDollar";
            this.edSigmaDollar.Size = new System.Drawing.Size(98, 22);
            this.edSigmaDollar.TabIndex = 10;
            this.edSigmaDollar.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            // 
            // edMuEuro
            // 
            this.edMuEuro.DecimalPlaces = 3;
            this.edMuEuro.Location = new System.Drawing.Point(188, 129);
            this.edMuEuro.Name = "edMuEuro";
            this.edMuEuro.Size = new System.Drawing.Size(98, 22);
            this.edMuEuro.TabIndex = 11;
            this.edMuEuro.Value = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            // 
            // edMuDollar
            // 
            this.edMuDollar.DecimalPlaces = 3;
            this.edMuDollar.Location = new System.Drawing.Point(302, 129);
            this.edMuDollar.Name = "edMuDollar";
            this.edMuDollar.Size = new System.Drawing.Size(98, 22);
            this.edMuDollar.TabIndex = 12;
            this.edMuDollar.Value = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Волатильность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дрифт:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 560);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPriceDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPriceEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSigmaEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSigmaDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMuEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMuDollar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edPriceEuro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown edPriceDollar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.NumericUpDown edMuDollar;
        private System.Windows.Forms.NumericUpDown edMuEuro;
        private System.Windows.Forms.NumericUpDown edSigmaDollar;
        private System.Windows.Forms.NumericUpDown edSigmaEuro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

