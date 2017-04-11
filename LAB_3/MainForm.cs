using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private const int a = 5;
        private const int b = 7;
        private const int m = 4096;
        private const int Y0 = 4003;
        private const int Y1 = 59;


        private int RandomGenerator (int y)
        {
            return (a * y + b) % m;
        }


        private string Encrypt(string text)
        {
            string EncryptText = "";

            var Yi = Y0;
            foreach (var ch in text)
            {
                EncryptText += (char)(ch ^ Yi);
                Yi = RandomGenerator(Yi);
            }
            return EncryptText;
        }

        private string Decrypt(string text)
        {
            return Encrypt(text);
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
