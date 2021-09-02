using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.ViewModels.UserDashboardViewModel
{
    public class CreateLodgeAccountViewModel
    {
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Please Provied Lodge Ammount")]
        [Display(Name = "Withdraw Ammount")]
        public double Ammount { get; set; }

        public DateTime LodgeDateTime { get; set; }
    }
}
