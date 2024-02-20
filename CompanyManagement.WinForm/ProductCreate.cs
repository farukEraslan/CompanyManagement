using CompanyManagement.Core.Utilities.Results;
using CompanyManagement.DataAccess.Context;
using CompanyManagement.Dtos.Product;
using CompanyManagement.Entities.Concrete;
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

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var productCreateDto = ProductBind();
                var result = await ProductCreate(productCreateDto);
                MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
        private Product ProductBind()
        {
            var productCreateDto = new Product();

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
            productCreateDto.CreatedBy = "GURTAS";
            productCreateDto.CreatedDate = DateTime.Now;
            productCreateDto.ModifiedBy = "GURTAS";
            productCreateDto.ModifiedDate = DateTime.Now;

            return productCreateDto;
        }

        private async Task<string> ProductCreate(Product productCreateDto)
        {
            try
            {
                CompanyManagementDbContext database = new CompanyManagementDbContext();
                database.Product.Add(productCreateDto);
                database.SaveChanges();
                return "Ürün başarı ile kaydedildi.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7233/api/");

            //var jsonData = JsonConvert.SerializeObject(productCreateDto);
            //var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            //var response = await client.PostAsync("Product/Create", content);

            //if (response.IsSuccessStatusCode)
            //{
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

        private void TextBoxNumberInputControl(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumberInputControl(e);
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumberInputControl(e);
        }

        private void txtLenght_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumberInputControl(e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumberInputControl(e);
        }

        private void txtEstWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumberInputControl(e);
        }

        private void txtLastPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumberInputControl(e);
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxNumberInputControl(e);
        }
    }
}
