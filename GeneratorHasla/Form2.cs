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
    public partial class Form2 : Form
    {
        private RSA rsa = new RSA();
        private BigInteger EncryptNum;



        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // W listbox2 muszą znajdować się hasła
            if (listBox2.Items.Count != 0)
            {



                // W listbox2 musi być zaznaczone hasło, aby móc je zapisać
                if (listBox2.SelectedItems.Count != 0)
                {

                    // Strona, do której chcemy mieć hasło (Facebook, Instagram, Onet...)
                    string strona = textBox1.Text;
                    string xyz = "";

                    if (textBox1.Text != "")
                    {
                        xyz = $"{strona}: {listBox2.SelectedItem}";

                    }
                    else
                    {
                        xyz = $"{listBox2.SelectedItem}";
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


                    listBox2.SelectedItems.Clear();
                }
                else
                {
                    MessageBox.Show("Zaznacz hasło, aby je zapisać!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Wygeneruj hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string haslo = "";
            string haslo2 = "";
            string fraza1 = "";
            string fraza2 = "";
            string fraza3 = "";
            string znakiSpecjalne = "!@#$%&*_+?";
            string[] wyrazy = new string[] { };
            string[] frazy = new string[3];
            string[] rzecz_meski = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe/rzeczowniki_meski.txt");
            string[] rzecz_zenski = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe/rzeczowniki_zenski.txt");
            string[] rzecz_nijaki = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe/rzeczowniki_nijaki.txt");
            string[] przym_meski = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe/przymiotniki_meski.txt");
            string[] przym_zenski = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe/przymiotniki_zenski.txt");
            string[] przym_nijaki = File.ReadAllLines(Directory.GetCurrentDirectory() + "/pliki_tekstowe/przymiotniki_nijaki.txt");
            Random random = new Random();
            int losowaLiczba17 = random.Next(1, 8);
            int losowaLiczba1 = 0;
            int losowaLiczba2 = 0;
            int losowaLiczba3 = 0;
            int losowaLiczba4 = 0;
            int losowaLiczba5 = 0;
            string losowyZnak = "";
            int dlugoscHasla = Convert.ToInt32(numericUpDown1.Value);


            // Narzucona długość wyrazów
            if (checkBox1.Checked)
            {
                while (!(haslo.Length == dlugoscHasla))
                {
                    haslo = "";
                    fraza1 = "";
                    fraza2 = "";
                    fraza3 = "";
                    losowaLiczba1 = 0;
                    losowaLiczba2 = 0;

                    fraza1 = (przym_meski[random.Next(0, przym_meski.Length)] + " " + rzecz_meski[random.Next(0, rzecz_meski.Length)]);
                    fraza2 = (przym_zenski[random.Next(0, przym_zenski.Length)] + " " + rzecz_zenski[random.Next(0, rzecz_zenski.Length)]);
                    fraza3 = (przym_nijaki[random.Next(0, przym_nijaki.Length)] + " " + rzecz_nijaki[random.Next(0, rzecz_nijaki.Length)]);

                    frazy[0] = fraza1;
                    frazy[1] = fraza2;
                    frazy[2] = fraza3;

                    while (losowaLiczba1 == losowaLiczba2)
                    {
                        losowaLiczba1 = random.Next(0, 3);
                        losowaLiczba2 = random.Next(0, 3);
                    }

                    haslo = frazy[losowaLiczba1] + " " + frazy[losowaLiczba2];
                }

            }
            // Długość hasła nie jest sprecyzowana
            else
            {
                // przymiotrnik r. męski + rzeczownik r. męski
                fraza1 = (przym_meski[random.Next(0, przym_meski.Length)] + " " + rzecz_meski[random.Next(0, rzecz_meski.Length)]);

                // przymiotrnik r. żeński + rzeczownik r. żeński
                fraza2 = (przym_zenski[random.Next(0, przym_zenski.Length)] + " " + rzecz_zenski[random.Next(0, rzecz_zenski.Length)]);

                // przymiotrnik r. nijaki + rzeczownik r. nijaki
                fraza3 = (przym_nijaki[random.Next(0, przym_nijaki.Length)] + " " + rzecz_nijaki[random.Next(0, rzecz_nijaki.Length)]);

                // Poszczególne frazy jako elementy tablicy
                frazy[0] = fraza1;
                frazy[1] = fraza2;
                frazy[2] = fraza3;

                // Stworzenie dwóch różnych liczb z zakresu 1-3
                while (losowaLiczba1 == losowaLiczba2)
                {
                    losowaLiczba1 = random.Next(0, 3);
                    losowaLiczba2 = random.Next(0, 3);
                }

                // Losowość, aby uniknąć powtarzalności
                // Dostępne kombinacje:     r. męski, r. męski      +       r. żeński, r. żeński
                //                          r. męski, r. męski      +       r. nijaki, r. nijaki
                //                          r. żeński, r. żeński    +       r. nijaki, r. nijaki
                //                          r. żeński, r. żeński    +       r. męski, r. męski
                //                          r. nijaki, r. nijaki    +       r. męski, r. męski
                //                          r. nijaki, r. nijaki    +       r. żeński, r. żeński
                // Bez losowości występowałyby dwie formy
                haslo = frazy[losowaLiczba1] + " " + frazy[losowaLiczba2];
            }

            listBox1.Items.Add(haslo);


            // Zamiana polskich znaków diakrytycznych na podstawowe.
            for (int i = 0; i < haslo.Length; i++)
            {
                if (haslo[i].ToString() == "ą") haslo = haslo.Replace("ą", "a");
                else if (haslo[i].ToString() == "ć") haslo = haslo.Replace("ć", "c");
                else if (haslo[i].ToString() == "ę") haslo = haslo.Replace("ę", "e");
                else if (haslo[i].ToString() == "ł") haslo = haslo.Replace("ł", "l");
                else if (haslo[i].ToString() == "ń") haslo = haslo.Replace("ń", "n");
                else if (haslo[i].ToString() == "ó") haslo = haslo.Replace("ó", "o");
                else if (haslo[i].ToString() == "ś") haslo = haslo.Replace("ś", "s");
                else if (haslo[i].ToString() == "ż") haslo = haslo.Replace("ż", "z");
                else if (haslo[i].ToString() == "ź") haslo = haslo.Replace("ź", "z");
            }


            // Tablica wyrazów
            wyrazy = haslo.Split(' ');

            // 3 kolejne liczby na początku hasła
            //haslo2 = losowaLiczba17.ToString() + (losowaLiczba17 + 1).ToString() + (losowaLiczba17 + 2).ToString() + "_";

            // Pierwsze dwie litery z każdego wyrazu
            for (int i = 0; i < wyrazy.Length; i++)
                haslo2 += (wyrazy[i][0].ToString().ToUpper() + wyrazy[i][1].ToString());


            // Zamiana znaków
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


            // Do hasła wstawiamy 3 losowe cyfry, na losowe miejsce
            //haslo2 = haslo2.Insert(random.Next(0, haslo2.Length), losowaLiczba3.ToString());
            //haslo2 = haslo2.Insert(random.Next(0, haslo2.Length), losowaLiczba4.ToString());
            //haslo2 = haslo2.Insert(random.Next(0, haslo2.Length), losowaLiczba5.ToString());

            // Do hasła wstawiamy 3 losowe cyfry, na początek
            haslo2 = haslo2.Insert(0, losowaLiczba3.ToString());
            haslo2 = haslo2.Insert(1, losowaLiczba4.ToString());
            haslo2 = haslo2.Insert(2, losowaLiczba5.ToString());


            // Losowy znak specjalny na końcu hasła
            losowyZnak = znakiSpecjalne[random.Next(0, znakiSpecjalne.Length)].ToString();

            haslo2 += losowyZnak;

            listBox2.Items.Add(haslo2);


        }



    }
}
