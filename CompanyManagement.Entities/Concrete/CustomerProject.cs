using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class CustomerProject : BaseEntity
    {
        public CustomerProject()
        {

        }

        public Guid ProjectId { get; set; }
        public ProjectEntity Project { get; set; }
        public Guid CustomerId { get; set; }
        public CustomerEntity Customer { get; set; }
    }
}
