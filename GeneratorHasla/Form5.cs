using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace GeneratorHasla
{
    public partial class Form5 : Form
    {
        private RSA rsa = new RSA();
        private BigInteger EncryptNum;
        private BigInteger DecryptNum;
        bool click = false;
        bool click2 = false;


        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            listBox1.Items.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt"))
            {
                string[] hasla_txt = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt");
                BigInteger[] hasla_bigIntegers = Array.ConvertAll(hasla_txt, BigInteger.Parse);
                string[] hasla_odszyfrowane = new string[hasla_bigIntegers.Length];

                for (int i = 0; i < hasla_bigIntegers.Length; i++)
                {
                    DecryptNum = rsa.Decryption(hasla_bigIntegers[i]);
                    string decoded = Encoding.UTF8.GetString(DecryptNum.ToByteArray());
                    hasla_odszyfrowane[i] = decoded;
                    listBox1.Items.Add(hasla_odszyfrowane[i]);
                }

                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Plik nie istnieje! Wygeneruj i zapisz hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            textBox1.Text = "";

            Bitmap image = new Bitmap(Directory.GetCurrentDirectory() + "/view.png");
            button7.Image = image;
            click = false;
            textBox1.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string[] haslo_logowanie_RSA = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe//haslo_logowanie.txt");
            BigInteger[] haslo_bigIntegers = Array.ConvertAll(haslo_logowanie_RSA, BigInteger.Parse);

            DecryptNum = rsa.Decryption(haslo_bigIntegers[0]);
            
            // Odszyfrowane hasło z pliku haslo_logowanie.txt
            string haslo_logowanie = Encoding.UTF8.GetString(DecryptNum.ToByteArray());



            if (textBox1.Text != "")
            {
                if (textBox1.Text == haslo_logowanie)
                {
                    panel1.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                }
                else
                {
                    MessageBox.Show("Podano błędne hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Wprowadź hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Bitmap image = new Bitmap(Directory.GetCurrentDirectory() + "/view.png");
            button7.Image = image;
            click = false;
            textBox1.Text = "";
            textBox1.UseSystemPasswordChar = true;
        }

        private void button6_Clicked(object sender, EventArgs e)
        {
            string[] haslo_logowanie_RSA = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe//haslo_logowanie.txt");
            BigInteger[] haslo_bigIntegers = Array.ConvertAll(haslo_logowanie_RSA, BigInteger.Parse);
            DecryptNum = rsa.Decryption(haslo_bigIntegers[0]);

            // Odszyfrowane hasło z pliku haslo_logowanie.txt
            string haslo_logowanie = Encoding.UTF8.GetString(DecryptNum.ToByteArray());


            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                if (textBox2.Text == haslo_logowanie && textBox3.Text == textBox4.Text)
                {
                    // Szyfrowanie
                    byte[] encoded = Encoding.UTF8.GetBytes(textBox3.Text);
                    BigInteger bigInt = new BigInteger(encoded);
                    if (bigInt > rsa.n)
                        MessageBox.Show("Tekst jest za długi!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EncryptNum = rsa.Encryption(bigInt);

                    // Zapis do pliku txt zaszyfrowanego hasła
                    using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "/pliki_tekstowe/haslo_logowanie.txt"))
                    {
                        writer.Write(EncryptNum);
                    }

                    MessageBox.Show("Pomyślnie zmieniono hasło!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    panel1.Visible = false;
                    panel2.Visible = true;
                    panel3.Visible = false;
                }
                else
                {
                    MessageBox.Show("Podano błędne dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wprowadź dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            Bitmap image = new Bitmap(Directory.GetCurrentDirectory() + "/view.png");
            button8.Image = image;
            click2 = false;
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            textBox4.UseSystemPasswordChar = true;
        }

        private void button5_Clicked(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            Bitmap image = new Bitmap(Directory.GetCurrentDirectory() + "/view.png");
            button8.Image = image;
            click2 = false;
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            textBox4.UseSystemPasswordChar = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!click)
            {
                Bitmap image = new Bitmap(Directory.GetCurrentDirectory() + "/hidden.png");
                button7.Image = image;
                click = true;
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                Bitmap image = new Bitmap(Directory.GetCurrentDirectory() + "/view.png");
                button7.Image = image;
                click = false;
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!click2)
            {
                Bitmap image = new Bitmap(Directory.GetCurrentDirectory() + "/hidden.png");
                button8.Image = image;
                click2 = true;
                textBox2.UseSystemPasswordChar = false;
                textBox3.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;

            }
            else
            {
                Bitmap image = new Bitmap(Directory.GetCurrentDirectory() + "/view.png");
                button8.Image = image;
                click2 = false;
                textBox2.UseSystemPasswordChar = true;
                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            listBox1.Items.Clear();
            button1.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != 0)
            {

                DialogResult dialogResult = MessageBox.Show("Czy chcesz usunąć hasło?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {

                    if (File.Exists(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt"))
                    {
                        // Wczytanie pliku z hasłami
                        string[] hasla_txt = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt");


                        // Opróżnienie pliku z hasłami
                        File.WriteAllText(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt", String.Empty);


                        // Zapis haseł z wyjątkiem zaznaczonego
                        using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt"))
                        {
                            foreach (string s in hasla_txt)
                            {
                                if (!s.Equals(hasla_txt[listBox1.SelectedIndex]))
                                {
                                    writer.WriteLine(s);
                                }
                            }
                        }

                        // Usunięcie z listboxa zaznaczonego hasła 
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                    }
                    else
                    {
                        MessageBox.Show("Plik nie istnieje! Wygeneruj i zapisz hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    MessageBox.Show("Pomyślnie usunięto hasło!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (dialogResult == DialogResult.No)
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Zaznacz hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
