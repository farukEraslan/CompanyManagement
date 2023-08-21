namespace CompanyManagement.Dtos.ProjectProduct
{
    public class ProjectProductUpdateDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ProjectId { get; set; }
    }
}
