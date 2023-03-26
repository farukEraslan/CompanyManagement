using CompanyManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class SupplierEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public string? SupplierPhone { get; set; }
        public string SupplierCity { get; set; }
        public string? SupplierRegion { get; set; }
        public string SupplierPostalCode { get; set; }
        public string SupplierCountry { get; set; }
        public string? SupplierState { get; set; }
        public string? SupplierZipCode { get; set; }
    }
}
