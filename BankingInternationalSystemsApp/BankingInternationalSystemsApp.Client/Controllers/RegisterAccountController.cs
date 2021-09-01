using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.Controllers
{
    public class RegisterAccountController : Controller
    {
        // GET: RegisterAccountController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RegisterAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegisterAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterAccountController/Create
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

        // GET: RegisterAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterAccountController/Edit/5
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

        // GET: RegisterAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterAccountController/Delete/5
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
