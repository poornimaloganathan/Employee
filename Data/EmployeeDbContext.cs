using Microsoft.EntityFrameworkCore;
using Employee1.Models;

namespace Employee1.Data
{
    public class EmployeeDbContext : DbContext

    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }


        public DbSet<EmployeeModel> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
