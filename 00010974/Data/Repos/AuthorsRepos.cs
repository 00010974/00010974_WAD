using _00010974.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using _00010974.Data.Base;

namespace _00010974.Data.Repos
{
    public class AuthorsRepos : EntityBaseRepos<Authors>, IAuthorsRepos
    {
        public AuthorsRepos(AppDbContext context) : base(context){}

        public Task AddAsync(Books books)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(int id, Books books)
        {
            throw new System.NotImplementedException();
        }
    }
}
