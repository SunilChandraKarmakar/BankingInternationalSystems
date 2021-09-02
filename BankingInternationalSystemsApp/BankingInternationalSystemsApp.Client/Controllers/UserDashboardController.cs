﻿using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using BankingInternationalSystemsApp.Client.ViewModels.UserDashboardViewModel;
using BankingInternationalSystemsApp.Client.ViewModels.WithdrawAccountViewModel;
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
        private readonly IWithdrawAccountManager _withdrawAccountManager;
        private readonly IMapper _mapper;
        private readonly INotyfService _notyfService;


        public UserDashboardController(IAccountManager accountManager, IMapper mapper, INotyfService notyfService, IWithdrawAccountManager withdrawAccountManager)
        {
            _accountManager = accountManager;
            _withdrawAccountManager = withdrawAccountManager;   
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
        public async Task<ActionResult> Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}