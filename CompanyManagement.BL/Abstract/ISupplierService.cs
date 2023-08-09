namespace CompanyManagement.Business.Abstract
{
    public interface ISupplierService
    {
        /// <summary>
        /// Tedarikçi ekleme işlemini yapar.
        /// </summary>
        /// <param name="supplierCreateDto"></param>
        /// <returns></returns>
        Task<IResult> CreateAsync(SupplierCreateDto supplierCreateDto);

        /// <summary>
        /// Tedarikçi güncelleme işlemini yapar.
        /// </summary>
        /// <param name="supplierUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> UpdateAsync(SupplierUpdateDto supplierUpdateDto);

        /// <summary>
        /// Tedaikçi silme işlemini yapar.
        /// </summary>
        /// <param name="supplierId"></param>
        /// <returns></returns>
        Task<IResult> DeleteAsync(Guid supplierId);

        /// <summary>
        /// Id'si verilen tedarikçinin bilgilerini getirir.
        /// </summary>
        /// <param name="supplierId"></param>
        /// <returns></returns>
        Task<IResult> GetByIdAsync(Guid supplierId);

        /// <summary>
        /// Tüm tedarikçilerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAllAsync();

        /// <summary>
        /// Tüm aktif tedarikçilerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActiveAsync();

        /// <summary>
        /// Tüm pasif tearikçilerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassiveAsync();
    }
}
