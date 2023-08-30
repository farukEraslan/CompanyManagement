using System.Drawing;

namespace CompanyManagement.Business.Abstract
{
    public interface IProductService
    {
        /// <summary>
        /// Ürün ekleme işlemini yapar.
        /// </summary>
        /// <param name="productCreateDto"></param>
        /// <returns></returns>
        Task<IDataResult<ProductQRCodeDto>> CreateAsync(ProductCreateDto productCreateDto);

        /// <summary>
        /// Ürün güncelleme işlemini yapar.
        /// </summary>
        /// <param name="productUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto);

        /// <summary>
        /// Ürün sime işlemini yapar.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<IResult> DeleteAsync(Guid productId);

        /// <summary>
        /// Id'si verilen ürünün bilgilerini getirir.
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        Task<IResult> GetByIdAsync(Guid productId);

        /// <summary>
        /// Tüm ürünlerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAllAsync();

        /// <summary>
        /// Tüm aktif ürünlerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActiveAsync();

        /// <summary>
        /// Tüm pasif ürünlerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassiveAsync();


        //Task<Byte[]> CreateQRCode(ProductQRCodeDto productQRCodeDto);

        Task<Byte[]> CreateQRCode(Guid productId);
    }
}
