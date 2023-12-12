namespace Tyuiu.ZyryanovAA.WindowsForm2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.buttonDev = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.numericFinish = new System.Windows.Forms.NumericUpDown();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.labelFinish = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.chartRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(13, 185);
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes.Size = new System.Drawing.Size(282, 253);
            this.textBoxRes.TabIndex = 5;
            this.textBoxRes.TextChanged += new System.EventHandler(this.textBoxRes_TextChanged);
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxTitle.Controls.Add(this.buttonDev);
            this.groupBoxTitle.Controls.Add(this.buttonCalc);
            this.groupBoxTitle.Controls.Add(this.numericFinish);
            this.groupBoxTitle.Controls.Add(this.numericStart);
            this.groupBoxTitle.Controls.Add(this.labelFinish);
            this.groupBoxTitle.Controls.Add(this.labelStart);
            this.groupBoxTitle.Controls.Add(this.textBoxDesc);
            this.groupBoxTitle.Location = new System.Drawing.Point(0, 12);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Size = new System.Drawing.Size(801, 100);
            this.groupBoxTitle.TabIndex = 4;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "Описание";
            this.groupBoxTitle.Enter += new System.EventHandler(this.groupBoxTitle_Enter);
            // 
            // buttonDev
            // 
            this.buttonDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDev.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDev.Location = new System.Drawing.Point(586, 58);
            this.buttonDev.Name = "buttonDev";
            this.buttonDev.Size = new System.Drawing.Size(200, 23);
            this.buttonDev.TabIndex = 3;
            this.buttonDev.Text = "О разработчике";
            this.buttonDev.UseVisualStyleBackColor = true;
            this.buttonDev.Click += new System.EventHandler(this.buttonDev_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCalc.BackColor = System.Drawing.SystemColors.Info;
            this.buttonCalc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(586, 24);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(200, 28);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "ВЫПОЛНИТЬ РАССЧЁТ";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // numericFinish
            // 
            this.numericFinish.Location = new System.Drawing.Point(514, 58);
            this.numericFinish.Name = "numericFinish";
            this.numericFinish.Size = new System.Drawing.Size(53, 20);
            this.numericFinish.TabIndex = 2;
            this.numericFinish.ValueChanged += new System.EventHandler(this.numericFinish_ValueChanged);
            // 
            // numericStart
            // 
            this.numericStart.Location = new System.Drawing.Point(433, 58);
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(64, 20);
            this.numericStart.TabIndex = 2;
            this.numericStart.ValueChanged += new System.EventHandler(this.numericStart_ValueChanged);
            // 
            // labelFinish
            // 
            this.labelFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFinish.AutoSize = true;
            this.labelFinish.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinish.Location = new System.Drawing.Point(511, 24);
            this.labelFinish.Name = "labelFinish";
            this.labelFinish.Size = new System.Drawing.Size(42, 15);
            this.labelFinish.TabIndex = 1;
            this.labelFinish.Text = "Конец";
            // 
            // labelStart
            // 
            this.labelStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(433, 24);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(47, 15);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Начало";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDesc.Location = new System.Drawing.Point(7, 21);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(420, 60);
            this.textBoxDesc.TabIndex = 0;
            this.textBoxDesc.TabStop = false;
            this.textBoxDesc.Text = "Для проведения рассчётов и построения графика \r\nнеобходимо ввести начальное и кон" +
    "ечное значение шага\r\nи нажать на кнопку \"ВЫПОЛНИТЬ РАССЧЁТ\"";
            this.textBoxDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chartRes
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRes.Legends.Add(legend1);
            this.chartRes.Location = new System.Drawing.Point(327, 127);
            this.chartRes.Name = "chartRes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes.Series.Add(series1);
            this.chartRes.Size = new System.Drawing.Size(459, 300);
            this.chartRes.TabIndex = 6;
            this.chartRes.Text = "chartRes";
            this.chartRes.Click += new System.EventHandler(this.chart1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chartRes);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.groupBoxTitle);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.GroupBox groupBoxTitle;
        private System.Windows.Forms.Button buttonDev;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.NumericUpDown numericFinish;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.Label labelFinish;
        private System.Windows.Forms.Label labelStart;
        public System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

