using CompanyManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class ProjectEntity : BaseEntity
    {
        public ProjectEntity()
        {
            CustomerProject = new List<CustomerProject>();
            ProjectProduct = new List<ProjectProduct>();
        }

        public string Name { get; set; }
        public string ProjectNumber { get; set; }

        public Guid CustomerProjectId { get; set; }
        public List<CustomerProject> CustomerProject { get; set; }
        public Guid ProjectProductId { get; set; }
        public List<ProjectProduct> ProjectProduct { get; set; }
    }
}
