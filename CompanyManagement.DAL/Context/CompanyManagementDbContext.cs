namespace CompanyManagement.DataAccess.Context
{
    public class CompanyManagementDbContext : IdentityDbContext<UserEntity, RoleEntity, Guid>
    {
        public CompanyManagementDbContext()
        {
                
        }

        public CompanyManagementDbContext(DbContextOptions<CompanyManagementDbContext> options) : base(options)
        {
        }

        public  readonly DbSet<Customer> Customers;
        public  readonly DbSet<CustomerProject> CustomerProjects;
        public  readonly DbSet<Product> Products;
        public  readonly DbSet<Project> Projects;
        public  readonly DbSet<ProjectProduct> ProjectProducts;
        public  readonly DbSet<Supplier> Suppliers;
        public  readonly DbSet<SupplierProduct> SupplierProducts;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // QNAP MariaDB Connection String
            optionsBuilder.UseSqlServer("Server = 192.168.1.116; Database = CompanyManagement; uid = admin; pwd = q1w2e3r4;");

            // Microsoft SQL Connection String
            //optionsBuilder.UseSqlServer("Server = FARUKERASLAN; Database = CompanyManagement; uid = sa; pwd = 123;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(IEntityTypeConfiguration).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
