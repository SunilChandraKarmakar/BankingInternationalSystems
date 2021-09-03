using BankingInternationalSystemsApp.Model.Models;
using BankingInternationalSystemsApp.Repository.Base;
using BankingInternationalSystemsApp.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Repository
{
    public class LodgeAccountRepository : BaseRepository<LodgeAccount>, ILodgeAccountRepository
    {
        public override async Task<ICollection<LodgeAccount>> GetAll()
        {
            return await _db.LodgeAccounts.Include(la => la.Account).ToListAsync();
        }
    }
}
