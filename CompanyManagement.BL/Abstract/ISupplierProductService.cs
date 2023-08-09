namespace CompanyManagement.Business.Abstract
{
    public interface ISupplierProductService
    {
        /// <summary>
        /// Tedarikçinin ürünlerini ekleme işlemini yapar.
        /// </summary>
        /// <param name="supplierProductCreateDto"></param>
        /// <returns></returns>
        Task<IResult> CreateAsync(SupplierProductCreateDto supplierProductCreateDto);

        /// <summary>
        /// Tedarikçinin ürünlerini güncelleme işlemini yapar.
        /// </summary>
        /// <param name="supplierProductUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> UpdateAsync(SupplierProductUpdateDto supplierProductUpdateDto);

        /// <summary>
        /// Tedaikçinin ürününğ silme işlemini yapar.
        /// </summary>
        /// <param name="supplierProductId"></param>
        /// <returns></returns>
        Task<IResult> DeleteAsync(Guid supplierProductId);

        /// <summary>
        /// Id'si verilen tedarikçi ürününün bilgilerini getirir.
        /// </summary>
        /// <param name="supplierProductId"></param>
        /// <returns></returns>
        Task<IResult> GetByIdAsync(Guid supplierProductId);

        /// <summary>
        /// Tüm tedarikçilerin ürünlerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAllAsync();

        /// <summary>
        /// Tüm aktif tedarikçilerin ürünlerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActiveAsync();

        /// <summary>
        /// Tüm pasif tedarikçilerin ürünlerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassiveAsync();
    }
}
