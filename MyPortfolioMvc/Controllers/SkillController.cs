namespace MyPortfolioMvc.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyPortfolioMvc.Models;

    public class SkillController : Controller
    {
        private readonly PortfolioDbContext _context; // Inject the DbContext

        public SkillController(PortfolioDbContext context)
        {
            _context = context;
        }

        // Action to display the list of skills
        public IActionResult Index()
        {
            var skills = _context.Skills.ToList(); // Fetch all skills
            return View(skills); // Pass skills to the view
        }
    }
}
