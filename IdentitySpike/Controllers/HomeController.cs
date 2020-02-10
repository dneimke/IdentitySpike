using IdentitySpike.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace IdentitySpike.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserContext _userContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(UserContext userContext, ILogger<HomeController> logger)
        {
            _userContext = userContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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
