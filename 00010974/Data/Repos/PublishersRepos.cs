using _00010974.Data.Service;
using _00010974.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _00010974.Data.Base;

namespace _00010974.Data.Repos
{
    public class PublishersRepos : EntityBaseRepos<Publishers>, IPublisherRepos
    {
        public  PublishersRepos(AppDbContext context) : base(context) { }
    }
}
