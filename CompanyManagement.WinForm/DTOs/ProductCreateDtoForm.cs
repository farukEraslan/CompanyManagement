using CompanyManagement.Core.Enums;
using CompanyManagement.Dtos.Product;

namespace CompanyManagement.WinForm.DTOs
{
    public class ProductCreateDtoForm : ProductCreateDto
    {
        public Status Status { get; set; } = Status.Added;
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
