using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class NewTransfer : Form
    {
        public string token;
        public string source;
        public Form1 parent;
        public NewTransfer()
        {
            InitializeComponent();
        }

        private void NewTransfer_Load(object sender, EventArgs e)
        {
            sourceTextBox.Text = source;
        }

        private void MakeTransferButton_Click(object sender, EventArgs e)
        {
            //pobieramy numer rachunku docelowego z formatki
            string target = targetTextBox.Text;
            //pobieramy kwotę przlewu z formatki jako float (w złotych)
            float userAmount = float.Parse(amountTextBox.Text);
            //sprawdzamy czy kwota jest większa od 0
            if (userAmount <= 0)
            {
                MessageBox.Show("Kwota przelewu musi być większa od 0");
                return;
            }
            //konwertujemy kwotę w złotówkach na grosze
            int amount = (int)Math.Round(userAmount * 100);
            //tworzymy obiekt zawierający dane przelewu
            var data = new
            {
                token = token,
                target = target,
                amount = amount
            };
            //wysyłamy do API zapytanie POST z danymi przelewu
            string url = "http://localhost/bankAPI/transfer/new/";
            HttpClient client = new HttpClient();
            //odpowiedz od api
            HttpResponseMessage response =
                client.PostAsJsonAsync(url, data).Result;
            //jeśli odpowiedź jest OK to przelew się udał
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Przelew wykonany pomyślnie");

                //odśwież dane rachunku - m.in. stan konta
                parent.GetAccountData();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Błąd podczas wykonywania przelewu");
                //TODO: wyciągnij błąd z jsona i wyświetl
            }
        }
    }
}