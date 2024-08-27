using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using session__2_EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session__2_EntityFrameworkCore.Configration
{
    internal class EmployeeConfigration : IEntityTypeConfiguration<Employee>

    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn(1, 1);
            builder.Property(e => e.Name).HasColumnName("EmployeeNmae").HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(e => e.Salary).HasColumnType("money").IsRequired(false);
        }
    }
}
