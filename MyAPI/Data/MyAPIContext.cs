using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Data
{
    public class MyAPIContext : DbContext
    {
        public MyAPIContext (DbContextOptions<MyAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MyAPI.Models.Customer> Customer { get; set; } = default!;

        public DbSet<MyAPI.Models.Invoice> Invoice { get; set; } = default!;
    }
}
