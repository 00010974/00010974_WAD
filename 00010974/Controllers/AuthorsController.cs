using System.Linq;
using System.Threading.Tasks;
using _00010974.Data;
using _00010974.Data.Repos;
using _00010974.Data.Service;
using _00010974.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _00010974.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IAuthorsRepos _repos;

        public AuthorsController(IAuthorsRepos repos)
        {
            _repos = repos;
        }
        public async Task<IActionResult> Index()
        {
            var allAuthors = await _repos.GetAllAsync();
            return View(allAuthors);
        }


        //Get: Publishers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("AuthorPicture, FullName, AuthorBooks")]Authors authors)
        {
            if (!ModelState.IsValid)
            {
                return View(authors);
            }
            await _repos.AddAsync(authors);
            return RedirectToAction(nameof(Index));
        }

        //Get: Authors/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var authorDetails = await _repos.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        //Get: Authors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var authorDetails = await _repos.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, AuthorPicture, FullName, AuthorBooks")] Authors authors)
        {
            if (!ModelState.IsValid)
            {
                return View(authors);
            }
            await _repos.UpdateAsync(id, authors);
            return RedirectToAction(nameof(Index));
        }

        //GET: Authors/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var authorDetails = await _repos.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authorDetails = await _repos.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");

            await _repos.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
