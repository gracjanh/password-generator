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
    public partial class Form3 : Form
    {

        private RSA rsa = new RSA();
        private BigInteger EncryptNum;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string haslo1 = "";
            string haslo2 = "";
            string zdanie = "";
            string znakiSpecjalne = "!@#$%&*_+?";
            string[] wyrazy = new string[] { };
            Random random = new Random();
            int losowaLiczba = random.Next(1, 8);
            int losowaLiczba3 = 0;
            int losowaLiczba4 = 0;
            int losowaLiczba5 = 0;
            int liczbaLiter = 0;
            string losowyZnak = "";
            zdanie = textBox1.Text.ToLower();

            if (textBox1.Text != "")
            {
                // Zamiana polskich znaków diakrytycznych na podstawowe. Usunięcie znaków interpunkcyjnych, nawiasów itp.
                for (int i = 0; i < zdanie.Length; i++)
                {
                    if (zdanie[i].ToString() == "ą") zdanie = zdanie.Replace("ą", "a");
                    else if (zdanie[i].ToString() == "ć") zdanie = zdanie.Replace("ć", "c");
                    else if (zdanie[i].ToString() == "ę") zdanie = zdanie.Replace("ę", "e");
                    else if (zdanie[i].ToString() == "ł") zdanie = zdanie.Replace("ł", "l");
                    else if (zdanie[i].ToString() == "ń") zdanie = zdanie.Replace("ń", "n");
                    else if (zdanie[i].ToString() == "ó") zdanie = zdanie.Replace("ó", "o");
                    else if (zdanie[i].ToString() == "ś") zdanie = zdanie.Replace("ś", "s");
                    else if (zdanie[i].ToString() == "ż") zdanie = zdanie.Replace("ż", "z");
                    else if (zdanie[i].ToString() == "ź") zdanie = zdanie.Replace("ź", "z");
                    else if (zdanie[i].ToString() == ",") zdanie = zdanie.Replace(",", "");
                    else if (zdanie[i].ToString() == ".") zdanie = zdanie.Replace(".", "");
                    else if (zdanie[i].ToString() == "!") zdanie = zdanie.Replace("!", "");
                    else if (zdanie[i].ToString() == "?") zdanie = zdanie.Replace("?", "");
                    else if (zdanie[i].ToString() == "'") zdanie = zdanie.Replace("'", "");
                    else if (zdanie[i].ToString() == "\"") zdanie = zdanie.Replace("\"", "");
                    else if (zdanie[i].ToString() == ":") zdanie = zdanie.Replace(":", "");
                    else if (zdanie[i].ToString() == ";") zdanie = zdanie.Replace(";", "");
                    else if (zdanie[i].ToString() == "-") zdanie = zdanie.Replace("-", "");
                    else if (zdanie[i].ToString() == "(") zdanie = zdanie.Replace("(", "");
                    else if (zdanie[i].ToString() == ")") zdanie = zdanie.Replace(")", "");
                }

                // Każdy wyraz to osobny element w tablicy. 
                wyrazy = zdanie.Split(' ');

                // Zamiana znaków
                for (int i = 0; i < zdanie.Length; i++)
                {
                    if (zdanie[i].ToString() == "a") zdanie = zdanie.Replace("a", "@");
                    else if (zdanie[i].ToString() == "s") zdanie = zdanie.Replace("s", "$");
                    else if (zdanie[i].ToString() == "o") zdanie = zdanie.Replace("o", "0");
                    else if (zdanie[i].ToString() == "i") zdanie = zdanie.Replace("i", "!");
                    else if (zdanie[i].ToString() == "e") zdanie = zdanie.Replace("e", "3");
                    else if (zdanie[i].ToString() == " ") zdanie = zdanie.Replace(" ", "-");
                }



                // Zliczenie liczby liter we wprowadzonej frazie
                for (int i = 0; i < zdanie.Length; i++)
                {
                    if (zdanie[i] != '-')
                        liczbaLiter++;
                }


                // Pierwsze dwie litery z każdego wyrazu
                for (int i = 0; i < wyrazy.Length; i++)
                {
                    // Gdy wyraz ma więcej niż dwie litery, dodajemy do hasła dwie pierwsze litery.
                    if (wyrazy[i].Length >= 2)
                        haslo2 += (wyrazy[i][0].ToString().ToUpper() + wyrazy[i][1].ToString());

                    // Gdy wyraz ma jedną literę, dodajemy ją do hasła.
                    else
                        haslo2 += wyrazy[i][0].ToString().ToUpper();
                }


                // Haslo1 - zamiana pierwszej litery kazdego wyrazu na wielką + reszta wyrazów
                for (int i = 0; i < wyrazy.Length; i++)
                {
                    haslo1 += (wyrazy[i][0].ToString().ToUpper() + wyrazy[i].ToString().Substring(1) + "-");
                }
                haslo1 = haslo1.Remove(haslo1.Length - 1);

                // Zamiana znaków - haslo1
                for (int i = 0; i < haslo1.Length; i++)
                {
                    if (haslo1[i].ToString() == "a") haslo1 = haslo1.Replace("a", "@");
                    else if (haslo1[i].ToString() == "A") haslo1 = haslo1.Replace("A", "@");
                    else if (haslo1[i].ToString() == "s") haslo1 = haslo1.Replace("s", "$");
                    else if (haslo1[i].ToString() == "S") haslo1 = haslo1.Replace("S", "$");
                    else if (haslo1[i].ToString() == "o") haslo1 = haslo1.Replace("o", "0");
                    else if (haslo1[i].ToString() == "O") haslo1 = haslo1.Replace("O", "0");
                    else if (haslo1[i].ToString() == "i") haslo1 = haslo1.Replace("i", "!");
                    else if (haslo1[i].ToString() == "I") haslo1 = haslo1.Replace("I", "!");
                    else if (haslo1[i].ToString() == "e") haslo1 = haslo1.Replace("e", "3");
                    else if (haslo1[i].ToString() == "E") haslo1 = haslo1.Replace("E", "3");
                }


                // Zamiana znaków - haslo2
                for (int i = 0; i < haslo2.Length; i++)
                {
                    if (haslo2[i].ToString() == "a") haslo2 = haslo2.Replace("a", "@");
                    else if (haslo2[i].ToString() == "A") haslo2 = haslo2.Replace("A", "@");
                    else if (haslo2[i].ToString() == "s") haslo2 = haslo2.Replace("s", "$");
                    else if (haslo2[i].ToString() == "S") haslo2 = haslo2.Replace("S", "$");
                    else if (haslo2[i].ToString() == "o") haslo2 = haslo2.Replace("o", "0");
                    else if (haslo2[i].ToString() == "O") haslo2 = haslo2.Replace("O", "0");
                    else if (haslo2[i].ToString() == "i") haslo2 = haslo2.Replace("i", "!");
                    else if (haslo2[i].ToString() == "I") haslo2 = haslo2.Replace("I", "!");
                    else if (haslo2[i].ToString() == "e") haslo2 = haslo2.Replace("e", "3");
                    else if (haslo2[i].ToString() == "E") haslo2 = haslo2.Replace("E", "3");
                }


                // Wygenerowanie 3 różnych losowych cyfr 0-9
                do
                {
                    losowaLiczba3 = random.Next(0, 10);
                    losowaLiczba4 = random.Next(0, 10);
                    losowaLiczba5 = random.Next(0, 10);

                } while ((losowaLiczba3 == losowaLiczba4) || (losowaLiczba4 == losowaLiczba5) || (losowaLiczba3 == losowaLiczba5));



                // Do haslo1 wstawiamy 3 losowe cyfry, na początek
                haslo1 = haslo1.Insert(0, losowaLiczba3.ToString());
                haslo1 = haslo1.Insert(1, losowaLiczba4.ToString());
                haslo1 = haslo1.Insert(2, losowaLiczba5.ToString());

                // Do haslo2 wstawiamy 3 losowe cyfry, na początek
                haslo2 = haslo2.Insert(0, losowaLiczba3.ToString());
                haslo2 = haslo2.Insert(1, losowaLiczba4.ToString());
                haslo2 = haslo2.Insert(2, losowaLiczba5.ToString());


                // Losowy znak specjalny na końcu hasła
                losowyZnak = znakiSpecjalne[random.Next(0, znakiSpecjalne.Length)].ToString();

                haslo1 += losowyZnak;
                haslo2 += losowyZnak;


                if (liczbaLiter <= 15) listBox1.Items.Add(haslo1);
                else if (liczbaLiter > 15) listBox1.Items.Add(haslo2);
            }
            else
            {
                MessageBox.Show("Wprowadź dane!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {



            listBox1.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // W listbox1 muszą znajdować się hasła
            if (listBox1.Items.Count != 0)
            {

                // W listbox1 musi być zaznaczone hasło, aby móc je zapisać
                if (listBox1.SelectedItems.Count != 0)
                {

                    // Strona, do której chcemy mieć hasło (Facebook, Instagram, Onet...)
                    string strona = textBox2.Text;
                    string xyz = "";

                    if (textBox2.Text != "")
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
                        MessageBox.Show("Tekst jest za długi!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EncryptNum = rsa.Encryption(bigInt);


                    // Zapis do pliku txt zaszyfrowanego hasła
                    using (StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "/pliki_tekstowe/hasla.txt", true))
                    {
                        writer.WriteLine(EncryptNum);
                    }

                    MessageBox.Show("Pomyślnie zapisano hasło!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    listBox1.SelectedItems.Clear();
                }
                else
                {
                    MessageBox.Show("Zaznacz hasło, aby je zapisać!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wprowadź dane i wygeneruj hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }


    }
}
