﻿using CompanyManagement.Core.Entities.EntityTypeConfigurations;

namespace CompanyManagement.DataAccess.Config
{
    public class CustomerConfig : AuditableEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(256);
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
