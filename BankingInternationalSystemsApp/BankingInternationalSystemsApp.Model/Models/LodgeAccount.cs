using System;
using System.ComponentModel.DataAnnotations;

namespace BankingInternationalSystemsApp.Model.Models
{
    public class LodgeAccount
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Select Your Account")]
        [Display(Name = "Account Name")]
        public int AccountId { get; set; }


        [Required(ErrorMessage = "Please Provied Lodge Ammount")]
        [Display(Name = "Withdraw Ammount")]
        [DataType(DataType.Currency)]
        public double Ammount { get; set; }

        [Required(ErrorMessage = "Select Lodge Date")]
        [DataType(DataType.Date)]
        [Display(Name = "Withdraw Date Time")]
        public DateTime LodgeDateTime { get; set; }

        public virtual Account Account {  get; set; }   
    }
}
