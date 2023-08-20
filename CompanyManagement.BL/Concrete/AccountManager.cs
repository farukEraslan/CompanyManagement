using Microsoft.AspNetCore.Identity;

namespace CompanyManagement.Business.Concrete
{
    public class AccountManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<UserEntity> _userManager;

        public AccountManager(IMapper mapper, UserManager<UserEntity> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<IResult> CreateAsync(UserCreateDto userCreateDto)
        {
            var user = await _userManager.FindByNameAsync(userCreateDto.Username);
            if (user != null)
            {
                return new ErrorResult("Kullanıcı zaten var.");
            }
            var newUser = await _userManager.CreateAsync(_mapper.Map<UserEntity>(userCreateDto));
            return new SuccessResult("Kullanıcı başarı ile oluşturuldu.");
        }

        public async Task<IResult> UpdateAsync(UserUpdateDto userUpdateDto)
        {
            var user = await _userManager.FindByIdAsync(userUpdateDto.Id.ToString());
            if (user == null)
            {
                return new ErrorResult("Kullanıcı bulunamadı.");
            }
            var updatedUser = _userManager.UpdateAsync(user);
            return new SuccessResult("Kullanıcı başarı ile güncellendi.");
        }

        public async Task<IResult> DeleteAsync(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if(user == null)
            {
                return new ErrorResult("Kullanıcı bulunamadı.");
            }
            await _userManager.DeleteAsync(user);
            return new SuccessResult("Kullanıcı başarı ile silindi.");
        }

        public async Task<IResult> GetByIdAsync(Guid userId)
        {
            var user = _userManager.FindByIdAsync(userId.ToString());
            return new SuccessResult("Kullanıcı başarı ile listelendi.");
        }

        public async Task<IResult> GetAllAsync()
        {
            var users = _userManager.Users.ToList();
            return new SuccessDataResult<UserDto>(_mapper.Map<UserDto>(users),"Kullanıcılar başarı ile listelendi.");
        }

        public async Task<IResult> GetActiveAsync()
        {
            var users = _userManager.Users.GroupBy(x => x.IsActıve == true).ToList();
            return null;
        }       

        public Task<IResult> GetPassiveAsync()
        {
            throw new NotImplementedException();
        }        
    }
}
