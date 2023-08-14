namespace CompanyManagement.DataAccess.Interfaces
{
    public interface IProductRepository : IAsyncRepository, IAsyncInsertableRepository<Product>, IAsyncFindableRepository<Product>, IAsyncOrderableRepository<Product>, IAsyncQueryableRepository<Product>, IAsyncUpdateableRepository<Product>, IAsyncDeleteableRepository<Product>
    {
    }
}
