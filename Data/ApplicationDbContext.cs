using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Employee> Employee { get; set; } = null!;
        public DbSet<HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = null!;
        public DbSet<DaiLy> DaiLy { get; set; } = null!;
    }
}
