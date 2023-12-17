using CompanyManagement.Dtos.UserRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Business.Abstract
{
    public interface IUserRoleService
    {
        Task<IResult> CreateAsync(UserRoleCreateDto userRoleCreateDto);
        Task<IResult> UpdateAsync(UserRoleUpdateDto userRoleUpdateDto);
        Task<IResult> DeleteAsync(Guid userRoleId);
        Task<IList<string>> GetByIdAsync(Guid userId);
        Task<IResult> GetAllAsync();
        Task<IResult> GetActiveAsync();
        Task<IResult> GetPassiveAsync();
    }
}
