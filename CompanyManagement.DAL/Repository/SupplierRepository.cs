namespace CompanyManagement.DataAccess.Repository
{
    public class SupplierRepository : EFBaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(CompanyManagementDbContext context) : base(context)
        {
        }
    }
}
