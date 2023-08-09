namespace CompanyManagement.Entities.Concrete
{
    public class ProjectProduct : AuditableEntity
    {
        public ProjectProduct()
        {

        }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
