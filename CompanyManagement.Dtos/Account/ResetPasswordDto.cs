using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Dtos.Account
{
    public class ResetPasswordDto
    {
        public string Email { get; set; }
        public string RecoveryEmail { get; set; }
    }
}
