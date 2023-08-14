namespace CompanyManagement.DataAccess.Repository
{
    public class ProjectProductRepository : EFBaseRepository<ProjectProduct>, IProjectProductRepository
    {
        public ProjectProductRepository(CompanyManagementDbContext context) : base(context)
        {
        }
    }
}
