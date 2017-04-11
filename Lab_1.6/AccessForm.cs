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
    public partial class AccessForm : Form
    {
        Form1 form;

        public AccessForm(Form1 form)
        {
            InitializeComponent();

            this.form = form;

            listBoxObject.DataSource = form.Objects;
            listBoxUser.DataSource = form.Users;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            form.Users.Add(textBoxUser.Text);
            textBoxUser.Text = "";

            form.P.Add(new List<int>());
            form.Objects.ToList().ForEach(y => form.P.Last().Add(0));
            form.P.Last().Add(0);
            form.PrivilegesUser.Add(3);
        }

        private void buttonAddObject_Click(object sender, EventArgs e)
        {
            form.Objects.Add(new Form1.DataObject { name = textBoxObject.Text, data = "", Privileges = 3 });
            textBoxObject.Text = "";

            form.P.ToList().ForEach(x => x.Add(0));
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            int index = form.Users.IndexOf(listBoxUser.SelectedItem.ToString());
            form.Users.RemoveAt(index);
            form.P.RemoveAt(index);
            form.PrivilegesUser.RemoveAt(index);
        }

        private void buttonDeleteObject_Click(object sender, EventArgs e)
        {
            var indexObject = form.Objects.IndexOf(form.Objects.First(x => x.name == listBoxObject.SelectedItem.ToString()));
            form.Objects.RemoveAt(indexObject);
            form.P.ToList().ForEach(x => x.RemoveAt(indexObject + 1));
        }

        private void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexObject = form.Objects.IndexOf(form.Objects.First(x => x.name == listBoxObject.SelectedItem.ToString()));
            int indexUser = form.Users.IndexOf(listBoxUser.SelectedItem.ToString());

            checkBox.Checked = form.P[indexUser][0] != 0;
            numericUpDown.Value = form.P[indexUser][indexObject + 1];
            numericUpDownPrivObj.Value = form.Objects[indexObject].Privileges;
            numericUpDownPriveleges.Value = form.PrivilegesUser[indexUser];
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            int indexUser = form.Users.IndexOf(listBoxUser.SelectedItem.ToString());
            form.P[indexUser][0] = checkBox.Checked ? 1 : 0;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var indexObject = form.Objects.IndexOf(form.Objects.First(x => x.name == listBoxObject.SelectedItem.ToString()));
            int indexUser = form.Users.IndexOf(listBoxUser.SelectedItem.ToString());

            form.P[indexUser][indexObject + 1] = (int)numericUpDown.Value;
        }

        private void numericUpDownPriveleges_ValueChanged(object sender, EventArgs e)
        {
            int indexUser = form.Users.IndexOf(listBoxUser.SelectedItem.ToString());

            form.PrivilegesUser[indexUser] = (int)numericUpDownPriveleges.Value;
        }

        private void numericUpDownPrivObj_ValueChanged(object sender, EventArgs e)
        {
            var indexObject = form.Objects.IndexOf(form.Objects.First(x => x.name == listBoxObject.SelectedItem.ToString()));
            form.Objects[indexObject].Privileges = (int)numericUpDownPrivObj.Value;
        }
    }
}
