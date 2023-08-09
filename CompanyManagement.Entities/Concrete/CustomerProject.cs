namespace CompanyManagement.Entities.Concrete
{
    public class CustomerProject : AuditableEntity
    {
        public CustomerProject()
        {

        }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
