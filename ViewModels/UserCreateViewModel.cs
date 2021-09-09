using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneProject.ViewModels
{
    public class UserCreateViewModel
    {
        [Display(Name = "Id")]
        public Guid guid { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Emial should be a valid email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int Role { get; set; }
    }
}
