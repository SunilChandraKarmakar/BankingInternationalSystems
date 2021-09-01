using BankingInternationalSystemsApp.Database;
using BankingInternationalSystemsApp.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Repository.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly BisContext _db;

        public BaseRepository()
        {
            _db = new BisContext();
        }

        public virtual async Task<ICollection<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetById(int? id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public virtual async Task<bool> Add(T entity)
        {
            _db.Set<T>().Add(entity);
            return await _db.SaveChangesAsync() > 0;
        }

        public virtual async Task<bool> Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return await _db.SaveChangesAsync() > 0;
        }

        public virtual async Task<bool> Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            return await _db.SaveChangesAsync() > 0;
        }                                 
    }
}
