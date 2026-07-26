namespace Hammurabi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.RulesLabel = new System.Windows.Forms.Label();
            this.GameGroupBox = new System.Windows.Forms.GroupBox();
            this.PlantUpDown = new System.Windows.Forms.NumericUpDown();
            this.FeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.LandUpDown = new System.Windows.Forms.NumericUpDown();
            this.BushelLabel = new System.Windows.Forms.Label();
            this.PlantLabel = new System.Windows.Forms.Label();
            this.FeedLabel = new System.Windows.Forms.Label();
            this.LandLabel = new System.Windows.Forms.Label();
            this.YearProgressBar = new System.Windows.Forms.ProgressBar();
            this.ActionButton = new System.Windows.Forms.Button();
            this.ReportLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.StatsGroupBox = new System.Windows.Forms.GroupBox();
            this.PopChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AcresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BushelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.GameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlantUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandUpDown)).BeginInit();
            this.StatsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PopChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcresChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BushelChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RulesLabel
            // 
            this.RulesLabel.AutoSize = true;
            this.RulesLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesLabel.Location = new System.Drawing.Point(12, 98);
            this.RulesLabel.Name = "RulesLabel";
            this.RulesLabel.Size = new System.Drawing.Size(755, 255);
            this.RulesLabel.TabIndex = 1;
            this.RulesLabel.Text = resources.GetString("RulesLabel.Text");
            // 
            // GameGroupBox
            // 
            this.GameGroupBox.Controls.Add(this.PlantUpDown);
            this.GameGroupBox.Controls.Add(this.FeedUpDown);
            this.GameGroupBox.Controls.Add(this.LandUpDown);
            this.GameGroupBox.Controls.Add(this.BushelLabel);
            this.GameGroupBox.Controls.Add(this.PlantLabel);
            this.GameGroupBox.Controls.Add(this.FeedLabel);
            this.GameGroupBox.Controls.Add(this.LandLabel);
            this.GameGroupBox.Controls.Add(this.YearProgressBar);
            this.GameGroupBox.Controls.Add(this.ActionButton);
            this.GameGroupBox.Controls.Add(this.ReportLabel);
            this.GameGroupBox.Controls.Add(this.YearLabel);
            this.GameGroupBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameGroupBox.Location = new System.Drawing.Point(15, 348);
            this.GameGroupBox.Name = "GameGroupBox";
            this.GameGroupBox.Size = new System.Drawing.Size(690, 338);
            this.GameGroupBox.TabIndex = 2;
            this.GameGroupBox.TabStop = false;
            this.GameGroupBox.Text = "Let\'s Play!";
            // 
            // PlantUpDown
            // 
            this.PlantUpDown.Location = new System.Drawing.Point(508, 195);
            this.PlantUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PlantUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.PlantUpDown.Name = "PlantUpDown";
            this.PlantUpDown.Size = new System.Drawing.Size(97, 25);
            this.PlantUpDown.TabIndex = 16;
            // 
            // FeedUpDown
            // 
            this.FeedUpDown.Location = new System.Drawing.Point(508, 127);
            this.FeedUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.FeedUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.FeedUpDown.Name = "FeedUpDown";
            this.FeedUpDown.Size = new System.Drawing.Size(97, 25);
            this.FeedUpDown.TabIndex = 15;
            // 
            // LandUpDown
            // 
            this.LandUpDown.Location = new System.Drawing.Point(508, 61);
            this.LandUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.LandUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.LandUpDown.Name = "LandUpDown";
            this.LandUpDown.Size = new System.Drawing.Size(97, 25);
            this.LandUpDown.TabIndex = 14;
            // 
            // BushelLabel
            // 
            this.BushelLabel.AutoSize = true;
            this.BushelLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BushelLabel.Location = new System.Drawing.Point(364, 21);
            this.BushelLabel.Name = "BushelLabel";
            this.BushelLabel.Size = new System.Drawing.Size(73, 21);
            this.BushelLabel.TabIndex = 13;
            this.BushelLabel.Text = "Bushels";
            // 
            // PlantLabel
            // 
            this.PlantLabel.AutoSize = true;
            this.PlantLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlantLabel.Location = new System.Drawing.Point(364, 197);
            this.PlantLabel.Name = "PlantLabel";
            this.PlantLabel.Size = new System.Drawing.Size(138, 34);
            this.PlantLabel.TabIndex = 12;
            this.PlantLabel.Text = "How many bushels\r\nwill you plant?";
            // 
            // FeedLabel
            // 
            this.FeedLabel.AutoSize = true;
            this.FeedLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedLabel.Location = new System.Drawing.Point(364, 127);
            this.FeedLabel.Name = "FeedLabel";
            this.FeedLabel.Size = new System.Drawing.Size(138, 51);
            this.FeedLabel.TabIndex = 11;
            this.FeedLabel.Text = "How many bushels\r\nwill you feed your \r\npeople with?";
            // 
            // LandLabel
            // 
            this.LandLabel.AutoSize = true;
            this.LandLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LandLabel.Location = new System.Drawing.Point(365, 61);
            this.LandLabel.Name = "LandLabel";
            this.LandLabel.Size = new System.Drawing.Size(129, 51);
            this.LandLabel.TabIndex = 10;
            this.LandLabel.Text = "How many acres \r\nof land will you \r\nbuy/sell?";
            // 
            // YearProgressBar
            // 
            this.YearProgressBar.Location = new System.Drawing.Point(115, 28);
            this.YearProgressBar.Maximum = 10;
            this.YearProgressBar.Name = "YearProgressBar";
            this.YearProgressBar.Size = new System.Drawing.Size(175, 23);
            this.YearProgressBar.Step = 1;
            this.YearProgressBar.TabIndex = 9;
            this.YearProgressBar.Value = 1;
            // 
            // ActionButton
            // 
            this.ActionButton.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionButton.Location = new System.Drawing.Point(368, 249);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(237, 47);
            this.ActionButton.TabIndex = 8;
            this.ActionButton.Text = "Make It So!";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // ReportLabel
            // 
            this.ReportLabel.AutoSize = true;
            this.ReportLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLabel.Location = new System.Drawing.Point(15, 59);
            this.ReportLabel.Name = "ReportLabel";
            this.ReportLabel.Size = new System.Drawing.Size(69, 21);
            this.ReportLabel.TabIndex = 4;
            this.ReportLabel.Text = "Report";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(15, 28);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(52, 21);
            this.YearLabel.TabIndex = 3;
            this.YearLabel.Text = "Year";
            // 
            // StatsGroupBox
            // 
            this.StatsGroupBox.Controls.Add(this.PopChart);
            this.StatsGroupBox.Controls.Add(this.AcresChart);
            this.StatsGroupBox.Controls.Add(this.BushelChart);
            this.StatsGroupBox.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsGroupBox.Location = new System.Drawing.Point(711, 348);
            this.StatsGroupBox.Name = "StatsGroupBox";
            this.StatsGroupBox.Size = new System.Drawing.Size(221, 338);
            this.StatsGroupBox.TabIndex = 3;
            this.StatsGroupBox.TabStop = false;
            this.StatsGroupBox.Text = "Stats";
            // 
            // PopChart
            // 
            this.PopChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PopChart.BorderlineColor = System.Drawing.Color.Empty;
            chartArea1.Name = "ChartArea1";
            this.PopChart.ChartAreas.Add(chartArea1);
            this.PopChart.Location = new System.Drawing.Point(49, 226);
            this.PopChart.Name = "PopChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Population";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            dataPoint1.AxisLabel = "Pop.";
            dataPoint1.IsEmpty = true;
            dataPoint1.IsVisibleInLegend = true;
            dataPoint1.Label = "";
            series1.Points.Add(dataPoint1);
            this.PopChart.Series.Add(series1);
            this.PopChart.Size = new System.Drawing.Size(128, 106);
            this.PopChart.TabIndex = 4;
            this.PopChart.Text = "Population";
            // 
            // AcresChart
            // 
            this.AcresChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AcresChart.BorderlineColor = System.Drawing.Color.Empty;
            chartArea2.Name = "ChartArea1";
            this.AcresChart.ChartAreas.Add(chartArea2);
            this.AcresChart.Location = new System.Drawing.Point(49, 118);
            this.AcresChart.Name = "AcresChart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Acres";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            dataPoint2.AxisLabel = "Acres";
            dataPoint2.IsEmpty = true;
            dataPoint2.IsVisibleInLegend = true;
            dataPoint2.Label = "";
            series2.Points.Add(dataPoint2);
            this.AcresChart.Series.Add(series2);
            this.AcresChart.Size = new System.Drawing.Size(128, 102);
            this.AcresChart.TabIndex = 1;
            this.AcresChart.Text = "Acres";
            // 
            // BushelChart
            // 
            this.BushelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BushelChart.BorderlineColor = System.Drawing.Color.Empty;
            chartArea3.Name = "ChartArea1";
            this.BushelChart.ChartAreas.Add(chartArea3);
            this.BushelChart.Location = new System.Drawing.Point(49, 12);
            this.BushelChart.Name = "BushelChart";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Bushels";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            dataPoint3.AxisLabel = "Bushels";
            dataPoint3.IsEmpty = true;
            dataPoint3.IsVisibleInLegend = true;
            dataPoint3.Label = "";
            series3.Points.Add(dataPoint3);
            this.BushelChart.Series.Add(series3);
            this.BushelChart.Size = new System.Drawing.Size(127, 113);
            this.BushelChart.TabIndex = 0;
            this.BushelChart.Text = "Bushels";
            // 
            // LogoBox
            // 
            this.LogoBox.BackgroundImage = global::Hammurabi.Properties.Resources.ceria_lebaran_regular;
            this.LogoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoBox.Location = new System.Drawing.Point(12, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(960, 83);
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 698);
            this.Controls.Add(this.StatsGroupBox);
            this.Controls.Add(this.GameGroupBox);
            this.Controls.Add(this.RulesLabel);
            this.Controls.Add(this.LogoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GameGroupBox.ResumeLayout(false);
            this.GameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlantUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LandUpDown)).EndInit();
            this.StatsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PopChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcresChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BushelChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label RulesLabel;
        private System.Windows.Forms.GroupBox GameGroupBox;
        private System.Windows.Forms.Label ReportLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.GroupBox StatsGroupBox;
        private System.Windows.Forms.ProgressBar YearProgressBar;
        private System.Windows.Forms.Label PlantLabel;
        private System.Windows.Forms.Label FeedLabel;
        private System.Windows.Forms.Label LandLabel;
        private System.Windows.Forms.Label BushelLabel;
        private System.Windows.Forms.NumericUpDown PlantUpDown;
        private System.Windows.Forms.NumericUpDown FeedUpDown;
        private System.Windows.Forms.NumericUpDown LandUpDown;
        private System.Windows.Forms.DataVisualization.Charting.Chart BushelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PopChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart AcresChart;
    }
}
