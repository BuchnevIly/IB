using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1._5
{


    public partial class Form1 : Form
    {
        public class DataObject
        {
            public string name { get; set; }
            public string data { get; set; }


            public override string ToString()
            {
                return name;
            }
        }

        public BindingList<string> Users;
        public BindingList<DataObject> Objects;
        public List<List<int>> P;

        private bool flag = false;

        public Form1()
        {
            InitializeComponent();

            Users = new BindingList<string> { "Пользователь 1", "Пользователь 2", "Пользователь 3" };
            Objects = new BindingList<DataObject> {
                new DataObject {name = "Объект 1", data = "Данные объекта 1" },
                new DataObject {name = "Объект 2", data = "Данные объекта 2" },
                new DataObject {name = "Объект 3", data = "Данные объекта 3" }
            };
            P = new List<List<int>>();
            Users.ToList().ForEach(x => P.Add(new List<int>()));
            P.ToList().ForEach(x =>
            {
                Objects.ToList().ForEach(y => x.Add(0));
                x.Add(0);
            });

            P[0][0] = 1;

            comboBoxUsers.DataSource = Users;
            listBoxObject.DataSource = Objects;
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Users.IndexOf(comboBoxUsers.SelectedItem.ToString());
            button1.Enabled = P[index][0] != 0;
            flag = false;
            ShowData();
        }

        private void ShowData()
        {
            var indexObject = Objects.IndexOf(Objects.First(x => x.name == listBoxObject.SelectedItem.ToString()));
            int indexUser = Users.IndexOf(comboBoxUsers.SelectedItem.ToString());

            switch (P[indexUser][indexObject + 1])
            {
                case 0:
                    textBox.Enabled = false;
                    textBox.Text = "Нет прав доступа";
                    break;
                case 1:
                    textBox.Enabled = false;
                    textBox.Text = Objects[indexObject].data;
                    break;
                case 2:
                    textBox.Enabled = true;
                    textBox.Text = Objects[indexObject].data;
                    break;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                var currentObject = Objects.First(x => x.name == listBoxObject.SelectedItem.ToString());
                currentObject.data = textBox.Text;
            }
            flag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AccessForm(this);
            form.ShowDialog();
            ShowData();
        }

        private void listBoxObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
