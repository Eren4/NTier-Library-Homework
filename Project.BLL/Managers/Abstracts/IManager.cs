using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BLL.DTOs;
using Project.Entities.Models;

namespace Project.BLL.Managers.Abstracts
{
    public interface IManager
    {
        public interface IManager<T, U> where T : class, IDTO where U : BaseEntity
        {
            // BL for Queries
            Task<List<T>> GetAllAsync();
            Task<T> GetByIdAsync(int id);
            List<T> GetActives();
            List<T> GetPassives();
            List<T> GetUpdateds();

            // BL for Commands
            Task CreateAsync(T entity);
            Task UpdateAsync(T entity);
            Task<string> SoftDeleteAsync(int id);
            Task<string> HardDeleteAsync(int id);
        }
    }
}
