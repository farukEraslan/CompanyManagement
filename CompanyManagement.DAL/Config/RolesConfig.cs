using CompanyManagement.Entities.Concrete;
using CompanyManagement.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.DAL.Config
{
    public class RolesConfig : IEntityTypeConfiguration<RoleEntity>
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
                Name = "Manager",
                NormalizedName = "MANAGER"
            });

            builder.HasData(new RoleEntity
            {
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            });
        }
    }
}
