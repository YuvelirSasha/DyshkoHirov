using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;

namespace DemoMVC.Context
{
    public class SchoolDatabaseContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<User> Users { get; set; }

        public SchoolDatabaseContext(DbContextOptions<SchoolDatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        
    }
}
