namespace CompanyManagement.DataAccess.Config
{
    public class RoleConfig : IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.HasData(new RoleEntity
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            builder.HasData(new RoleEntity
            {
                Name = "Operator",
                NormalizedName = "OPERATOR"
            });
        }
    }
}
