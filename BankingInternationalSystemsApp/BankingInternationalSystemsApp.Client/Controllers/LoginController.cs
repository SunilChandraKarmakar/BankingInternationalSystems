using BankingInternationalSystemsApp.Client.ViewModels.LoginRegisterViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.Controllers
{
    public class LoginController : Controller
    {
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

            }

            return View();
        }
    }
}
