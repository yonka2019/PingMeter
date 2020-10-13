namespace InternetStatusF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.StatusL = new System.Windows.Forms.Label();
            this.PingL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CleanB = new System.Windows.Forms.Button();
            this.PPB = new System.Windows.Forms.Button();
            this.SettingsB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // StatusL
            // 
            this.StatusL.AutoSize = true;
            this.StatusL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusL.Location = new System.Drawing.Point(411, 12);
            this.StatusL.Name = "StatusL";
            this.StatusL.Size = new System.Drawing.Size(140, 26);
            this.StatusL.TabIndex = 2;
            this.StatusL.Text = "Connecting...";
            // 
            // PingL
            // 
            this.PingL.AutoSize = true;
            this.PingL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PingL.Location = new System.Drawing.Point(395, 54);
            this.PingL.Name = "PingL";
            this.PingL.Size = new System.Drawing.Size(24, 26);
            this.PingL.TabIndex = 4;
            this.PingL.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(335, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ping:";
            // 
            // PingChart
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.PingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PingChart.Legends.Add(legend1);
            this.PingChart.Location = new System.Drawing.Point(0, 94);
            this.PingChart.Name = "PingChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Ping (ms)";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.PingChart.Series.Add(series1);
            this.PingChart.Size = new System.Drawing.Size(802, 346);
            this.PingChart.TabIndex = 5;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            title1.Name = "HostName";
            title1.Text = "Host:";
            this.PingChart.Titles.Add(title1);
            // 
            // CleanB
            // 
            this.CleanB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CleanB.Location = new System.Drawing.Point(676, 382);
            this.CleanB.Name = "CleanB";
            this.CleanB.Size = new System.Drawing.Size(108, 44);
            this.CleanB.TabIndex = 6;
            this.CleanB.Text = "Clean";
            this.CleanB.UseVisualStyleBackColor = true;
            this.CleanB.Click += new System.EventHandler(this.CleanB_Click);
            // 
            // PPB
            // 
            this.PPB.Image = global::InternetStatusF.Properties.Resources.Play;
            this.PPB.Location = new System.Drawing.Point(720, 194);
            this.PPB.Name = "PPB";
            this.PPB.Size = new System.Drawing.Size(40, 40);
            this.PPB.TabIndex = 8;
            this.PPB.UseVisualStyleBackColor = true;
            this.PPB.Click += new System.EventHandler(this.PPB_Click);
            // 
            // SettingsB
            // 
            this.SettingsB.Image = global::InternetStatusF.Properties.Resources.Settings;
            this.SettingsB.Location = new System.Drawing.Point(720, 283);
            this.SettingsB.Name = "SettingsB";
            this.SettingsB.Size = new System.Drawing.Size(40, 40);
            this.SettingsB.TabIndex = 7;
            this.SettingsB.UseVisualStyleBackColor = true;
            this.SettingsB.Click += new System.EventHandler(this.SettingsB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 438);
            this.Controls.Add(this.PPB);
            this.Controls.Add(this.SettingsB);
            this.Controls.Add(this.CleanB);
            this.Controls.Add(this.PingChart);
            this.Controls.Add(this.PingL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PingChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusL;
        private System.Windows.Forms.Label PingL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CleanB;
        private System.Windows.Forms.Button SettingsB;
        private System.Windows.Forms.DataVisualization.Charting.Chart PingChart;
        private System.Windows.Forms.Button PPB;
    }
}

