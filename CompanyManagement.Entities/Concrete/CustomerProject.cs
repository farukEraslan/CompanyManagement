namespace CompanyManagement.Entities.Concrete
{
    public class CustomerProject : BaseEntity
    {
        public CustomerProject()
        {

        }

        public Guid ProjectId { get; set; }
        public ProjectEntity Project { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerEntity Customer { get; set; }
    }
}
