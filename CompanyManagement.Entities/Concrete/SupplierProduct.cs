namespace CompanyManagement.Entities.Concrete
{
    public class SupplierProduct : AuditableEntity
    {
        public SupplierProduct()
        {

        }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
