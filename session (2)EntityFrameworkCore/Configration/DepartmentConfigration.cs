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
    internal class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id);
            builder.Property(D=>D.Id).UseIdentityColumn(1,1);
            builder.Property(D=>D.DeptName).HasColumnName("DepartmentName").HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
