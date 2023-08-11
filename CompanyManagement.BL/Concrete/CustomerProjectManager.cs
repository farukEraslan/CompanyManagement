namespace CompanyManagement.Business.Concrete
{
    public class CustomerProjectManager : ICustomerProjectService
    {
        public CustomerProjectManager()
        {
            
        }

        public Task<IResult> CreateAsync(CustomerProjectCreateDto customerProjectCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteAsync(Guid customerProjectId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetActiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetByIdAsync(Guid customerProjectId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetPassiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(CustomerProjectUpdateDto customerProjectUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
