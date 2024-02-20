using CompanyManagement.WinForm.DTOs.Request;
using CompanyManagement.WinForm.DTOs.Response;
using CompanyManagement.WinForm.Services.IServices;
using CompanyManagement.WinForm.Utility;

namespace CompanyManagement.WinForm
{
    public partial class LoginPage : Form
    {
        private readonly IBaseService _baseService;
        public LoginPage(IBaseService baseService)
        {
            _baseService = baseService;
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private bool buttonClicked = false;

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (buttonClicked is false)
            {
                LoginRequestDto loginRequestDto = new()
                {
                    UserName = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };

                if (loginRequestDto.UserName == "" || loginRequestDto.Password == "")
                {
                    MessageBox.Show("Kullanıcı adı veya Şifre alanları boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    buttonClicked = true;

                    ResponseDto result = await _baseService.SendAsync(new RequestDto
                    {
                        ApiType = SD.ApiType.POST,
                        Data = loginRequestDto,
                        Url = SD.AuthAPIBase + "api/Account/Login"
                    });

                    if (!result.IsSuccess)
                    {
                        MessageBox.Show(result.Message);
                        buttonClicked = false;
                    }
                    else
                    {
                        var homePage = new HomePage();
                        this.Hide();
                        homePage.Show();
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
