using CompanyManagement.Dtos.Product;
using CompanyManagement.WinForm.DTOs.ProductDtoSeriliaze;
using Newtonsoft.Json;
using System.Windows.Forms;

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

        private void ProductPageForm_Load(object sender, EventArgs e)
        {
            GetProductList();
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

        private void UrunCikarToolStripMenuItem_Click(object sender, EventArgs e)
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
