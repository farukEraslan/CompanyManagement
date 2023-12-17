using CompanyManagement.Dtos.Product;
using CompanyManagement.WinForm.DTOs.ProductDtoSeriliaze;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace CompanyManagement.WinForm
{
    public partial class productPageForm : Form
    {
        private readonly HttpClient _httpClient;

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

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreatePage();
            productCreateForm.ShowDialog();
        }

        private void ürünÇýkarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productDeleteForm = new ProductDeletePage();
            productDeleteForm.ShowDialog();
        }

        private void productPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Ürün listesini alma
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
    }
}
