using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.Model;
using System.Drawing;

namespace On_Demand_Car_Wash.DataBaseContext
{
    public class CarDbContext:DbContext
    {
        public CarDbContext(DbContextOptions<CarDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Washer> Washers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<AccountDetail> AccountDetails { get; set; }
        public DbSet<Payment> payments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //modelBuilder.Entity<Customer>().HasMany()


            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                  //
                  CustomerId = 1,
                    Name = "test",
                    Address = "123 hello",
                    City = "pune",
                    PostalCode = 123456,
                    Phone = 1234567891,
                    Email = "abc@gmail.com",
                    Password = "abc12345678@",
                    WashingDate = DateTime.Now,
                    AccountDetailId = 1,
                    OrderId = 1,
                    WasherId = 1,
                    ServiceId = 1,
                    PaymentId = 1
                }
                );
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    CustomerId = 1,
                    WasherId = 1,
                    Amount = 2000,
                    ServiceId = 1,
                    ShudelingTime = DateTime.Now,
                    Address = "Test"

                });
            modelBuilder.Entity<Washer>().HasData(
                new Washer
                {
                    WasherId = 1,
                    Name = "Test",
                    PhoneNumber = 1234567891,
                    IsApproved = true,
                    IsAvilable = true,
                    Email = "Test@gmail.com",
                    Password = "Abc12345678@",
                    Rating = 2.7f
                }
                );
            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    ServiceId = 1,
                    Name = "Test",
                    Description = "Test",
                    Amount = 2000
                });
            modelBuilder.Entity<AccountDetail>().HasData(
                new AccountDetail
                {
                    AccountDetailId = 1,
                    AccountName = "Test",
                    AccountNumber = 1234567891234567,
                    BankName = "Test",
                    IfscCode = "Test"
                });
            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    PaymentId = 1,
                    CustomerId = 1,
                    WasherId = 1,
                    OrderId = 1
                });
        }
    }
}
