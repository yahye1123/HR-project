using HR3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HR3.data
{
    public class HRDbContext : IdentityDbContext

    {
        public HRDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Attendance> Attenadance { get; set; }
        public DbSet<Pay> Pay { get; set; }
        public DbSet<Title> Title { get; set; }
    }
}
