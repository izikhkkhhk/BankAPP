using Newtonsoft.Json;
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
    public partial class Login : Form
    {
        //referencja od głównego okna aplikacji
        Form1 MainForm;
        public Login(Form1 p)
        {
            MainForm = p;
            InitializeComponent();
        }

        private void LoginButtonPressed(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            //to jest blibioteka do wysyłania zapytań http
            //i przetwarzania odpowiedzi otrzymanych z API
            HttpClient client = new HttpClient();
            //adres API
            string url = "http://localhost/bankAPI/login/";
            //stworz dane do wysłania
            //stworz "w powietrzu" obiekt zawierający login i hasło
            var data = new { login = login, password = password };
            //zakoduj jako json i wyślij postem
            //odbierz odpowiedź z API jako HttpResponseMessage
            HttpResponseMessage response = 
                client.PostAsJsonAsync(url, data).Result;
            //wyciągnij z odpowiedzi dane w formacie JSON
            string json = response.Content.ReadAsStringAsync().Result;
            Token t = JsonConvert.DeserializeObject<Token>(json);
            //przekazujemy token do głównego okna aplikacji używajac referencji
            MainForm.token = t.token;
            //zamykamy okno logowania
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ExitButtonPressed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
