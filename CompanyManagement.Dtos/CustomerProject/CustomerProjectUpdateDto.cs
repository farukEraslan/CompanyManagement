namespace CompanyManagement.Dtos.CustomerProject
{
    public class CustomerProjectUpdateDto
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public Guid CustomerId { get; set; }
    }
}
