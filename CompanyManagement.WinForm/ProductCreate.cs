using CompanyManagement.Dtos.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        ProductCreateDto productCreateDto = new ProductCreateDto();

        private void btnCreate_Click(object sender, EventArgs e)
        {
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
        private async void ProductCreate(ProductCreateDto productCreateDto)
        {
            string apiUrl = "https://localhost:7233/api/Product/Create";
            string jsonData = $"{{\r\n  \"serialNo\": \"{productCreateDto.SerialNo}\",\r\n  \"name\": \"{productCreateDto.Name}\",\r\n  \"description\": \"{productCreateDto.Description}\",\r\n  \"brand\": \"{productCreateDto.Brand}\",\r\n  \"height\": {productCreateDto.Height},\r\n  \"width\": {productCreateDto.Width},\r\n  \"lenght\": {productCreateDto.Lenght},\r\n  \"quantity\": {productCreateDto.Quantity},\r\n  \"quantityUnit\": \"{productCreateDto.QuantityUnit}\",\r\n  \"estWeight\": {productCreateDto.EstWeight},\r\n  \"weightUnit\": \"{productCreateDto.WeightUnit}\",\r\n  \"expiryDate\": \"{productCreateDto.ExpiryDate}\",\r\n  \"qualityGrade\": \"{productCreateDto.QualityGrade}\",\r\n  \"lastBoughtPrice\": {productCreateDto.LastBoughtPrice},\r\n  \"unitPrice\": {productCreateDto.UnitPrice}\r\n}}";

            //HttpClient httpClient = new HttpClient();
            //StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            //try
            //{
            //    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

            //    if (response.IsSuccessStatusCode)
            //    {
            //        // İstek başarıyla tamamlandı
            //        string responseContent = await response.Content.ReadAsStringAsync();
            //        // Yanıtı işleyin
            //        MessageBox.Show("İstek başarıyla gönderildi. Yanıt: " + responseContent);
            //    }
            //    else
            //    {
            //        // İstek başarısız oldu
            //        MessageBox.Show("İstek başarısız oldu. Hata kodu: " + response.StatusCode);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hata oluştu: " + ex.Message);
            //}
            //finally
            //{
            //    httpClient.Dispose(); // HttpClient'i temizleyin
            //}

            var httpClient = new HttpClient();

            try
            {
                var request = new HttpRequestMessage
                {
                    RequestUri = new Uri("https://localhost:7233/api/Product/Create"), // API'nin URL'si
                    Method = HttpMethod.Post,
                    Content = new StringContent(jsonData, Encoding.UTF8, "application/json")
                };

                // İstek gönderme
                using (var response = await httpClient.SendAsync(request))
                {
                    // Başarılı yanıt durumu kontrolü (200-299 arası kodlar)
                    if (response.IsSuccessStatusCode)
                    {
                        // Yanıtı string olarak al
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        // İşlemleri burada yapabilirsiniz (örneğin, apiResponse üzerinden veri işleme)
                        MessageBox.Show("İstek başarıyla gönderildi. Yanıt: " + apiResponse);
                    }
                    else
                    {
                        MessageBox.Show("İstek başarısız! HTTP kodu: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
}
