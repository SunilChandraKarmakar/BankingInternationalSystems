using BankingInternationalSystemsApp.Model.Models;
using BankingInternationalSystemsApp.Repository.Base;
using BankingInternationalSystemsApp.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Repository
{
    public class WithdrawAccountRepository : BaseRepository<WithdrawAccount>, IWithdrawAccountRepository
    {
        public override async Task<ICollection<WithdrawAccount>> GetAll()
        {
            return await _db.WithdrawAccounts.Include(wa => wa.Account).ToListAsync();
        }
    }
}
