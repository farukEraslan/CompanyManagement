using CompanyManagement.WinForm.DTOs.ProductDtoSeriliaze;
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
            //var userRole = await GetUserRole(this.Tag.ToString());
            //if (userRole is null)
            //{
            //    MessageBox.Show("Programa giri� yetkiniz bulunmamakta!");
            //    return;
            //}
            //else
            //{
            //    if (userRole == "Admin")
            //    {
            //        UploadExcelFile.Enabled = false;
            //    }
            //}

            UploadExcelFile.Enabled = false;

            GetProductList();
        }

        private void ProductTableHeaderBind()
        {
            productListTable.Columns[0].HeaderText = "�r�n ID";
            productListTable.Columns[1].HeaderText = "Seri Numaras�";
            productListTable.Columns[2].HeaderText = "�r�n Ad�";
            productListTable.Columns[3].HeaderText = "A��klama";
            productListTable.Columns[4].HeaderText = "Marka";
            productListTable.Columns[5].HeaderText = "Y�kseklik";
            productListTable.Columns[6].HeaderText = "Geni�lik";
            productListTable.Columns[7].HeaderText = "Uzunluk";
            productListTable.Columns[8].HeaderText = "Miktar";
            productListTable.Columns[9].HeaderText = "Birim";
            productListTable.Columns[10].HeaderText = "Ort. A��rl�k";
            productListTable.Columns[11].HeaderText = "Birim";
            productListTable.Columns[12].HeaderText = "Son Kullanma Tarihi";
            productListTable.Columns[13].HeaderText = "Kalite";
            productListTable.Columns[14].HeaderText = "Son Al�nan Fiyat";
            productListTable.Columns[15].HeaderText = "G�ncel Fiyat";
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

        // �r�n listesini alma metodu
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
                        ProductTableHeaderBind();

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
    }
}
