namespace LAB_2._4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.numericUpDownPWin1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPWin2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownXWin1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownYWin1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownF = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownYWin2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownXWin2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownYInf = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownXInf = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXWin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYWin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYWin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXWin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYInf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXInf)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(306, 268);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Вычислить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(19, 273);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // numericUpDownPWin1
            // 
            this.numericUpDownPWin1.DecimalPlaces = 3;
            this.numericUpDownPWin1.Location = new System.Drawing.Point(78, 12);
            this.numericUpDownPWin1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPWin1.Name = "numericUpDownPWin1";
            this.numericUpDownPWin1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPWin1.TabIndex = 2;
            this.numericUpDownPWin1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownPWin1.ValueChanged += new System.EventHandler(this.numericUpDownPWin1_ValueChanged);
            this.numericUpDownPWin1.Click += new System.EventHandler(this.numericUpDownPWin1_Click);
            this.numericUpDownPWin1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPWin1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "P окн1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "P окн2";
            // 
            // numericUpDownPWin2
            // 
            this.numericUpDownPWin2.DecimalPlaces = 3;
            this.numericUpDownPWin2.Location = new System.Drawing.Point(78, 38);
            this.numericUpDownPWin2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPWin2.Name = "numericUpDownPWin2";
            this.numericUpDownPWin2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPWin2.TabIndex = 4;
            this.numericUpDownPWin2.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownPWin2.ValueChanged += new System.EventHandler(this.numericUpDownPWin2_ValueChanged);
            this.numericUpDownPWin2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPWin1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X окн1";
            // 
            // numericUpDownXWin1
            // 
            this.numericUpDownXWin1.DecimalPlaces = 3;
            this.numericUpDownXWin1.Location = new System.Drawing.Point(78, 92);
            this.numericUpDownXWin1.Name = "numericUpDownXWin1";
            this.numericUpDownXWin1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXWin1.TabIndex = 6;
            this.numericUpDownXWin1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownXWin1.ValueChanged += new System.EventHandler(this.numericUpDownXWin1_ValueChanged);
            this.numericUpDownXWin1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPWin1_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y окн1";
            // 
            // numericUpDownYWin1
            // 
            this.numericUpDownYWin1.DecimalPlaces = 3;
            this.numericUpDownYWin1.Location = new System.Drawing.Point(78, 118);
            this.numericUpDownYWin1.Name = "numericUpDownYWin1";
            this.numericUpDownYWin1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYWin1.TabIndex = 8;
            this.numericUpDownYWin1.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownYWin1.ValueChanged += new System.EventHandler(this.numericUpDownYWin1_ValueChanged);
            this.numericUpDownYWin1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPWin1_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y забора";
            // 
            // numericUpDownF
            // 
            this.numericUpDownF.DecimalPlaces = 3;
            this.numericUpDownF.Location = new System.Drawing.Point(78, 232);
            this.numericUpDownF.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numericUpDownF.Name = "numericUpDownF";
            this.numericUpDownF.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownF.TabIndex = 10;
            this.numericUpDownF.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownF.ValueChanged += new System.EventHandler(this.numericUpDownF_ValueChanged);
            this.numericUpDownF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPWin1_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y окн2";
            // 
            // numericUpDownYWin2
            // 
            this.numericUpDownYWin2.DecimalPlaces = 3;
            this.numericUpDownYWin2.Enabled = false;
            this.numericUpDownYWin2.Location = new System.Drawing.Point(271, 118);
            this.numericUpDownYWin2.Name = "numericUpDownYWin2";
            this.numericUpDownYWin2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYWin2.TabIndex = 14;
            this.numericUpDownYWin2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownYWin2.ValueChanged += new System.EventHandler(this.numericUpDownYWin2_ValueChanged);
            this.numericUpDownYWin2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPWin1_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "X окн2";
            // 
            // numericUpDownXWin2
            // 
            this.numericUpDownXWin2.DecimalPlaces = 3;
            this.numericUpDownXWin2.Location = new System.Drawing.Point(271, 92);
            this.numericUpDownXWin2.Name = "numericUpDownXWin2";
            this.numericUpDownXWin2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXWin2.TabIndex = 12;
            this.numericUpDownXWin2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownXWin2.ValueChanged += new System.EventHandler(this.numericUpDownXWin2_ValueChanged);
            this.numericUpDownXWin2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPWin1_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Y инф";
            // 
            // numericUpDownYInf
            // 
            this.numericUpDownYInf.DecimalPlaces = 3;
            this.numericUpDownYInf.Location = new System.Drawing.Point(78, 191);
            this.numericUpDownYInf.Name = "numericUpDownYInf";
            this.numericUpDownYInf.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYInf.TabIndex = 18;
            this.numericUpDownYInf.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownYInf.ValueChanged += new System.EventHandler(this.numericUpDownYInf_ValueChanged);
            this.numericUpDownYInf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPWin1_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "X инф";
            // 
            // numericUpDownXInf
            // 
            this.numericUpDownXInf.DecimalPlaces = 3;
            this.numericUpDownXInf.Location = new System.Drawing.Point(78, 165);
            this.numericUpDownXInf.Name = "numericUpDownXInf";
            this.numericUpDownXInf.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXInf.TabIndex = 16;
            this.numericUpDownXInf.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownXInf.ValueChanged += new System.EventHandler(this.numericUpDownXInf_ValueChanged);
            this.numericUpDownXInf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.numericUpDownPWin1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 346);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownYInf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownXInf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownYWin2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownXWin2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownYWin1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownXWin1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownPWin2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownPWin1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Лаб 1.1 Бучнев Илья";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPWin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXWin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYWin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYWin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXWin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYInf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXInf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.NumericUpDown numericUpDownPWin1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPWin2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownXWin1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownYWin1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownYWin2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownXWin2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownYInf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownXInf;
    }
}

