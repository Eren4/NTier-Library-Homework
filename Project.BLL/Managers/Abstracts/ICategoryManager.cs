using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BLL.DTOs;
using Project.Entities.Models;
using static Project.BLL.Managers.Abstracts.IManager;

namespace Project.BLL.Managers.Abstracts
{
    public interface ICategoryManager : IManager<CategoryDTO, Category>
    {
    }
}
