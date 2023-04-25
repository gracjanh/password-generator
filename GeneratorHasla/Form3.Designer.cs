namespace GeneratorHasla
{
    partial class Form3
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(229, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(646, 32);
            textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(103, 150);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(772, 292);
            listBox1.TabIndex = 27;
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
            // textBox2
            // 
            textBox2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(519, 501);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(351, 32);
            textBox2.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(439, 504);
            label2.Name = "label2";
            label2.Size = new Size(74, 24);
            label2.TabIndex = 54;
            label2.Text = "Strona:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 123);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 55;
            label1.Text = "Hasła:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(103, 73);
            label3.Name = "label3";
            label3.Size = new Size(120, 24);
            label3.TabIndex = 56;
            label3.Text = "Wpisz frazę:";
            // 
            // Form3
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(982, 553);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}