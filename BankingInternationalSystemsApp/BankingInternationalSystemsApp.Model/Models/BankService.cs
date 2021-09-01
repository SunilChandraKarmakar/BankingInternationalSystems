using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Model.Models
{
    public class BankService
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Provied Service Name")]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Service Name")]
        public string Name { get; set; }
    }
}
