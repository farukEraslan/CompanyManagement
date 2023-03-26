using CompanyManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Entities.Concrete
{
    public class ProductEntity : IBaseEntity
    {
        public ProductEntity()
        {
            Projects = new List<ProjectEntity>();
            Suppliers = new List<SupplierEntity>();
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string? SerialNo { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string? ProductBrand { get; set; }
        public string? Dimensions { get; set; }
        public string? DimensionUnit { get; set; }
        public double? EstimatedWeight { get; set; }
        public string? WeightUnit { get; set; }
        public int ProjectId { get; set; }
        public List<ProjectEntity> Projects { get; set; }
        public int SupplierId { get; set; }
        public List<SupplierEntity> Suppliers { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double Stock { get; set; }
        public string StockUnit { get; set; }
        public decimal? LastBoughtPrice { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
