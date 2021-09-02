using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using BankingInternationalSystemsApp.Client.ViewModels.UserDashboardViewModel;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.Controllers
{
    public class UserDashboardController : Controller
    {
        private readonly IAccountManager _accountManager;
        private readonly IMapper _mapper;
        private readonly INotyfService _notyfService;


        public UserDashboardController(IAccountManager accountManager, IMapper mapper, INotyfService notyfService)
        {
            _accountManager = accountManager;
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
        public async Task<ActionResult> Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}
