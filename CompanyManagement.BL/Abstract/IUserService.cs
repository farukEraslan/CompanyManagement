namespace CompanyManagement.Business.Abstract
{
    public interface IUserService
    {
        /// <summary>
        /// Kullanıcı ekleme işlemini yapar.
        /// </summary>
        /// <param name="userCreateDto"></param>
        /// <returns></returns>
        Task<IResult> CreateAsync(UserCreateDto userCreateDto);

        /// <summary>
        /// Kullanıcı güncelleme işlemini yapar.
        /// </summary>
        /// <param name="userUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> UpdateAsync(UserUpdateDto userUpdateDto);

        /// <summary>
        /// Kullanıcı silme işlemini yapar.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<IResult> DeleteAsync(Guid userId);

        /// <summary>
        /// Id'si verilen kullanıcının bilgilerini getirir.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<IResult> GetByIdAsync(Guid userId);

        /// <summary>
        /// Tüm kullanıcıların bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAllAsync();

        /// <summary>
        /// Tüm aktif kullanıcıların bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActiveAsync();

        /// <summary>
        /// Tüm pasif kullanıcıların bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassiveAsync();
    }
}
