using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class ProjectProduct : BaseEntity
    {
        public ProjectProduct()
        {

        }

        public Guid ProductId { get; set; }
        public ProductEntity Product { get; set; }
        public Guid ProjectId { get; set; }
        public ProjectEntity Project { get; set; }
    }
}
