using CompanyManagement.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class RoleEntity : IdentityRole<Guid>
    {
        public RoleEntity()
        {
            
        }
    }
}
