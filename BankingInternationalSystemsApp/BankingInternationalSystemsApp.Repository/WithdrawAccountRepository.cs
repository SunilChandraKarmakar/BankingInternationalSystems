using BankingInternationalSystemsApp.Model.Models;
using BankingInternationalSystemsApp.Repository.Base;
using BankingInternationalSystemsApp.Repository.Contracts;

namespace BankingInternationalSystemsApp.Repository
{
    public class WithdrawAccountRepository : BaseRepository<WithdrawAccount>, IWithdrawAccountRepository    
    {
    }
}
