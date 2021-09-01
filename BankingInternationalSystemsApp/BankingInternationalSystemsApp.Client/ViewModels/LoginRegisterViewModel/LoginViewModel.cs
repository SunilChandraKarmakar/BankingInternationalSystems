using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.ViewModels.LoginRegisterViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please Provied Valid Email Address")]
        [StringLength(100, MinimumLength = 11)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Provied Your Password")]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
