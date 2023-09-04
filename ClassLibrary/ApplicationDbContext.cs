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
        /// <summary>
        /// Generate customers for the seeder
        /// </summary>
        /// <param name="modelBuilder"></param>
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
                modelBuilder.Entity<Customer>().HasData(
                             new Customer()
                             {
                                 CustomerId = customerId,
                                 Name = names[i],
                                 PhoneNumber = GenerateRandomPhoneNumber(),
                             }
                             );
                modelBuilder.Entity<Order>().HasData(GenerateOrders(customerId));
            }
        }
        /// <summary>
        /// Generate an orders
        /// </summary>
        /// <param name="customerId">customerId for orders</param>
        /// <returns>List of orders</returns>
        private int _orderId = 1;
        private List<Order> GenerateOrders(int customerId)
        {
            var random = new Random();
            int ordersLength = random.Next(0, 5);
            var order = new List<Order>();
            for (int i = 0; i < ordersLength; i++, _orderId++)
            {
                order.Add(new Order()
                {
                    OrderId = _orderId,
                    CustomerId = customerId,
                    Amount = random.Next(1000, 500000),
                });
            }
            return order;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Random phone number based on the Philippines</returns>
        private string GenerateRandomPhoneNumber()
        {
            var random = new Random();
            int part = random.Next(100000000, 999999999); //Nine digit number after 09

            string phoneNumber = $"09{part}";
            return phoneNumber;
        }
    }
}
