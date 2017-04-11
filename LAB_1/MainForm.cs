using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitTable();
        }

        private void InitTable()
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.RowCount = 5;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var matrix = BildTable();

            // Идем по маршруту
            string result = "";
            for (int i = 0; i < 5; i++)
                result += matrix[i, 0];

            for (int j = 1; j < 8; j++)
                result += matrix[4, j];

            for (int j = 7; j > 0; j--)
                result += matrix[3, j];

            for (int i = 2; i >= 0; i--)
                result += matrix[i, 1];

            for (int i = 0; i < 2; i++)
                result += matrix[i, 2];

            for (int j = 2; j <= 5; j++)
                result += matrix[2, j];

            for (int j = 5; j >= 3; j--)
                result += matrix[1, j];

            for (int j = 3; j <= 7; j++)
                result += matrix[0, j];

            for (int i = 1; i <= 2; i++)
                result += matrix[i, 7];

            for (int i = 2; i >= 1; i--)
                result += matrix[i, 6];

            textBox2.Text = result;

        }

        public char[,] BildTable()
        {
            var matrix = new char[5,8];
            var text = textBox1.Text;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    try
                    {
                        dataGridView1.Rows[i].Cells[j].Value = text[8 * i + j];
                        matrix[i, j] = text[8 * i + j];
                    }
                    catch (Exception)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = " ";
                        matrix[i, j] = ' ';

                    }

            return matrix;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var matrix = new char[5, 8];
            var text = textBox2.Text;
            var position = 0;

            // Идем по маршруту
            for (int i = 0; i < 5; i++, position++)
                matrix[i, 0] = text.Length > position?text[position]:' ';

            for (int j = 1; j < 8; j++, position++)
                matrix[4, j] = text.Length > position ? text[position] : ' ';

            for (int j = 7; j > 0; j--, position++)
                matrix[3, j] = text.Length > position ? text[position] : ' ';

            for (int i = 2; i >= 0; i--, position++)
                matrix[i, 1] = text.Length > position ? text[position] : ' ';

            for (int i = 0; i < 2; i++, position++)
                matrix[i, 2] = text.Length > position ? text[position] : ' ';

            for (int j = 2; j <= 5; j++, position++)
                matrix[2, j] = text.Length > position ? text[position] : ' ';

            for (int j = 5; j >= 3; j--, position++)
                matrix[1, j] = text.Length > position ? text[position] : ' ';

            for (int j = 3; j <= 7; j++, position++)
                matrix[0, j] = text.Length > position ? text[position] : ' ';

            for (int i = 1; i <= 2; i++, position++)
                matrix[i, 7] = text.Length > position ? text[position] : ' ';

            for (int i = 2; i >= 1; i--, position++)
                matrix[i, 6] = text.Length > position ? text[position] : ' ';

            string result = "";
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                    result += matrix[i, j];
                }
            textBox3.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    dataGridView1.Rows[i].Cells[j].Value = "";
        }
    }
}
