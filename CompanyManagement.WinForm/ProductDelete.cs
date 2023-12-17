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
            var result = await ProductDelete(Guid.Parse(txtProductDelete.Text.Trim()));
            if (result != null)
            {
                MessageBox.Show(result);
            }
            else
            {
                this.Close();
            }
        }

        private async Task<string> ProductDelete(Guid productId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7233/api/");

            var response = await client.DeleteAsync($"Product/Delete?productId={productId}");

            if (response.IsSuccessStatusCode)
            {
                this.Close();
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
            this.Close();
        }
    }
}
