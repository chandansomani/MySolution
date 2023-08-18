using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.DataContext
{
    public class AppDBContext : DbContext
    {
        private readonly DbContext _context;
        public AppDBContext(DbContext context)
        {

            _context = context;

        }

        public DbSet<DSR> dSRs { get; set; }
    }
}
