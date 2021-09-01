using BankingInternationalSystemsApp.Client.ViewModels.LoginRegisterViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.Controllers
{
    public class LoginController : Controller
    {
        // GET: LogicController
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(AccountLoginViewModel accountLoginViewModel)
        {
            if(ModelState.IsValid)
            {

            }

            return View();
        }

        // GET: LogicController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogicController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogicController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogicController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogicController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogicController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogicController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
