using CompanyManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class CustomerEntity : BaseEntity
    {
        public CustomerEntity()
        {
            CustomerProject = new List<CustomerProject>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set;}
        public string? Address { get; set;}

        public Guid CustomerProjectId { get; set; }
        public List<CustomerProject> CustomerProject { get; set; }
    }
}
