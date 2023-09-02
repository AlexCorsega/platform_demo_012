using ClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            GenerateCustomers(modelBuilder); //Comment this when seed is finish
            base.OnModelCreating(modelBuilder);
        }
        //Seeder function
        private void GenerateCustomers(ModelBuilder modelBuilder)
        {
            string[] names = new string[]
            {
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Ella",
                "Frank",
                "Grace",
                "Hannah",
                "Isaac",
                "Julia",
                "Karl",
                "Lily",
                "Michael",
                "Nora",
                "Oliver"
            };
            for (int i = 0; i < names.Length; i++)
            {
                int customerId = i + 1;
                modelBuilder.Entity<Customer>(options =>
                        {
                            options.HasData(
                                  new Customer()
                                  {
                                      CustomerId = customerId,
                                      Name = names[i],
                                      PhoneNumber = GenerateRandomPhoneNumber(),//Add Orders per customer
                                  }
                             );
                            options.OwnsMany(d => d.Orders).HasData(GenerateOrders(customerId));
                        });
            }
        }
        private List<Order> GenerateOrders(int customerId)
        {
            var random = new Random();
            int ordersLength = random.Next(0, 5);
            var order = new List<Order>();
            for (int i = 0; i < ordersLength; i++)
            {
                order.Add(new Order()
                {
                    OrderId = random.Next(1, 1000),
                    CustomerId = customerId,
                    Amount = random.Next(1000, 500000),
                });
            }
            return order;
        }
        //Generate random Philippines phone number
        private string GenerateRandomPhoneNumber()
        {
            var random = new Random();
            int part = random.Next(100000000, 999999999); //Nine digit number after 09

            string phoneNumber = $"09{part}";
            return phoneNumber;
        }
    }
}
