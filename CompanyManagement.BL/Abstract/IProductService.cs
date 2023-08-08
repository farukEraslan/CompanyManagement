namespace CompanyManagement.BL.Abstract
{
    public interface IProductService
    {
        /// <summary>
        /// Ürün ekleme işlemini yapar.
        /// </summary>
        /// <param name="productCreateDto"></param>
        /// <returns></returns>
        Task<IResult> Create(ProductCreateDto productCreateDto);

        /// <summary>
        /// Ürün güncelleme işlemini yapar.
        /// </summary>
        /// <param name="productUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> Update(ProductUpdateDto productUpdateDto);

        /// <summary>
        /// Ürün sime işlemini yapar.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<IResult> Delete(Guid productId);

        /// <summary>
        /// Id'si verilen ürünün bilgilerini getirir.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<IResult> GetById(Guid productId);

        /// <summary>
        /// Tüm ürünlerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAll();

        /// <summary>
        /// Tüm aktif ürünlerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActive();

        /// <summary>
        /// Tüm pasif ürünlerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassive();
    }
}
