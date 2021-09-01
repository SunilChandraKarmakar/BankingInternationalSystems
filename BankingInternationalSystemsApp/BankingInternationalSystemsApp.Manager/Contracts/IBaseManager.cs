using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Manager.Contracts
{
    public interface IBaseManager<T> where T : class
    {
        Task<ICollection<T>> GetAll();
        Task<T> GetById(int? id);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
    }
}
