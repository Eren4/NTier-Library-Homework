using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.ContextClasses;
using Project.DAL.Repositories.Abstracts;
using Project.Entities.Models;

namespace Project.DAL.Repositories.Concretes
{
    public class BookTagRepository : BaseRepository<BookTag>, IBookTagRepository
    {
        public BookTagRepository(MyContext context) : base(context)
        {

        }
    }
}
