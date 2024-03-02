using CompanyManagement.Core.Utilities.Results;
using CompanyManagement.DataAccess.Context;
using CompanyManagement.Dtos.Product;
using CompanyManagement.Dtos.Project;
using CompanyManagement.Entities.Concrete;
using CompanyManagement.WinForm.DTOs.ProductDtoSeriliaze;
using Newtonsoft.Json;
using System.Text;

namespace CompanyManagement.WinForm
{
    public partial class ProductUpdatePage : Form
    {
        public ProductUpdatePage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            ProductGetById(Guid.Parse(txtProductId.Text.Trim()));
        }

        private void ProductGetById(Guid productId)
        {
            CompanyManagementDbContext database = new CompanyManagementDbContext();
            var product = database.Product.Where(product => product.Id == productId).ToList();
            ProductGetByIdBind(product.First());


            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7233/api/");

            //HttpResponseMessage response = await client.GetAsync($"Product/GetById?productId={productId}");

            //if (response.IsSuccessStatusCode)
            //{
            //    string apiResponse = await response.Content.ReadAsStringAsync();
            //    var result = JsonConvert.DeserializeObject<ProductGetByIdSeriliaze>(apiResponse);

            //    if (result.IsSuccess)
            //    {
            //        ProductGetByIdBind(result.Data);
            //        return result.Data;
            //    }
            //    else
            //    {
            //        MessageBox.Show("API'den hata mesajı alındı: " + result.Message);
            //        return null;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("API'den veri alınamadı. Hata kodu: " + response.StatusCode);
            //    return null;
            //}
        }

        private void ProductGetByIdBind(Product data)
        {
            txtSerialNo.Text = data.SerialNo;
            txtProductName.Text = data.Name;
            txtDescription.Text = data.Description;
            txtBrand.Text = data.Brand;
            txtHeight.Text = data.Height.ToString();
            txtWidth.Text = data.Width.ToString();
            txtLenght.Text = data.Lenght.ToString();
            txtQuantity.Text = data.Quantity.ToString();
            txtQuantityUnit.Text = data.QuantityUnit;
            txtEstWeight.Text = data.EstWeight.ToString();
            txtWeightUnit.Text = data.WeightUnit;
            dtExpiryDate.Value = data.ExpiryDate.Value;
            txtQualityGrade.Text = data.QualityGrade;
            txtLastPrice.Text = data.LastBoughtPrice.ToString();
            txtUnitPrice.Text = data.UnitPrice.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtSerialNo.Text = "";
            txtProductName.Text = "";
            txtDescription.Text = "";
            txtBrand.Text = "";
            txtHeight.Text = "";
            txtWidth.Text = "";
            txtLenght.Text = "";
            txtQuantity.Text = "";
            txtQuantityUnit.Text = "";
            txtEstWeight.Text = "";
            txtWeightUnit.Text = "";
            dtExpiryDate.Value = DateTime.Now;
            txtQualityGrade.Text = "";
            txtLastPrice.Text = "";
            txtUnitPrice.Text = "";
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var product = ProductUpdateBind(Guid.Parse(txtProductId.Text.Trim()));
                var result = await ProductUpdate(product);
                MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private Product ProductUpdateBind(Guid productId)
        {
            CompanyManagementDbContext database = new CompanyManagementDbContext();
            var productUpdateDto = database.Product.Where(product => product.Id == productId).ToList().First();

            productUpdateDto.Id = Guid.Parse(txtProductId.Text.Trim());
            productUpdateDto.SerialNo = txtSerialNo.Text.Trim();
            productUpdateDto.Name = txtProductName.Text.Trim();
            productUpdateDto.Description = txtDescription.Text.Trim();
            productUpdateDto.Brand = txtBrand.Text.Trim();
            productUpdateDto.Height = Convert.ToDouble(txtHeight.Text.Trim());
            productUpdateDto.Width = Convert.ToDouble(txtWidth.Text.Trim());
            productUpdateDto.Lenght = Convert.ToDouble(txtLenght.Text.Trim());
            productUpdateDto.WeightUnit = txtWeightUnit.Text.Trim();
            productUpdateDto.Lenght = Convert.ToDouble(txtLenght.Text.Trim());
            productUpdateDto.Quantity = Convert.ToDouble(txtQuantity.Text.Trim());
            productUpdateDto.QuantityUnit = txtQuantityUnit.Text.Trim();
            productUpdateDto.EstWeight = Convert.ToDouble(txtEstWeight.Text.Trim());
            productUpdateDto.WeightUnit = txtWeightUnit.Text.Trim();
            productUpdateDto.ExpiryDate = dtExpiryDate.Value;
            productUpdateDto.QualityGrade = txtQualityGrade.Text.Trim();
            productUpdateDto.LastBoughtPrice = Convert.ToDecimal(txtLastPrice.Text.Trim());
            productUpdateDto.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim());
            productUpdateDto.ModifiedBy = "GURTAS";
            productUpdateDto.ModifiedDate = DateTime.Now;

            return productUpdateDto;
        }

        private async Task<string> ProductUpdate(Product productUpdateDto)
        {
            try
            {
                CompanyManagementDbContext database = new CompanyManagementDbContext();
                var hasProduct = database.Product.Select(p => p.SerialNo == productUpdateDto.SerialNo).First();
                if (hasProduct)
                {
                    return "Ürün zaten var!";
                }
                else if (productUpdateDto.SerialNo == "" || productUpdateDto.Name == "")
                {
                    return "Seri numarası ya da ürün adı girmelisiniz!";
                }
                database.Product.Update(productUpdateDto);
                database.SaveChanges();
                return "Ürün başarı ile güncellendi.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:7233/api/");

            //var jsonData = JsonConvert.SerializeObject(productUpdateDto);
            //var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            //var response = await client.PutAsync("Product/Update", content);

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
