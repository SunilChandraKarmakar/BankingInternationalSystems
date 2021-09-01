﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Client.ViewModels.Account
{
    public class CreateAccountViewModel
    {
        [Required(ErrorMessage = "Please Provied Unique Account Number")]
        [StringLength(10, MinimumLength = 2)]
        [DataType(DataType.PhoneNumber)]
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
        [DataType(DataType.Currency)]
        public double InitialBalance { get; set; }

        [Required(ErrorMessage = "Please Provied Valid Email Address")]
        [StringLength(50, MinimumLength = 11)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Provied Full Address")]
        [StringLength(500, MinimumLength = 2)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}
