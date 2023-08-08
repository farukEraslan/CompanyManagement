namespace CompanyManagement.BL.Abstract
{
    public interface IProjectService
    {
        /// <summary>
        /// Proje ekleme işlemini yapar.
        /// </summary>
        /// <param name="projectCreateDto"></param>
        /// <returns></returns>
        Task<IResult> Create(ProjectCreateDto projectCreateDto);

        /// <summary>
        /// Proje güncelleme işlemini yapar.
        /// </summary>
        /// <param name="projectUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> Update(ProjectUpdateDto projectUpdateDto);

        /// <summary>
        /// Proje silme işlemini yapar.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IResult> Delete(Guid projectId);

        /// <summary>
        /// Id'si verilen projenin bilgilerini getirir.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IResult> GetById(Guid projectId);

        /// <summary>
        /// Tüm projelerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAll();

        /// <summary>
        /// Tüm aktif projelerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActive();

        /// <summary>
        /// Tüm pasif projelerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassive();
    }
}
