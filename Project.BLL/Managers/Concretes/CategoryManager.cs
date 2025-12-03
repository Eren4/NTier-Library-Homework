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
    public class CategoryManager : BaseManager<CategoryDTO, Category>, ICategoryManager
    {
        private readonly ICategoryRepository _repository;

        public CategoryManager(ICategoryRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }
    }
}
