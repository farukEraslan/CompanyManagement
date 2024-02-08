using Microsoft.EntityFrameworkCore;

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
            #region QNAP MariaDB Connection String
            var mariaDbConStr = "Server=192.168.1.116; Port=3307; Uid=admin; Pwd=q1w2e3r4; Database=CompanyManagement;";
            var mariaDbServerVersion = new MariaDbServerVersion(new Version(10, 5, 08));
            optionsBuilder.UseMySql(mariaDbConStr, mariaDbServerVersion);
            #endregion

            #region Microsoft SQL Connection String
            var msSqlConStr = "Server = .; Database = CompanyManagement; uid = sa; pwd = 123;";
            //optionsBuilder.UseSqlServer(msSqlConStr);
            #endregion

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(IEntityTypeConfiguration).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
