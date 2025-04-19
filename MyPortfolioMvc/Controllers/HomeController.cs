using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioMvc.Models;

namespace MyPortfolioMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PortfolioDbContext _context; // Inject the DbContext for accessing the User data

        public HomeController(ILogger<HomeController> logger, PortfolioDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // Fetch the first user's name from the User database
            var userName = _context.Users.FirstOrDefault()?.Name;
            ViewData["UserName"] = userName ?? "Your Name"; // Fallback to a default name if no user exists
            return View();
        }
        public IActionResult About()
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