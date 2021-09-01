using BankingInternationalSystemsApp.Manager.Base;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using BankingInternationalSystemsApp.Repository.Contracts;

namespace BankingInternationalSystemsApp.Manager
{
    public class AccountRoleManager : BaseManager<AccountRole>, IAccountRoleManager
    {
        private readonly IAccountRoleRepository _accountRoleRepository; 

        public AccountRoleManager(IAccountRoleRepository accountRoleRepository) : base(accountRoleRepository)
        {
            _accountRoleRepository = accountRoleRepository;
        }
    }
}
