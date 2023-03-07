using CompanyManagement.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.DAL.Config
{
    public class UserConfig : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdentityNumber).HasMaxLength(20);
            builder.Property(x => x.FirstName).HasMaxLength(255);
            builder.Property(x => x.SecondName).HasMaxLength(255);
            builder.Property(x => x.LastName).HasMaxLength(255);
            builder.Property(x => x.SecondLastName).HasMaxLength(255);
            builder.Property(x => x.Gender).HasMaxLength(255);
            builder.Property(x => x.Address).HasMaxLength(1000);
            builder.Property(x => x.BirthDate).HasMaxLength(255);
            builder.Property(x => x.BirthLocation).HasMaxLength(255);
            builder.Property(x => x.ImageURL).HasMaxLength(255);
            builder.Property(x => x.IsActıve).HasMaxLength(255);
            builder.Property(x => x.JobEnterDate).HasMaxLength(255);
            builder.Property(x => x.JobExitDate).HasMaxLength(255);
            builder.Property(x => x.Job).HasMaxLength(255);
            builder.Property(x => x.Department).HasMaxLength(255);
            builder.Property(x => x.Salary).HasMaxLength(255);
            builder.Property(x => x.TotalLeaveDay).HasMaxLength(255);
            builder.Property(x => x.PersonelMail).HasMaxLength(500);
        }
    }
}
