using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BankingInternationalSystemsApp.Model.Models
{
    public class Account
    {
        public Account()
        {
            WithdrawAccounts = new HashSet<WithdrawAccount>(); 
            LodgeAccounts = new HashSet<LodgeAccount>();
            AccountRoles = new HashSet<AccountRole>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please Provied Unique Account Number")]
        [StringLength(15, MinimumLength = 2)]
        [Display(Name = "Account Number")]
        public int AccountNumber { get; set; }

        [Required(ErrorMessage = "Please Provied Your First Name")]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Provied Your Second Name")]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Second Name")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Please Provied Initial Balance")]
        [Display(Name = "Initial Balance")]
        public double InitialBalance { get; set; }

        [Required(ErrorMessage = "Please Provied Valid Email Address")]
        [StringLength(50, MinimumLength = 11)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Provied Your Password")]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Provied Full Address")]
        [StringLength(500, MinimumLength = 2)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public virtual ICollection<WithdrawAccount> WithdrawAccounts { get; set; }
        public virtual ICollection<LodgeAccount> LodgeAccounts {  get; set; }   
        public virtual ICollection<AccountRole> AccountRoles { get; set; }
    }
}
