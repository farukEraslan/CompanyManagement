namespace CompanyManagement.DataAccess.Config
{
    public class UserConfig : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(255);
            builder.Property(x => x.LastName).HasMaxLength(255);
            builder.Property(x => x.Gender).HasMaxLength(255);
            builder.Property(x => x.Address).HasMaxLength(1000);
            builder.Property(x => x.BirthDate).HasMaxLength(255);
            builder.Property(x => x.ImageURL).HasMaxLength(255);
            builder.Property(x => x.IsActıve).HasMaxLength(255);
            builder.Property(x => x.PersonelMail).HasMaxLength(500);
        }
    }
}
