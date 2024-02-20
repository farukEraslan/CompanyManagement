using CompanyManagement.DataAccess.Context;
using CompanyManagement.Dtos.Product;
using CompanyManagement.Dtos.Project;
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
            try
            {
                var result = await ProductDelete(Guid.Parse(txtProductDelete.Text.Trim()));
                MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private async Task<string> ProductDelete(Guid productId)
        {
            try
            {
                CompanyManagementDbContext database = new CompanyManagementDbContext();
                var product = database.Product.Where(product => product.Id == productId).ToList();
                database.Product.Remove(product.First());
                database.SaveChanges();
                return "Ürün başarı ile silindi.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7233/api/");

            //var response = await client.DeleteAsync($"Product/Delete?productId={productId}");

            //if (response.IsSuccessStatusCode)
            //{
            //    this.Close();
            //    return null;
            //}
            //else
            //{
            //    string errorMessage = await response.Content.ReadAsStringAsync();
            //    return errorMessage;
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
