using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIS.Data.DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        T GetById(int id);
        void Remove(T entity);
        void Create(T entity);
        Task<T> CreateAsync(T entity);
        void Update(T entity);
    }
}
