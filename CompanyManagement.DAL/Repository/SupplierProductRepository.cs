namespace CompanyManagement.DataAccess.Repository
{
    public class SupplierProductRepository : EFBaseRepository<SupplierProduct>, ISupplierProductRepository
    {
        public SupplierProductRepository(CompanyManagementDbContext context) : base(context)
        {
        }
    }
}
