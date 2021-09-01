using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingInternationalSystemsApp.Model.Models
{
    public class Role
    {
        public Role()
        {
            AccountRoles = new HashSet<AccountRole>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please provied role name.")]
        [Display(Name = "Role Name")]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        public ICollection<AccountRole> AccountRoles { get; set; }
    }
}
