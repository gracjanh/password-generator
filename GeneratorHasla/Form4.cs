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
    public partial class Form4 : Form
    {

        private RSA rsa = new RSA();
        private BigInteger EncryptNum;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textBox1 nie może być pusty
            if (textBox1.Text != "")
            {

                
                    // Strona, do której chcemy mieć hasło (Facebook, Instagram, Onet...)
                    string strona = textBox2.Text;
                    string xyz = "";

                    if (textBox2.Text != "")
                    {
                        xyz = $"{strona}: {textBox1.Text}";

                    }
                    else
                    {
                        xyz = $"{textBox1.Text}";
                    }

                // Szyfrowanie
                if (textBox1.Text != "")
                {
                    byte[] encoded = Encoding.UTF8.GetBytes(xyz);
                    BigInteger bigInt = new BigInteger(encoded);
                    if (bigInt > rsa.n)
                        MessageBox.Show("Tekst jest za długi!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EncryptNum = rsa.Encryption(bigInt);


                }
                else
                {
                    MessageBox.Show("Wprowadź dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


                // Zapis do pliku txt zaszyfrowanego hasła
                using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt", true))
                {
                    writer.WriteLine(EncryptNum);
                }

                MessageBox.Show("Pomyślnie zapisano hasło!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";


            }
            else
            {
                MessageBox.Show("Wprowadź dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        
    }
}
