using BankingInternationalSystemsApp.Model.Models;
using BankingInternationalSystemsApp.Repository.Base;
using BankingInternationalSystemsApp.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Repository
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
    }
}
