using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Data
{
    public static class SeedClass
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Insert sample data here
            modelBuilder.Entity<Customer>().HasData(
                new Customer { ID = 1, Name = "Mangesh Shinde", Place = "Latur", Phone = "9998887773", OpeningBalance = 1000 },
                new Customer { ID = 2, Name = "Ninad P", Place = "Nagar", Phone = "9997776662" , OpeningBalance = 2000 }
            );
        }
    }
}
