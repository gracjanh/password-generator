namespace GeneratorHasla
{
    partial class Form2
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
            listBox1 = new ListBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox2 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(12, 114);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.None;
            listBox1.Size = new Size(645, 364);
            listBox1.TabIndex = 0;
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
            button3.TabIndex = 32;
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
            button2.TabIndex = 31;
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
            button1.TabIndex = 30;
            button1.Text = "Generuj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 24;
            listBox2.Location = new Point(663, 114);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(307, 364);
            listBox2.TabIndex = 35;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(209, 41);
            numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 32);
            numericUpDown1.TabIndex = 41;
            numericUpDown1.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(12, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(191, 28);
            checkBox1.TabIndex = 44;
            checkBox1.Text = "Długość wyrazów:";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(518, 501);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(452, 32);
            textBox1.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(438, 504);
            label2.Name = "label2";
            label2.Size = new Size(74, 24);
            label2.TabIndex = 54;
            label2.Text = "Strona:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(663, 87);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 55;
            label1.Text = "Hasła:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 56;
            label3.Text = "Wyrazy:";
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(982, 553);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private ListBox listBox2;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}