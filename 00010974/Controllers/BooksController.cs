using _00010974.Data;
using _00010974.Data.Repos;
using _00010974.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace _00010974.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksRepos _repos;

        public BooksController(IBooksRepos repos)
        {
            _repos = repos;
        }
        public async Task<IActionResult> Index()
        {
            var allbooks = await _repos.GetAllAsync();
            return View(allbooks);
        }

        //Get: Publishers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("IngUrl, Title, AuthorName, Series, Price, Genre, PublishingHouse, Description")] Books books)

        {
            if (!ModelState.IsValid)
            {
                return View(books);
            }
            await _repos.AddAsync(books);
            return RedirectToAction(nameof(Index));
        }

        
        //Get: Authors/Details/1

        public async Task<IActionResult> DetailsAsync(int id)
        {
            var bookDetails = await _repos.GetByIdAsync(id);
            if (bookDetails == null) return View("NotFound");
            return View(bookDetails);
        }

        //Get: Authors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var bookDetails = await _repos.GetByIdAsync(id);
            if (bookDetails == null) return View("NotFound");
            return View(bookDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, IngUrl, Title, AuthorName, Series, Price, Genre, PublishingHouse, Description")] Books books)
        {
            if (!ModelState.IsValid)
            {
                return View(books);
            }
            await _repos.UpdateAsync(id, books);
            return RedirectToAction(nameof(Index));
        }

        //GET: Authors/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var bookDetails = await _repos.GetByIdAsync(id);
            if (bookDetails == null) return View("NotFound");
            return View(bookDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookDetails = await _repos.GetByIdAsync(id);
            if (bookDetails == null) return View("NotFound");

            await _repos.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
