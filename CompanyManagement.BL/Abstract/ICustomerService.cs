namespace CompanyManagement.Business.Abstract
{
    public interface ICustomerService
    {
        /// <summary>
        /// Müşteri ekleme işlemini yapar.
        /// </summary>
        /// <param name="customerCreateDto"></param>
        /// <returns></returns>
        Task<IResult> CreateAsync(CustomerCreateDto customerCreateDto);

        /// <summary>
        /// Müşteri güncelleme işlemini yapar.
        /// </summary>
        /// <param name="customerUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> UpdateAsync(CustomerUpdateDto customerUpdateDto);

        /// <summary>
        /// Müşteri silme işlemini yapar.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<IResult> DeleteAsync(Guid customerId);

        /// <summary>
        /// Id'si verilen müşterinin bilgilerini getirir.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<IResult> GetByIdAsync(Guid customerId);

        /// <summary>
        /// Tüm müşterilerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAllAsync();

        /// <summary>
        /// Tüm aktif müşterilerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActiveAsync();

        /// <summary>
        /// Tüm pasif müşterilerin bilgisini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassiveAsync();
    }
}
