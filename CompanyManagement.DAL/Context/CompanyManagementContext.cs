namespace CompanyManagement.DataAccess.Context
{
    public class CompanyManagementContext : IdentityDbContext<UserEntity, RoleEntity, Guid>
    {
        public CompanyManagementContext(DbContextOptions<CompanyManagementContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = FARUKERASLAN; Database = CompanyManagement; uid = sa; pwd = 123;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CustomerConfig());
            builder.ApplyConfiguration(new CustomerProjectConfig());
            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new ProjectConfig());
            builder.ApplyConfiguration(new ProjectProductConfig());
            builder.ApplyConfiguration(new SupplierConfig());
            builder.ApplyConfiguration(new SupplierProductConfig());
            base.OnModelCreating(builder);
        }

        private readonly DbSet<Customer> Customers;
        private readonly DbSet<Product> Products;
        private readonly DbSet<Project> Projects;
        private readonly DbSet<Supplier> Suppliers;
    }
}
