using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int m = 11;

        private int ReplacementTo(char ch)
        {
            switch (ch)
            {
                case 'b': return 0; 
                case 'e': return 1; 
                case ' ': return 2; 
                case 'a': return 3; 
                case 'c': return 4; 
                case 'k': return 5; 
                case 't': return 6; 
                case 'o': return 7; 
                case 'm': return 8; 
                case 'r': return 9; 
                case 'w': return 10;  
            }

            return -1;
        }

        private char ReplacementFrom(int i)
        {
            switch (i)
            {
                case 0:  return 'b';
                case 1 : return 'e';
                case 2 : return ' ';
                case 3 : return 'a';
                case 4 : return 'c';
                case 5 : return 'k';
                case 6 : return 't';
                case 7 : return 'o';
                case 8 : return 'm';
                case 9 : return 'r';
                case 10: return 'w';
            }

            return '.' ;
        }

        List<int> k;

        private string Encrypt(string text)
        {
            var x = new List<int>();
            k = new List<int>();
            var y = new List<int>();
            var b = "";
            var rnd = new Random();
            foreach (char ch in text)
            {
                var ki = (int)(rnd.NextDouble() * 10);
                var xi = ReplacementTo(ch);
                var yi = (xi + ki) % m;
                x.Add(xi);
                k.Add(ki);
                y.Add(yi);

                b += ReplacementFrom(yi);
            }

            textBox4.Text = string.Join(" ", k);

            return b;
        }

        private string Decrypt(string text)
        {
            var x = new List<int>();
            var y = new List<int>();
            var b = "";

            var i = 0;
            foreach (char ch in text)
            {
                var xi = ReplacementTo(ch);
                var yi = (xi - k[i]);
                while (yi < 0) yi += m;
                yi = yi % m;
                x.Add(xi);
                y.Add(yi);

                b += ReplacementFrom(yi);
                i++;
            }

            return b;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Encrypt(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Decrypt(textBox2.Text);
        }
    }
}
