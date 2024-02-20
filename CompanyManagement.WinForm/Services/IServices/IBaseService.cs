using CompanyManagement.WinForm.DTOs.Request;
using CompanyManagement.WinForm.DTOs.Response;

namespace CompanyManagement.WinForm.Services.IServices
{
    public interface IBaseService
    {
        Task<ResponseDto> SendAsync(RequestDto requestDto, bool withBearer = false);
    }
}
