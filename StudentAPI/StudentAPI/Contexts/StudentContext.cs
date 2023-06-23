using Microsoft.EntityFrameworkCore;
using StudentAPI.Entities;

namespace StudentAPI.Contexts
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=KHOANGUYEN\SQLEXPRESS;Initial Catalog=StudentDb;Integrated Security=True; Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, Email = "khoa.nguyen@codegym.vn", FullName = "Khoa Nguyễn" },
                new Student() { StudentId = 2, Email = "phu@gmail.com", FullName = "Phú Nguyễn" }
            );
        }
    }
}
