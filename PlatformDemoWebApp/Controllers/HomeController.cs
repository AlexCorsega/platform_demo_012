using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using PlatformDemoWebApp.Models;
using PlatformDemoWebApp.Repository;
using PlatformDemoWebApp.Repository.CustomerRepository;
using System.Diagnostics;

namespace PlatformDemoWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerRepository _customerRepository;

        public HomeController(ILogger<HomeController> logger,ICustomerRepository customerRepository)
        {
            _logger = logger;
            this._customerRepository = customerRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _customerRepository.GetAllWithTotalOrders());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
