using Microsoft.EntityFrameworkCore;
using DSRWebAPI.Models;

namespace DSRWebAPI.DataContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options ) : base(options)
        {
            
        }

        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<InvoiceModel> Invoices { get; set; }
    }
}
