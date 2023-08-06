using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Abstract
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
