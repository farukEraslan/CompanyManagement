namespace CompanyManagement.Business.Helpers
{
    public static class ExcelToDatabase
    {
        public static string ProcessExcelFile(string excelFilePath)
        {
            if (!string.IsNullOrEmpty(excelFilePath) && File.Exists(excelFilePath))
            {
                // Excel dosyasını oku ve veritabanına ekle
                var package = new ExcelPackage(new FileInfo(excelFilePath));
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var worksheet = package.Workbook.Worksheets.FirstOrDefault();
                if (worksheet != null)
                {
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;
                    var list = new List<Product>();

                    var context = new CompanyManagementDbContext();

                    for (int row = 2; row <= rowCount; row++) // İlk satırı atla (başlık satırı)
                    {
                        var newData = new Product(); // Excel verilerine karşılık gelen varlık sınıfı

                        // Verileri oku ve varlık sınıfına ekle
                        newData.SerialNo = worksheet.Cells[row, 1].Value?.ToString();
                        newData.Name = worksheet.Cells[row, 2].Value?.ToString();
                        newData.Description = worksheet.Cells[row, 3].Value?.ToString();
                        newData.Brand = worksheet.Cells[row, 4].Value?.ToString();
                        newData.Height = (double)worksheet.Cells[row, 5].Value;
                        newData.Width = (double)worksheet.Cells[row, 6].Value;
                        newData.Lenght = (double)worksheet.Cells[row, 7].Value;
                        newData.Quantity = (double)worksheet.Cells[row, 8].Value;
                        newData.QuantityUnit = worksheet.Cells[row, 9].Value?.ToString();
                        newData.EstWeight = (double)worksheet.Cells[row, 10].Value;
                        newData.WeightUnit = worksheet.Cells[row, 11].Value?.ToString();
                        newData.ExpiryDate = (DateTime?)worksheet.Cells[row, 12].Value;
                        newData.QualityGrade = worksheet.Cells[row, 13].Value?.ToString();
                        newData.LastBoughtPrice = Convert.ToDecimal(worksheet.Cells[row, 14].Value);
                        newData.UnitPrice = Convert.ToDecimal(worksheet.Cells[row, 15].Value);
                        newData.CreatedBy = Guid.NewGuid().ToString();
                        newData.ModifiedBy = Guid.NewGuid().ToString();
                        newData.CreatedDate = DateTime.Now;
                        newData.ModifiedDate = DateTime.Now;
                        // Diğer özellikler için gerekli okuma işlemlerini yapın

                        // Veritabanına ekle
                        //context.Products.Add(newData);
                        list.Add(newData);
                    }

                    
                    context.AddRange(list);
                    // Değişiklikleri kaydet
                    context.SaveChanges();

                    return "Excel verileri başarıyla veritabanına eklendi!";
                }
                else
                {
                    return "Excel dosyasında veri bulunamadı!";
                }
            }
            else
            {
                return "Lütfen bir Excel dosyası seçin!";
            }
        }
    }
}
