using ClassLibrary;
using ClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace PlatformDemoWebApp.Repository.OrderRepository
{
    /// <summary>
    /// Order Repository Implementation
    /// Implement the other functions if needed
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Task AddAsync(Order entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get All the Orders of The Customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
       public async Task<List<Order>> FindCustomerOrdersAsync(int customerId)
       {
            var orders = await _dbContext.Order.Where(s => s.CustomerId.Equals(customerId)).ToListAsync();
            return orders;
       }
    }
}
