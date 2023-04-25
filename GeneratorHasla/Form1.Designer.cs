namespace GeneratorHasla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox2 = new TextBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            checkBox4 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox8.Location = new Point(0, 366);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(277, 28);
            checkBox8.TabIndex = 37;
            checkBox8.Text = "Liczba znaków specjalnych:";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            checkBox8.Click += checkBox8_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox7.Location = new Point(0, 315);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(133, 28);
            checkBox7.TabIndex = 36;
            checkBox7.Text = "Liczba cyfr:";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            checkBox7.Click += checkBox7_CheckedChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Enabled = false;
            numericUpDown3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown3.Location = new Point(278, 365);
            numericUpDown3.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(63, 32);
            numericUpDown3.TabIndex = 35;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Enabled = false;
            numericUpDown2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(134, 314);
            numericUpDown2.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(63, 32);
            numericUpDown2.TabIndex = 34;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(113, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(351, 32);
            textBox2.TabIndex = 33;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(0, 265);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(103, 28);
            checkBox6.TabIndex = 32;
            checkBox6.Text = "Własne:";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            checkBox6.Click += checkBox6_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(0, 217);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(110, 28);
            checkBox5.TabIndex = 31;
            checkBox5.Text = "Wyklucz:";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            checkBox5.Click += checkBox5_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(113, 215);
            textBox1.MaxLength = 9;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 32);
            textBox1.TabIndex = 30;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Highlight;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(262, 491);
            button3.Name = "button3";
            button3.Size = new Size(119, 50);
            button3.TabIndex = 29;
            button3.Text = "Zapisz";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(137, 491);
            button2.Name = "button2";
            button2.Size = new Size(119, 50);
            button2.TabIndex = 28;
            button2.Text = "Wyczyść";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 491);
            button1.Name = "button1";
            button1.Size = new Size(119, 50);
            button1.TabIndex = 27;
            button1.Text = "Generuj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(520, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(450, 508);
            listBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-2, 17);
            label1.Name = "label1";
            label1.Size = new Size(139, 24);
            label1.TabIndex = 24;
            label1.Text = "Długość hasła:";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(0, 165);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(171, 28);
            checkBox4.TabIndex = 23;
            checkBox4.Text = "Znaki specjalne";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(168, 28);
            numericUpDown1.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 32);
            numericUpDown1.TabIndex = 25;
            numericUpDown1.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(0, 131);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(77, 28);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "Cyfry";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(0, 97);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(125, 28);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "Małe litery";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(0, 63);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(146, 28);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Wielkie litery";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(80, 416);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(383, 32);
            textBox3.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 419);
            label2.Name = "label2";
            label2.Size = new Size(74, 24);
            label2.TabIndex = 53;
            label2.Text = "Strona:";
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox8);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox7);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox6);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 473);
            panel1.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(520, 6);
            label3.Name = "label3";
            label3.Size = new Size(66, 24);
            label3.TabIndex = 55;
            label3.Text = "Hasła:";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(982, 553);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private TextBox textBox2;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private CheckBox checkBox4;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}