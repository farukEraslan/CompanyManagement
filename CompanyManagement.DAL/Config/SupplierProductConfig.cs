using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.DAL.Config
{
    public class SupplierProductConfig : IEntityTypeConfiguration<SupplierProduct>
    {
        public void Configure(EntityTypeBuilder<SupplierProduct> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedBy);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.ModifiedBy);
            builder.Property(x => x.ModifiedDate);

            builder.HasOne(x => x.Supplier).WithMany(x => x.SupplierProduct).HasForeignKey(x => x.SupplierId);
            builder.HasOne(x => x.Product).WithMany(x => x.SupplierProduct).HasForeignKey(x => x.ProductId);
        }
    }
}
