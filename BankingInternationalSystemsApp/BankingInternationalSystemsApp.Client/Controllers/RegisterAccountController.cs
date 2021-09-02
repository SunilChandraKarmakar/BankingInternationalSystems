using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using BankingInternationalSystemsApp.Client.ViewModels.LoginRegisterViewModel;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.Controllers
{
    public class RegisterAccountController : Controller
    {
        private readonly IAccountManager _accountManager;
        private readonly IAccountRoleManager _accountRoleManager;
        private readonly INotyfService _notyfService;
        private readonly IMapper _mapper;

        public RegisterAccountController(IAccountManager accountManager, IAccountRoleManager accountRoleManager,
                                        INotyfService notyfService , IMapper mapper)
        {
            _accountManager = accountManager;
            _accountRoleManager = accountRoleManager;
            _notyfService = notyfService;
            _mapper = mapper;   
        }

        [HttpPost]
        public async Task<ActionResult> RegisterAccount(AccountLoginViewModel registerAccount)
        {
            if(ModelState.IsValid)
            {
                Account createAccount = _mapper.Map<Account>(registerAccount.CreateAccountViewModel);
                createAccount.AccountNumber = GenerateUniqueAccountNumber();
                createAccount.InitialBalance = 50;
                bool isAccountCreated = await _accountManager.Add(createAccount);

                AccountRole accountRoleIsUser = new AccountRole
                {
                    AccountId = createAccount.Id,
                    RoleId = 2
                };

                bool isAccountRoleCreated = await _accountRoleManager.Add(accountRoleIsUser);                  
                if(isAccountCreated && isAccountRoleCreated)
                {
                    _notyfService.Success("Account Registered Success.", 5);
                    return RedirectToAction("Login", "Login");
                }
                else
                {
                    _notyfService.Error("Account Registered Faild!", 5);
                    return RedirectToAction("Login", "Login");
                }
            }

            return RedirectToAction("Login", "Login");
        }

        private int GenerateUniqueAccountNumber()
        {
            Random uniqueAccountNumber = new Random(10000);
            return uniqueAccountNumber.Next(1111111, 9999999);
        }
    }
}
