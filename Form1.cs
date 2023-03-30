using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniKantor
{
    public partial class Form1 : Form
    {
        
        string[] currency = { "CZK", "USD", "EUR" }; //tabela przechowująca dostępne waluty
        double[] buy = { 0.19, 4.35, 4.69 }; // tabela przechowująca ceny kupna waluty
        double[] sell = { 0.2, 4.39, 4.74 }; // tabela przechowująca ceny sprzedaży waluty

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // wyświetli odpowiednie ceny do wybranej waluty przez użytkownika
        {
            int index = comboBox1.SelectedIndex;
            label2.Text = "Cena kupna: " + buy[index] + " PLN";
            label3.Text = "Cena sprzedaży: " + sell[index] + " PLN";
        }

        private void button1_Click(object sender, EventArgs e) //wywoływane gdy użytkownika kliknie w przycisk transkacji
        {
            double amount;
            if (double.TryParse(textBox1.Text, out amount)) //jeśli kwota została wprowadzona prawdiłowo przez użytkownika w pole tekstowe
            {
                int index = comboBox1.SelectedIndex;
                if (radioButton1.Checked) // jeśli użytkownik chce kupić walutę
                {
                    double result = amount * buy[index];
                    label4.Text = "Wartość transakcji: " + result + " PLN";
                }
                else //w innym przypadku - jeśli użytkownik chce sprzedać walutę
                {
                    double result = amount * sell[index];
                    label4.Text = "Wartość transakcji: " + result + " PLN";
                }
            }
            else //wyświetl komunikat gdy wprowadzone dane są nieprawidłowe
            {
                MessageBox.Show("Niepoprawna kwota!");
            }
        }
    }
}