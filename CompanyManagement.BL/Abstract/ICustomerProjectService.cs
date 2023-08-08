namespace CompanyManagement.BL.Abstract
{
    public interface ICustomerProjectService
    {
        /// <summary>
        /// Müşteri projesi oluşturma işlemi yapar.
        /// </summary>
        /// <param name="customerProjectCreateDto"></param>
        /// <returns></returns>
        Task<IResult> Create(CustomerProjectCreateDto customerProjectCreateDto);

        /// <summary>
        /// Müşteri projesini güncelleme işlemini yapar.
        /// </summary>
        /// <param name="customerProjectUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> Update(CustomerProjectUpdateDto customerProjectUpdateDto);

        /// <summary>
        /// Müşteri projesini silme işlemi yapar.
        /// </summary>
        /// <param name="customerProjectId"></param>
        /// <returns></returns>
        Task<IResult> Delete(Guid customerProjectId);

        /// <summary>
        /// Id'si verilen müşteri projesinin bilgilerini getirir.
        /// </summary>
        /// <param name="customerProjectId"></param>
        /// <returns></returns>
        Task<IResult> GetById(Guid customerProjectId);

        /// <summary>
        /// Tüm müşteri projelerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAll();

        /// <summary>
        /// Tüm aktif müşteri projelerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActive();

        /// <summary>
        /// Tüm pasif müşteri projelerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassive();
    }
}
