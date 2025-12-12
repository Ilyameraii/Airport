using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }

        public DatabaseContext()
        {
                Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
           @"Server=(localdb)\mssqllocaldb;Database=AirportDB;Trusted_Connection=True;");
        }
    }
}
