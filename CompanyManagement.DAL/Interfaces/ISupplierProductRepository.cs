namespace CompanyManagement.DataAccess.Interfaces
{
    public interface ISupplierProductRepository : IAsyncRepository, IAsyncInsertableRepository<SupplierProduct>, IAsyncFindableRepository<SupplierProduct>, IAsyncOrderableRepository<SupplierProduct>, IAsyncQueryableRepository<SupplierProduct>, IAsyncUpdateableRepository<SupplierProduct>, IAsyncDeleteableRepository<SupplierProduct>
    {
    }
}
