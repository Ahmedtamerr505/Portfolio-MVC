namespace MyPortfolioMvc.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MyPortfolioMvc.Models;

    public class ContactMessageController : Controller
    {
        private readonly PortfolioDbContext _context; // Inject the DbContext

        public ContactMessageController(PortfolioDbContext context)
        {
            _context = context;
        }

        // Action to display all contact messages
        public IActionResult Index()
        {
            var messages = _context.ContactMessages.ToList(); // Fetch all messages
            return View(messages); // Pass messages to the view
        }

        // HttpGet action to display the form
        [HttpGet]
        public IActionResult Create()
        {
            return View(); // Renders the Create.cshtml form view
        }

        // HttpPost action to handle form submissions
        [HttpPost]
        public IActionResult Create(ContactMessage message)
        {
            if (ModelState.IsValid)
            {
                _context.ContactMessages.Add(message); // Add the message to the database
                _context.SaveChanges(); // Save changes to the database
                return RedirectToAction("Index"); // Redirect to the messages list
            }
            return View(message); // Return the form with validation errors, if any
        }
    }
}
