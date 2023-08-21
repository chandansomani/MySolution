using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.DataContext
{
    public class AppDBContext : DbContext
    {     
        public AppDBContext(DbContextOptions<AppDBContext> context) : base(context)
        {
           
        }
        public DbSet<DSR> DSRs { get; set; }

    }
}
