namespace CompanyManagement.Business.Abstract
{
    public interface IRoleService
    {
        /// <summary>
        /// Rol ekleme işlemini yapar.
        /// </summary>
        /// <param name="RoleCreateDto"></param>
        /// <returns></returns>
        Task<IResult> CreateAsync(RoleCreateDto RoleCreateDto);

        /// <summary>
        /// Rol güncelleme işlemini yapar.
        /// </summary>
        /// <param name="RoleUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> UpdateAsync(RoleUpdateDto RoleUpdateDto);

        /// <summary>
        /// Rol silme işlemini yapar.
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        Task<IResult> DeleteAsync(Guid RoleId);

        /// <summary>
        /// Id'si verilen Rol bilgilerini getirir.
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        Task<IResult> GetByIdAsync(Guid RoleId);

        /// <summary>
        /// Tüm Rollerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAllAsync();

        /// <summary>
        /// Tüm aktif Rollerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActiveAsync();

        /// <summary>
        /// Tüm pasif Rollerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassiveAsync();
    }
}
