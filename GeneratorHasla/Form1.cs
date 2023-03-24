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
    public partial class Form1 : Form
    {

        private RSA rsa = new RSA();
        private BigInteger EncryptNum;


        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Zmienne
            string wielkieLitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string maleLitery = "abcdefghijklmnopqrstuvwxyz";
            string cyfry = "0123456789";
            string znakiSpecjalne = @"!@#$%^&*()_-+=/\?";
            string wszystkieZnaki = "";
            string wykluczoneZnaki = "";
            string wlasneZnaki = "";
            string haslo = "";
            int dlugoscHasla = Convert.ToInt32(numericUpDown1.Value);
            int liczbaCyfr = Convert.ToInt32(numericUpDown2.Value);
            int liczbaZnakowSpecjalnych = Convert.ToInt32(numericUpDown3.Value);
            bool bool_wielkieLitery = false;
            bool bool_maleLitery = false;
            bool bool_cyfry = false;
            bool bool_znakiSpecjalne = false;
            bool bool_wlasneZnaki = false;
            bool bool_liczbaCyfr = false;
            bool bool_LiczbaZnakow = false;
            bool ma_wielkieLitery = false;
            bool ma_maleLitery = false;
            bool ma_cyfry = false;
            bool ma_znakiSpecjalne = false;
            bool ma_wlasneZnaki = false;
            bool ma_liczbeCyfr = false;
            bool ma_liczbeZnakow = false;
            int licznik = 0;
            int policz_1 = 0;
            int policz_2 = 0;
            Random random = new Random();


            // Dostêpna pula znaków w zale¿noœci od checkboxa
            if (checkBox1.Checked)
            {
                bool_wielkieLitery = true;
                wszystkieZnaki += wielkieLitery;

            }


            if (checkBox2.Checked)
            {
                bool_maleLitery = true;
                wszystkieZnaki += maleLitery;

            }


            if (checkBox3.Checked)
            {
                bool_cyfry = true;
                wszystkieZnaki += cyfry;

            }


            if (checkBox4.Checked)
            {
                bool_znakiSpecjalne = true;
                wszystkieZnaki += znakiSpecjalne;

            }


            // Wykluczenie znaków
            if (checkBox5.Checked)
            {


                wykluczoneZnaki = textBox1.Text;

                // Usuniêcie wskazanych znaków z puli wszystkich znaków
                foreach (var cc in wykluczoneZnaki)
                    wszystkieZnaki = wszystkieZnaki.Replace(cc.ToString(), "");
            }

            // W³asna pula znaków
            if (checkBox6.Checked)
            {
                bool_wlasneZnaki = true;
                bool_wielkieLitery = false;
                bool_maleLitery = false;
                bool_cyfry = false;
                bool_znakiSpecjalne = false;
                wszystkieZnaki = "";
                wykluczoneZnaki = "";
                wlasneZnaki = textBox2.Text;

                // Dodanie w³asnych znaków do puli wszystkich znaków
                foreach (char cc in wlasneZnaki)
                    wszystkieZnaki += cc.ToString();
            }

            // Liczba cyfr
            if (checkBox7.Checked)
                bool_liczbaCyfr = true;


            // Liczba znaków specjalnych
            if (checkBox8.Checked)
                bool_LiczbaZnakow = true;


            #region -1- W£ASNA PULA ZNAKÓW

            // Zaznaczono w³asn¹ pulê znaków i nie jest pusta
            if (checkBox6.Checked && textBox2.Text != "")
            {
                // Liczba wprowadzonych znaków nie mo¿e byæ wiêksza ni¿ d³ugoœæ has³a
                if (wlasneZnaki.Length <= dlugoscHasla)
                {

                    // Generujemy has³o tak d³ugo, a¿ bêdzie zawiera³o wszystkie wprowadzone znaki
                    // (zapewnienie, ¿e has³o posiada te znaki, które wprowadzono)
                    while (!(bool_wlasneZnaki == ma_wlasneZnaki))
                    {
                        // Wartoœci domyœlne na pocz¹tku pêtli
                        ma_wielkieLitery = false;
                        ma_maleLitery = false;
                        ma_cyfry = false;
                        ma_znakiSpecjalne = false;
                        ma_wlasneZnaki = false;
                        haslo = "";
                        licznik = 0;

                        for (int i = 0; i < dlugoscHasla; i++)
                        {
                            // Utworzenie has³a
                            haslo += wszystkieZnaki[random.Next(0, wszystkieZnaki.Length)];
                        }

                        // Sprawdzenie, czy has³o zawiera wprowadzone znaki
                        for (int i = 0; i < wlasneZnaki.Length; i++)
                        {
                            if (haslo.Contains(wlasneZnaki[i]))
                                licznik++;
                        }

                        if (licznik == wlasneZnaki.Length)
                            ma_wlasneZnaki = true;
                    }

                    // Dodanie has³a do listBox1
                    listBox1.Items.Add(haslo);



                }
                else
                {
                    MessageBox.Show("Liczba znaków nie mo¿e byæ wiêksza ni¿ d³ugoœæ has³a!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkBox6.Checked && textBox2.Text == "")
            {
                MessageBox.Show("WprowadŸ znaki!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            #endregion



            #region -2- WIELKIE LITERY, MA£E LITERY, CYFRY, ZNAKI SPECJALNE, LICZBA CYFR, LICZBA ZNAKÓW SPECJALNYCH

            else if ((checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked ||
                checkBox7.Checked || checkBox8.Checked))
            {

                if (checkBox7.Checked && !checkBox3.Checked ||
                    checkBox8.Checked && !checkBox4.Checked ||
                    checkBox7.Checked && !checkBox3.Checked && checkBox8.Checked && !checkBox4.Checked)
                {
                    MessageBox.Show("Zaznacz wiêcej opcji!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                else if (checkBox7.Checked && checkBox3.Checked && !checkBox1.Checked && !checkBox2.Checked && !checkBox4.Checked ||
                         checkBox8.Checked && checkBox4.Checked && !checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked ||
                         checkBox7.Checked && checkBox3.Checked && checkBox8.Checked && checkBox4.Checked && !checkBox1.Checked && !checkBox2.Checked)
                {
                    MessageBox.Show("Zaznacz wiêcej opcji!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                else
                {


                    // Generujemy has³o tak d³ugo, a¿ bêdzie zawiera³o wszystkie znaki zaznaczone w checkboxach
                    // (zapewnienie, ¿e has³o posiada te znaki, które zaznaczono)
                    while (!((bool_LiczbaZnakow == ma_liczbeZnakow) && (bool_liczbaCyfr == ma_liczbeCyfr) && (bool_wielkieLitery == ma_wielkieLitery) && (bool_maleLitery == ma_maleLitery) &&
                         (bool_cyfry == ma_cyfry) && (bool_znakiSpecjalne == ma_znakiSpecjalne)))
                    {
                        // Wartoœci domyœlne na pocz¹tku pêtli
                        ma_wielkieLitery = false;
                        ma_maleLitery = false;
                        ma_cyfry = false;
                        ma_znakiSpecjalne = false;
                        ma_wlasneZnaki = false;
                        ma_liczbeCyfr = false;
                        ma_liczbeZnakow = false;
                        haslo = "";
                        policz_2 = 0;

                        for (int i = 0; i < dlugoscHasla; i++)
                        {
                            // Utworzenie has³a
                            haslo += wszystkieZnaki[random.Next(0, wszystkieZnaki.Length)];
                        }

                        // Sprawdzenie, co zawiera has³o
                        for (int i = 0; i < wielkieLitery.Length; i++)
                        {
                            if (haslo.Contains(wielkieLitery[i]))
                                ma_wielkieLitery = true;
                        }

                        for (int i = 0; i < maleLitery.Length; i++)
                        {
                            if (haslo.Contains(maleLitery[i]))
                                ma_maleLitery = true;
                        }

                        for (int i = 0; i < cyfry.Length; i++)
                        {
                            if (haslo.Contains(cyfry[i]))
                                ma_cyfry = true;
                        }

                        for (int i = 0; i < znakiSpecjalne.Length; i++)
                        {
                            if (haslo.Contains(znakiSpecjalne[i]))
                                ma_znakiSpecjalne = true;
                        }

                        // Zliczenie liczby cyfr
                        policz_1 = haslo.Count(Char.IsDigit);

                        if (policz_1 == liczbaCyfr)
                            ma_liczbeCyfr = true;


                        // Zliczenie liczby znaków specjalnych
                        for (int i = 0; i < dlugoscHasla; i++)
                        {
                            if (!char.IsLetterOrDigit(haslo[i]))
                                policz_2++;
                        }

                        if (policz_2 == liczbaZnakowSpecjalnych)
                            ma_liczbeZnakow = true;

                    }
                    // Dodanie has³a do listBox1
                    listBox1.Items.Add(haslo);

                }
            }
            #endregion






            // ¯adna z opcji nie zosta³a zaznaczona
            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked &&
                !checkBox5.Checked && !checkBox7.Checked && !checkBox8.Checked)
            {
                MessageBox.Show("Nie zaznaczono ¿adnej opcji!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Zaznaczona tylko opcja "wyklucz"

            else if (checkBox5.Checked && !checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked &&
                !checkBox6.Checked && !checkBox7.Checked && !checkBox8.Checked)
            {
                MessageBox.Show("Zaznacz wiêcej opcji!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {

                if (listBox1.SelectedItems.Count != 0)
                {

                    // Strona, do której chcemy mieæ has³o (Facebook, Instagram, Onet...)
                    string strona = textBox3.Text;
                    string xyz = "";

                    if (textBox3.Text != "")
                    {
                        xyz = $"{strona}: {listBox1.SelectedItem}";

                    }
                    else
                    {
                        xyz = $"{listBox1.SelectedItem}";
                    }

                    // Szyfrowanie
                    byte[] encoded = Encoding.UTF8.GetBytes(xyz);
                    BigInteger bigInt = new BigInteger(encoded);
                    if (bigInt > rsa.n)
                        MessageBox.Show("Tekst jest za d³ugi!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EncryptNum = rsa.Encryption(bigInt);



                    // Zapis do pliku txt zaszyfrowanego has³a
                    using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt", true))
                    {
                        writer.WriteLine(EncryptNum);
                    }

                    MessageBox.Show("Pomyœlnie zapisano has³o!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox3.Text = "";
                    listBox1.SelectedItems.Clear();
                }
                else
                {
                    MessageBox.Show("Zaznacz has³o, aby je zapisaæ!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Wygeneruj has³o!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }


        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox5.Checked)
                textBox1.Enabled = true;
            else
                textBox1.Enabled = false;

        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = true;

                if (!checkBox6.Checked && checkBox5.Checked)
                {
                    textBox1.Enabled = true;
                    textBox2.Enabled = false;
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown2.Enabled = false;

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                numericUpDown3.Enabled = true;
            }
            else
            {
                numericUpDown3.Enabled = false;

            }
        }


    }
}