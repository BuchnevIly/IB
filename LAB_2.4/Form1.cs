using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2._4
{
    public partial class Form1 : Form
    {
        private bool isFirst = false;

        public double X_fence { get; set; }


        // Входные данные
        public double Y_fence { get; set; }

        public double X_win1 { get; set; }
        public double Y_win1 { get; set; }

        public double X_win2 { get; set; }
        public double Y_win2 { get; set; }

        public double X_inf { get; set; }
        public double Y_inf { get; set; }

        public double P_win1 { get; set; }
        public double P_win2 { get; set; }


        const double K1 = 2;
        const double K2 = 0.5;
        const int N = 100;

        public Form1()
        {
            InitializeComponent();

            numericUpDownPWin1.DataBindings.Add(new Binding("Value", this, "P_win1"));
            numericUpDownPWin2.DataBindings.Add(new Binding("Value", this, "P_win2"));
            numericUpDownXWin1.DataBindings.Add(new Binding("Value", this, "X_win1"));
            numericUpDownYWin1.DataBindings.Add(new Binding("Value", this, "Y_win1"));
            numericUpDownXWin2.DataBindings.Add(new Binding("Value", this, "X_win2"));
            numericUpDownYWin2.DataBindings.Add(new Binding("Value", this, "Y_win2"));
            numericUpDownF.DataBindings.Add(new Binding("Value", this, "Y_fence"));
            numericUpDownXInf.DataBindings.Add(new Binding("Value", this, "X_inf"));
            numericUpDownYInf.DataBindings.Add(new Binding("Value", this, "Y_inf"));

            P_win1 = 0.5;
            P_win2 = 0.5;

            X_win1 = 10;
            X_win2 = 50;

            Y_win1 = 40;
            Y_win2 = 40;

            X_inf = 25;
            Y_inf = 25;

            Y_fence = 50;
        }


        private double lenght (double xa, double xb, double ya, double yb)
        {
            return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
        }

        public double Pi1 ()
        {
            var l11 = lenght(X_win1, X_fence, Y_win1, Y_fence);
            var l21 = lenght(X_win1, X_inf, Y_win1, Y_inf);
            return (K1 / l11) * P_win1 * (K2 / l21); ;
        }

        public double Pi2 ()
        {
            var l12 = lenght(X_win2, X_fence, Y_win2, Y_fence);
            var l22 = lenght(X_win2, X_inf, Y_win2, Y_inf);
            return (K1 / l12) * P_win2 * (K2 / l22);
        }

        public void GetResult()
        {
            var Pmin = double.MaxValue;
            var X = 0.0;
            var window = 1;
            for (X_fence = 0; X_fence <= N; X_fence++)
            {
                if (Pi1() < Pmin)
                {
                    Pmin = Pi1();
                    window = 1;
                    X = X_fence;
                }

                if (Pi2() < Pmin)
                {
                    Pmin = Pi2();
                    window = 2;
                    X = X_fence;
                }
            }

            labelResult.Text = string.Format("Результат: \n P = {0};\n Окно {1};\n Координаты ({2}, {3})\n", Pmin, window, X, Y_fence);        }

        private void button_Click(object sender, EventArgs e)
        {
            GetResult();
        }


        private void ValidateValue()
        {
            if (!isFirst)
            {
                isFirst = true;
                return;
            }
            isFirst = false;

            numericUpDownYWin2.Value = numericUpDownYWin1.Value;
            numericUpDownXWin1.Maximum = numericUpDownXWin2.Value - 1;
            numericUpDownF.Minimum = numericUpDownYWin1.Value + 1;
            numericUpDownYWin1.Maximum = numericUpDownF.Value - 1;
            numericUpDownXInf.Maximum = numericUpDownYWin1.Value - 1;
            numericUpDownYWin1.Minimum = numericUpDownYInf.Value + 1;
            isFirst = true;
        }

        private void numericUpDownPWin1_ValueChanged(object sender, EventArgs e)
        {
            //ValidateValue();
        }

        private void numericUpDownPWin2_ValueChanged(object sender, EventArgs e)
        {
            //ValidateValue();
        }

        private void numericUpDownXWin1_ValueChanged(object sender, EventArgs e)
        {
            ValidateValue();
        }

        private void numericUpDownYWin1_ValueChanged(object sender, EventArgs e)
        {
            ValidateValue();
        }

        private void numericUpDownXWin2_ValueChanged(object sender, EventArgs e)
        {
            ValidateValue();
        }

        private void numericUpDownYWin2_ValueChanged(object sender, EventArgs e)
        {
            ValidateValue();
        }

        private void numericUpDownXInf_ValueChanged(object sender, EventArgs e)
        {
            ValidateValue();
        }

        private void numericUpDownYInf_ValueChanged(object sender, EventArgs e)
        {
            ValidateValue();
        }

        private void numericUpDownF_ValueChanged(object sender, EventArgs e)
        {
            ValidateValue();
        }

        private void numericUpDownPWin1_MouseClick(object sender, MouseEventArgs e)
        {
            ValidateValue();
        }

        private void numericUpDownPWin1_Click(object sender, EventArgs e)
        {
            ValidateValue();
        }
    }
}
