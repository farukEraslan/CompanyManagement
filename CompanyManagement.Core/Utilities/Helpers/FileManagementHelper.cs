namespace CompanyManagement.Core.Utilities.Helpers
{
    public class FileManagementHelper
    {
        /// <summary>
        /// Bu metot kullanıcıdan alınan dosyayı, verilen dosya kategorisi yardımıyla ilgili klasöre kayıt eder.
        /// 
        /// - Homework : Ödev oluştururken kullanılacak olan enum parametre.
        /// - StudentHomework : Öğrencinin yükleyeceği ödev için kullanılacak parametre.
        /// - SupplementaryResources : Yardımcı kaynak eklemek için kullanılacak olan parametre.
        /// 
        /// Kategori tipleri CompanyManagement.Core.Enums.FileCategory içinden gelir.
        /// </summary>
        /// <param name="file">Kullanıcıdan alınan dosya</param>
        /// <param name="fileCategory">Yapılan işleme bağlı olarak seçilecek olan dosya kategorisi tipi.</param>
        /// <returns>Kullanıcıdan alınan dosya için oluşturulan Id ve dosya uzantısını döner.</returns>
        public static async Task<string> UploadFileAsync(IFormFile file, FileCategory fileCategory)
        {
            try
            {
                // Kayıt klasörü atama
                string targetPath = "";

                if (fileCategory == FileCategory.Homework)
                {
                    targetPath = Environment.CurrentDirectory + "\\wwwroot\\documents\\Homework";
                }
                else if (fileCategory == FileCategory.StudentHomework)
                {
                    targetPath = Environment.CurrentDirectory + "\\wwwroot\\documents\\StudentHomework";
                }
                else if (fileCategory == FileCategory.SupplementaryResource)
                {
                    targetPath = Environment.CurrentDirectory + "\\wwwroot\\documents\\SupplementaryResource";
                }

                // Dosya uzantısını alma
                string extension = Path.GetExtension(file.FileName);
                string itemId = Guid.NewGuid().ToString();
                // Hedef dosya yolunu oluşturma
                string targetFilePath = Path.Combine(targetPath, itemId + extension);

                // Dosyayı hedef klasöre kopyalama
                using (var stream = new FileStream(targetFilePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return itemId + extension;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static async Task<string> DeleteFileAsync(string filePath, FileCategory fileCategory)
        {
            try
            {
                string targetPath = "";

                if (fileCategory == FileCategory.Homework)
                {
                    targetPath = Environment.CurrentDirectory + "\\wwwroot\\documents\\Homework";
                }
                else if (fileCategory == FileCategory.StudentHomework)
                {
                    targetPath = Environment.CurrentDirectory + "\\wwwroot\\documents\\StudentHomework";
                }
                else if (fileCategory == FileCategory.SupplementaryResource)
                {
                    targetPath = Environment.CurrentDirectory + "\\wwwroot\\documents\\SupplementaryResource";
                }

                var entityFilePath = Path.Combine(targetPath, filePath);

                File.Delete(entityFilePath);

                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static async Task<string> UpdateFileAsync(string filePath, IFormFile file, FileCategory fileCategory)
        {
            await DeleteFileAsync(filePath, fileCategory);
            var newFileName = await UploadFileAsync(file, fileCategory);
            return newFileName;
        }
    }
}
