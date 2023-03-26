using CompanyManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class CustomerEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public string CustomerCity { get; set; }
        public string? CustomerRegion { get; set; }
        public string CustomerPostalCode { get; set;}
        public string CustomerCountry { get; set; }
        public string? CustomerState { get; set; }
        public string? CustomerZipCode { get; set;}
    }
}
