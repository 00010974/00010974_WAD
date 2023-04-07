using System;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using _00010974.Data;
using _00010974.Data.Service;
using _00010974.Models;
using Microsoft.AspNetCore.Mvc;

namespace _00010974.Controllers
{
    public class PublishersController : Controller
    {
        private readonly IPublisherRepos _repos;

        public PublishersController(IPublisherRepos repos)
        {
            _repos = repos;
        }

        public async Task<IActionResult> Index()
        {
            var data = await  _repos.GetAllAsync();
            return View(data); 
        }

        //Get: Publishers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title, Bio")] Publishers publishers)
        {
            if (!ModelState.IsValid)
            {
                return View(publishers);
            }
            await _repos.AddAsync(publishers);
            return RedirectToAction(nameof(Index));
        }
        //Get: Auhtors/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var publishersDetails = await _repos.GetByIdAsync(id);

            if (publishersDetails == null) return View("NotFound");
            return View(publishersDetails);
        }

        //Get: Publishers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var publishersDetails = await _repos.GetByIdAsync(id);
            if (publishersDetails == null) return View("NotFound");
            return View(publishersDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Title, Bio")] Publishers publishers)
        {
            if (!ModelState.IsValid)
            {
                return View(publishers);
            }
            await _repos.UpdateAsync(id, publishers);
            return RedirectToAction(nameof(Index));
        }

        //GET: Authors/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var publisherDetails = await _repos.GetByIdAsync(id);
            if (publisherDetails == null) return View("NotFound");
            return View(publisherDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var publisherDetails = await _repos.GetByIdAsync(id);
            if (publisherDetails == null) return View("NotFound");

            await _repos.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
