using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DSRWebAPI.Models;

namespace DSRWebAPI.Data
{
    public class DSRWebAPIContext : DbContext
    {
        public DSRWebAPIContext (DbContextOptions<DSRWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DSRWebAPI.Models.CustomerModel> CustomerModel { get; set; } = default!;

        public DbSet<DSRWebAPI.Models.InvoiceModel> InvoiceModel { get; set; } = default!;
    }
}
