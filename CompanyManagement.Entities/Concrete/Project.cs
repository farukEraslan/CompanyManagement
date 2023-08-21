namespace CompanyManagement.Entities.Concrete
{
    public class Project : AuditableEntity
    {
        public Project()
        {
            CustomerProject = new List<CustomerProject>();
            ProjectProduct = new List<ProjectProduct>();
        }

        public string Name { get; set; }
        public string ProjectNumber { get; set; }

        public List<CustomerProject> CustomerProject { get; set; }
        public List<ProjectProduct> ProjectProduct { get; set; }
    }
}
