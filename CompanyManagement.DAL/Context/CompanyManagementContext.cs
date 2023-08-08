using CompanyManagement.DAL.Config;
using CompanyManagement.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.DAL.Context
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

        private readonly DbSet<CustomerEntity> Customers;
        private readonly DbSet<ProductEntity> Products;
        private readonly DbSet<ProjectEntity> Projects;
        private readonly DbSet<SupplierEntity> Suppliers;
    }
}
