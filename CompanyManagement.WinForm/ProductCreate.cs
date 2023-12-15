using CompanyManagement.Dtos.Product;
using CompanyManagement.WinForm.DTOs;
using Newtonsoft.Json;
using System.Text;

namespace CompanyManagement.WinForm
{
    public partial class ProductCreatePage : Form
    {
        public ProductCreatePage()
        {
            InitializeComponent();
        }

        private void ProductCreatePage_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var productCreateDto = ProductBind();
            ProductCreate(productCreateDto);
        }

        // Formu Temizleme
        private void Clear()
        {
            txtBrand.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEstWeight.Text = string.Empty;
            txtHeight.Text = string.Empty;
            txtWidth.Text = string.Empty;
            txtLastPrice.Text = string.Empty;
            txtLenght.Text = string.Empty;
            txtQualityGrade.Text = string.Empty;
            txtQuantityUnit.Text = string.Empty;
            txtSerialNo.Text = string.Empty;
            txtWeightUnit.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            dtExpiryDate.Value = DateTime.Now;
        }

        // Ürün Oluşturma
        private ProductCreateDto ProductBind()
        {
            var productCreateDto = new ProductCreateDto();

            productCreateDto.SerialNo = txtSerialNo.Text.Trim();
            productCreateDto.Name = txtName.Text.Trim();
            productCreateDto.Description = txtDescription.Text.Trim();
            productCreateDto.Brand = txtBrand.Text.Trim();
            productCreateDto.Height = Convert.ToDouble(txtHeight.Text.Trim());
            productCreateDto.Width = Convert.ToDouble(txtWidth.Text.Trim());
            productCreateDto.Lenght = Convert.ToDouble(txtLenght.Text.Trim());
            productCreateDto.WeightUnit = txtWeightUnit.Text.Trim();
            productCreateDto.Lenght = Convert.ToDouble(txtLenght.Text.Trim());
            productCreateDto.Quantity = Convert.ToDouble(txtQuantity.Text.Trim());
            productCreateDto.QuantityUnit = txtQuantityUnit.Text.Trim();
            productCreateDto.EstWeight = Convert.ToDouble(txtEstWeight.Text.Trim());
            productCreateDto.WeightUnit = txtWeightUnit.Text.Trim();
            productCreateDto.ExpiryDate = dtExpiryDate.Value;
            productCreateDto.QualityGrade = txtQualityGrade.Text.Trim();
            productCreateDto.LastBoughtPrice = Convert.ToDecimal(txtLastPrice.Text.Trim());
            productCreateDto.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim());
            productCreateDto.CreatedBy = Guid.NewGuid();
            productCreateDto.ModifiedBy = Guid.NewGuid();

            return productCreateDto;
        }
        private async Task ProductCreate(ProductCreateDto productCreateDto)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7233/api/");

            var jsonData = JsonConvert.SerializeObject(productCreateDto);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("Product/Create", content);

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
    }
}
