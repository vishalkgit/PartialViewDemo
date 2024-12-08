using Microsoft.EntityFrameworkCore;

namespace PartialViewDemo.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }

        public DbSet<Employee>? Employees { get; set; }
    }
}
