namespace CompanyManagement.Business.Abstract
{
    public interface ICustomerProjectService
    {
        /// <summary>
        /// Müşteri projesi oluşturma işlemi yapar.
        /// </summary>
        /// <param name="customerProjectCreateDto"></param>
        /// <returns></returns>
        Task<IResult> CreateAsync(CustomerProjectCreateDto customerProjectCreateDto);

        /// <summary>
        /// Müşteri projesini güncelleme işlemini yapar.
        /// </summary>
        /// <param name="customerProjectUpdateDto"></param>
        /// <returns></returns>
        Task<IResult> UpdateAsync(CustomerProjectUpdateDto customerProjectUpdateDto);

        /// <summary>
        /// Müşteri projesini silme işlemi yapar.
        /// </summary>
        /// <param name="customerProjectId"></param>
        /// <returns></returns>
        Task<IResult> DeleteAsync(Guid customerProjectId);

        /// <summary>
        /// Id'si verilen müşteri projesinin bilgilerini getirir.
        /// </summary>
        /// <param name="customerProjectId"></param>
        /// <returns></returns>
        Task<IResult> GetByIdAsync(Guid customerProjectId);

        /// <summary>
        /// Tüm müşteri projelerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetAllAsync();

        /// <summary>
        /// Tüm aktif müşteri projelerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetActiveAsync();

        /// <summary>
        /// Tüm pasif müşteri projelerinin bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        Task<IResult> GetPassiveAsync();
    }
}
