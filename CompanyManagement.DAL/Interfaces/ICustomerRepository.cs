namespace CompanyManagement.DataAccess.Interfaces
{
    public interface ICustomerRepository : IAsyncRepository, IAsyncInsertableRepository<Customer>, IAsyncFindableRepository<Customer>, IAsyncOrderableRepository<Customer>, IAsyncQueryableRepository<Customer>, IAsyncUpdateableRepository<Customer>, IAsyncDeleteableRepository<Customer>
    {
    }
}
