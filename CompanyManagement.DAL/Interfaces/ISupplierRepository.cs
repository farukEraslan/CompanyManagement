namespace CompanyManagement.DataAccess.Interfaces
{
    public interface ISupplierRepository : IAsyncRepository, IAsyncInsertableRepository<Supplier>, IAsyncFindableRepository<Supplier>, IAsyncOrderableRepository<Supplier>, IAsyncQueryableRepository<Supplier>, IAsyncUpdateableRepository<Supplier>, IAsyncDeleteableRepository<Supplier>
    {
    }
}
