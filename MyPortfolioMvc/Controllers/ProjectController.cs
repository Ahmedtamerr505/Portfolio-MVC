namespace MyPortfolioMvc.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyPortfolioMvc.Models;

    public class ProjectController : Controller
    {
        private readonly PortfolioDbContext _context; // Inject the DbContext

        public ProjectController(PortfolioDbContext context)
        {
            _context = context;
        }

        // Action to display the list of projects
        public IActionResult Index()
        {
            var projects = _context.Projects.ToList(); // Fetch all projects
            return View(projects); // Pass projects to the view
        }

        // Action to view details of a single project
        public IActionResult Details(int id)
        {
            var project = _context.Projects.FirstOrDefault(p => p.ProjectID == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project); // Pass project details to the view
        }
    }
}
