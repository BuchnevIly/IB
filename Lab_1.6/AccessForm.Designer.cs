namespace Lab_1._5
{
    partial class AccessForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteObject = new System.Windows.Forms.Button();
            this.textBoxObject = new System.Windows.Forms.TextBox();
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.listBoxObject = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPriveleges = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPrivObj = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriveleges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrivObj)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteUser);
            this.groupBox1.Controls.Add(this.textBoxUser);
            this.groupBox1.Controls.Add(this.buttonAddUser);
            this.groupBox1.Controls.Add(this.listBoxUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользователь";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(119, 149);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(75, 20);
            this.buttonDeleteUser.TabIndex = 3;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(12, 22);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 2;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(119, 22);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 20);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // listBoxUser
            // 
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.Location = new System.Drawing.Point(12, 48);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.Size = new System.Drawing.Size(182, 95);
            this.listBoxUser.TabIndex = 0;
            this.listBoxUser.SelectedIndexChanged += new System.EventHandler(this.listBoxUser_SelectedIndexChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(24, 215);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(105, 17);
            this.checkBox.TabIndex = 0;
            this.checkBox.Text = "Администратор";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(111, 238);
            this.numericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown.TabIndex = 2;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Права доступа";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteObject);
            this.groupBox2.Controls.Add(this.textBoxObject);
            this.groupBox2.Controls.Add(this.buttonAddObject);
            this.groupBox2.Controls.Add(this.listBoxObject);
            this.groupBox2.Location = new System.Drawing.Point(226, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 185);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Объект";
            // 
            // buttonDeleteObject
            // 
            this.buttonDeleteObject.Location = new System.Drawing.Point(119, 149);
            this.buttonDeleteObject.Name = "buttonDeleteObject";
            this.buttonDeleteObject.Size = new System.Drawing.Size(75, 20);
            this.buttonDeleteObject.TabIndex = 3;
            this.buttonDeleteObject.Text = "Удалить";
            this.buttonDeleteObject.UseVisualStyleBackColor = true;
            this.buttonDeleteObject.Click += new System.EventHandler(this.buttonDeleteObject_Click);
            // 
            // textBoxObject
            // 
            this.textBoxObject.Location = new System.Drawing.Point(12, 22);
            this.textBoxObject.Name = "textBoxObject";
            this.textBoxObject.Size = new System.Drawing.Size(100, 20);
            this.textBoxObject.TabIndex = 2;
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.Location = new System.Drawing.Point(119, 22);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(75, 20);
            this.buttonAddObject.TabIndex = 1;
            this.buttonAddObject.Text = "Добавить";
            this.buttonAddObject.UseVisualStyleBackColor = true;
            this.buttonAddObject.Click += new System.EventHandler(this.buttonAddObject_Click);
            // 
            // listBoxObject
            // 
            this.listBoxObject.FormattingEnabled = true;
            this.listBoxObject.Location = new System.Drawing.Point(12, 48);
            this.listBoxObject.Name = "listBoxObject";
            this.listBoxObject.Size = new System.Drawing.Size(182, 95);
            this.listBoxObject.TabIndex = 0;
            this.listBoxObject.SelectedIndexChanged += new System.EventHandler(this.listBoxUser_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Привелегии";
            // 
            // numericUpDownPriveleges
            // 
            this.numericUpDownPriveleges.Location = new System.Drawing.Point(111, 264);
            this.numericUpDownPriveleges.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownPriveleges.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPriveleges.Name = "numericUpDownPriveleges";
            this.numericUpDownPriveleges.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPriveleges.TabIndex = 5;
            this.numericUpDownPriveleges.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPriveleges.ValueChanged += new System.EventHandler(this.numericUpDownPriveleges_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Привелегии";
            // 
            // numericUpDownPrivObj
            // 
            this.numericUpDownPrivObj.Location = new System.Drawing.Point(314, 238);
            this.numericUpDownPrivObj.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownPrivObj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrivObj.Name = "numericUpDownPrivObj";
            this.numericUpDownPrivObj.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPrivObj.TabIndex = 7;
            this.numericUpDownPrivObj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrivObj.ValueChanged += new System.EventHandler(this.numericUpDownPrivObj_ValueChanged);
            // 
            // AccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownPrivObj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownPriveleges);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccessForm";
            this.Text = "AccessForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriveleges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrivObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDeleteObject;
        private System.Windows.Forms.TextBox textBoxObject;
        private System.Windows.Forms.Button buttonAddObject;
        private System.Windows.Forms.ListBox listBoxObject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPriveleges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPrivObj;
    }
}