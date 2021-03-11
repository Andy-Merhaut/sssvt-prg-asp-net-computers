using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Computers;

namespace WebApplication1.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Computer> Computer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=computers;user=root;password=");
        }
    }
}
