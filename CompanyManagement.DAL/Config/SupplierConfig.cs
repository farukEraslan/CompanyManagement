﻿namespace CompanyManagement.DataAccess.Config
{
    public class SupplierConfig : AuditableEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Name).IsRequired().HasMaxLength(256);
            builder.Property(x=> x.Email).HasMaxLength(256);
            builder.Property(x => x.Phone).IsRequired().HasMaxLength(25);
            builder.Property(x => x.City).HasMaxLength(128);
            builder.Property(x => x.Country).HasMaxLength(128);
            builder.Property(x => x.PostalCode).HasMaxLength(128);
            builder.Property(x => x.Address);
            builder.Property(x => x.CreatedBy);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.ModifiedBy);
            builder.Property(x => x.ModifiedDate);
        }
    }
}
