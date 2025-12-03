using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Project.BLL.DTOs;
using Project.BLL.Managers.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.Entities.Models;

namespace Project.BLL.Managers.Concretes
{
    public class BookTagManager : BaseManager<BookTagDTO, BookTag>, IBookTagManager
    {
        private readonly IBookTagRepository _repository;

        public BookTagManager(IBookTagRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
