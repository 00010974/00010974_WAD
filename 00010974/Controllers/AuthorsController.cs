using System.Linq;
using System.Threading.Tasks;
using _00010974.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _00010974.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allAuthors = await _context.Authors.ToListAsync();
            return View(allAuthors);
        }
    }
}
