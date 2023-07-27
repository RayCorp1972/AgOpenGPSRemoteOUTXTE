﻿namespace AgOpenGPS
{
    partial class FormXTEGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.unoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPWM = new System.Windows.Forms.Label();
            this.lblSteerAng = new System.Windows.Forms.Label();
            this.btnGainUp = new System.Windows.Forms.Button();
            this.btnGainDown = new System.Windows.Forms.Button();
            this.btnGainAuto = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VerbindBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ZendBtn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.unoChart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // unoChart
            // 
            this.unoChart.AllowDrop = true;
            this.unoChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unoChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.unoChart.BackColor = System.Drawing.Color.Black;
            chartArea6.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea6.AxisY.LineWidth = 2;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea6.BackColor = System.Drawing.Color.Black;
            chartArea6.BorderWidth = 0;
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 100F;
            chartArea6.Position.Width = 100F;
            this.unoChart.ChartAreas.Add(chartArea6);
            this.unoChart.Location = new System.Drawing.Point(3, 12);
            this.unoChart.Margin = new System.Windows.Forms.Padding(0);
            this.unoChart.Name = "unoChart";
            this.unoChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series11.BackSecondaryColor = System.Drawing.Color.White;
            series11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Color = System.Drawing.Color.OrangeRed;
            series11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.Legend = "Legend1";
            series11.Name = "S";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Color = System.Drawing.Color.Lime;
            series12.IsVisibleInLegend = false;
            series12.Legend = "Legend1";
            series12.Name = "PWM";
            this.unoChart.Series.Add(series11);
            this.unoChart.Series.Add(series12);
            this.unoChart.Size = new System.Drawing.Size(421, 253);
            this.unoChart.TabIndex = 180;
            this.unoChart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 196;
            this.label5.Text = "Heading:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(217, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 195;
            this.label1.Text = "XTE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPWM
            // 
            this.lblPWM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPWM.AutoSize = true;
            this.lblPWM.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblPWM.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPWM.ForeColor = System.Drawing.Color.Lime;
            this.lblPWM.Location = new System.Drawing.Point(294, 274);
            this.lblPWM.Name = "lblPWM";
            this.lblPWM.Size = new System.Drawing.Size(85, 29);
            this.lblPWM.TabIndex = 194;
            this.lblPWM.Text = "label5";
            this.lblPWM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSteerAng
            // 
            this.lblSteerAng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSteerAng.AutoSize = true;
            this.lblSteerAng.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblSteerAng.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteerAng.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSteerAng.Location = new System.Drawing.Point(126, 274);
            this.lblSteerAng.Name = "lblSteerAng";
            this.lblSteerAng.Size = new System.Drawing.Size(85, 29);
            this.lblSteerAng.TabIndex = 193;
            this.lblSteerAng.Text = "label1";
            this.lblSteerAng.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGainUp
            // 
            this.btnGainUp.BackColor = System.Drawing.Color.Transparent;
            this.btnGainUp.FlatAppearance.BorderSize = 2;
            this.btnGainUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGainUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGainUp.ForeColor = System.Drawing.Color.White;
            this.btnGainUp.Location = new System.Drawing.Point(3, 12);
            this.btnGainUp.Name = "btnGainUp";
            this.btnGainUp.Size = new System.Drawing.Size(48, 55);
            this.btnGainUp.TabIndex = 197;
            this.btnGainUp.Text = "+";
            this.btnGainUp.UseVisualStyleBackColor = false;
            this.btnGainUp.Click += new System.EventHandler(this.btnGainUp_Click);
            // 
            // btnGainDown
            // 
            this.btnGainDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGainDown.BackColor = System.Drawing.Color.Transparent;
            this.btnGainDown.FlatAppearance.BorderSize = 2;
            this.btnGainDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGainDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGainDown.ForeColor = System.Drawing.Color.White;
            this.btnGainDown.Location = new System.Drawing.Point(3, 185);
            this.btnGainDown.Name = "btnGainDown";
            this.btnGainDown.Size = new System.Drawing.Size(48, 55);
            this.btnGainDown.TabIndex = 198;
            this.btnGainDown.Text = "-";
            this.btnGainDown.UseVisualStyleBackColor = false;
            this.btnGainDown.Click += new System.EventHandler(this.btnGainDown_Click);
            // 
            // btnGainAuto
            // 
            this.btnGainAuto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGainAuto.BackColor = System.Drawing.Color.Transparent;
            this.btnGainAuto.FlatAppearance.BorderSize = 2;
            this.btnGainAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGainAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGainAuto.ForeColor = System.Drawing.Color.White;
            this.btnGainAuto.Location = new System.Drawing.Point(3, 95);
            this.btnGainAuto.Name = "btnGainAuto";
            this.btnGainAuto.Size = new System.Drawing.Size(48, 55);
            this.btnGainAuto.TabIndex = 199;
            this.btnGainAuto.Text = "A";
            this.btnGainAuto.UseVisualStyleBackColor = false;
            this.btnGainAuto.Click += new System.EventHandler(this.btnGainAuto_Click);
            // 
            // lblMin
            // 
            this.lblMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMin.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblMin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Lime;
            this.lblMin.Location = new System.Drawing.Point(329, 279);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(100, 23);
            this.lblMin.TabIndex = 200;
            this.lblMin.Text = "10";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMax
            // 
            this.lblMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMax.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblMax.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.Lime;
            this.lblMax.Location = new System.Drawing.Point(332, 1);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(100, 23);
            this.lblMax.TabIndex = 201;
            this.lblMax.Text = "Auto";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(414, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 33);
            this.label2.TabIndex = 202;
            this.label2.Text = "<";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VerbindBtn
            // 
            this.VerbindBtn.Location = new System.Drawing.Point(32, 325);
            this.VerbindBtn.Name = "VerbindBtn";
            this.VerbindBtn.Size = new System.Drawing.Size(75, 23);
            this.VerbindBtn.TabIndex = 203;
            this.VerbindBtn.Text = "Verbinden";
            this.VerbindBtn.UseVisualStyleBackColor = true;
            this.VerbindBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 204;
            // 
            // ZendBtn
            // 
            this.ZendBtn.Location = new System.Drawing.Point(32, 352);
            this.ZendBtn.Name = "ZendBtn";
            this.ZendBtn.Size = new System.Drawing.Size(75, 23);
            this.ZendBtn.TabIndex = 205;
            this.ZendBtn.Text = "button2";
            this.ZendBtn.UseVisualStyleBackColor = true;
            this.ZendBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(186, 352);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 206;
            this.comboBox2.Text = "115200";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "5",
            "10",
            "100",
            "1000"});
            this.comboBox3.Location = new System.Drawing.Point(349, 325);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(52, 21);
            this.comboBox3.TabIndex = 207;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(331, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 208;
            this.label3.Text = "label5";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormXTEGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(441, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.ZendBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.VerbindBtn);
            this.Controls.Add(this.lblPWM);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnGainAuto);
            this.Controls.Add(this.btnGainDown);
            this.Controls.Add(this.btnGainUp);
            this.Controls.Add(this.lblSteerAng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unoChart);
            this.Controls.Add(this.label2);
            this.Location = new System.Drawing.Point(30, 30);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(457, 255);
            this.Name = "FormXTEGraph";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XTE Graph";
            this.Load += new System.EventHandler(this.FormSteerGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unoChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart unoChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPWM;
        private System.Windows.Forms.Label lblSteerAng;
        private System.Windows.Forms.Button btnGainUp;
        private System.Windows.Forms.Button btnGainDown;
        private System.Windows.Forms.Button btnGainAuto;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VerbindBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ZendBtn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
    }
}