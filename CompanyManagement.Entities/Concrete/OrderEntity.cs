using CompanyManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class OrderEntity : IBaseEntity
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
    }
}
