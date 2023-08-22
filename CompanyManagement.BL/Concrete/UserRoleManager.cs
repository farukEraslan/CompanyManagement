using CompanyManagement.Dtos.UserRole;
using CompanyManagement.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Business.Concrete
{
    public class UserRoleManager
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<UserEntity> _roleManager;

        public UserRoleManager(UserManager<UserEntity> userManager, RoleManager<UserEntity> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IResult> CreateAsync(UserRoleCreateDto userRoleCreateDto)
        {
            var user = await _userManager.FindByIdAsync(userRoleCreateDto.UserId.ToString());
            if (user == null)
            {
                return new ErrorResult("Kullanıcı bulunamadı.");
            }
            var role = await _roleManager.FindByNameAsync(userRoleCreateDto.Role);
            if (role == null)
            {
                return new ErrorResult("Rol bulunamadı.");
            }

            var result = new IdentityResult();

            if (userRoleCreateDto.Role == "admin")
            {
                result = await _userManager.AddToRoleAsync(user, Roles.Admin.ToString());
            }
            else if (userRoleCreateDto.Role == "operator")
            {
                result = await _userManager.AddToRoleAsync(user, Roles.Operator.ToString());
            }
            if (result.Succeeded != true)
            {
                return new ErrorResult("Kullanıcının rolü atanamadı.");
            }
            return new SuccessResult("Kullanıcının rolü başarıyla atandı.");
        }

        public Task<IResult> UpdateAsync(UserRoleUpdateDto userRoleUpdateDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(Guid userRoleId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetByIdAsync(Guid userRoleId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetPassiveAsync()
        {
            throw new NotImplementedException();
        }


    }
}
