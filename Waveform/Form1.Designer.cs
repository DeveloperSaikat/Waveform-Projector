namespace Waveform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.T5 = new System.Windows.Forms.TextBox();
            this.T4 = new System.Windows.Forms.TextBox();
            this.T3 = new System.Windows.Forms.TextBox();
            this.T2 = new System.Windows.Forms.TextBox();
            this.T1 = new System.Windows.Forms.TextBox();
            this.V5 = new System.Windows.Forms.TextBox();
            this.V4 = new System.Windows.Forms.TextBox();
            this.V3 = new System.Windows.Forms.TextBox();
            this.V2 = new System.Windows.Forms.TextBox();
            this.V1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of levels:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter voltage levels:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter times for each level:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 90);
            this.button1.TabIndex = 14;
            this.button1.Text = "Calculate ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer
            // 
            this.answer.Enabled = false;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(379, 491);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(190, 90);
            this.answer.TabIndex = 16;
            // 
            // T5
            // 
            this.T5.Enabled = false;
            this.T5.Location = new System.Drawing.Point(379, 365);
            this.T5.Multiline = true;
            this.T5.Name = "T5";
            this.T5.Size = new System.Drawing.Size(190, 44);
            this.T5.TabIndex = 17;
            this.T5.Text = "0";
            this.T5.Enter += new System.EventHandler(this.Values_OnFocus);
            this.T5.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // T4
            // 
            this.T4.Enabled = false;
            this.T4.Location = new System.Drawing.Point(379, 315);
            this.T4.Multiline = true;
            this.T4.Name = "T4";
            this.T4.Size = new System.Drawing.Size(190, 44);
            this.T4.TabIndex = 18;
            this.T4.Text = "0";
            this.T4.Enter += new System.EventHandler(this.Values_OnFocus);
            this.T4.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // T3
            // 
            this.T3.Enabled = false;
            this.T3.Location = new System.Drawing.Point(379, 267);
            this.T3.Multiline = true;
            this.T3.Name = "T3";
            this.T3.Size = new System.Drawing.Size(190, 44);
            this.T3.TabIndex = 19;
            this.T3.Text = "0";
            this.T3.Enter += new System.EventHandler(this.Values_OnFocus);
            this.T3.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // T2
            // 
            this.T2.Enabled = false;
            this.T2.Location = new System.Drawing.Point(379, 217);
            this.T2.Multiline = true;
            this.T2.Name = "T2";
            this.T2.Size = new System.Drawing.Size(190, 44);
            this.T2.TabIndex = 20;
            this.T2.Text = "0";
            this.T2.Enter += new System.EventHandler(this.Values_OnFocus);
            this.T2.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // T1
            // 
            this.T1.Enabled = false;
            this.T1.Location = new System.Drawing.Point(379, 167);
            this.T1.Multiline = true;
            this.T1.Name = "T1";
            this.T1.Size = new System.Drawing.Size(190, 44);
            this.T1.TabIndex = 21;
            this.T1.Text = "0";
            this.T1.Enter += new System.EventHandler(this.Values_OnFocus);
            this.T1.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // V5
            // 
            this.V5.Enabled = false;
            this.V5.Location = new System.Drawing.Point(34, 365);
            this.V5.Multiline = true;
            this.V5.Name = "V5";
            this.V5.Size = new System.Drawing.Size(190, 44);
            this.V5.TabIndex = 22;
            this.V5.Text = "0";
            this.V5.Enter += new System.EventHandler(this.Values_OnFocus);
            this.V5.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // V4
            // 
            this.V4.Enabled = false;
            this.V4.Location = new System.Drawing.Point(34, 315);
            this.V4.Multiline = true;
            this.V4.Name = "V4";
            this.V4.Size = new System.Drawing.Size(190, 44);
            this.V4.TabIndex = 23;
            this.V4.Text = "0";
            this.V4.Enter += new System.EventHandler(this.Values_OnFocus);
            this.V4.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // V3
            // 
            this.V3.Enabled = false;
            this.V3.Location = new System.Drawing.Point(34, 267);
            this.V3.Multiline = true;
            this.V3.Name = "V3";
            this.V3.Size = new System.Drawing.Size(190, 44);
            this.V3.TabIndex = 24;
            this.V3.Text = "0";
            this.V3.Enter += new System.EventHandler(this.Values_OnFocus);
            this.V3.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // V2
            // 
            this.V2.Enabled = false;
            this.V2.Location = new System.Drawing.Point(34, 217);
            this.V2.Multiline = true;
            this.V2.Name = "V2";
            this.V2.Size = new System.Drawing.Size(190, 44);
            this.V2.TabIndex = 25;
            this.V2.Text = "0";
            this.V2.Enter += new System.EventHandler(this.Values_OnFocus);
            this.V2.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // V1
            // 
            this.V1.Enabled = false;
            this.V1.Location = new System.Drawing.Point(34, 167);
            this.V1.Multiline = true;
            this.V1.Name = "V1";
            this.V1.Size = new System.Drawing.Size(190, 44);
            this.V1.TabIndex = 26;
            this.V1.Text = "0";
            this.V1.Enter += new System.EventHandler(this.Values_OnFocus);
            this.V1.Leave += new System.EventHandler(this.Values_LeaveFocus);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(609, 145);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Voltage";
            series2.BorderColor = System.Drawing.Color.Yellow;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Time";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(578, 300);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 28;
            this.button2.Text = "Load Chart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(324, 53);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(151, 22);
            this.numericUpDown1.TabIndex = 35;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 650);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.V1);
            this.Controls.Add(this.V2);
            this.Controls.Add(this.V3);
            this.Controls.Add(this.V4);
            this.Controls.Add(this.V5);
            this.Controls.Add(this.T1);
            this.Controls.Add(this.T2);
            this.Controls.Add(this.T3);
            this.Controls.Add(this.T4);
            this.Controls.Add(this.T5);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Waveform Projector";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.TextBox T5;
        private System.Windows.Forms.TextBox T4;
        private System.Windows.Forms.TextBox T3;
        private System.Windows.Forms.TextBox T2;
        private System.Windows.Forms.TextBox T1;
        private System.Windows.Forms.TextBox V5;
        private System.Windows.Forms.TextBox V4;
        private System.Windows.Forms.TextBox V3;
        private System.Windows.Forms.TextBox V2;
        private System.Windows.Forms.TextBox V1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

