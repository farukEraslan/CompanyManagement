using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Dtos.UserRole
{
    public class UserRoleUpdateDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Role { get; set; }
    }
}
