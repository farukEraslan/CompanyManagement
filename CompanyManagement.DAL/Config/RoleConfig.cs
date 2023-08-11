namespace CompanyManagement.DataAccess.Config
{
    public class RoleConfig : IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.HasData(new RoleEntity
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            builder.HasData(new RoleEntity
            {
                Id = Guid.NewGuid(),
                Name = "Operator",
                NormalizedName = "OPERATOR"
            });
        }
    }
}
