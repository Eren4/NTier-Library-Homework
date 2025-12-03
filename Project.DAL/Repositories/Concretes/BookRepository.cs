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
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(MyContext context) : base(context)
        {

        }
    }
}
