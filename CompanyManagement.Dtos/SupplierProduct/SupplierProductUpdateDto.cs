namespace CompanyManagement.Dtos.SupplierProduct
{
    public class SupplierProductUpdateDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid SupplierId { get; set; }
    }
}
