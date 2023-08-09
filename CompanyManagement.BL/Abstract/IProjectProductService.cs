namespace CompanyManagement.Business.Abstract
{
    public interface IProjectProductService
    {
        /// <summary>
        /// Projenin ürünlerini ekleme işlemini yapar.
        /// </summary>
        /// <param name="projectProductCreateDto"></param>
        /// <returns></returns>
        Task<IResult> CreateAsync(ProjectProductCreateDto projectProductCreateDto);

        /// <summary>
        /// Projenin ürünlerini güncelleme işlemini yapar.
        /// </summary>
        /// <param name="projectProductUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> UpdateAsync(ProjectProductUpdateDto projectProductUpdateDto);

        /// <summary>
        /// Projenin ürünlerini silme işlemini yapar.
        /// </summary>
        /// <param name="projectProductId"></param>
        /// <returns></returns>
        Task<IResult> DeleteAsync(Guid projectProductId);

        /// <summary>
        /// Id'si verilen proje ürününün bilgilerini getirir.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IResult> GetByIdAsync(Guid projectProductId);

        /// <summary>
        /// Tüm proje ürünlerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAllAsync();

        /// <summary>
        /// Tüm aktif proje ürünlerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActiveAsync();

        /// <summary>
        /// Tüm pasif proje ürünlerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassiveAsync();
    }
}
