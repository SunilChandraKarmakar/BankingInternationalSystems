using BankingInternationalSystemsApp.Manager.Base;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using BankingInternationalSystemsApp.Repository.Contracts;

namespace BankingInternationalSystemsApp.Manager
{
    public class WithdrawAccountManager : BaseManager<WithdrawAccount>, IWithdrawAccountManager
    {
        private readonly IWithdrawAccountRepository _withdrawAccountRepository;

        public WithdrawAccountManager(IWithdrawAccountRepository withdrawAccountRepository) : base(withdrawAccountRepository)
        {
            _withdrawAccountRepository = withdrawAccountRepository;
        }
    }
}
