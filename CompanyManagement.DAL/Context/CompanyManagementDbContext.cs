namespace CompanyManagement.DataAccess.Context
{
    public class CompanyManagementDbContext : IdentityDbContext<UserEntity, RoleEntity, Guid>
    {
        public CompanyManagementDbContext(DbContextOptions<CompanyManagementDbContext> options) : base(options)
        {

        }

        private readonly DbSet<Customer> Customers;
        private readonly DbSet<CustomerProject> CustomerProjects;
        private readonly DbSet<Product> Products;
        private readonly DbSet<Project> Projects;
        private readonly DbSet<ProjectProduct> ProjectProducts;
        private readonly DbSet<Supplier> Suppliers;
        private readonly DbSet<SupplierProduct> SupplierProducts;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = FARUKERASLAN; Database = CompanyManagement; uid = sa; pwd = 123;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(IEntityTypeConfiguration).Assembly);
            //builder.ApplyConfiguration(new CustomerConfig());
            //builder.ApplyConfiguration(new CustomerProjectConfig());
            //builder.ApplyConfiguration(new ProductConfig());
            //builder.ApplyConfiguration(new ProjectConfig());
            //builder.ApplyConfiguration(new ProjectProductConfig());
            //builder.ApplyConfiguration(new SupplierConfig());
            //builder.ApplyConfiguration(new SupplierProductConfig());
            base.OnModelCreating(builder);
        }
    }
}
