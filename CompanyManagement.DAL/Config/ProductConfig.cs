namespace CompanyManagement.DataAccess.Config
{
    public class ProductConfig : AuditableEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.SerialNo).HasMaxLength(256);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(1024);
            builder.Property(x => x.Brand).HasMaxLength(256);
            builder.Property(x => x.Height);
            builder.Property(x => x.Width);
            builder.Property(x => x.Lenght);
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.QuantityUnit).IsRequired();
            builder.Property(x => x.EstWeight);
            builder.Property(x => x.WeightUnit);
            builder.Property(x => x.ExpiryDate);
            builder.Property(x => x.QualityGrade);
            builder.Property(x => x.LastBoughtPrice);
            builder.Property(x => x.UnitPrice);
        }
    }
}
