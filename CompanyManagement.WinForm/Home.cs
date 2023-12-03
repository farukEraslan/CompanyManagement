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

        private void �r�nListesiniYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetProductList();
        }

        // �r�n listesini alma
        private async void GetProductList()
        {
            try
            {
                // API'den veri al
                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7233/api/Product/GetAll");

                // Ba�ar�l� yan�t� kontrol et
                if (response.IsSuccessStatusCode)
                {
                    // JSON veriyi ��z�mle
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ProductDtoSeriliaze>(apiResponse);

                    if (result.IsSuccess)
                    {
                        productListTable.DataSource = result.Data;
                    }
                    else
                    {
                        MessageBox.Show("API'den hata mesaj� al�nd�: " + result.Message);
                    }
                }

                else
                {
                    MessageBox.Show("API'den veri al�namad�. Hata kodu: " + response.StatusCode);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata olu�tu: " + ex.Message);
            }
        }

        private void �r�nEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreate();
            productCreateForm.ShowDialog();
        }
    }
}
