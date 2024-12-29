using FormsGestaoHotelariaAPI;
using Newtonsoft.Json;
using System.Text;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsGestaoHotelariaAPI;
using Newtonsoft.Json;


namespace FormLogin
{
    public partial class Login : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, preencha ambos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var loginRequest = new
            {
                Email = email,
                Password = password
            };

            var jsonContent = JsonConvert.SerializeObject(loginRequest);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("https://localhost:7056/api/Auth/login", content);
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseString);

                    MessageBox.Show($"Login bem-sucedido! Perfil: {loginResponse.Perfil}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Utilizadores utilizadoresForm = new Utilizadores();
                    utilizadoresForm.Show();
                    this.Hide();
                }

                else
                {
                    var errorResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Erro: {errorResponse}", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class LoginResponse
    {
        public string Token { get; set; }
        public string Perfil { get; set; }
    }
}
