namespace CompanyManagement.Dtos.SupplierProduct
{
    public class SupplierProductCreateDto
    {
        public Guid ProductId { get; set; }
        public Guid SupplierId { get; set; }
    }
}
