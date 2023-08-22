using CompanyManagement.Entities.Enum;
using Microsoft.AspNetCore.Identity;

namespace CompanyManagement.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<UserEntity> _userManager;

        public RoleManager(IMapper mapper, UserManager<UserEntity> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public Task<IResult> CreateAsync(RoleCreateDto RoleCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(Guid RoleId)
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

        public Task<IResult> GetByIdAsync(Guid RoleId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetPassiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(RoleUpdateDto RoleUpdateDto)
        {
            throw new NotImplementedException();
        }

    }
}
