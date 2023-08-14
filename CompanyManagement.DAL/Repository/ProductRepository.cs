namespace CompanyManagement.DataAccess.Repository
{
    public class ProductRepository : EFBaseRepository<Product>, IProductRepository
    {
        public ProductRepository(CompanyManagementDbContext context) : base(context)
        {
        }
    }
}
