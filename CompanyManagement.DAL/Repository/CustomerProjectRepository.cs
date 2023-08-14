using CompanyManagement.Core.DataAccess.EntityFramework;
using CompanyManagement.DataAccess.Interfaces;

namespace CompanyManagement.DataAccess.Repository
{
    public class CustomerProjectRepository : EFBaseRepository<CustomerProject>, ICustomerProjectRepository
    {
        public CustomerProjectRepository(CompanyManagementDbContext context) : base(context)
        {
        }
    }
}
