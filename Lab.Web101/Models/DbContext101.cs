using Microsoft.EntityFrameworkCore;

namespace Lab.Web101.Models
{
    public class DbContext101 : DbContext
    {
        public DbContext101(DbContextOptions<DbContext101> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}