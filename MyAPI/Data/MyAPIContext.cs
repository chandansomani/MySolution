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

        public DbSet<Customer> Customer { get; set; } = default!;

        public DbSet<Invoice> Invoice { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Invoice>()
            //    .HasOne(i => i.Customer)
            //    .WithMany()
            //    .HasForeignKey(i => i.CustID) // Specify foreign key property
            //    .HasPrincipalKey(c => c.ID); // Specify corresponding principal key property
                
            // You can add more configurations here if needed

            SeedClass.Seed(modelBuilder);
        }





    }
}
