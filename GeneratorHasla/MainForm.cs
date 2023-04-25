using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorHasla
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.TopLevel = false;
            form1.TopMost = true;
            form1.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form1);
            form1.BringToFront();
            form1.Show();

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.TopLevel = false;
            form2.TopMost = true;
            form2.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form2);
            form2.BringToFront();
            form2.Show();

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.TopLevel = false;
            form3.TopMost = true;
            form3.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form3);
            form3.BringToFront();
            form3.Show();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.TopLevel = false;
            form4.TopMost = true;
            form4.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form4);
            form4.BringToFront();
            form4.Show();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.TopLevel = false;
            form5.TopMost = true;
            form5.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form5);
            form5.BringToFront();
            form5.Show();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;

        }

       
    }
}
