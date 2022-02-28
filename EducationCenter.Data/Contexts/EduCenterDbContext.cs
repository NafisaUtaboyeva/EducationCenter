using EducationCenter.Domain.Models;
using EducationCenter.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace EducationCenter.Data.Contexts
{
    public class EduCenterDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.CONNECTION_STRING);
        }
    }
}
