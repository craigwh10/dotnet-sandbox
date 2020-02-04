using Microsoft.EntityFrameworkCore;

namespace Company.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<CompanyItem> TodoItems { get; set; }
    }
}