using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Model.Models
{
    public class AccountRole
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Select User Name")]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Select Role Name")]
        public int RoleId { get; set; }

        public Account Account { get; set; }
        public Role Role { get; set; }
    }
}
