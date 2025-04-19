namespace MyPortfolioMvc.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyPortfolioMvc.Models;

    public class UserController : Controller
    {
        private readonly PortfolioDbContext _context; // Inject the DbContext

        public UserController(PortfolioDbContext context)
        {
            _context = context;
        }

        // Action to display the list of users
        public IActionResult Index()
        {
            var users = _context.Users.ToList(); // Fetch all users
            return View(users); // Pass users to the view
        }

        // Action to view details of a single user
        public IActionResult Details(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserID == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user); // Pass user details to the view
        }
    }
}
