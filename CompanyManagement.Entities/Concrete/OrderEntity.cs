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
        public OrderEntity()
        {
            OrderDetail = new List<OrderDetail>();
        }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string OrderNumber { get; set; }
        public int ProjectId { get; set; }
        public int SupplierId { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DeliveryTime { get; set; }
    }
}
