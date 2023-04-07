using _00010974.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _00010974.Data.Repos
{
    public class BooksRepos : IBooksRepos
    {
        private readonly AppDbContext _context;

        public BooksRepos(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Books books)
        {
            await _context.Books.AddAsync(books);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var result = await _context.Books.FirstOrDefaultAsync(n => n.Id == id);
            _context.Books.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Books>> GetAllAsync()
        {
            var result = await _context.Books.ToListAsync();
            return result;
        }

        public Task<Books> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Books> UpdateAsync(int id, Books newBooks)
        {
            _context.Update(newBooks);
            await _context.SaveChangesAsync();
            return newBooks;
        }

        Task IBooksRepos.UpdateAsync(int id, Books entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
