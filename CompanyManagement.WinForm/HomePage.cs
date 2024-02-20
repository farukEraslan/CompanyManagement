using CompanyManagement.Business.Helpers;
using CompanyManagement.DataAccess.Context;
using Newtonsoft.Json;

namespace CompanyManagement.WinForm
{
    public partial class HomePage : Form
    {
        private readonly HttpClient _httpClient;

        public HomePage()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void ProductPageForm_Load(object sender, EventArgs e)
        {
            GetProductList();
        }

        private void ProductTableHeaderBind()
        {
            productListTable.Columns[0].HeaderText = "Ürün ID";
            productListTable.Columns[1].HeaderText = "Seri Numarasý";
            productListTable.Columns[2].HeaderText = "Ürün Adý";
            productListTable.Columns[3].HeaderText = "Açýklama";
            productListTable.Columns[4].HeaderText = "Marka";
            productListTable.Columns[5].HeaderText = "Yükseklik";
            productListTable.Columns[6].HeaderText = "Geniþlik";
            productListTable.Columns[7].HeaderText = "Uzunluk";
            productListTable.Columns[8].HeaderText = "Miktar";
            productListTable.Columns[9].HeaderText = "Birim";
            productListTable.Columns[10].HeaderText = "Ort. Aðýrlýk";
            productListTable.Columns[11].HeaderText = "Birim";
            productListTable.Columns[12].HeaderText = "Son Kullanma Tarihi";
            productListTable.Columns[13].HeaderText = "Kalite";
            productListTable.Columns[14].HeaderText = "Son Alýnan Fiyat";
            productListTable.Columns[15].HeaderText = "Güncel Fiyat";
        }

        private async Task<string> GetUserRole(string tag)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7233/api/");

            var response = await client.GetAsync($"UserRole/GetRole?userId={tag}");

            string apiResponse = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<string>(apiResponse);
            return result;
        }

        // Ürün listesini alma metodu
        public async void GetProductList()
        {
            CompanyManagementDbContext database = new CompanyManagementDbContext();

            productListTable.DataSource = database.Product.Select(col => new
            {
                col.Id,
                col.SerialNo,
                col.Name,
                col.Description,
                col.Brand,
                col.Height,
                col.Width,
                col.Lenght,
                col.Quantity,
                col.QuantityUnit,
                col.EstWeight,
                col.WeightUnit,
                col.ExpiryDate,
                col.QualityGrade,
                col.LastBoughtPrice,
                col.UnitPrice
            }).ToList();
            ProductTableHeaderBind();

            //try
            //{
            //    HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:7233/api/Product/GetAll");

            //    if (response.IsSuccessStatusCode)
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        var result = JsonConvert.DeserializeObject<ProductDtoSeriliaze>(apiResponse);

            //        if (result.IsSuccess)
            //        {
            //            productListTable.DataSource = result.Data;
            //            ProductTableHeaderBind();

            //        }
            //        else
            //        {
            //            MessageBox.Show("API'den hata mesajý alýndý: " + result.Message);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("API'den veri alýnamadý. Hata kodu: " + response.StatusCode);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
            //}
        }

        private void UrunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreatePage();
            productCreateForm.ShowDialog();
            GetProductList();
        }

        private void UrunSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productDeleteForm = new ProductDeletePage();
            productDeleteForm.ShowDialog();
            GetProductList();
        }

        private void UrunGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productUpdateForm = new ProductUpdatePage();
            productUpdateForm.ShowDialog();
            GetProductList();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreatePage();
            productCreateForm.ShowDialog();
            GetProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var productDeleteForm = new ProductDeletePage();
            productDeleteForm.ShowDialog();
            GetProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var productUpdateForm = new ProductUpdatePage();
            productUpdateForm.ShowDialog();
            GetProductList();
        }

        private void btnRefreshTable_Click(object sender, EventArgs e)
        {
            GetProductList();
        }

        private void ProductPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void UploadExcelFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    var result = ExcelToDatabase.ProcessExcelFile(selectedFilePath);
                    MessageBox.Show(result, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetProductList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel dosyasýný kontrol ediniz!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
