using assignment_1_entity_frame_work.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Entity_FrameWork.Context
{
    internal class ITI_EFW_Context :DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course_Inst>().HasKey(k => new {k.Course_ID,k.inst_ID});
            modelBuilder.Entity<Stud_Course>().HasKey(E => new { E.Course_ID, E.stud_ID });
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-G62R036\\VAMPRITA;Database=ITIERS02;Trusted_Connection=true;TrustServerCertificate =true;");
        }
        public DbSet<Course> Course { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Topic> Topic { get; set; }
      
    }
}
