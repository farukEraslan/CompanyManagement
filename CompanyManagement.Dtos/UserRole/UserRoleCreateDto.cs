using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Dtos.UserRole
{
    public class UserRoleCreateDto
    {
        public Guid UserId { get; set; }
        public string Role { get; set; }
    }
}
