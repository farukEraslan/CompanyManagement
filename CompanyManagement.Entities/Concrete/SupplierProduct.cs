namespace CompanyManagement.Entities.Concrete
{
    public class SupplierProduct : BaseEntity
    {
        public SupplierProduct()
        {

        }

        public Guid ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public Guid SupplierId { get; set; }
        public SupplierEntity Supplier { get; set; }
    }
}
