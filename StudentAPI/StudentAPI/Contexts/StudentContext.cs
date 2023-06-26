using Microsoft.EntityFrameworkCore;
using StudentAPI.Entities;

namespace StudentAPI.Contexts
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=KHOANGUYEN\SQLEXPRESS;Initial Catalog=StudentDatabase;Integrated Security=True; Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, Email = "khoa.nguyen@codegym.vn", FullName = "Khoa Nguyễn", GradeId = 1 },
                new Student() { StudentId = 2, Email = "phu@gmail.com", FullName = "Phú Nguyễn", GradeId = 2 },
                new Student() { StudentId = 3, Email = "luong@gmail.com", FullName = "Lượng Nguyễn", GradeId = 1 },
                new Student() { StudentId = 4, Email = "thien@gmail.com", FullName = "Thiện Nguyễn", GradeId = 2 },
                new Student() { StudentId = 5, Email = "duy@gmail.com", FullName = "Duy Nguyễn", GradeId = 2 }
            );

            modelBuilder.Entity<Grade>().HasData(
                new Grade() { GradeId = 1, GradeName = "C0523H1", Completed = false },
                new Grade() { GradeId = 2, GradeName = "C0623G1", Completed = false }
           );
        }
    }
}
