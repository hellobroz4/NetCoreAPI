using Microsoft.EntityFrameworkCore;
using baithuchanh.Models;
using MvcMovie.Models;

namespace baithuchanh.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
