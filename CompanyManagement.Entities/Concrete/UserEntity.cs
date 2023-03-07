using CompanyManagement.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class UserEntity : IdentityUser<int>, IBaseEntity
    {
        public UserEntity()
        {
            
        }

        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string LastName { get; set; }
        public string? SecondLastName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthLocation { get; set; }
        public string ImageURL { get; set; }
        public bool IsActıve { get; set; }
        public DateTime JobEnterDate { get; set; }
        public DateTime? JobExitDate { get; set; }
        
        public string Job { get; set; }
        public string Department { get; set; }
        
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public int? YillikIzinSayisi { get; set; }
        public string PersonelMail { get; set; }
    }
}
