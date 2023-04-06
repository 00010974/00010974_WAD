using System.Linq;
using _00010974.Data;
using Microsoft.AspNetCore.Mvc;

namespace _00010974.Controllers
{
    public class PublishersController : Controller
    {
        private readonly AppDbContext _context;

        public PublishersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Publishers.ToList();
            return View(data);
        }
    }
}
