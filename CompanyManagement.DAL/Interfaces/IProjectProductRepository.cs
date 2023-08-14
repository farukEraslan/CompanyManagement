namespace CompanyManagement.DataAccess.Interfaces
{
    public interface IProjectProductRepository : IAsyncRepository, IAsyncInsertableRepository<ProjectProduct>, IAsyncFindableRepository<ProjectProduct>, IAsyncOrderableRepository<ProjectProduct>, IAsyncQueryableRepository<ProjectProduct>, IAsyncUpdateableRepository<ProjectProduct>, IAsyncDeleteableRepository<ProjectProduct>
    {
    }
}
