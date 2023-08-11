using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Business.Concrete
{
    public class AccountManager : IUserService
    {
        public AccountManager()
        {
            
        }

        public Task<IResult> CreateAsync(UserCreateDto userCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(Guid userId)
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

        public Task<IResult> GetByIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetPassiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(UserUpdateDto userUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
