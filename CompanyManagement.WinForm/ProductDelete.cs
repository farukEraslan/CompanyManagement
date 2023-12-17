using CompanyManagement.Dtos.Product;
using Newtonsoft.Json;
using System.Text;

namespace CompanyManagement.WinForm
{
    public partial class ProductDeletePage : Form
    {
        public ProductDeletePage()
        {
            InitializeComponent();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var productDeleteDto = ProductBind();
            await ProductDelete(productDeleteDto);
        }

        private ProductDeleteDto ProductBind()
        {
            var productDeleteDto = new ProductDeleteDto();

            productDeleteDto.ProductId =txtProductDelete.Text.Trim();

            return productDeleteDto;
        }

        private async Task ProductDelete(ProductDeleteDto productDeleteDto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7233/api/");

            //var jsonData = JsonConvert.SerializeObject(productDeleteDto);
            //var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var deleteUri = new Uri($"https://localhost:7233/api/Product/Delete/{productDeleteDto.ProductId}");
            var response = await client.DeleteAsync(deleteUri);

            if (response.IsSuccessStatusCode)
            {
                // Başarılı yanıt durumunda işlemleri gerçekleştirin
                var home = new productPageForm();
                home.GetProductList();
                this.Close();
                home.Show();
            }
            else
            {
                // Hata durumunda hata mesajını işleyin
                string errorMessage = await response.Content.ReadAsStringAsync();
                // Hata mesajını gösterin veya işleyin
            }
        }

        private void ProductDeletePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            var home = new productPageForm();
            home.GetProductList();
        }
    }
}
