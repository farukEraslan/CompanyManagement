using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Dtos.Product
{
    public class ProductQRCodeDto
    {
        public Guid Id { get; set; }
        public string? SerialNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Brand { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Lenght { get; set; }
    }
}
