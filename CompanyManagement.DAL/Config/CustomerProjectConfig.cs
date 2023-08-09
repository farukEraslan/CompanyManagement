namespace CompanyManagement.DataAccess.Config
{
    public class CustomerProjectConfig : IEntityTypeConfiguration<CustomerProject>
    {
        public void Configure(EntityTypeBuilder<CustomerProject> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedBy);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.ModifiedBy);
            builder.Property(x => x.ModifiedDate);

            builder.HasOne(x=>x.Project).WithMany(x=>x.CustomerProject).HasForeignKey(x=>x.ProjectId);
            builder.HasOne(x=>x.Customer).WithMany(x=>x.CustomerProject).HasForeignKey(x=>x.CustomerId);
        }
    }
}
