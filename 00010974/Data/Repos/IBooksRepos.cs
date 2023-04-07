using _00010974.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using _00010974.Data.Base;
using System.Linq.Expressions;
using System;

namespace _00010974.Data.Repos
{
    public interface IBooksRepos
    {
        Task<IEnumerable<Books>> GetAllAsync();
        Task<Books> GetByIdAsync(int id);
        Task AddAsync(Books entity);
        Task UpdateAsync(int id, Books entity);
        Task DeleteAsync(int id);
    }
}
