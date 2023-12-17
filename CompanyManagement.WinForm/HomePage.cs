using CompanyManagement.WinForm.DTOs.ProductDtoSeriliaze;
using Newtonsoft.Json;

namespace CompanyManagement.WinForm
{
    public partial class HomePage : Form
    {
        private readonly HttpClient _httpClient;

        public HomePage()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void ProductPageForm_Load(object sender, EventArgs e)
        {
            //var userRole = await GetUserRole(this.Tag.ToString());
            //if (userRole is null)
            //{
            //    MessageBox.Show("Programa giriþ yetkiniz bulunmamakta!");
            //    return;
            //}
            //else
            //{
            //    if (userRole == "Admin")
            //    {
            //        UploadExcelFile.Enabled = false;
            //    }
            //}

            UploadExcelFile.Enabled = false;

            GetProductList();
        }

        private async Task<string> GetUserRole(string tag)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7233/api/");

            var response = await client.GetAsync($"UserRole/GetRole?userId={tag}");

            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<string>(apiResponse);
            return result;
        }

        // Ürün listesini alma metodu
        public async void GetProductList()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7233/api/Product/GetAll");

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ProductDtoSeriliaze>(apiResponse);

                    if (result.IsSuccess)
                    {
                        productListTable.DataSource = result.Data;
                    }
                    else
                    {
                        MessageBox.Show("API'den hata mesajý alýndý: " + result.Message);
                    }
                }
                else
                {
                    MessageBox.Show("API'den veri alýnamadý. Hata kodu: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            }
        }

        private void UrunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreatePage();
            productCreateForm.ShowDialog();
            GetProductList();
        }

        private void UrunSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productDeleteForm = new ProductDeletePage();
            productDeleteForm.ShowDialog();
            GetProductList();
        }

        private void UrunGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productUpdateForm = new ProductUpdatePage();
            productUpdateForm.ShowDialog();
            GetProductList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreatePage();
            productCreateForm.ShowDialog();
            GetProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var productDeleteForm = new ProductDeletePage();
            productDeleteForm.ShowDialog();
            GetProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var productUpdateForm = new ProductUpdatePage();
            productUpdateForm.ShowDialog();
            GetProductList();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            GetProductList();
        }

        private void ProductPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
