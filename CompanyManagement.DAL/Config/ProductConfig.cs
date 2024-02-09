namespace CompanyManagement.DataAccess.Config
{
    public class ProductConfig : AuditableEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.SerialNo).HasMaxLength(256);
            builder.Property(x => x.Name).HasMaxLength(256);
            builder.Property(x => x.Description).HasMaxLength(1024);
            builder.Property(x => x.Brand).HasMaxLength(256);
            builder.Property(x => x.Height);
            builder.Property(x => x.Width);
            builder.Property(x => x.Lenght);
            builder.Property(x => x.Quantity);
            builder.Property(x => x.QuantityUnit);
            builder.Property(x => x.EstWeight);
            builder.Property(x => x.WeightUnit);
            builder.Property(x => x.ExpiryDate);
            builder.Property(x => x.QualityGrade);
            builder.Property(x => x.LastBoughtPrice);
            builder.Property(x => x.UnitPrice);
        }
    }
}
