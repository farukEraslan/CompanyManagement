using CompanyManagement.Dtos.Product;
using CompanyManagement.Dtos.UserDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.WinForm.DTOs.ProductDtoSeriliaze
{
    public class LoginSeriliaze
    {
        public UserDto Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
