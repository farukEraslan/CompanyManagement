using CompanyManagement.Dtos.Product;

namespace CompanyManagement.WinForm.DTOs.ProductDtoSeriliaze
{
    public class ProductDtoSeriliaze
    {
        public List<ProductDto> Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
