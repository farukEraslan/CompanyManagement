namespace CompanyManagement.DataAccess.Config
{
    public class ProjectProductConfig : AuditableEntityTypeConfiguration<ProjectProduct>
    {
        public void Configure(EntityTypeBuilder<ProjectProduct> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedBy);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.ModifiedBy);
            builder.Property(x => x.ModifiedDate);

            builder.HasOne(x=>x.Product).WithMany(x=>x.ProjectProduct).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x=>x.Project).WithMany(x=>x.ProjectProduct).HasForeignKey(x=>x.ProjectId);
        }
    }
}
