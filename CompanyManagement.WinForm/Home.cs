using CompanyManagement.Dtos.Product;
using CompanyManagement.WinForm.DTOs.ProductDtoSeriliaze;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CompanyManagement.WinForm
{
    public partial class productPageForm : Form
    {
        private readonly HttpClient _httpClient;

        private const string ApiUrl = "https://localhost:7233/api/Product/Create"; // API'nin URL'si

        public productPageForm()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private void productPageForm_Load(object sender, EventArgs e)
        {
            GetProductList();
        }

        private void ürünListesiniYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetProductList();
        }

        // Ürün listesini alma
        private async void GetProductList()
        {
            try
            {
                // API'den veri al
                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7233/api/Product/GetAll");

                // Baþarýlý yanýtý kontrol et
                if (response.IsSuccessStatusCode)
                {
                    // JSON veriyi çözümle
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

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreate();
            productCreateForm.ShowDialog();
        }
    }
}
