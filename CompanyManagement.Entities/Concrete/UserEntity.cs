using CompanyManagement.Entities.Abstract;
using CompanyManagement.Entities.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class UserEntity : IdentityUser<Guid>
    {
        public UserEntity()
        {
            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ImageURL { get; set; }
        public bool IsActıve { get; set; }
        public string PersonelMail { get; set; }
    }
}
