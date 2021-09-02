using AspNetCoreHero.ToastNotification.Abstractions;
using BankingInternationalSystemsApp.Client.ViewModels.LoginRegisterViewModel;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAccountManager _accountManager;
        private readonly IAccountRoleManager _accountRoleManager;
        private readonly INotyfService _notyfService;

        public LoginController(IAccountManager accountManager, INotyfService notyfService, IAccountRoleManager accountRoleManager)
        {
            _accountManager = accountManager;
            _notyfService = notyfService;
            _accountRoleManager = accountRoleManager;   
        }

        [HttpGet]
        public async Task<ActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(AccountLoginViewModel accountLoginViewModel)
        {
            if(ModelState.IsValid)
            {
                ICollection<Account> accounts = await _accountManager.GetAll();
                Account loginAccount = accounts.Where(a => a.Email.ToLower() == accountLoginViewModel.LoginViewModel.Email.ToLower() &&
                                                      a.Password.ToLower() == accountLoginViewModel.LoginViewModel.Password.ToLower()).FirstOrDefault();

                if(loginAccount == null)
                {
                    _notyfService.Error("Login failed. Email and Password not match, Try again.", 5);
                    return RedirectToAction("Login", "Login");
                }

                ICollection<AccountRole> accountRoles = await _accountRoleManager.GetAll();
                AccountRole loginAccountIsUser = accountRoles.Where(ar => ar.AccountId == loginAccount.Id && ar.RoleId == 2).FirstOrDefault();
                AccountRole loginAccountIsAdmin = accountRoles.Where(ar => ar.AccountId == loginAccount.Id && ar.RoleId == 1).FirstOrDefault();

                if(loginAccountIsUser != null)
                {
                    HttpContext.Session.SetString("userId", loginAccountIsUser.AccountId.ToString());
                    _notyfService.Success("Login Successfull", 5);
                    return RedirectToAction("Index", "UserDashboard");
                }

                if (loginAccountIsAdmin != null)
                {
                    HttpContext.Session.SetString("adminId", loginAccountIsAdmin.AccountId.ToString());
                    _notyfService.Success("Login Successfull", 5);
                    return RedirectToAction("Index", "AdminDashboard");
                }
            }

            return View();
        }
    }
}
