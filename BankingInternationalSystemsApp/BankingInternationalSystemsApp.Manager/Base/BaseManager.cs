using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Repository.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Manager.Base
{
    public abstract class BaseManager<T> : IBaseManager<T> where T : class 
    {
        private readonly IBaseRepository<T> _iBaseRepository;

        public BaseManager(IBaseRepository<T> baseRepository)
        {
            _iBaseRepository = baseRepository;
        }

        public virtual async Task<ICollection<T>> GetAll()
        {
            return await _iBaseRepository.GetAll();
        }

        public virtual async Task<T> GetById(int? id)
        {
            return await _iBaseRepository.GetById(id);
        }

        public virtual async Task<bool> Add(T entity)
        {
            return await _iBaseRepository.Add(entity);
        }

        public virtual async Task<bool> Update(T entity)
        {
            return await _iBaseRepository.Update(entity);
        }

        public virtual async Task<bool> Delete(T entity)
        {
            return await _iBaseRepository.Delete(entity);
        }
    }
}
