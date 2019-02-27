using Microsoft.EntityFrameworkCore;

namespace Server.Models
{
    public class TeacherCreditContext : DbContext
    {
        public TeacherCreditContext(DbContextOptions<TeacherCreditContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserSemester> UserSemesters { get; set; }
        public DbSet<Semester> Semesters { get; set; }
    }
}