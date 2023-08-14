namespace CompanyManagement.DataAccess.Repository
{
    public class CustomerRepository : EFBaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CompanyManagementDbContext context) : base(context)
        {

        }
    }
}
