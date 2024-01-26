using CompanyManagement.Core.Entities.Base;
using CompanyManagement.Core.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Security.Claims;

namespace CompanyManagement.DataAccess.Context
{
    public class CompanyManagementDbContext : IdentityDbContext<UserEntity, RoleEntity, Guid>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CompanyManagementDbContext(DbContextOptions<CompanyManagementDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
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
            optionsBuilder.UseSqlServer("Server = 192.168.1.116; Database = CompanyManagement; uid = admin; pwd = q1w2e3r4;");
            //optionsBuilder.UseSqlServer("Server = FARUKERASLAN; Database = CompanyManagement; uid = sa; pwd = 123;");
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

        public override int SaveChanges()
        {
            //SetBaseProperties();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //SetBaseProperties();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetBaseProperties()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();

            var user = _httpContextAccessor.HttpContext!.User;
            var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            foreach (var entry in entries)
            {
                SetIfAdded(entry, userId);
                SetIfModified(entry, userId);
                SetIfDeleted(entry, userId);
            }
        }

        private void SetIfDeleted(EntityEntry<BaseEntity> entry, string userId)
        {
            if (entry.State is not EntityState.Deleted)
            {
                return;
            }

            if (entry.Entity is not AuditableEntity entity)
            {
                return;
            }

            entry.State = EntityState.Modified;

            entity.Status = Status.Deleted;
            entity.DeletedDate = DateTime.Now;
            entity.DeletedBy = userId;
        }

        private void SetIfModified(EntityEntry<BaseEntity> entry, string userId)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Entity.Status = Status.Modified;
            }

            entry.Entity.ModifiedBy = userId;
            entry.Entity.ModifiedDate = DateTime.Now;
        }

        private void SetIfAdded(EntityEntry<BaseEntity> entry, string userId)
        {
            if (entry.State != EntityState.Added)
            {
                return;
            }

            entry.Entity.Status = Status.Added;
            entry.Entity.CreatedBy = userId;
            entry.Entity.CreatedDate = DateTime.Now;
        }
    }
}
