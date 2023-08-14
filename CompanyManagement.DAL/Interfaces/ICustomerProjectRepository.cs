namespace CompanyManagement.DataAccess.Interfaces
{
    public interface ICustomerProjectRepository : IAsyncRepository, IAsyncInsertableRepository<CustomerProject>, IAsyncFindableRepository<CustomerProject>, IAsyncOrderableRepository<CustomerProject>, IAsyncQueryableRepository<CustomerProject>, IAsyncUpdateableRepository<CustomerProject>, IAsyncDeleteableRepository<CustomerProject>
    {
    }
}
