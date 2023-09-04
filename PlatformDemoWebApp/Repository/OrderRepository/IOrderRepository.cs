using ClassLibrary.Entities;

namespace PlatformDemoWebApp.Repository.OrderRepository
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        Task<List<Order>> FindCustomerOrdersAsync(int customerId);
    }
}
