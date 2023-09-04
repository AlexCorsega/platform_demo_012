using ClassLibrary.Entities;
using PlatformDemoWebApp.DTO;

namespace PlatformDemoWebApp.Repository.CustomerRepository
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Task<List<CustomerDTO>> GetAllWithTotalOrders();
    }
}
