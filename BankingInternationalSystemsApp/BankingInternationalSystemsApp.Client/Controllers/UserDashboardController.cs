using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using BankingInternationalSystemsApp.Client.ViewModels.UserDashboardViewModel;
using BankingInternationalSystemsApp.Client.ViewModels.WithdrawAccountViewModel;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.Controllers
{
    public class UserDashboardController : Controller
    {
        private readonly IAccountManager _accountManager;
        private readonly IWithdrawAccountManager _withdrawAccountManager;
        private readonly ILodgeAccountManager _lodgeAccountManager;
        private readonly IMapper _mapper;
        private readonly INotyfService _notyfService;


        public UserDashboardController(IAccountManager accountManager, IMapper mapper, INotyfService notyfService, 
                                       IWithdrawAccountManager withdrawAccountManager, ILodgeAccountManager lodgeAccountManager)
        {
            _accountManager = accountManager;
            _withdrawAccountManager = withdrawAccountManager;
            _lodgeAccountManager = lodgeAccountManager;
            _mapper = mapper;
            _notyfService = notyfService;
        }

        [HttpGet]
        public async Task<IActionResult> MyAccountInfo()
        {
            if (HttpContext.Session.GetString("userId") != null)
            {
                int loginUserAccountId = Convert.ToInt32(HttpContext.Session.GetString("userId"));
                Account accountInfo = await _accountManager.GetById(loginUserAccountId);
                LoginAccountViewModel loginAccountInfo = _mapper.Map<LoginAccountViewModel>(accountInfo);

                return View(loginAccountInfo);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        public async Task<ActionResult> MyAccountInfo(LoginAccountViewModel loginAccountInfo)
        {
            if(HttpContext.Session.GetString("userId") != null)
            {
                if(ModelState.IsValid)
                {
                    Account updateLoginAccountInfo = _mapper.Map<Account>(loginAccountInfo);
                    bool isUpdateLoginAccountInfo = await _accountManager.Update(updateLoginAccountInfo);

                    if (isUpdateLoginAccountInfo)
                    {
                        _notyfService.Success("Account Info Updated.", 5);
                        return RedirectToAction("MyAccountInfo");
                    }
                }

                return View(loginAccountInfo);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public async Task<ActionResult> WithdrawAmmount()
        {
            if(HttpContext.Session.GetString("userId") != null)
            {
                CreateWithdrawAccountViewModel createWithdrawAccountViewModel = new CreateWithdrawAccountViewModel
                {
                    AccountId = Convert.ToInt32((HttpContext.Session.GetString("userId")))
                };

                return View(createWithdrawAccountViewModel);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        public async Task<ActionResult> WithdrawAmmount(CreateWithdrawAccountViewModel model)
        {
            if(HttpContext.Session.GetString("userId") != null)
            {
                if(ModelState.IsValid)
                {
                    Account currentUser = await _accountManager.GetById(model.AccountId);
                    currentUser.InitialBalance = currentUser.InitialBalance - model.Ammount;
                    bool isUpdateCurrentUser = await _accountManager.Update(currentUser);

                    WithdrawAccount withdrawAccountInfo = _mapper.Map<WithdrawAccount>(model);
                    withdrawAccountInfo.WithdrawDateTime = DateTime.UtcNow;
                    bool isSaveWithdrawAccountInfo = await _withdrawAccountManager.Add(withdrawAccountInfo);

                    if(isUpdateCurrentUser && isSaveWithdrawAccountInfo)
                    {
                        _notyfService.Success("Withdraw Ammount Successfull.", 5);
                        return RedirectToAction("MyAccountInfo");
                    }
                }

                return View(model);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public async Task<ActionResult> LodgeAmmount()
        {
            if(HttpContext.Session.GetString("userId") != null)
            {
                CreateLodgeAccountViewModel createLodgeAccountViewModel = new CreateLodgeAccountViewModel
                {
                    AccountId = Convert.ToInt32((HttpContext.Session.GetString("userId")))
                };

                return View(createLodgeAccountViewModel);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        public async Task<ActionResult> LodgeAmmount(CreateLodgeAccountViewModel model)
        {
            if (HttpContext.Session.GetString("userId") != null)
            {
                if(ModelState.IsValid)
                {
                    Account currentUser = await _accountManager.GetById(model.AccountId);
                    currentUser.InitialBalance = currentUser.InitialBalance + model.Ammount;
                    bool isUpdateCurrentUser = await _accountManager.Update(currentUser);

                    LodgeAccount lodgeAccountInfo = _mapper.Map<LodgeAccount>(model);
                    lodgeAccountInfo.LodgeDateTime = DateTime.UtcNow;
                    bool isSaveLodgeAccountInfo = await _lodgeAccountManager.Add(lodgeAccountInfo);

                    if (isUpdateCurrentUser && isSaveLodgeAccountInfo)
                    {
                        _notyfService.Success("Lodge Ammount Successfull.", 5);
                        return RedirectToAction("MyAccountInfo");
                    }
                }

                return View(model);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteAccount(int? id)
        {
            if (HttpContext.Session.GetString("userId") != null)
            {
                if (id == null)
                {
                    _notyfService.Success("Your account id not found! Trg again.", 5);
                    return RedirectToAction("MyAccountInfo");
                }

                Account currentAccountInfo = await _accountManager.GetById(id);

                if (currentAccountInfo == null)
                {
                    _notyfService.Success("Your account can not delete! Trg again.", 5);
                    return RedirectToAction("MyAccountInfo");
                }

                bool isAccountDleted = await _accountManager.Delete(currentAccountInfo);

                if (isAccountDleted)
                {
                    _notyfService.Success("Your account has been deleted.", 5);
                    HttpContext.Session.Clear();
                    return RedirectToAction("Login", "Login");
                }
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public async Task<ActionResult> Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}
