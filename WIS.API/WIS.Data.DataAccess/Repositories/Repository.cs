using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WIS.Data.DataAccess.Interfaces;

namespace WIS.Data.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly WISDataContext _db;
        public Repository(WISDataContext db)
        {
        }

        public void Create(T entity)
        {
            _db.Set<T>().Add(entity);
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            IEnumerable<T> entities = await _db.Set<T>().ToListAsync();
            return entities;
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            T entity = await _db.Set<T>().FindAsync(id);
            return entity;
        }

        public void Remove(T entity)
        {
            _db.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }
    }
}
