using BankingInternationalSystemsApp.Manager.Base;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using BankingInternationalSystemsApp.Repository.Contracts;

namespace BankingInternationalSystemsApp.Manager
{
    public class AccountManager : BaseManager<Account>, IAccountManager
    {
        private readonly IAccountRepository _iAccountRepository;

        public AccountManager(IAccountRepository accountRepository) : base(accountRepository)
        {
            _iAccountRepository = accountRepository;
        }
    }
}
