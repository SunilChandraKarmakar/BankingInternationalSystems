using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using BankingInternationalSystemsApp.Client.ViewModels.AdminDashboardViewModel;
using BankingInternationalSystemsApp.Manager.Contracts;
using BankingInternationalSystemsApp.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingInternationalSystemsApp.Client.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly IAccountManager _accountManager;
        private readonly IMapper _mapper;
        private readonly INotyfService _notyfService;

        public AdminDashboardController(IAccountManager accountManager, IMapper mapper, INotyfService notyfService)
        {
            _accountManager = accountManager;
            _mapper = mapper;
            _notyfService = notyfService;
        }

        [HttpGet]
        public async Task<ActionResult> DisplayAccount()
        {
            if(HttpContext.Session.GetString("adminId") != null)
            {
                ICollection<AccountViewModel> displayAccounts = _mapper.Map<ICollection<AccountViewModel>>(await _accountManager.GetAll());
                displayAccounts = displayAccounts.Where(a => a.InitialBalance < 100).ToList();

                return View(displayAccounts);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public async Task<ActionResult> AccountDetails(int? id)
        {
            if(HttpContext.Session.GetString("adminId") != null)
            {
                if(id == null)
                {
                    _notyfService.Warning("Account id can not found! Try again", 5);
                    return RedirectToAction("DisplayAccount");
                }

                Account existAccountInfo = await _accountManager.GetById(id);

                if(existAccountInfo == null)
                {
                    _notyfService.Warning("Account can not found! Try again", 5);
                    return RedirectToAction("DisplayAccount");
                }

                return View(existAccountInfo);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public async Task<ActionResult> Logout()
        {
            if(HttpContext.Session.GetString("adminId") != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login", "Login");
            }

            return RedirectToAction("Login", "Login");
        }
    }
}
