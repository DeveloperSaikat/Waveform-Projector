using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waveform
{
    public partial class Form1 : Form
    {
        List<TextBox> Voltages = new List<TextBox>();
        List<TextBox> Times = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();

            Voltages.Add(V1); Voltages.Add(V2); Voltages.Add(V3); Voltages.Add(V4); Voltages.Add(V5);
            Times.Add(T1); Times.Add(T2); Times.Add(T3); Times.Add(T4); Times.Add(T5); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var v1Text = Double.Parse(V1.Text)*double.Parse(T1.Text)+double.Parse(V2.Text)*double.Parse(T2.Text)+double.Parse(V3.Text)*double.Parse(T3.Text)+double.Parse(V4.Text)*double.Parse(T4.Text)+double.Parse(V5.Text)*double.Parse(T5.Text);
            var T = double.Parse(T1.Text) + double.Parse(T2.Text) + double.Parse(T3.Text) + double.Parse(T4.Text) + double.Parse(T5.Text);
            double VTsum = (v1Text / T);
            answer.Text = VTsum.ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Voltage"].Points.AddXY("V1,T1", V1.Text);
            this.chart1.Series["Time"].Points.AddXY("T1", T1.Text);
            this.chart1.Series["Voltage"].Points.AddXY("V2,T2", V2.Text);
            this.chart1.Series["Time"].Points.AddXY("T2", T2.Text);
            this.chart1.Series["Voltage"].Points.AddXY("V3,T3", V3.Text);
            this.chart1.Series["Time"].Points.AddXY("T3", T3.Text);
            this.chart1.Series["Voltage"].Points.AddXY("V4,T4", V4.Text);
            this.chart1.Series["Time"].Points.AddXY("T4",T4.Text);
            this.chart1.Series["Voltage"].Points.AddXY("V5,T5", V5.Text);
            this.chart1.Series["Time"].Points.AddXY("T5", T5.Text);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < numericUpDown1.Value; i++) 
                Voltages[i].Enabled = Times[i].Enabled = true;

            for (; i < 5; i++) 
                Voltages[i].Enabled = Times[i].Enabled = false;
        }

        private void Values_OnFocus(object sender, EventArgs e)
        {
            if(((TextBox)sender).Text.Equals("0"))
                ((TextBox)sender).Text = string.Empty;
        }

        private void Values_LeaveFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Equals(string.Empty))
                ((TextBox)sender).Text = "0";
        }
    }
}
