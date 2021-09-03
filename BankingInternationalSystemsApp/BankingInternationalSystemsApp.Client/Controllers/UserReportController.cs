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
    public class UserReportController : Controller
    {
        private readonly IWithdrawAccountManager _withdrawAccountManager;
        private readonly ILodgeAccountManager _lodgeAccountManager;

        public UserReportController(IWithdrawAccountManager withdrawAccountManager, ILodgeAccountManager lodgeAccountManager)
        {
            _withdrawAccountManager = withdrawAccountManager;
            _lodgeAccountManager = lodgeAccountManager;
        }

        [HttpGet]
        public async Task<ActionResult> WithdrawHistory()
        {
            if(HttpContext.Session.GetString("userId") != null)
            {
                int currentUserId = Convert.ToInt32(HttpContext.Session.GetString("userId"));
                ICollection<WithdrawAccount> withdrawAccounts = await _withdrawAccountManager.GetAll();
                withdrawAccounts = withdrawAccounts.Where(wa => wa.AccountId == currentUserId).ToList();

                return View(withdrawAccounts);
            }

            return RedirectToAction("Login", "Login");
        }

        [HttpGet]
        public async Task<ActionResult> LodgeHistory()
        {
            if(HttpContext.Session.GetString("userId") != null)
            {
                int currentUserId = Convert.ToInt32(HttpContext.Session.GetString("userId"));
                ICollection<LodgeAccount> lodgeAccounts = await _lodgeAccountManager.GetAll();
                lodgeAccounts = lodgeAccounts.Where(wa => wa.AccountId == currentUserId).ToList();

                return View(lodgeAccounts);
            }

            return RedirectToAction("Login", "Login");
        }
    }
}
