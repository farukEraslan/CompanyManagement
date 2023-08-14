namespace CompanyManagement.DataAccess.Interfaces
{
    public interface IProjectRepository : IAsyncRepository, IAsyncInsertableRepository<Project>, IAsyncFindableRepository<Project>, IAsyncOrderableRepository<Project>, IAsyncQueryableRepository<Project>, IAsyncUpdateableRepository<Project>, IAsyncDeleteableRepository<Project>
    {
    }
}
