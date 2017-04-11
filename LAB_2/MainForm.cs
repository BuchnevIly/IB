using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class MainForm : Form
    {
        const string alphabet = "абвгдежзиклмнопрстуфхцчшщъыьэюя ";
        const int m = 32;

        public MainForm()
        {
            InitializeComponent();
        }

        private char f(char a)
        {
            var A = (int)numericUpDown1.Value;
            var B = (int)numericUpDown2.Value;
            var T = alphabet.IndexOf(a);

            return alphabet[(A*T + B)%m];
        }

        private int inv (int K)
        {
            var i = 1;
            while ((i * K) % m != 1)
                i++;

            return i;
        }

        private char fi(char a)
        {
            var A = (int)numericUpDown1.Value;
            var B = (int)numericUpDown2.Value;
            var T = alphabet.IndexOf(a);

            return alphabet[(inv(A) * (T + m - B) % m)];
        }

        private string uncoding(string text)
        {
            string result = "";
            foreach (char ch in text)
                result += fi(ch);
            return result;
        }


        private string coding(string text)
        {
            string result = "";
            foreach (char ch in text)
                result += f(ch);
            return result;
        }

        private bool isSimple()
        {
            var a = (int)numericUpDown1.Value;
            var mm= m;

            while (a != mm)
                if (a > mm)
                    a = a - mm;
                else
                    mm = mm - a;

            return a == 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = coding(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = uncoding(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (isSimple())
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }
    }
}
