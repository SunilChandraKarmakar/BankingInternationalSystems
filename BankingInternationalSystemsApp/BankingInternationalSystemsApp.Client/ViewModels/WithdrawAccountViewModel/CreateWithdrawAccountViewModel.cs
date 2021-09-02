using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.ViewModels.WithdrawAccountViewModel
{
    public class CreateWithdrawAccountViewModel
    {
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Please Provied Withdraw Ammount")]
        [Display(Name = "Withdraw Ammount")]
        public double Ammount { get; set; }

        public DateTime WithdrawDateTime { get; set; }
    }
}
