namespace CompanyManagement.BL.Abstract
{
    public interface IProjectProductService
    {
        /// <summary>
        /// Projenin ürünlerini ekleme işlemini yapar.
        /// </summary>
        /// <param name="projectProductCreateDto"></param>
        /// <returns></returns>
        Task<IResult> Create(ProjectProductCreateDto projectProductCreateDto);

        /// <summary>
        /// Projenin ürünlerini güncelleme işlemini yapar.
        /// </summary>
        /// <param name="projectProductUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> Update(ProjectProductUpdateDto projectProductUpdateDto);

        /// <summary>
        /// Projenin ürünlerini silme işlemini yapar.
        /// </summary>
        /// <param name="projectProductId"></param>
        /// <returns></returns>
        Task<IResult> Delete(Guid projectProductId);

        /// <summary>
        /// Id'si verilen proje ürününün bilgilerini getirir.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        Task<IResult> GetById(Guid projectProductId);

        /// <summary>
        /// Tüm proje ürünlerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAll();

        /// <summary>
        /// Tüm aktif proje ürünlerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActive();

        /// <summary>
        /// Tüm pasif proje ürünlerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassive();
    }
}
