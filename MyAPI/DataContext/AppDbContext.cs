using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<InvoiceModel> Invoices { get; set; }

    }
}
