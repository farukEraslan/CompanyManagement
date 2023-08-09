namespace CompanyManagement.Business.Abstract
{
    public interface IProjectService
    {
        /// <summary>
        /// Proje ekleme işlemini yapar.
        /// </summary>
        /// <param name="projectCreateDto"></param>
        /// <returns></returns>
        Task<IResult> CreateAsync(ProjectCreateDto projectCreateDto);

        /// <summary>
        /// Proje güncelleme işlemini yapar.
        /// </summary>
        /// <param name="projectUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> UpdateAsync(ProjectUpdateDto projectUpdateDto);

        /// <summary>
        /// Proje silme işlemini yapar.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IResult> DeleteAsync(Guid projectId);

        /// <summary>
        /// Id'si verilen projenin bilgilerini getirir.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IResult> GetByIdAsync(Guid projectId);

        /// <summary>
        /// Tüm projelerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAllAsync();

        /// <summary>
        /// Tüm aktif projelerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActiveAsync();

        /// <summary>
        /// Tüm pasif projelerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassiveAsync();
    }
}
