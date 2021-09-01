using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Repository.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        Task<ICollection<T>> GetAll();
        Task<T> GetById(int? id);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);    
        Task<bool> Delete(T entity);
    }
}
