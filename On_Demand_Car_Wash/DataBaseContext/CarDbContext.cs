using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.Model;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net;

namespace On_Demand_Car_Wash.DataBaseContext
{
    public class CarDbContext:DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options) { }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<UserDetails> Users { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}
