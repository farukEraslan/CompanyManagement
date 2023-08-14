namespace CompanyManagement.DataAccess.Repository
{
    public class ProjectRepository : EFBaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(CompanyManagementDbContext context) : base(context)
        {
        }
    }
}
