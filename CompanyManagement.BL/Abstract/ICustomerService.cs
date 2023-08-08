namespace CompanyManagement.BL.Abstract
{
    public interface ICustomerService
    {
        /// <summary>
        /// Müşteri ekleme işlemini yapar.
        /// </summary>
        /// <param name="customerCreateDto"></param>
        /// <returns></returns>
        Task<IResult> Create(CustomerCreateDto customerCreateDto);

        /// <summary>
        /// Müşteri güncelleme işlemini yapar.
        /// </summary>
        /// <param name="customerUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> Update(CustomerUpdateDto customerUpdateDto);

        /// <summary>
        /// Müşteri silme işlemini yapar.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<IResult> Delete(Guid customerId);

        /// <summary>
        /// Id'si verilen müşterinin bilgilerini getirir.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        Task<IResult> GetById(Guid customerId);

        /// <summary>
        /// Tüm müşterilerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAll();

        /// <summary>
        /// Tüm aktif müşterilerin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActive();

        /// <summary>
        /// Tüm pasif müşterilerin bilgisini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassive();
    }
}
