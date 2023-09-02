using Microsoft.AspNetCore.Mvc;
using PlatformDemoWebApp.Repository.OrderRepository;

namespace PlatformDemoWebApp.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }
        [HttpGet("[action]/{customerId}")]
        public async Task<IActionResult> CustomerOrders(int customerId)
        {
            var orders =await _orderRepository.FindCustomerOrdersAsync(customerId);
            return PartialView("~/Views/Partial/OrdersTablePartialView.cshtml",orders);
        }
    }
}
