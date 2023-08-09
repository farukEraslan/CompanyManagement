namespace CompanyManagement.Entities.Concrete
{
    public class Product : AuditableEntity
    {
        public Product()
        {
            ProjectProduct = new List<ProjectProduct>();
            SupplierProduct = new List<SupplierProduct>();
        }

        public string? SerialNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Brand { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Lenght { get; set; }
        public float Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public float? EstWeight { get; set; }
        public string? WeightUnit { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? QualityGrade { get; set; }
        public decimal? LastBoughtPrice { get; set; }
        public decimal? UnitPrice { get; set; }

        public Guid ProjectProductId { get; set; }
        public List<ProjectProduct> ProjectProduct { get; set; }
        public Guid SupplierProductId { get; set; }
        public List<SupplierProduct> SupplierProduct { get; set; }
        
    }
}
