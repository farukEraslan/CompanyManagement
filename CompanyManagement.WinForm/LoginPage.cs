using CompanyManagement.Dtos.Account;
using Newtonsoft.Json;
using System.Text;

namespace CompanyManagement.WinForm
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginDto = LoginBind();
            Login(loginDto);
        }

        private LoginDto LoginBind()
        {
            var loginDto = new LoginDto();
            loginDto.Email = txtUsername.Text;
            loginDto.Password = txtPassword.Text;
            return loginDto;
        }

        private async void Login(LoginDto loginDto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7233/api/");

            var jsonData = JsonConvert.SerializeObject(loginDto);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("Account/Login", content);

            if (response.IsSuccessStatusCode)
            {
                // Başarılı yanıt durumunda işlemleri gerçekleştirin
                var home = new productPageForm();
                home.GetProductList();
                this.Hide();
                home.Show();
            }
            else
            {
                // Hata durumunda hata mesajını işleyin
                string errorMessage = await response.Content.ReadAsStringAsync();
                // Hata mesajını gösterin veya işleyin
            }
        }
    }
}
