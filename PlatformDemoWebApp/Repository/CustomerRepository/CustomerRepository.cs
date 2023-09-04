using ClassLibrary;
using ClassLibrary.Entities;
using Microsoft.EntityFrameworkCore;
using PlatformDemoWebApp.DTO;

namespace PlatformDemoWebApp.Repository.CustomerRepository;
/// <summary>
/// Customer Repository Implementation
/// </summary>
public class CustomerRepository : ICustomerRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CustomerRepository(ApplicationDbContext dbContext)
    {
        this._dbContext = dbContext;
    }
    /// <summary>
    /// Add new customer to the database
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public async Task AddAsync(Customer entity)
    {
        await _dbContext.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }
    /// <summary>
    /// Remove the customer from the database
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task DeleteAsync(int id)
    {
        await _dbContext.Customer.Where(s=>s.CustomerId.Equals(id)).ExecuteDeleteAsync();
    }
    /// <summary>
    /// Find the customer with the specified id
    /// returns null if customer not found
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>

    public async Task<Customer> FindAsync(int id)
    {

        return await _dbContext.Customer.FindAsync(id);
    }
    /// <summary>
    /// Get all customer from the database
    /// </summary>
    /// <returns></returns>
    public async Task<List<Customer>> GetAllAsync()
    {
        return await _dbContext.Customer.ToListAsync();
    }
    /// <summary>
    /// update the customer entity 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>

    public async Task UpdateAsync(Customer entity)
    {
        await _dbContext.Customer
            .Where(s => s.CustomerId.Equals(entity.CustomerId))
            .ExecuteUpdateAsync(p => p.SetProperty(b => entity.Name,
                                b => b.PhoneNumber));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns>All the customers with total orders</returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<List<CustomerDTO>> GetAllWithTotalOrders()
    {
        return await _dbContext.Customer.Select(s=>new CustomerDTO()
        {
            CustomerId = s.CustomerId,
            Name = s.Name,
            PhoneNumber = s.PhoneNumber,
            TotalOrders = s.Orders.Sum(o=>o.Amount)
        }).ToListAsync();
    }
}
