using Microsoft.EntityFrameworkCore;
using session__2_EntityFrameworkCore.Configration;
using session__2_EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session__2_EntityFrameworkCore.Context
{
    internal class AppDbContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigration());
            modelBuilder.ApplyConfiguration(new DepartmentConfigration());
            modelBuilder.Entity<Department>().HasOne(D => D.Manager).WithOne(E => E.Department).HasForeignKey<Department>(D => D.EmptId);
            modelBuilder.Entity<Department>().HasMany(D=>D.Employees).WithOne(E=>E.WorkFor).HasForeignKey(F=>F.WorkForId);
            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-G62R036\\VAMPRITA;Database=AppERS02;Trusted_Connection=true;TrustServerCertificate =true;");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments{ get; set; }

    }
}
