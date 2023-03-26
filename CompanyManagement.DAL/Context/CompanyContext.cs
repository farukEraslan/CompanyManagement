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
    public class CompanyContext : IdentityDbContext<UserEntity, RoleEntity, int>
    {
        //public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = desktop-ufhr98h; Database = CompanyManagement; uid = sa; pwd = 123;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        private readonly DbSet<CustomerEntity> Customers;
        private readonly DbSet<OrderEntity> Orders;
        private readonly DbSet<OrderDetail> OrderDetails;
        private readonly DbSet<ProductEntity> Products;
        private readonly DbSet<ProjectEntity> Projects;
        private readonly DbSet<SupplierEntity> Suppliers;
    }
}
