using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Dtos.CustomerProject
{
    public class CustomerProjectDto
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        //public string Project { get; set; }
        public Guid CustomerId { get; set; }
        //public string Customer { get; set; }
    }
}
