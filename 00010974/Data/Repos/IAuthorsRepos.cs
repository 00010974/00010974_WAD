using _00010974.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using _00010974.Data.Base;

namespace _00010974.Data.Repos
{
    public interface IAuthorsRepos : IEntityBaseRepos<Authors>
    {
        Task AddAsync(Books books);
        Task UpdateAsync(int id, Books books);
    }
}
