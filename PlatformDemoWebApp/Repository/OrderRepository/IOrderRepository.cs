using ClassLibrary.Entities;

namespace PlatformDemoWebApp.Repository.OrderRepository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<List<Order>> FindCustomerOrdersAsync(int customerId);
    }
}
