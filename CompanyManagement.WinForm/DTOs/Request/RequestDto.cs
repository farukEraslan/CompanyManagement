using static CompanyManagement.WinForm.Utility.SD;

namespace CompanyManagement.WinForm.DTOs.Request
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
