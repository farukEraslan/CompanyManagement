using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public CustomerManager()
        {
            
        }

        public Task<IResult> CreateAsync(CustomerCreateDto customerCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetByIdAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetPassiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(CustomerUpdateDto customerUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
