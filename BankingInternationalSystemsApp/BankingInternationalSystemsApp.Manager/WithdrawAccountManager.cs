using BankingInternationalSystemsApp.Manager.Base;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using BankingInternationalSystemsApp.Repository.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Manager
{
    public class WithdrawAccountManager : BaseManager<WithdrawAccount>, IWithdrawAccountManager
    {
        private readonly IWithdrawAccountRepository _withdrawAccountRepository;

        public WithdrawAccountManager(IWithdrawAccountRepository withdrawAccountRepository) : base(withdrawAccountRepository)
        {
            _withdrawAccountRepository = withdrawAccountRepository;
        }

        public override async Task<ICollection<WithdrawAccount>> GetAll()
        {
            return await _withdrawAccountRepository.GetAll();
        }
    }
}
