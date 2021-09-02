using BankingInternationalSystemsApp.Manager.Base;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using BankingInternationalSystemsApp.Repository.Contracts;

namespace BankingInternationalSystemsApp.Manager
{
    public class LodgeAccountManager : BaseManager<LodgeAccount>, ILodgeAccountManager
    {
        private readonly ILodgeAccountRepository _lodgeAccountRepository;

        public LodgeAccountManager(ILodgeAccountRepository lodgeAccountRepository) : base(lodgeAccountRepository)
        {
            _lodgeAccountRepository = lodgeAccountRepository;
        }
    }
}
