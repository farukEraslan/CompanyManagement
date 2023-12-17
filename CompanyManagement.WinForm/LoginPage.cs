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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //var loginDto = LoginBind();
            //var result = await Login(loginDto);

            //if (result != null)
            //{
            //    MessageBox.Show(result);
            //}
            //else
            //{
            //    var home = new productPageForm();
            //    home.GetProductList();
            //    this.Hide();
            //    home.Show();
            //}

            var home = new HomePage();
            home.GetProductList();
            this.Hide();
            home.Show();
        }

        private LoginDto LoginBind()
        {
            var loginDto = new LoginDto();
            loginDto.Email = txtUsername.Text;
            loginDto.Password = txtPassword.Text;
            return loginDto;
        }

        private async Task<string> Login(LoginDto loginDto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7233/api/");

            var jsonData = JsonConvert.SerializeObject(loginDto);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("Account/Login", content);

            if (response.IsSuccessStatusCode)
            {
                return null;
            }
            else
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                return errorMessage;                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
