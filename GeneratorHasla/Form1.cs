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


            // Dost�pna pula znak�w w zale�no�ci od checkboxa
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


            // Wykluczenie znak�w
            if (checkBox5.Checked)
            {


                wykluczoneZnaki = textBox1.Text;

                // Usuni�cie wskazanych znak�w z puli wszystkich znak�w
                foreach (var cc in wykluczoneZnaki)
                    wszystkieZnaki = wszystkieZnaki.Replace(cc.ToString(), "");
            }

            // W�asna pula znak�w
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

                // Dodanie w�asnych znak�w do puli wszystkich znak�w
                foreach (char cc in wlasneZnaki)
                    wszystkieZnaki += cc.ToString();
            }

            // Liczba cyfr
            if (checkBox7.Checked)
                bool_liczbaCyfr = true;


            // Liczba znak�w specjalnych
            if (checkBox8.Checked)
                bool_LiczbaZnakow = true;


            #region -1- W�ASNA PULA ZNAK�W

            // Zaznaczono w�asn� pul� znak�w i nie jest pusta
            if (checkBox6.Checked && textBox2.Text != "")
            {
                // Liczba wprowadzonych znak�w nie mo�e by� wi�ksza ni� d�ugo�� has�a
                if (wlasneZnaki.Length <= dlugoscHasla)
                {

                    // Generujemy has�o tak d�ugo, a� b�dzie zawiera�o wszystkie wprowadzone znaki
                    // (zapewnienie, �e has�o posiada te znaki, kt�re wprowadzono)
                    while (!(bool_wlasneZnaki == ma_wlasneZnaki))
                    {
                        // Warto�ci domy�lne na pocz�tku p�tli
                        ma_wielkieLitery = false;
                        ma_maleLitery = false;
                        ma_cyfry = false;
                        ma_znakiSpecjalne = false;
                        ma_wlasneZnaki = false;
                        haslo = "";
                        licznik = 0;

                        for (int i = 0; i < dlugoscHasla; i++)
                        {
                            // Utworzenie has�a
                            haslo += wszystkieZnaki[random.Next(0, wszystkieZnaki.Length)];
                        }

                        // Sprawdzenie, czy has�o zawiera wprowadzone znaki
                        for (int i = 0; i < wlasneZnaki.Length; i++)
                        {
                            if (haslo.Contains(wlasneZnaki[i]))
                                licznik++;
                        }

                        if (licznik == wlasneZnaki.Length)
                            ma_wlasneZnaki = true;
                    }

                    // Dodanie has�a do listBox1
                    listBox1.Items.Add(haslo);



                }
                else
                {
                    MessageBox.Show("Liczba znak�w nie mo�e by� wi�ksza ni� d�ugo�� has�a!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (checkBox6.Checked && textBox2.Text == "")
            {
                MessageBox.Show("Wprowad� znaki!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            #endregion



            #region -2- WIELKIE LITERY, MA�E LITERY, CYFRY, ZNAKI SPECJALNE, LICZBA CYFR, LICZBA ZNAK�W SPECJALNYCH

            else if ((checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked ||
                checkBox7.Checked || checkBox8.Checked))
            {

                if (checkBox7.Checked && !checkBox3.Checked ||
                    checkBox8.Checked && !checkBox4.Checked ||
                    checkBox7.Checked && !checkBox3.Checked && checkBox8.Checked && !checkBox4.Checked)
                {
                    MessageBox.Show("Zaznacz wi�cej opcji!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                else if (checkBox7.Checked && checkBox3.Checked && !checkBox1.Checked && !checkBox2.Checked && !checkBox4.Checked ||
                         checkBox8.Checked && checkBox4.Checked && !checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked ||
                         checkBox7.Checked && checkBox3.Checked && checkBox8.Checked && checkBox4.Checked && !checkBox1.Checked && !checkBox2.Checked)
                {
                    MessageBox.Show("Zaznacz wi�cej opcji!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                else
                {


                    // Generujemy has�o tak d�ugo, a� b�dzie zawiera�o wszystkie znaki zaznaczone w checkboxach
                    // (zapewnienie, �e has�o posiada te znaki, kt�re zaznaczono)
                    while (!((bool_LiczbaZnakow == ma_liczbeZnakow) && (bool_liczbaCyfr == ma_liczbeCyfr) && (bool_wielkieLitery == ma_wielkieLitery) && (bool_maleLitery == ma_maleLitery) &&
                         (bool_cyfry == ma_cyfry) && (bool_znakiSpecjalne == ma_znakiSpecjalne)))
                    {
                        // Warto�ci domy�lne na pocz�tku p�tli
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
                            // Utworzenie has�a
                            haslo += wszystkieZnaki[random.Next(0, wszystkieZnaki.Length)];
                        }

                        // Sprawdzenie, co zawiera has�o
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


                        // Zliczenie liczby znak�w specjalnych
                        for (int i = 0; i < dlugoscHasla; i++)
                        {
                            if (!char.IsLetterOrDigit(haslo[i]))
                                policz_2++;
                        }

                        if (policz_2 == liczbaZnakowSpecjalnych)
                            ma_liczbeZnakow = true;

                    }
                    // Dodanie has�a do listBox1
                    listBox1.Items.Add(haslo);

                }
            }
            #endregion






            // �adna z opcji nie zosta�a zaznaczona
            else if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked &&
                !checkBox5.Checked && !checkBox7.Checked && !checkBox8.Checked)
            {
                MessageBox.Show("Nie zaznaczono �adnej opcji!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Zaznaczona tylko opcja "wyklucz"

            else if (checkBox5.Checked && !checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked &&
                !checkBox6.Checked && !checkBox7.Checked && !checkBox8.Checked)
            {
                MessageBox.Show("Zaznacz wi�cej opcji!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // Strona, do kt�rej chcemy mie� has�o (Facebook, Instagram, Onet...)
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
                        MessageBox.Show("Tekst jest za d�ugi!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EncryptNum = rsa.Encryption(bigInt);



                    // Zapis do pliku txt zaszyfrowanego has�a
                    using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt", true))
                    {
                        writer.WriteLine(EncryptNum);
                    }

                    MessageBox.Show("Pomy�lnie zapisano has�o!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox3.Text = "";
                    listBox1.SelectedItems.Clear();
                }
                else
                {
                    MessageBox.Show("Zaznacz has�o, aby je zapisa�!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Wygeneruj has�o!", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error);


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