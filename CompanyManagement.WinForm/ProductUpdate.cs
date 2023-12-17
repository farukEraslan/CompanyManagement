using CompanyManagement.Dtos.Product;
using CompanyManagement.Dtos.Project;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async void btnGetById_Click(object sender, EventArgs e)
        {
            var product = await ProductGetById(Guid.Parse(txtProductId.Text.Trim()));
        }

        private async Task<ProductUpdateDto> ProductGetById(Guid productId)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7233/api/");

            var responseMessage = client.GetAsync($"Product/GetById?productId={productId}");

            if (responseMessage.IsCompletedSuccessfully)
            {
                
            }
            return null;
        }
    }
}
