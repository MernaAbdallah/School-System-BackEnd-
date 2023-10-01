using Domain.EnrollmentAggregate;
using Domain.Lookups;
using Domain.ManagerAggregate;
using Domain.SchoolAggregate;
using Domain.TeacherAggregate;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Manger> Managers { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<StudentLevel> StudentLevels { get; set; }
        public virtual DbSet<TeacherCategory> TeacherCategories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
